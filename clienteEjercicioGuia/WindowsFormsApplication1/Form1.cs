using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;    //Necesario para que los elementos de los formularios puedan
                                                        //ser accedididos desde threads diferentes a los que los crearon
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos mensaje del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string [] trozos = Encoding.ASCII.GetString(msg2).Split('/');  //Tenemos dos trozos de string 
                int codigo = Convert.ToInt32(trozos[0]);
                
                string mensaje = trozos[1].Split('\0')[0];  //Arrancamos trozo hasta fin de linea
                switch (codigo)
                {
                    case 1:
                        MessageBox.Show("La longitud de tu nombre es: " + mensaje);
                        break;
                    case 2:
                        if (mensaje == "SI")
                            MessageBox.Show("Tu nombre ES bonito.");
                        else
                            MessageBox.Show("Tu nombre NO es bonito. Lo siento.");
                        break;
                    case 3:
                        MessageBox.Show(mensaje);
                        break;
                    case 4: //Notificacion
                        contLbl.Text = mensaje;
                        break;
                }
            }
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            if (Longitud.Checked)
            {
                // Quiere saber la longitud
                string mensaje = "1/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
            else if (Bonito.Checked)
            {
                // Quiere saber si el nombre es bonito
                string mensaje = "2/" + nombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            else
            {
                // Enviamos nombre y altura
                string mensaje = "3/" + nombre.Text + "/" + alt.Text;
                // ENviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9000);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");
            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //pongo en marcha el thread que atenderá los mensajes del servidor
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            // Mensaje de desconexion
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            atender.Abort();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            
        }
    }
}

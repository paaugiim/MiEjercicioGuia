namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(232, 60);
            this.nombre.Margin = new System.Windows.Forms.Padding(6);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(324, 31);
            this.nombre.TabIndex = 3;
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(260, 277);
            this.enviar.Margin = new System.Windows.Forms.Padding(6);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(150, 44);
            this.enviar.TabIndex = 5;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.alt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enviar);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(24, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(726, 542);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // alt
            // 
            this.alt.Location = new System.Drawing.Point(75, 221);
            this.alt.Margin = new System.Windows.Forms.Padding(6);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(123, 31);
            this.alt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Altura";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(232, 222);
            this.Altura.Margin = new System.Windows.Forms.Padding(6);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(195, 29);
            this.Altura.TabIndex = 9;
            this.Altura.TabStop = true;
            this.Altura.Text = "Dime si soy alto";
            this.Altura.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(232, 175);
            this.Longitud.Margin = new System.Windows.Forms.Padding(6);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(333, 29);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(232, 131);
            this.Bonito.Margin = new System.Windows.Forms.Padding(6);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(314, 29);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // conectar
            // 
            this.conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectar.Location = new System.Drawing.Point(165, 71);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(443, 120);
            this.conectar.TabIndex = 7;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desconectar.Location = new System.Drawing.Point(165, 813);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(443, 120);
            this.desconectar.TabIndex = 8;
            this.desconectar.Text = "Desonectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // contLbl
            // 
            this.contLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contLbl.Location = new System.Drawing.Point(935, 440);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(207, 152);
            this.contLbl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 1158);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.TextBox alt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Altura;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.Label contLbl;
    }
}


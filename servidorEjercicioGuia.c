#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

int contador;
//Hacemos vector de sockets para atender mￃﾡs de 1 cliente a la vez
int sockets[100];
i=0;

//Estructura nexesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s = (int *) socket;
	sock_conn=*s;
	char peticion[512];
	char respuesta[512];
	int ret;
	// Bucle de atencion al cliente
	int terminar = 0;
	while (terminar==0)
	{
		
		// Ahora recibimos su peticion
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibida una peticion\n");
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		//Escribimos la peticion en la consola
		
		printf ("La peticion es: %s\n",peticion); 
		char *p = strtok(peticion, "/");
		int codigo =  atoi (p);
		char nombre[20];
		if ((codigo!=0)&&(codigo!=4))
		{
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		
		if (codigo==0)
			terminar = 1;
		else if (codigo ==1) //piden la longitd del nombre
			sprintf (respuesta,"1/%d",strlen (nombre));
		else if (codigo==2)
			// quieren saber si el nombre es bonito
			if((nombre[0]=='M') || (nombre[0]=='S'))
			strcpy (respuesta,"2/SI");
			else
				strcpy (respuesta,"2/NO");
			else
			{
				p = strtok(NULL, "/");
				float altura = atof (p);
				if (altura > 1.70)
					sprintf(respuesta, "3/%s: Eres alto", nombre);
				else
					sprintf(respuesta, "3/%s: Eres bajo", nombre);
			}
			
			if (codigo!=0)	
				// Enviamos la respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			
			if ((codigo==1) || (codigo==2)||(codigo==3))
			{
				pthread_mutex_lock(&mutex); // No me interrumpas ahora
				contador = contador+1;
				pthread_mutex_unlock(&mutex); //Ya puedes interrumpirme
				// Notificar a todos los clientes conectados:
				char notificacion[20];
				sprintf(notificacion, "4/%d", contador);
				// Tenemos que enviar notificacion a todos los clientes conectados, enviamos mensaje por todos los sockets que tenemos conectados:
				int j;
				for(j=0;j<i;j++) //i nos dice clientes que se han conectado
					write (sockets[j], notificacion, strlen(notificacion));
			} 
	}	
	// Se acabo el servicio para este cliente
	close(sock_conn); 
}

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9000);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	int contador = 0;
	pthread_t thread;	// No es un vector pq no necessitem tots els threads, cada cop anira matxacant lanterior.
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		sockets[i] = sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		// Crear thred y decirle que tiene que hacer:
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);	//No podem fer que els vectors siguin infinits i arriba un moment que no podem colﾷlocar els sockets a la posicio que tocaria
		i = i+1;
	}
	/*	for(i=0;i<5;i++)*/
	/*		pthread_join(thread[i],NULL);*/	// Nomes seria si tinguessim un buvle limitat
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Informacion;

using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace servidor
{
    class servidor
    {
        static Socket svr;
        static List<inf_cliente> clientes;
       static IPAddress miIP = datos.obtenerip();
       static List<datos> usuariosConectados;

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Servidor");
            svr = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientes = new List<inf_cliente>();
            usuariosConectados = new List<datos>();

            IPEndPoint ipe = new IPEndPoint(miIP, 1806);
            svr.Bind(ipe);


            Thread escuchar = new Thread(escucharThread);
            escuchar.Start();

            Console.WriteLine("Servidor en linea["+datos.obtenerip()+"]");
        }

        static void escucharThread()
        {
            while (true)
            {
                svr.Listen(0);
                clientes.Add(new inf_cliente(svr.Accept()));

            }
        }

        public static void datos_entrando(object cl_socket)
        {
            Socket clienteSocket = (Socket)cl_socket;
            byte[] buffer;
            int readbytes;

            while (true)
            {
                try
                {
                    buffer = new byte[clienteSocket.SendBufferSize];
                    readbytes = clienteSocket.Receive(buffer);

                    if (readbytes > 0)
                    {
                        datos d = new datos(buffer);
                        direccionador(d);
                    }

                }
                catch
                {
                    foreach (inf_cliente i in clientes)
                    {
                        if (i.cliente == clienteSocket)
                        {
                            clientes.Remove(i);
                            break;
                        }
                    }
                    
                    break;
                }
            }

        }

        public static void direccionador(datos d){

            switch (d.tipomsj)
            {
                
                case tipo.chat:

                    foreach (inf_cliente i in clientes)
                    {
                        i.cliente.Send(d.toBytes());
                    }

                    break;
                case tipo.privadocrear:
                    
                    
                    break;

                case tipo.privadoconfirmado:


               break;

                case tipo.zumbido:

                    foreach (inf_cliente i in clientes)
                    {
                        i.cliente.Send(d.toBytes());
                    }
                    break;

                case tipo.estado:

                    break;
                case tipo.delete:
                   
                    break;
            }
        }

        class inf_cliente
        {
            public Socket cliente;
            public Thread proceso;

            public inf_cliente(){}

            public inf_cliente(Socket cliente)
            {
                this.cliente = cliente;
                proceso = new Thread(servidor.datos_entrando);
                proceso.Start(cliente);
                IPEndPoint remoteIpEndPoint = cliente.RemoteEndPoint as IPEndPoint;

                datos d=new datos(tipo.add,remoteIpEndPoint.Address);

                usuariosConectados.Add(d);
            }
    
          
        }

    }

}

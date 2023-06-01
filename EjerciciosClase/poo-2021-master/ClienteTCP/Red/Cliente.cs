using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace Red
{
    public class Cliente
    {
        TcpClient cliente;

        public Cliente(int puerto)
        {
            IPEndPoint miExtremo = new IPEndPoint(IPAddress.Any, puerto);
            cliente = new TcpClient(miExtremo);
        }

        internal Cliente(TcpClient unCliente)
        {
            cliente = unCliente;
        }


        
        public EndPoint extremoRemoto
        {
            get { return cliente.Client.RemoteEndPoint; }
            
        }


        public void Conectar(string ip, int puerto)
        {
            IPEndPoint extremo = new IPEndPoint(IPAddress.Parse(ip), puerto);

            cliente.Connect(extremo);
        
        }

        public void Enviar(string mensaje)
        {
            if (cliente.Connected)
            {

                Byte[] datos = Encoding.ASCII.GetBytes(mensaje);

                cliente.Client.Send(datos);
            }
        
        }

        public string Recibir()
        {
            string mensaje = string.Empty;

            if (cliente.Available>0)
            {
                Byte[] datos = new byte[512];

                cliente.Client.Receive(datos);

                mensaje = Encoding.ASCII.GetString(datos);

            }

            return mensaje;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using System.Text;
using System.Net;
using System.Net.Sockets;


namespace RED
{
    public class MiSocket
    {
        private UdpClient socket;

        private int puerto;

        public int Puerto
        {
            get { return puerto; }
        }

        public MiSocket(int p)
        {
            puerto = p;

            IPEndPoint miExtremo = new IPEndPoint( IPAddress.Any, puerto  );

            socket = new UdpClient(miExtremo);
        }

        public void EnviarMensaje( string mensaje, string destino, int puertoDestino)
        {
            IPEndPoint extremoDestino = new IPEndPoint(IPAddress.Parse(destino), puertoDestino);

            Byte[] datos = Encoding.ASCII.GetBytes(mensaje);

            socket.Send(datos, datos.Length, extremoDestino);

        }

        public string RecibirDatos()
        {

            string mensaje = string.Empty;

            if (socket.Available >0)
            {
                Byte[] datos = new Byte[512];

                IPEndPoint extremoDestino = new IPEndPoint(IPAddress.Any, 0);

                datos = socket.Receive(ref extremoDestino);

                mensaje = extremoDestino.Address.ToString() + ':' + extremoDestino.Port.ToString() + " dice:";

                mensaje += " " + Encoding.ASCII.GetString(datos);
            }

            return mensaje;
        }


    }
}

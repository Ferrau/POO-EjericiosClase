using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Red
{
    public class MiServidor
    {
        TcpListener escuchador;


        List<Cliente> clientes = new List<Cliente>();

        public event delRecibirMensaje RecibirConexion;

        public event delRecibirMensaje RecibirMensaje;

        public void IniciarEscuchador(int puerto)
        {

            IPEndPoint miExtremo = new IPEndPoint(IPAddress.Any, puerto);

            escuchador = new TcpListener(miExtremo);
            escuchador.Start();

        }

        public void DetenerEscuchador()
        {
            escuchador.Stop();
            escuchador = null;
            GC.Collect();
        }



        public void VerificarConexionesEntrantes()
        {
            if (escuchador.Pending())
            {
                TcpClient cliente =  escuchador.AcceptTcpClient();
                clientes.Add(new Cliente( cliente));

                this.RecibirConexion(cliente.Client.RemoteEndPoint.ToString(), "Se conecto: ");
            
            }        
        
        }

        public void VerificarEntradaMensajes()
        {
            foreach (Cliente cliente in clientes)
            {
                string mensaje = cliente.Recibir();

                if (!string.IsNullOrWhiteSpace(mensaje))
                {
                    this.RecibirMensaje(cliente.extremoRemoto.ToString(), mensaje);
                }
            
            }
        
        }


        

    }
}

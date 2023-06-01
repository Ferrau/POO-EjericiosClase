using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Red;

namespace ClienteTCP
{
    public partial class Form1 : Form
    {
        public Cliente miCliente;

        public MiServidor servidor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (servidor == null)
            {
                servidor = new MiServidor();
                servidor.RecibirConexion += Servidor_RecibirConexion;
                servidor.RecibirMensaje += Servidor_RecibirMensaje;
            }

            servidor.IniciarEscuchador(8000);
            timer1.Start();
        }

        private void Servidor_RecibirMensaje(string origen, string mensaje)
        {

            listBox1.Items.Insert(0, mensaje);
            listBox1.Items.Insert(0, origen + " dice: ");
        }

        private void Servidor_RecibirConexion(string origen, string mensaje)
        {
            listBox1.Items.Insert(0, mensaje + " " + origen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            servidor.DetenerEscuchador();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            servidor.VerificarConexionesEntrantes();

            servidor.VerificarEntradaMensajes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            miCliente = new Cliente(int.Parse(textBox1.Text) );

            miCliente.Conectar(textBox2.Text, int.Parse(textBox3.Text));



        }

        private void button4_Click(object sender, EventArgs e)
        {
            miCliente.Enviar(textBox4.Text);
        }
    }
}

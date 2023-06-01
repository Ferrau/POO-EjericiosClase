using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RED;

namespace ClienteUDP
{
    public partial class Form1 : Form
    {
        MiSocket cliente; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente = new MiSocket(int.Parse(txtPuerto.Text));

            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente.EnviarMensaje(txtMensaje.Text, txtIpDestino.Text, int.Parse(txtPuertoDesstino.Text));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string mensaje = cliente.RecibirDatos();

            if (!string.IsNullOrWhiteSpace(mensaje))
            {
                listBox1.Items.Insert(0, mensaje);
            
            }
        }
    }
}

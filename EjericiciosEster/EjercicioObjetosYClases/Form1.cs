using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioObjetosYClases
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Cliente MiCliente;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Creamos una nueva instancia de la clase Cliente.
            MiCliente = new Cliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cargamos el nombre y el apellido
            MiCliente.Nombre = this.textBox1.Text;
            MiCliente.Apellido = this.textBox2.Text;
            this.label1.Text = MiCliente.Nombre.ToString() + " " + MiCliente.Apellido.ToString();
        
            //Leemos las propíedades

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre es: " + MiCliente.Nombre + "\r\nEl apellido es: " + MiCliente.Apellido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reloj R = new Reloj();
            R.Horas = int.Parse(textBox3.Text);
            this.textBox4.Text = (R.Horas * 3600).ToString();
        }
    }
}

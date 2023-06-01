using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2_EstacionServicio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
        }
        private Nafta nafta;

        public Nafta Nafta
        {
            get { return nafta; }
            set { nafta = value;
                textBox1.Text = nafta.Tipo;
                textBox2.Text = nafta.Precio.ToString();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nafta.Precio = float.Parse(textBox2.Text);
            nafta.Tipo = textBox1.Text;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

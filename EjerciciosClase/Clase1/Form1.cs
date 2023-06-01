using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1
{
    public partial class Form1 : Form
    {
        TELEVISOR tvSeleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(textBox1.Text ))
            {
                MessageBox.Show("Falta la marca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                TELEVISOR tv = new TELEVISOR();
                tv.marca = textBox1.Text;
                listBox1.Items.Add(tv);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MostrarDetalles();

        }

        void MostrarDetalles()
        {
            if (listBox1.SelectedItem != null)
            {
                tvSeleccionado = (TELEVISOR)listBox1.SelectedItem;
                label1.Text = "Marca: " + tvSeleccionado.marca;

                label2.Text = "Estado: " + tvSeleccionado.estado.ToString();

                label4.Text = $"Canal actual {tvSeleccionado.canalactual}";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tvSeleccionado?.Encender();
            MostrarDetalles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tvSeleccionado != null)
            { 
                if (!tvSeleccionado.SubirCanal())
                {
                    MessageBox.Show("La tele está apagada");
                }
                MostrarDetalles();
            }
        }
    }
}

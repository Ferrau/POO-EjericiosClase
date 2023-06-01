using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Clase_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                TV tele = new TV();

                tele.marca = textBox1.Text;

                listBox1.Items.Add(tele);
            }
            else
            {
                MessageBox.Show("Ingrese una marca");
            }


        }

        void Consultar(TV tv)
        {
            label1.Text = tv.marca;

            label2.Text = tv.encendido.ToString();

            label4.Text = tv.canal.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TV tv = (TV)listBox1.SelectedItem;
            Consultar(tv);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                TV tv = (TV)listBox1.SelectedItem;

                tv.Encender();

                Consultar(tv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                TV tv = (TV)listBox1.SelectedItem;

                if (!tv.SubirCanal())
                {
                    MessageBox.Show("La tele está apagada");
                }
                else
                {
                    Consultar(tv);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                TV tv = (TV)listBox1.SelectedItem;

                if (!tv.BajarCanal())
                {
                    MessageBox.Show("La tele está apagada");
                }
                else
                {
                    Consultar(tv);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instrumento ins;
            if (radioButton1.Checked)
            {
                ins = new Guitarra();
            }
            else if (radioButton2.Checked)
            {
                ins = new Piano();
            }
            else
            {
                ins = new GuitarraElectrica();
            }

            listBox1.Items.Add(ins);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CASTING: convierte el tipo de dato del objeto seleccionado a un
            //tipo de dato "Instrumento".

            Instrumento ins = (Instrumento)listBox1.SelectedItem;

            label1.Text = ins.Tocar();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is Guitarra)
            {
                Guitarra guitarra = (Guitarra)listBox1.SelectedItem;

                label2.Text = guitarra.Afinar();

            }
            else
            {
                label2.Text = "N/A";
            }

        }
    }
}

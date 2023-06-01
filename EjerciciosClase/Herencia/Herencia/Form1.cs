using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
            ImpresoraColor imp = new ImpresoraColor();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impresora imp;

            if (radioButton1.Checked)
            {
               imp = new Impresora();            
            }
            else
            {
                imp = new ImpresoraColor();             

            }

          



            imp.Marca = textBox1.Text;

            listBox1.Items.Add(imp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Impresora imp = (Impresora)listBox1.SelectedItem;
            label2.Text = imp.Imprimir();
            MostrarNivelesTinta();


        }


        void MostrarNivelesTinta()
        {
            Impresora imp = (Impresora)listBox1.SelectedItem;
            label3.Text = "Negro: " + imp.CartuchoNegro.Nivel.ToString();
            if (imp is ImpresoraColor)
            {
                ImpresoraColor ic = (ImpresoraColor)imp;
                label4.Text = "Azul: " + ic.CartuchoAzul.Nivel.ToString();
                 label5.Text = "Amarillo: " + ic.CartuchoAmarillo.Nivel.ToString();
                label6.Text = "Magenta: " + ic.CartuchoMagenta.Nivel.ToString();
            }
            else { 
                label4.Text="No corresponde";
                label5.Text="No corresponde";
                label6.Text = "No corresponde";
            }
        
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            MostrarNivelesTinta();


        }
    }
}

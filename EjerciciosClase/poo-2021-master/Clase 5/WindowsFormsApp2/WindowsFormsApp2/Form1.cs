using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Ligadura tardía o dinámica

            IMPRESORA imp;

                       
            if (radioButton3.Checked)
            {
                imp = new IMPRESORA();
            }
            else
            {
                imp = new ImpresoraColor();
            }
            

            imp.Marca = (radioButton1.Checked) ? "Epson" : "HP";

            listBox1.Items.Add(imp);


            listBox1.DisplayMember = "Marca";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMPRESORA imp = (IMPRESORA)listBox1.SelectedItem;

            if (imp is ImpresoraColor)
            {
                label1.Text = ((ImpresoraColor) imp ).ImprimirColor() ;
            }
            else
            {
                label1.Text = imp.Imprimir();
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMPRESORA imp = (IMPRESORA)listBox1.SelectedItem;
                        
            ConsultarNivelesdeTinta(imp);
        }


        public void ConsultarNivelesdeTinta( IMPRESORA imp )
        {
            
            label2.Text = imp.CARTUCHO.Color + " nivel: " + imp.CARTUCHO.Nivel.ToString();

            if (imp is ImpresoraColor)
            {
                //Unboxing

                ImpresoraColor imp2 = (ImpresoraColor)imp;

                label3.Text = imp2.Amarillo.Color + " nivel: " + imp2.Amarillo.Nivel.ToString();
                label4.Text = imp2.Cyan.Color + " nivel: " + imp2.Cyan.Nivel.ToString();
                label5.Text = imp2.Magenta.Color + " nivel: " + imp2.Magenta.Nivel.ToString();

            }

            else
            {
                label3.Text = "N/A";
                label4.Text = "N/A";
                label5.Text = "N/A";
            }





        }


    }
}

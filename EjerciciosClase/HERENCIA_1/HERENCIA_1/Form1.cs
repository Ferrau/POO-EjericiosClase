using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CARTUCHO cartucho = new CARTUCHO();
            cartucho.Nivel = 10;

            IMPRESORA imp;
                
            if(radioButton1.Checked)
            {
                imp = new IMPRESORA();
            }
            else
            {
                imp = new IMPRESORA_COLOR();

                //UNBOXING: 
                //utilizando constructor de copia, hablamos del mismo objeto.

                //Cuando igualo un objeto con otro, le estoy asignando la 
                //posicion de memoria donde se encuentra.

                //Son dos identidades distintas, cada una hace referencia a objeto
                //en memoria, como no las puedo llamar a las 2 igual, una la llamo
                //de una manera diferente.

                //Ej: El objeto Papa es el mismo que el objeto Bergolio, 
                //la identidad que le damos es distinta porque algunos lo conocen
                //por un nombre y otros por otro. Pero son el mismo objeto.

                IMPRESORA_COLOR imc = (IMPRESORA_COLOR)imp; //le agrego los cartuchos que faltan
                
                imc.Cyan = new CARTUCHO();
                imc.Cyan.Nivel = 10;
                imc.Amarillo = new CARTUCHO();
                imc.Amarillo.Nivel = 10;
                imc.MG = new CARTUCHO();
                imc.MG.Nivel = 10;
                
            }
                
            
            imp.Negro = cartucho;

            listBox1.Items.Add(imp);


        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMPRESORA imp = (IMPRESORA)listBox1.SelectedItem;

            label5.Text = imp.Imprimir();

            Mostrar(imp);

        }

        void Mostrar(IMPRESORA imp)
        {
            label1.Text = "Nivel de tinta negra: " + imp.Negro.Nivel.ToString();

            if(imp is IMPRESORA_COLOR)
            {
                //OTRA FORMA DE HACER UN CONSTRUCTOR DE COPIA
                label2.Text = "Nivel de tinta cyan: " + ((IMPRESORA_COLOR) imp).Cyan.Nivel.ToString();
                label3.Text = "Nivel de tinta mg: " + ((IMPRESORA_COLOR)imp).MG.Nivel.ToString();
                label4.Text = "Nivel de tinta Amarillo: " + ((IMPRESORA_COLOR)imp).Cyan.Nivel.ToString();
            }
            else
            {
                label2.Text = "N/A";
                label3.Text ="N/A";
                label4.Text ="N/A";

            }



        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMPRESORA imp = listBox1.SelectedItem as IMPRESORA;
            Mostrar(imp);
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic
{
    public partial class Form1 : Form
    {
            
        public Form1()
        {
            InitializeComponent();
        }

        void Mostrar(object vari)
        {
            var variable = vari;
            label1.Text = variable.GetType().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
           
                Mostrar("hola mundo");
            
            }
            else if (radioButton2.Checked)
            {
                Mostrar(55);             

            }
            else if (radioButton3.Checked)
            {
                Mostrar(55f);
            }
            else
            {
                Mostrar(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text += e.KeyCode.ToString(); 
        }
    }
}

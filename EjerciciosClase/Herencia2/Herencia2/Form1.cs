using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Instrumento ins = new Piano();
            ins.Nombre = "Piano";
            listBox1.Items.Add(ins);
            ins = new Guitarra();
            ins.Nombre = "Guitarra";
            listBox1.Items.Add(ins);

            Organo org = new Organo();

            org.Nombre = "Organo";
            listBox1.Items.Add(org);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instrumento ins = (Instrumento)listBox1.SelectedItem;

            label1.Text = ins.Tocar();
        }
    }
}

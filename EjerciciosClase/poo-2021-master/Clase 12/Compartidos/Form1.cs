using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compartidos
{
    public partial class Form1 : Form
    {
        List<TV> tvs = new List<TV>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TV t = new TV();

            tvs.Add(t);
            enlazar();
          
        }


        void enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = tvs;

            listBox1.DisplayMember = "CanalActual";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TV.Canal = int.Parse(textBox1.Text);

            enlazar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TV.CambiarCanal(int.Parse(textBox1.Text));


            MessageBox.Show("HOLA MUNDO");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}

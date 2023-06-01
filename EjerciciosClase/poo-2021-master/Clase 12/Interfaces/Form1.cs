using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ITocable ins = (ITocable)listBox1.SelectedItem;

            label1.Text = ins.tocar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ITocable ins = new Piano();


            listBox1.Items.Add(ins);


            ins = new Rallador();

            listBox1.Items.Add(ins);

        }
    }
}

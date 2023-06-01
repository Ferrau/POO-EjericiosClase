using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces2
{
    public partial class Form1 : Form
    {

        List<PERSONA> personas = new List<PERSONA>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int n = 0; n < 50; n++)
            {
                personas.Add(new PERSONA());
            }


            Enlazar();
        }


        void Enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = personas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personas.Sort();
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PERSONA p = (PERSONA)listBox1.SelectedItem;

            PERSONA p2 = new PERSONA();

            p2.Nombre = p.Nombre;
            p2.Edad = p.Edad;

            listBox2.Items.Add(p2);

            listBox2.Items.Add(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PERSONA p = (PERSONA)listBox1.SelectedItem;
            PERSONA p2 = (PERSONA)listBox2.SelectedItem;

            MessageBox.Show(p.Equals( p2).ToString() );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PERSONA p = (PERSONA)listBox1.SelectedItem;

            PERSONA p2 = (PERSONA)p.Clone();


            listBox2.Items.Add(p2);

            listBox2.Items.Add(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (PERSONA p = new PERSONA())
            {
                p.Nombre = "CHRISTIAN";
                p.Edad = 40;
                p.Dispose();
               
            }

        


        }
    }
}

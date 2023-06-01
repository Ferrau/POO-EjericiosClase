using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
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
            Grilla.DataSource = null;
            Grilla.DataSource = personas;
        }


        void Enlazar(List<PERSONA> pers)
        {
            Grilla.DataSource = null;
            Grilla.DataSource = pers;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var query = ( from PERSONA p in personas
                          where p.Nombre.IndexOf(textBox1.Text)>-1
                          orderby p.Edad descending, p.Nombre ascending
                          select p);

            Enlazar(query.ToList());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Func<int,int> numero = x => x*2  ;


            MessageBox.Show(numero(5).ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (personas.Exists(x => x.Nombre == "Persona -2"))
            {
                MessageBox.Show("Existe");
            }
            else
            {
                MessageBox.Show("No Existe");
            }
        }
    }
}

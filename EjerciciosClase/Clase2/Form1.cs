using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2
{
    public partial class Form1 : Form
    {
        public List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = textBox1.Text;

            listBox1.Items.Add(p);

            listBox1.DisplayMember = "NombreCompleto";

            personas.Add(p);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personas;
        }
    }
}

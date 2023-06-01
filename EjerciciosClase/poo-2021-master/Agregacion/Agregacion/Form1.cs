using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agregacion
{
    public partial class Form1 : Form
    {
        List<PERSONA> personas = new List<PERSONA>();
        public JUEZ juez = new JUEZ();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int n = 1; n < 20; n++)
            {
                PERSONA persona = new PERSONA();
                persona.Nombre = "PERSONA " + n.ToString();
                personas.Add(persona);


            }

            listBox1.DataSource = personas;
            listBox1.DisplayMember = "Nombre";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 1)
            {
                PAREJA pareja = juez.Casar((PERSONA)listBox1.SelectedItems[0], (PERSONA)listBox1.SelectedItems[1]);
                if (pareja != null)
                {
                    listBox2.Items.Add(pareja);
                    listBox2.DisplayMember = "NombrePareja";
                }
                else
                {
                    label1.Text = "No se puede casar con uno mismo";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItem == ((PAREJA)listBox2.SelectedItem).Persona1) ? "Es el mismo objeto en memoria" : "Son objetos diferentes"; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItem == ((PAREJA)listBox2.SelectedItem).Persona2) ? "Es el mismo objeto en memoria" : "Son objetos diferentes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAREJA pareja = (PAREJA)listBox2.SelectedItem;

            listBox2.Items.Remove(pareja);

            pareja = null;
        }
    }
}

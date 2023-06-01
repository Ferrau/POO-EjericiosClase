using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3
{
    public partial class Form1 : Form
    {
        JUEZ juez = new JUEZ();

        List<PAREJA> casados = new List<PAREJA>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) )
            {

                PERSONA p = new PERSONA();
                p.Nombre = textBox1.Text;
                p.Apellido = textBox2.Text;
                listBox1.Items.Add(p);
                listBox1.DisplayMember = "NomApe"; 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 2)
            {
                PERSONA p1 = (PERSONA)listBox1.SelectedItems[0];
                PERSONA p2 = (PERSONA)listBox1.SelectedItems[1];

                PAREJA par = juez.Casar(p1, p2);

                casados.Add(par);

                listBox1.Items.Remove(p1);
                listBox1.Items.Remove(p2);

                Enlazar();
            }          





        }


        public void Enlazar()
        {

            listBox2.DataSource = null;
            listBox2.DataSource = casados;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(listBox2.SelectedItem != null)
            {
                PAREJA par = (PAREJA)listBox2.SelectedItem;
                List<PERSONA> personas = juez.Divorciar(par);

                casados.Remove(par);

                Enlazar();

                listBox1.Items.AddRange(personas.ToArray());

            }


        }
    }
}

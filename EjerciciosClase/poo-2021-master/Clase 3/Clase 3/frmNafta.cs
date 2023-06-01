using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_3
{
    public partial class frmNafta : Form
    {
        public frmNafta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nafta nafta = (Nafta)listBox1.SelectedItem;

            nafta.Nombre = textBox1.Text;

            nafta.Precio = float.Parse(textBox2.Text);

        }

        Estacion estacion;      
        
        
        private void frmNafta_Load(object sender, EventArgs e)
        {

            estacion = ((Form1)this.MdiParent).estacion;

            listBox1.Items.Add(estacion.Nafta1 );
            listBox1.Items.Add(estacion.Nafta2);
            listBox1.Items.Add(estacion.Nafta3);

            listBox1.DisplayMember = "Nombre";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nafta nafta = (Nafta)listBox1.SelectedItem;

            textBox1.Text = nafta.Nombre;

            textBox2.Text = nafta.Precio.ToString();

        }
    }
}

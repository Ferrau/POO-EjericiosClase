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
    public partial class frmSurtidor : Form
    {
        Estacion estacion;
        public frmSurtidor()
        {
            InitializeComponent();
        }

        private void frmSurtidor_Load(object sender, EventArgs e)
        {
            estacion = ((Form1)this.MdiParent).estacion;

            comboBox1.Items.Add(estacion.Nafta1);

            comboBox1.Items.Add(estacion.Nafta2);

            comboBox1.Items.Add(estacion.Nafta3);

            comboBox1.DisplayMember = "Nombre";

            listBox1.Items.Add(estacion.Surtidor1);
            listBox1.Items.Add(estacion.Surtidor2);
            listBox1.Items.Add(estacion.Surtidor3);

            listBox1.DisplayMember = "Numero";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Surtidor surtidor = (Surtidor)listBox1.SelectedItem;

            surtidor.Numero = int.Parse(textBox1.Text);

            surtidor.Capacidad = int.Parse(textBox2.Text);
            surtidor.Nafta = (Nafta)comboBox1.SelectedItem;

            listBox1.Refresh();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Estacion estacion = new Estacion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            estacion.Nafta1.Nombre = "Normal";
            estacion.Nafta2.Nombre = "Premium";

            estacion.Nafta3.Nombre = "Super";

            estacion.Nafta1.Precio = 17;
            estacion.Nafta2.Precio = 18.5f;
            estacion.Nafta3.Precio = 21.3f;



        }

        private void nAFTAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmNafta frm = new frmNafta();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void sURTIDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSurtidor frm = new frmSurtidor();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

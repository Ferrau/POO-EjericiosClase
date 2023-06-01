using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class frmConsulta : Form, ICerrable
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        public event delCerrar Cerrar;

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void frmConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Cerrar(this);
        }
    }
}

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
    public partial class frmPrincipal : Form
    {

        frmInscripcion frmInsc = null;

        frmConsulta frmC =null;
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea  Salir?", "¿Sales Corriendo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }

        private void inscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInsc == null)
            {
                frmInsc = new frmInscripcion();
                frmInsc.MdiParent = this;
                frmInsc.Show();
                frmInsc.StartPosition = FormStartPosition.CenterParent;

                frmInsc.Cerrar += Frm_Cerrar;
            }
        }

        private void Frm_Cerrar(Form unFormulario)
        {
            if (unFormulario is frmInscripcion)
            {
                frmInsc = null;
            }
            else if (unFormulario is frmConsulta)
            {
                frmC = null;
            }

            GC.Collect();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmC == null)
            {

                frmC = new frmConsulta();
                frmC.MdiParent = this;
                frmC.Show();

                frmC.Cerrar += Frm_Cerrar;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocumento doc = new frmDocumento();
            doc.MdiParent = this;
            doc.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscar frmB = new frmBuscar();
            frmB.ShowDialog();

            string criterio = frmB.Criterio;

            Form formulario = (from Form f in this.MdiChildren
                               where f.Text == criterio
                               select f
                                ).FirstOrDefault();

            if (formulario == null)
            {
                MessageBox.Show("El formulario no existe");
            }
            else
            {
                formulario.Focus();
            }

        }
    }
}

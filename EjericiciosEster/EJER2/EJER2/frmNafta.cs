using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJER2
{
    public partial class frmNafta : Form
    {
        public frmNafta()
        {
            InitializeComponent();
        }

        private Nafta nafta;

        public Nafta Nafta
        {
            get { return nafta; }
            set { nafta = value;
                textBox1.Text = nafta.Nombre;
                textBox2.Text = nafta.Precio.ToString();
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nafta.Precio = float.Parse(textBox2.Text);
            nafta.Nombre = textBox1.Text;

            this.Close();
        }

        private void frmNafta_Load(object sender, EventArgs e)
        {

        }
    }
}

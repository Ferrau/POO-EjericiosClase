using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public libreria Lib = new libreria();

        private venta VentaActual = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(this.maskedTextBox1.Text))
            {
                producto p = new producto();
                p.Cb = textBox1.Text;
                p.Nombre = textBox2.Text;
                p.Precio = float.Parse(maskedTextBox1.Text);
                p.Descrip = textBox3.Text;

                Lib.Productos.Add(p);

                listBox1.DataSource = null;
                listBox1.DataSource = Lib.Productos;

                listBox1.DisplayMember = "Nombre";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaActual = new venta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(VentaActual != null)
            {
                itemventa item = new itemventa();

                item.Cantidad = int.Parse(maskedTextBox2.Text);
                item.Producto = (producto)listBox1.SelectedItem;
                VentaActual.Items.Add(item);
                VentaActual.CalcularSubtotal();
                label6.Text = "Subtotal " + VentaActual.Subtotal.ToString();

                listBox2.DataSource = null;
                listBox2.DataSource = VentaActual.Items;
                listBox2.DisplayMember = "desc";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VentaActual != null && VentaActual.Items.Count >0)
            {
                Lib.Ventas.Add(VentaActual);
                VentaActual = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lib.CalcularTotalRecaudado();
            label7.Text = Lib.Recaudacion.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

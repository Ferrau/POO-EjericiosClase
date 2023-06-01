using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_2___EJERCICIO_1
{
    public partial class Form1 : Form
    {
        Libreria libreria = new Libreria();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!libreria.IniciarVenta())
            {
                MessageBox.Show("Ya hay una venta iniciada");
            }
            else
            {
                button2.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            libreria.FinalizarVenta();
            button2.Enabled = false;
            button1.Enabled = true;
            Blanquear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto");
            }
            else
            { 
                Producto producto = new Producto();
                producto.Nombre = textBox2.Text;
                producto.Codigo = textBox1.Text;
                producto.descripcion = textBox3.Text;
                producto.precio = float.Parse(textBox4.Text);

                listBox1.Items.Add(producto);
                listBox1.DisplayMember = "Nombre";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (libreria.ventaActual != null)
            {
                int cantidad = int.Parse(textBox5.Text);
                Producto producto = (Producto)listBox1.SelectedItem;

                libreria.ventaActual.AgregarProducto( cantidad, producto );

                lblSubtotal.Text = "$ " + libreria.ventaActual.Subtotal.ToString();

            }
            else
            {
                MessageBox.Show("No hay una venta iniciada");
            }

        }

        void Blanquear()
        {
            textBox5.Text = "";
            lblSubtotal.Text = "$ 0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblRecaudacion.Text = libreria.total.ToString();
        }
    }
}

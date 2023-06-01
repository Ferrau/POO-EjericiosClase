using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2_EstacionServicio
{
    public partial class Form1 : Form
    {
        ESTACION estacion = new ESTACION();
         

        
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(estacion.Surtidor1);
            comboBox1.Items.Add(estacion.Surtidor2);
            comboBox1.Items.Add(estacion.Surtidor3);

            comboBox2.Items.Add(estacion.Normal);
            comboBox2.Items.Add(estacion.Super);
            comboBox2.Items.Add(estacion.Premium);
        }

        void MostrarDetalle()
        {
            Surtidor surtidor = ((Surtidor)listBox1.SelectedItem);

            textBox3.Text = surtidor.LitrosRestantes.ToString();

            //2)	Obtener la recaudación total de un surtidor
            textBox4.Text = surtidor.TotalRecaudacion.ToString();

            //1)	Obtener la recaudación total de la estación de servicio
            textBox2.Text = estacion.ObtenerRecaudacion().ToString();

            //3)	Obtener el surtidor que más recaudó.
            textBox5.Text = estacion.SurtidorMasRecaudacion().ToString();

            //4)	Obtener el surtidor que menos recaudó
            textBox6.Text = estacion.SurtidorMenosRecaudacion().ToString();

            //5)	Obtener el surtidor que más clientes tuvo.
            textBox7.Text = estacion.MayorCantClientes().ToString();

            //9)	Mostrar el surtidor con mayor cantidad recargas. 
            textBox14.Text = estacion.MayorCantRecargas().ToString();

            //10)	Calcular el promedio de ventas por surtidor.


            //11)	Calcular el promedio de recaudación por surtidor.
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void InicarCarga_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
          


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Surtidor surtidor = (Surtidor)comboBox1.SelectedItem;
            Nafta nafta = (Nafta)comboBox2.SelectedItem;

            //Hay que recargar el surtidor con la nafta que elegimos.
            surtidor.Nafta = nafta;
            surtidor.Recarcar();

            //las removemos de los combobox
            comboBox1.Items.Remove(surtidor);
            comboBox2.Items.Remove(nafta);


            listBox1.Items.Add(surtidor);


            

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            //Casting: saco para afuera lo que estoy seleccionando y le digo que es.
            Nafta nafta = (Nafta)comboBox2.SelectedItem;

            //Se lo paso al otro formulario para que se lo lleve.
            form.Nafta = nafta;

            form.ShowDialog();

            comboBox2.Items.Remove(nafta);
            comboBox2.Items.Add(nafta);



        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((Surtidor)listBox1.SelectedItem).VentaNafta((float)numericUpDown1.Value).ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Surtidor surtidor = (Surtidor)listBox1.SelectedItem;

            if (!surtidor.Vender((float)numericUpDown1.Value))
            {
                MessageBox.Show("No hay nafta para la venta");
            }
            else
            {
                MostrarDetalle();
            }

            
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
       
        ESTACION_SERVICIO estacionDeServicio = new ESTACION_SERVICIO();

            List<SURTIDOR> listaSurtidor = new List<SURTIDOR>();

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(estacionDeServicio.Surtidor1);
            comboBox1.Items.Add(estacionDeServicio.Surtidor2);
            comboBox1.Items.Add(estacionDeServicio.Surtidor3);

            comboBox3.Items.Add(estacionDeServicio.Super);
            comboBox3.Items.Add(estacionDeServicio.Premium);
            comboBox3.Items.Add(estacionDeServicio.Normal);



        }

        private void btnRealizarCarga_Click(object sender, EventArgs e)
        {
            string naftaS = comboBox1.SelectedItem.ToString();
            numericUpDown1.Value = 0;
        }

          

        private void btnRealizarRecarga_Click(object sender, EventArgs e)
        {
           SURTIDOR surtidor = (SURTIDOR)listBox1.SelectedItem;

           if(!surtidor.Vender((float) numericUpDown1.Value) )
           {
                MessageBox.Show("No tiene nafta");
            }
           else
            {
                MostrarInfo();
            }


        }

        void MostrarInfo()
        {
            //Muestro surtidor con mayor recargas
            label25.Text = "Surtidor con mayor cantidad ventas: " + estacionDeServicio.MostrarSurtiMasVentas().ToString();
            // Obtengo surtidor con mas recargas
            textBox4.Text = estacionDeServicio.MostrarSurtiMasRecargas().Nombre;

            // Obtengo surtidor que mas recaudo
            textBox2.Text = estacionDeServicio.MostrarSurtiMasRecaudacion().Nombre;

            // Obtengo surtidor que menos recaudo
            textBox3.Text = estacionDeServicio.MostrarSurtiMenorRecaudacion().Nombre;

            SURTIDOR surtidor = ((SURTIDOR)listBox1.SelectedItem);


            lblLitrosRest.Text = $"Litros Restantes: {surtidor.LitrosRestantes}";
            label24.Text = $"Recaudación {surtidor.Recaudacion}";

            // Actualizo el textBox de la recaudación total


            txtRecTotaEst.Text = "$" + estacionDeServicio.ObtenerRecaudacion();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            frmNafta frm = new frmNafta();

            Nafta nafta = (Nafta)comboBox3.SelectedItem; 

            frm.Nafta = nafta;

            frm.ShowDialog();

            comboBox3.Items.Remove(nafta);
            comboBox3.Items.Add(nafta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SURTIDOR surtidor = (SURTIDOR)comboBox1.SelectedItem;
            Nafta nafta = (Nafta)comboBox3.SelectedItem;

            surtidor.Nafta = nafta;
            surtidor.Recargar();

            comboBox3.Items.Remove(nafta);
            comboBox1.Items.Remove(surtidor);

            listBox1.Items.Add(surtidor);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((SURTIDOR)listBox1.SelectedItem).Recargar();
            MostrarInfo();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = "$" + ((SURTIDOR)listBox1.SelectedItem).ObtenerPrecio((float)numericUpDown1.Value).ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPorNorm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPreXLitro_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

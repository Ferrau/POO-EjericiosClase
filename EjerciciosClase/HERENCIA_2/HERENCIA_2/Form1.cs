﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lo declaro como instrumento pero lo instancio como Piano.
            INSTRUMENTO ins = new Piano(); //ligadura temprana o estica
            ins.Nombre = "Piano";
            listBox1.Items.Add(ins);

            ins = new Guitarra(); //NEW: nueva posicion de memoria
            ins.Nombre = "Guitarra";
            listBox1.Items.Add(ins);



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            INSTRUMENTO ins = (INSTRUMENTO)listBox1.SelectedItem;
            label1.Text = ins.Tocar();
        }
    }
}

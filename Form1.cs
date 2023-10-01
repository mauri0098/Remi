﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Remi
{
    public partial class Form1 : Form
    {
        REMIS oRemis;
        DataTable tRemis;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            REMIS oChofer = new REMIS();
            DataRow fila = oChofer.buscar(Convert.ToInt32(txtchofer.Text));
            if (fila == null)
            {
                MessageBox.Show("EL NUMERO DE CHOFER NO EXISTE", "ERROR");
            }
            else
            {
                textBox2.Text = fila["nombre"].ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            REMIS onombre = new REMIS();

            onombre.Chofer = Convert.ToInt32(txtchofer.Text);
            onombre.Nombre = textBox2.Text;

            onombre.modificar();

            txtchofer.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

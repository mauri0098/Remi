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
    public partial class Form2 : Form
    {
        DataTable tabla;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                string d1 = fila["nombre"].ToString().ToUpper();
                string d2 = textBox1.Text.ToUpper();

                int pos = d1.IndexOf(d2);
                if (pos != -1)
                {
                    dataGridView1.Rows.Add(fila["nombre"], fila["chofer"]);
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           REMIS oremis = new REMIS();
            tabla = oremis.getData();
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

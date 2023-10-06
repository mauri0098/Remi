using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remi
{
    public partial class Form11 : Form
    {
        DataTable tablaCOMPLETA;
        
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            REMIS rEMIS = new REMIS();// PARTA QUE ME APARESCA TODA LA TABLA MAS FACIL ES CON UN GETDATA 
            tablaCOMPLETA= rEMIS.getData();
            dataGridView1.DataSource = tablaCOMPLETA;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

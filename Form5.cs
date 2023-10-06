using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Remi
{
    public partial class Form5 : Form
    {
        DataTable tablaBarrios;
        DataTable tablaViajes;
        DataTable tabladechofers;//CREO UNA DATATABLET
        public Form5()
        {
            InitializeComponent();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvViajes.Rows.Clear();
            TotalViajes viaje = new TotalViajes();
            tablaViajes = viaje.getData();

            barrio barrio = new barrio();
            tablaBarrios = barrio.getData();
            foreach (DataRow filaViaje in tablaViajes.Rows)
            {
                if (filaViaje["chofer"].ToString() == lst.SelectedValue.ToString())
                {
                    DataRow desdeBarrio = tablaBarrios.Rows.Find(Convert.ToInt32(filaViaje["desdebarrio"]));
                    DataRow hastaBarrio = tablaBarrios.Rows.Find(Convert.ToInt32(filaViaje["hastabarrio"]));
                    DateTime fechaViaje = Convert.ToDateTime(filaViaje["fecha"]);
                    dgvViajes.Rows.Add(fechaViaje.ToString("dd/MM/yyyy"), desdeBarrio["nombre"], hastaBarrio["nombre"], filaViaje["km"], Convert.ToDecimal(filaViaje["importe"]));
                }
            }



        }

        private void Form5_Load(object sender, EventArgs e)
        {
           REMIS Ochofer = new REMIS();//ABRO LA CLASE  CREO EL OBJETO CHOFER
            tabladechofers = Ochofer.getData();//metodo getdata para traer la tabla de los choferes
            lst.DataSource = tabladechofers;//vincula los datos de la tabla con la listbox
            lst.DisplayMember = "nombre";//muestrra el nombre 
            lst.ValueMember = "chofer";//muestra el los choferes



        }
    }
}

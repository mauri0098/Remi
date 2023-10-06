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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {

            REMIS Ochoferes = new REMIS();
            DataTable tablanombre = Ochoferes.getData();//ABRO LA CLASE  CREO EL OBJETO CHOFER
            TotalViajes Oviajes = new TotalViajes();
            DataTable tViajes = Oviajes.getData();
            DateTime Desde = Convert.ToDateTime(dtpFechaDesde.Text);//creo dos variables datetime y las declaro como la fecha
            DateTime hasta = Convert.ToDateTime(dtpFechaHasta.Text);//creo dos variables datetime y las declaro como la fecha
            dgvViajes.Rows.Clear();//borro 

            foreach (DataRow FilaViaje in tViajes.Rows)//que recora fila viaje en la tabla VIAJES
            {
                DateTime fechaViaje = Convert.ToDateTime(FilaViaje["fecha"]);//HAGO OTRA VARIABLE Y LA USO COMO DATATIME
                if (fechaViaje >= Desde && fechaViaje <= hasta)//UN IF QUE DEGA DESDE Y HAASTA DONDE ELIJO LA FECHA
                {

                    DataRow filachofer = tablanombre.Rows.Find(Convert.ToString(FilaViaje["chofer"]));
                    string fecha = fechaViaje.ToString("dd/MM/yyyy");
                    dgvViajes.Rows.Add(FilaViaje["viaje"], fecha, filachofer["nombre"], FilaViaje["importe"]);//al datagrid le digo



                }
                

            }


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            




        }
    }
}

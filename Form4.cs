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
            DataTable tablanombre = Ochoferes.getData();
            TotalViajes Oviajes = new TotalViajes();
            DataTable tViajes = Oviajes.getData();
            DateTime Desde = Convert.ToDateTime(dtpFechaDesde.Text);
            DateTime hasta = Convert.ToDateTime(dtpFechaHasta.Text);
            dgvViajes.Rows.Clear();

            foreach (DataRow FilaViaje in tViajes.Rows)
            {
                DateTime fechaViaje = Convert.ToDateTime(FilaViaje["fecha"]);
                if (fechaViaje >= Desde && fechaViaje <= hasta)
                {

                    DataRow filachofer = tablanombre.Rows.Find(Convert.ToString(FilaViaje["chofer"]));
                    string fecha = fechaViaje.ToString("dd/MM/yyyy");
                    dgvViajes.Rows.Add(FilaViaje["viaje"], fecha, filachofer["nombre"], FilaViaje["importe"]);//al datagrid le digo



                }
                

            }


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            REMIS Ochoferes = new REMIS();
            DataTable tNombre = Ochoferes.getData();
            TotalViajes Oviajes = new TotalViajes();
            DataTable tViajes = Oviajes.getData();
            DateTime Desde = Convert.ToDateTime(dtpFechaDesde.Text);
            DateTime hasta = Convert.ToDateTime(dtpFechaHasta.Text);
            dgvViajes.Rows.Clear();

            foreach (DataRow FilaViaje in tViajes.Rows)
            {
                DateTime fechaViaje = Convert.ToDateTime(FilaViaje["fecha"]);
                if (fechaViaje <=Desde && fechaViaje >=hasta )
                {
                    




                }
                dgvViajes.Rows.Add(FilaViaje["viaje"],fechaViaje, FilaViaje["chofer"], FilaViaje["importe"]);

            }




        }
    }
}

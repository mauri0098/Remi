using System;
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
    public partial class Form3 : Form
    {
        DataTable tabla;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          REMIS       chofer = new REMIS();//creo la objeto
          DataTable Tchoferes = chofer.getData();//traigo la tabla con el metodo 
          TotalViajes totalViajes = new TotalViajes();//creo la objeto
          DataTable   Tviajes   =  totalViajes.getData();//traigo la tabla con el metodo 
            foreach (DataRow filasChofer in Tchoferes.Rows)//hago que recorra todas la FILAS de chofer en la TABLA DE CHOFER (Tchoferes)
            {
                 decimal Total = 0;//variable decimal 0
                foreach (DataRow filasViajes in Tviajes.Rows)//hago que recorra todas la FILAS de Viaje en la TABLA DE VIAJES (Tviajes)
                {
                    if (filasChofer["chofer"].ToString() == filasViajes["chofer"].ToString())//UN IF QUE PREGUNTA SI LAS FILAS DE CHOFER SON IGUALES A LAS FILAS DE VIAJES CHOFER
                    {
                        Total += Convert.ToDecimal(filasViajes["importe"]);//SUMA LA VARIABLE DE TOTAL CON EL IMPORTE
                    }
                }
                dptcuadro.Rows.Add(filasChofer["nombre"],Total);//LO MUESTRA





            }
            





        }
    }
}

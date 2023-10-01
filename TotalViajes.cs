using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remi
{
    internal class TotalViajes
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        public TotalViajes()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=REMISYA.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Viajes";

            adaptador = new OleDbDataAdapter(comando);

            tabla = new DataTable();

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["chofer"];
            tabla.PrimaryKey = vec;
        }
        public void ver(DataGridView dptcuadro2)//lo llama de otro formulario
        {
            dptcuadro2.DataSource = tabla;//lo mostramos en la tabla




        }

    }
}

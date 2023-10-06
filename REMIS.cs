using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Remi
{
    class REMIS
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        string cadena;
        private int chofer;

        public int Chofer
        {
            get { return chofer; }
            set { chofer = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }




        public REMIS()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=REMISYA.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Choferes";

            adaptador = new OleDbDataAdapter(comando);

            tabla = new DataTable();

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["chofer"];
            tabla.PrimaryKey = vec;

        }

        public DataRow buscar(int chofer)
        {
            DataRow fila = tabla.Rows.Find(chofer);
            return fila;
        }
        public void modificar() //LO GRABA EM MEMORIA
        {
            DataRow fila = tabla.NewRow();
            fila["chofer"] = chofer;
            fila["nombre"] = nombre;
            tabla.Rows.Add(fila);
            

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
        }

        public DataTable getData()
        {
            return tabla;
        }
        public void ver(ListBox lst) //LO GRABA EM MEMORIA
        {
            lst.DisplayMember = "nombre";
            lst.ValueMember = "chofer";
            lst.DataSource = tabla;


            
        }





    }

}
    
    





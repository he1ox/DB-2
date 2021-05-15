using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CRUD1A.CLASES.archivos;
using CRUD1A.CLASES.baseDatos;

namespace CRUD1A
{
    public partial class frmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void mostrarPopUp(string mensaje)
        {
            //Muestra un mensaje en el navegador. 
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", $"alert('{mensaje}');", true);
        }

        private bool CargarArchivoExterno()
        {
            try
            {
                string fuente = @"C:\Users\georg\source\repos\PARCIAL II\crudDB.csv";
                clsArchivo ar = new clsArchivo();
                clsConexion cn = new clsConexion();



                //obtener todo el archivo en un arreglo
                string[] arregloNotas = ar.LeerArchivo(fuente);

                string sentencia_sql = "";
                int NumeroLinea = 0;


                //Iterando el arreglo, linea x linea para luego convertirlo en datos indivuales
                foreach (string linea in arregloNotas)
                {
                    string[] datos = linea.Split(';');
                    if (NumeroLinea > 0)
                    {
                        sentencia_sql += $"INSERT INTO tb_alumnos VALUES({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                    }
                    NumeroLinea++;
                } //end foreach
                NumeroLinea = 0;
                cn.EjecutaSQLDirecto(sentencia_sql); //mandar todo a la BD

                return true;
            }
            catch
            {
                return false;
            }
            
        }


        protected void ButtonCargaDatos_Click(object sender, EventArgs e)
        {
            bool Success = CargarArchivoExterno();
            if (Success != false)
            {
                mostrarPopUp("Se ha cargado la BD con exito.");
            }
            else
            {
                mostrarPopUp("No se ha cargado la BD.");
            }
        }


        protected void btnBuscarID_Click1(object sender, EventArgs e)
        {
            string id = txtboxID.Text.Trim();
            clsConexion cn = new clsConexion();
            DataTable dt = new DataTable();

            string sentencia = $"SELECT * FROM tb_alumnos WHERE correlativo = {id}";

            dt = cn.consultaTablaDirecta(sentencia);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                txtBoxNombre.Text = nombre;
            }
        }




        protected void btnBuscarID_Click(object sender, EventArgs e)
        {
            //sin Uso
        }
    }
}
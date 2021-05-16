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
    public partial class formMYSQL : System.Web.UI.Page
    {
        mysqlConexion sqlconexion;

        protected void Page_Load(object sender, EventArgs e)
        {
            sqlconexion = new mysqlConexion();
        }

        protected void btnCargarDatos_Click(object sender, EventArgs e)
        {
            bool successDatos = CargarArchivoExterno();
            if (successDatos != false)
            {
                mostrarPopUp("Los datos se han cargado.");
                //Muestra un boton que da la posibilidad de eliminar los datos del .CSV
                btnEliminarDatos.Visible = true;
            }
            else
            {
                mostrarPopUp("No se ha cargado ningun dato.");
            }
        }

        protected void btnProbarBD_Click(object sender, EventArgs e)
        {
            bool success = sqlconexion.testBD();
            if (success != false)
            {
                mostrarPopUp("Conectado con exito.");
                this.btnProbarBD.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                mostrarPopUp("No se ha conectado a la bd.");
                this.btnProbarBD.BackColor = System.Drawing.Color.Red;
            }
        }


        protected void btnBuscarID_Click(object sender, EventArgs e)
        {
            string id = txtBoxID.Text.Trim();
            string condicion = $"correlativo = {id}";

            DataTable dataID = CargarDatosDB(condicion);

            if (dataID.Rows.Count > 0)
            {
                string nombre = dataID.Rows[0].Field<string>("nombre");
                txtBoxNombre.Text = nombre;
            }
            else
            {
                mostrarPopUp("Vuelve a intentarlo.");
                txtBoxNombre.Text = "No se han encontrado resultados.";
            }
        }


        protected void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";


            DataTable dataNombre = CargarDatosDB(condicion);


            if (dataNombre.Rows.Count > 0)
            {
                int id = dataNombre.Rows[0].Field<int>("correlativo");
                txtBoxID.Text = id.ToString();
            }
            else
            {
                mostrarPopUp("Vuelve a intentarlo.");
                txtBoxNombre.Text = "No se han encontrado resultados.";
            }
        }


        protected void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            string sentencia = "DELETE FROM tb_alumnos";
            sqlconexion.EjecutaSQLDirecto(sentencia);
            mostrarPopUp("Datos eliminados.");
            this.btnEliminarDatos.Visible = false;
        }



        //Espacio para funciones

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
                sqlconexion.EjecutaSQLDirecto(sentencia_sql); //mandar todo a la BD

                return true;
            }
            catch
            {
                return false;
            }

        }


        



        public DataTable CargarDatosDB(String condicion = "1=1")
        {
            DataTable dt = new DataTable();
            string sentencia = $"SELECT * FROM tb_alumnos WHERE {condicion}";

            dt = sqlconexion.consultaTablaDirecta(sentencia);

            return dt;
        }

        

        //End Funciones


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tarea
{
    class Funcionalidades
    {
        /*
         * atributo necesario para la conexion con 
         * sql server
         */
        SqlConnection conexionBaseDatos;

        /*
         * inicializa la clase que conecta con sql server
         * con el string de la conexion
         */
        public Funcionalidades(string stringConexion) {
            conexionBaseDatos = new SqlConnection(stringConexion);
        }

        /*
         * abre la conexion entre sql server y c#
         * por medio de la libreria
         */
        public void abrirConexion() {
            conexionBaseDatos.Open();
        }

        /*
         * cierra la conexion entre sql server y c#
         * por medio de la libreria
         */
        public void cerrarConexion() {
            conexionBaseDatos.Close();
        }

        /*
         * comando que realiza los update de la base de datos 
         * desde c#
         */
        public void actualizarValoresBaseDatos(string query, string columna, string condicionWhere) {
            string updateQuery = query + " where " + columna + "="  + condicionWhere;
            SqlCommand comandoEjecutar = new SqlCommand(updateQuery, conexionBaseDatos);
            comandoEjecutar.ExecuteNonQuery();
        }

        /*
         * comando que realiza los delete de la base de datos 
         * desde c#
         */
        public void eliminarValoresBaseDatos(string tabla, string columna, string condicionWhere)
        {
            string updateQuery = "delete from "+tabla + " where "+ columna +"=" + condicionWhere;
            SqlCommand comandoEjecutar = new SqlCommand(updateQuery, conexionBaseDatos);
            comandoEjecutar.ExecuteNonQuery();
        }

        /*
         * comando que realiza los select de la base de datos 
         * desde c#
         */
        public void seleccionarValoresBaseDatos()
        {
            /*
             * aqui voy a copiar el codigo de la progra pasada
             */
        }

        /*
         * comando que realiza los insert de la base de datos 
         * desde c#
         */
        public void agregarValoresBaseDatos(string tabla, string columna, string atributos)
        {
            string updateQuery = "INSERT INTO"+ tabla+"("+columna+") Values ("+atributos +")"; 
            SqlCommand comandoEjecutar = new SqlCommand(updateQuery, conexionBaseDatos);
            comandoEjecutar.ExecuteNonQuery();
        }

    }
}

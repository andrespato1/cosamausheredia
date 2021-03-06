﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace tarea
{
    class ConexionSQLVisualStudio
    {
        /*
         * atributo necesario para hacer la conexion con 
         * sql server.
         */
        SqlConnection conexionBaseDatos;

        /*
         * inicializa la clase que conecta con sql server
         * con el string de la conexion
         */
        public ConexionSQLVisualStudio() {
            conexionBaseDatos = new SqlConnection(@"Data Source=PATO\ANDRESSERVER;Initial Catalog=sistemaDeVentas;Integrated Security=True");
           //conexionBaseDatos = new SqlConnection(@"Data Source = INDIANA; Initial Catalog = sistemaDeVentas; Integrated Security = True");
           //conexionBaseDatos = new SqlConnection(@"Data Source=ESTRADAJ\JOSESQLEXPRESS;Initial Catalog=sistemaDeVentas;Integrated Security=True");
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
        public void actualizarValoresBaseDatos(string query, string columna, string condicionWhere)
        {
            abrirConexion();
            string updateQuery = query + " where " + columna + " = " + condicionWhere;
            SqlCommand comandoEjecutar = new SqlCommand(updateQuery, conexionBaseDatos);
            int resultado = comandoEjecutar.ExecuteNonQuery();
            cerrarConexion();
        }

        /*
         * comando que realiza los delete de la base de datos 
         * desde c#
         */
        public void eliminarValoresBaseDatos(string tabla, string columna, string condicionWhere)
        {
            abrirConexion();
            string deleteQuery = "delete from " + tabla + " where " + columna + " = " + condicionWhere;
            MessageBox.Show(deleteQuery, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            SqlCommand comandoEjecutar = new SqlCommand(deleteQuery, conexionBaseDatos);
            int resultado = comandoEjecutar.ExecuteNonQuery();
            cerrarConexion();
        }

        /*
         * comando que realiza los select de la base de datos 
         * desde c#
         */
        public void seleccionarValoresBaseDatos(DataGridView ventana, string tabla, string columna, string condicion)
        {
            abrirConexion();
            System.Data.DataSet dataSet = new System.Data.DataSet();
            string selectQuery;
            if (condicion != "")
            {
                selectQuery = "select " + columna + " from " + tabla + " where " + columna + " " + condicion;
            }
            else
            {
                selectQuery = "select " + columna + " from " + tabla;
            }
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(selectQuery, conexionBaseDatos);
            MiDataAdapter.Fill(dataSet, columna);
            ventana.DataSource = dataSet;
            ventana.DataMember = columna;
            cerrarConexion();
        }

        /*
         * comando que realiza los select de la base de datos 
         * desde c#
         */
        public void seleccionarValoresBaseDatosTodasLasTablas(DataGridView ventana, string tabla, string columna, string condicion)
        {
            abrirConexion();
            System.Data.DataSet dataSet = new System.Data.DataSet();
            string selectQuery;
            if (condicion != "")
            {
                selectQuery = "select * from " + tabla + " where " + columna + " " + condicion;
            }
            else
            {
                selectQuery = "select * from " + tabla;
            }
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(selectQuery, conexionBaseDatos);
            MiDataAdapter.Fill(dataSet, columna);
            ventana.DataSource = dataSet;
            ventana.DataMember = columna;
            cerrarConexion();
        }

        /*
         * comando que realiza los insert de la base de datos 
         * desde c#
         */
        public void agregarValoresBaseDatos(string tabla, string datos)
        {
            abrirConexion();
            string updateQuery = "insert into " + tabla + " values (" + datos + ")";
            SqlCommand comandoEjecutar = new SqlCommand(updateQuery, conexionBaseDatos);
            MessageBox.Show(updateQuery, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            int resultado = comandoEjecutar.ExecuteNonQuery();
            cerrarConexion();

           
        }

    }
}

using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

namespace CRUD_TEST_CORE.Utilities
{
    public class SQL_Helper
    {
        #region Methods...
        /// <summary>
        /// Método que sirve para hacer consultas a la BD y devolver una tabla con datos.
        /// </summary>
        /// <param name="SqlConexionString"></param>
        /// <param name="SqlComandoString"></param>
        /// <returns>Devuelve un valor DataTable, obtenido del comando sql mandado.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public DataTable GetDataTable(string ConnectionString, string CommandString)
        {
            //Comprobamos que la conexión no venga vacía o nulo.
            if (string.IsNullOrEmpty(ConnectionString)) throw new ArgumentNullException("Conexión Nula o Vacía");
            //Comprobamos que el comando no venga vacío o nulo.
            if (string.IsNullOrEmpty(CommandString)) throw new ArgumentNullException("Comando Nulo o Vacío");
            //Creamos DataTable.
            DataTable dt = new DataTable();
            //Iniciamos la clase SqlConnection.
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                //Abrimos la conexión.
                conn.Open();
                //Iniciamos la clase SqlCommand.
                using (SqlCommand cmd = new SqlCommand(CommandString, conn))
                {
                    //Iniciamos la clase SqlDataAdapter que sirve para llenar la tabla.
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        //Método fill para rellenar la tabla.
                        adapter.Fill(dt);
                    }
                }
                //Cerrar la conexión
                conn.Close();
            }
            //Devolvemos la tabla llena.
            return dt;
        }

        /// <summary>
        /// Sirve para ejecutar cualquier comando que no sea para consultar.
        /// </summary>
        /// <param name="SqlConexionString"></param>
        /// <param name="SqlComandoString"></param>
        /// <returns>Devuelve un valor int, obtenido de las filas afectadas por el comando sql.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int ExecuteANonQuery(string ConnectionString, string CommandString)
        {
            //Comprobamos que la conexión no venga vacía o nulo.
            if (string.IsNullOrEmpty(ConnectionString)) throw new ArgumentNullException("Conexión Nula o Vacía");
            //Comprobamos que el comando no venga vacío o nulo.
            if (string.IsNullOrEmpty(CommandString)) throw new ArgumentNullException("Comando Nulo o Vacío");
            int FilasAfectadas = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                //Abrimos la conexión.
                conn.Open();
                //Iniciamos la clase SqlCommand.
                using (SqlCommand cmd = new SqlCommand(CommandString, conn))
                {
                    FilasAfectadas = cmd.ExecuteNonQuery();
                }
                //Cerrar la conexión
                conn.Close();
            }
            return FilasAfectadas;
        }
        #endregion
    }
}

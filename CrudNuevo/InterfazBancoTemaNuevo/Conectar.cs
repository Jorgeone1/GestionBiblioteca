using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    internal class Conectar
    {
        private String server = "localhost";
        private String database = "Coviran";
        private String username = "root";
        private String password = "";
        private int port = 3306;
        String commandConect;
        /// <summary>
        /// Constructor que crea el String
        /// </summary>
        public Conectar()
        {
            commandConect =$"Server={server};port={port};Database={database};Uid={username};Pwd={password};";
        }
        /// <summary>
        /// Crea la conexion 
        /// </summary>
        /// <returns>la devuelve</returns>
        public MySqlConnection GetConnection()
        {
            MySqlConnection conexion = new MySqlConnection(commandConect);
            return conexion;
        }
        /// <summary>
        /// Prueba la conexion
        /// </summary>
        /// <returns>devuelve true o false si es correcto</returns>
        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection conexion = GetConnection())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}

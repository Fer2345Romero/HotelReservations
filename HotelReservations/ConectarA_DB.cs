using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace HotelReservations
{
    internal static class ConectarDb
    {
        // Metodo para conectar a la base de datos devuelve un objeto de tipo SqlConnection
        public static SqlConnection Conectar()
        {
            // Cadena de conexion
            string connectionString = "Data Source=LISSETH15ARGUET\\SQLEXPRESS01;Initial Catalog=HotelReservations;Integrated Security=True;Encrypt=False";

            try
            {
                // Abrir la conexion
                SqlConnection connection = new SqlConnection(connectionString);
                // MessageBox.Show("Conectado a la base");
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la conexion: " + ex.Message);
                return null;
                throw;
            }
        }
    }
}

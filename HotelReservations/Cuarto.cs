using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    internal class Cuarto
    {
        public string TipoCuarto { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public Boolean Disponible { get; set; }

        public Cuarto(string tipoCuarto, decimal precioPorNoche)
        {
            TipoCuarto = tipoCuarto;
            PrecioPorNoche = precioPorNoche;
            Disponible = true;
        }

        public void CambiarDisponibilidad()
        {
            Disponible = !Disponible;
        }

        // Agregar cliente a base de datos tabla Customers
        public void AgregarCuarto()
        {
            // Conectar a la base de datos
            SqlConnection connection = ConectarDb.Conectar();
            connection.Open();

            // Query para insertar cuarto
            string query = "INSERT INTO Rooms (RoomType, PricePerNight, IsAvailable) VALUES (@TipoCuarto, @PrecioPorNoche, @Disponible)";

            // Crear comando
            SqlCommand command = new SqlCommand(query, connection);

            // Agregar parametros
            command.Parameters.AddWithValue("@TipoCuarto", this.TipoCuarto);
            command.Parameters.AddWithValue("@PrecioPorNoche", this.PrecioPorNoche);
            command.Parameters.AddWithValue("@Disponible", this.Disponible);

            // Ejecutar comando
            command.ExecuteNonQuery();

            // Cerrar conexion
            connection.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    internal class Reservacion
    {
        public int IdCliente { get; set; }
        public int IdCuarto { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal CostoTotal { get; set; }

        public Reservacion(int idCliente, int idCuarto, DateTime fechaEntrada, DateTime fechaSalida, decimal costoTotal)
        {
            IdCliente = idCliente;
            IdCuarto = idCuarto;
            FechaEntrada = fechaEntrada;
            FechaSalida = fechaSalida;
            CostoTotal = costoTotal;
        }

        // Agregar reservacion a base de datos en la tabla Reservations
        public void AgregarReservacion()
        {
            // Conectar a la base de datos
            SqlConnection connection = ConectarDb.Conectar();
            connection.Open();

            // Query para insertar cuarto
            string query = "INSERT INTO Reservations (CustomerID, RoomID, CheckInDate, CheckOutDate, TotalCost) " +
                "VALUES (@idCliente, @idCuarto, @fechaEntrada, @fechaSalida, @costoTotal)";

            // Crear comando
            SqlCommand command = new SqlCommand(query, connection);

            // Agregar parametros
            command.Parameters.AddWithValue("@idCliente", this.IdCliente);
            command.Parameters.AddWithValue("@idCuarto", this.IdCuarto);
            command.Parameters.AddWithValue("@fechaEntrada", this.FechaEntrada);
            command.Parameters.AddWithValue("@fechaSalida", this.FechaSalida);
            command.Parameters.AddWithValue("@costoTotal", this.CostoTotal);

            // Ejecutar comando
            command.ExecuteNonQuery();

            // Cerrar conexion
            connection.Close();
        }
    }
}

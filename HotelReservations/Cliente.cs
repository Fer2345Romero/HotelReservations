using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservations
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string InformacionContacto { get; set; }
        public string Direccion { get; set; }

        public Cliente(string nombre, string informacionContacto, string direccion)
        {
            Nombre = nombre;
            InformacionContacto = informacionContacto;
            Direccion = direccion;
        }

        // Agregar cliente a base de datos tabla Customers
        public void AgregarCliente()
        {
            // Conectar a la base de datos
            SqlConnection connection = ConectarDb.Conectar();
            connection.Open();

            // Query para insertar cliente
            string query = "INSERT INTO Customers (Name, ContactInformation, Address) VALUES (@Nombre, @InformacionContacto, @Direccion)";

            // Crear comando
            SqlCommand command = new SqlCommand(query, connection);

            // Agregar parametros
            command.Parameters.AddWithValue("@Nombre", this.Nombre);
            command.Parameters.AddWithValue("@InformacionContacto", this.InformacionContacto);
            command.Parameters.AddWithValue("@Direccion", this.Direccion);
           
            // Ejecutar comando
            command.ExecuteNonQuery();

            // Cerrar conexion
            connection.Close();
        }
    }
}

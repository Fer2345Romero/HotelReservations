using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservations
{
    public partial class Reservaciones : Form
    {
        public Reservaciones()
        {
            InitializeComponent();
        }

        private void Reservaciones_Load(object sender, EventArgs e)
        {
            // Conectar a la base de datos
            SqlConnection sqlConnection = ConectarDb.Conectar();
            sqlConnection.Open();


            // Query para obtener las reservaciones de la tabla Reservations de la base de datos
            string query = "SELECT * FROM Reservations";
            // Crear comando
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            // Crear adaptador de datos y mostrar en el DataGridView
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvReservaciones.DataSource = dataTable;
            // Cerrar conexion
            sqlConnection.Close();


            // Agregar los nombres de los clientes de la tabla Customers de la base de datos
            // a el ComboBox
            // Conectar a la base de datos
            sqlConnection.Open();
            // Query
            string query1 = "SELECT Name FROM Customers";
            SqlCommand sqlCommand1 = new SqlCommand(query1, sqlConnection);
            SqlDataReader reader1 = sqlCommand1.ExecuteReader();
            cmbClientes.Items.Clear();
            while (reader1.Read())
            {
                cmbClientes.Items.Add(reader1["Name"].ToString());
            }
            sqlConnection.Close();


            // Agregar los IDs de los cuartos ocupados de la tabla Rooms de la base de datos
            // a el ComboBox
            // Conectar a la base de datos
            sqlConnection.Open();
            // Query
            string query2 = "SELECT RoomID FROM Rooms WHERE IsAvailable = 0";
            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
            SqlDataReader reader2 = sqlCommand2.ExecuteReader();
            cmbCuartos.Items.Clear();
            while (reader2.Read())
            {
                cmbCuartos.Items.Add(reader2["RoomID"].ToString());
            }
            sqlConnection.Close();
        }
    }
}

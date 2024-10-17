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
    public partial class AgregarReservacion : Form
    {
        public AgregarReservacion()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Abrir formulario de agregar cliente
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.Show();
        }

        private void btnActualizarClintes_Click(object sender, EventArgs e)
        {
            actualizarDgvClientes();
        }




        private void btnAgregarCuarto_Click(object sender, EventArgs e)
        {
            // Abrir formulario de agregar cuarto
            AgregarCuarto agregarCuarto = new AgregarCuarto();
            agregarCuarto.Show();
        }

        private void btnActulizarCuartos_Click(object sender, EventArgs e)
        {
            actualizarDgvCuartosDisponibles();
        }




        private void btnAgregarReservacion_Click(object sender, EventArgs e)
        {
            // Validamos que este seleccionado un cliente en el DataGridView dgvClientes
            // y un cuarto en el DataGridView dgvCuartosDisponibles
            if (dgvClientes.SelectedRows.Count == 0 || dgvCuartosDisponibles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente y un cuarto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Obtener el id del cliente seleccionado
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);

                // Obtener el id del cuarto seleccionado
                int idCuarto = Convert.ToInt32(dgvCuartosDisponibles.SelectedRows[0].Cells[0].Value);
                
                // Fecha de ingreso
                DateTime fechaIngreso = dtpFechaIngreso.Value;

                // Fecha de salida
                DateTime fechaSalida = dtpFechaSalida.Value;

                // Costo total
                decimal costoTotal = Convert.ToDecimal(dgvCuartosDisponibles.SelectedRows[0].Cells[2].Value);

                // Crear una nueva reservacion
                Reservacion reservacion = new Reservacion(idCliente, idCuarto, fechaIngreso, fechaSalida, costoTotal);

                // Agregar la reservacion a la base de datos
                reservacion.AgregarReservacion();

                MessageBox.Show("Reservación agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                // Actualizar la disponibilidad del cuarto en la tabla Rooms de la base de datos
                // Conectar a la base de datos
                SqlConnection connection = ConectarDb.Conectar();
                connection.Open();
                // Query 
                string query = "UPDATE Rooms SET IsAvailable = 0 WHERE RoomID = @RoomID";
                // Command
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", idCuarto);
                command.ExecuteNonQuery();
                connection.Close(); // Cerrar conexion


                actualizarDgvCuartosDisponibles(); // Actualizar, el DataGridViw de cuartos disponibles
            }
        }

        private void btnVerReservaciones_Click(object sender, EventArgs e)
        {
            // Ver reservaciones
            Reservaciones reservaciones = new Reservaciones();
            reservaciones.Show();
        }




        // Obtener los clientes de la tabla Customers de la base de datos y mostrarlos en el
        // DataGridView dgvClientes
        public void actualizarDgvClientes()
        {
            // Conectar a la base de datos
            SqlConnection sqlConnection = ConectarDb.Conectar();
            sqlConnection.Open();

            // Query para obtener los clientes
            string query = "SELECT * FROM Customers";

            // Crear comando
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            // Crear adaptador de datos y mostrar en el DataGridView
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvClientes.DataSource = dataTable;

            // Cerrar conexion
            sqlConnection.Close();
        }

        // Obtener los Cuartos de la tabla Rooms de la base de datos y mostrarlos en el
        // DataGridView dgvCuartosDisponibles
        public void actualizarDgvCuartosDisponibles()
        {
            // Conectar a la base de datos
            SqlConnection sqlConnection = ConectarDb.Conectar();
            sqlConnection.Open();

            // Query para obtener los cuartos disponibles (que no estén ocupados) 
            //  IsAvailable BIT DEFAULT 1
            string query = "SELECT * FROM Rooms WHERE IsAvailable = 1";

            // Crear comando
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            // Crear adaptador de datos y mostrar en el DataGridView
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvCuartosDisponibles.DataSource = dataTable;

            // Cerrar conexion
            sqlConnection.Close();
        }

        private void AgregarReservacion_Load(object sender, EventArgs e)
        {
            actualizarDgvClientes();
            actualizarDgvCuartosDisponibles();
        }

    }
}

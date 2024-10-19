using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;




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


            // Query para obtener las reservaciones con el nombre del cliente y tipo de habitación
            string query = @"SELECT r.ReservationID, c.Name AS Cliente, ro.RoomType AS Habitacion, 
                        r.CheckInDate, r.CheckOutDate, r.TotalCost
                 FROM Reservations r
                 INNER JOIN Customers c ON r.CustomerID = c.CustomerID
                 INNER JOIN Rooms ro ON r.RoomID = ro.RoomID";

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
            //cerrar la conexion a la base de datos
            sqlConnection.Close();


            // Agregar los IDs de los cuartos ocupados de la tabla Rooms de la base de datos
            // a el ComboBox
            // Conectar a la base de datos
            sqlConnection.Open();
            // Query
            string query2 = "SELECT RoomType FROM Rooms WHERE IsAvailable = 0";
            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
            SqlDataReader reader2 = sqlCommand2.ExecuteReader();
            cmbCuartos.Items.Clear();
            while (reader2.Read())
            {
                cmbCuartos.Items.Add(reader2["RoomType"].ToString());
            }
            //Cerar la conexion a la base de datos
            sqlConnection.Close();

        }

        // Botón para realizar búsquedas por nombre de cliente
        private void searchCustomer_Click(object sender, EventArgs e)
        {
            string customerName = cmbClientes.Text.Trim(); // Obtener el nombre del cliente escrito o seleccionado

            // Verificar si el campo está vacío
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Por favor, seleccione o escriba un nombre de cliente.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = ConectarDb.Conectar())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SearchReservationsByCustomerName", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", customerName); // Se pasará el nombre ingresado

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    dgvReservaciones.DataSource = dt; // Actualizar el DataGridView

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron reservaciones para el cliente especificado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Botón para realizar búsquedas por tipo de habitación
        private void searchRoom_Click(object sender, EventArgs e)
        {
            string roomType = cmbCuartos.Text.Trim(); // Obtener el tipo de habitación escrito o seleccionado

            // Verificar si el campo está vacío
            if (string.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("Por favor, seleccione o escriba un tipo de habitación.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = ConectarDb.Conectar())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SearchReservationsByRoomType", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomType", roomType);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dgvReservaciones.DataSource = dt; // Actualizar el DataGridView con los resultados
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron reservaciones para el tipo de habitación especificado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvReservaciones.DataSource = null; // Limpiar el DataGridView si no hay resultados
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        //Botón para realizar busquedas de reservaciones por rango de fechas
        private void searchDateTime_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpFechaInicio.Value; // Obtener la fecha de inicio
            DateTime endDate = dtpFechaFin.Value; // Obtener la fecha final

            // Validar que la fecha final no sea inferior a la fecha de inicio
            if (endDate < startDate)
            {
                MessageBox.Show("La fecha de fin no puede ser inferior a la fecha de inicio.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si las fechas son inválidas
            }

            using (SqlConnection con = ConectarDb.Conectar())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_SearchDateTime", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Pasar el rango de fechas al procedimiento almacenado
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                // Ejecutar la consulta y llenar el DataTable con los resultados
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Mostrar resultados en el DataGridView
                dgvReservaciones.DataSource = dt;
            }
        }

        // Botón para generar reporte Excel
        private void btnGenerarReporteExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvReservaciones.DataSource; // Obtener el DataTable del DataGridView

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generar un número aleatorio para el nombre del archivo
            Random random = new Random();
            int reportNumber = random.Next(1000, 9999); // Generar un número aleatorio entre 1000 y 9999
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", $"ReporteReservaciones_{reportNumber}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Reservaciones");
                worksheet.Cell(1, 1).Value = "ID Reservación";
                worksheet.Cell(1, 2).Value = "Cliente";
                worksheet.Cell(1, 3).Value = "Habitación";
                worksheet.Cell(1, 4).Value = "Fecha de Check-In";
                worksheet.Cell(1, 5).Value = "Fecha de Check-Out";
                worksheet.Cell(1, 6).Value = "Costo Total";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = Convert.ToInt32(dt.Rows[i]["ReservationID"]);
                    worksheet.Cell(i + 2, 2).Value = dt.Rows[i]["Cliente"].ToString();
                    worksheet.Cell(i + 2, 3).Value = dt.Rows[i]["Habitacion"].ToString();
                    worksheet.Cell(i + 2, 4).Value = Convert.ToDateTime(dt.Rows[i]["CheckInDate"]);
                    worksheet.Cell(i + 2, 5).Value = Convert.ToDateTime(dt.Rows[i]["CheckOutDate"]);
                    worksheet.Cell(i + 2, 6).Value = Convert.ToDecimal(dt.Rows[i]["TotalCost"]);
                }

                // Formato de la tabla
                worksheet.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                worksheet.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                workbook.SaveAs(filePath);
                MessageBox.Show($"Reporte Excel generado exitosamente en: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Botón para generar reporte PDF
        private void btnGenerarReportePDF_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvReservaciones.DataSource;

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generar un número aleatorio para el nombre del archivo
            Random random = new Random();
            int reportNumber = random.Next(1000, 9999); // Generar un número aleatorio entre 1000 y 9999
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", $"ReporteReservaciones_{reportNumber}.pdf");

            try
            {
                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(1, Unit.Centimetre);
                        page.Header().Element(headerContainer =>
                        {
                            ComposeHeader(headerContainer); // Llamar a ComposeHeader
                        });
                        page.Content().Element(contentContainer =>
                        {
                            ComposeContent(contentContainer, dt); // Llamar a ComposeContent
                        });
                        page.Footer().AlignCenter().Text(x =>
                        {
                            x.CurrentPageNumber();
                            x.Span(" / ");
                            x.TotalPages();
                        });
                    });
                });

                // Guardar el documento PDF
                document.GeneratePdf(filePath);
                MessageBox.Show($"Reporte PDF generado exitosamente en: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComposeHeader(QuestPDF.Infrastructure.IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("Reporte de Reservaciones").FontSize(20).Bold();
                    column.Item().Text($"Fecha: {DateTime.Now.ToShortDateString()}").FontSize(10);
                });
                row.ConstantItem(100).AlignRight().Text($"Reporte #: {new Random().Next(1000, 9999)}"); // Número aleatorio para el reporte
            });
        }

        private void ComposeContent(QuestPDF.Infrastructure.IContainer container, DataTable dt)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Header(header =>
                {
                    header.Cell().Text("ID Reservación");
                    header.Cell().Text("Cliente");
                    header.Cell().Text("Habitación");
                    header.Cell().Text("Fecha de Check-In");
                    header.Cell().Text("Fecha de Check-Out");
                    header.Cell().Text("Costo Total");
                });

                foreach (DataRow row in dt.Rows)
                {
                    table.Cell().Text(row["ReservationID"].ToString());
                    table.Cell().Text(row["Cliente"].ToString());
                    table.Cell().Text(row["Habitacion"].ToString());
                    table.Cell().Text(Convert.ToDateTime(row["CheckInDate"]).ToShortDateString());
                    table.Cell().Text(Convert.ToDateTime(row["CheckOutDate"]).ToShortDateString());
                    table.Cell().Text(row["TotalCost"].ToString());
                }
            });
        }
    }
}
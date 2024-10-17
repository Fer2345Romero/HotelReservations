using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservations
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (txtNombre.Text == "" || txtInformacionContacto.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Agregar cliente a la base de datos
                Cliente cliente = new Cliente(txtNombre.Text, txtInformacionContacto.Text, txtDireccion.Text);
                cliente.AgregarCliente();  
                MessageBox.Show("Cliente agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close(); // Cerrar formulario 
            }
        }
    }
}

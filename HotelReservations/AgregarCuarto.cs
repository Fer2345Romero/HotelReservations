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
    public partial class AgregarCuarto : Form
    {
        public AgregarCuarto()
        {
            InitializeComponent();
        }

        private void btnAgregarCuarto_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (txtTipoCuarto.Text == "" || txtPrecioPorNoche.Text == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Agregar cuarto a la base de datos
                Cuarto cuarto = new Cuarto(txtTipoCuarto.Text, Convert.ToDecimal(txtPrecioPorNoche.Text));
                cuarto.AgregarCuarto();
                MessageBox.Show("Cuarto agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close(); // Cerrar formulario 
            }
        }
    }
}

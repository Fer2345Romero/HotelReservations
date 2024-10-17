namespace HotelReservations
{
    partial class AgregarReservacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCuartosDisponibles = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.btnVerReservaciones = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCuarto = new System.Windows.Forms.Button();
            this.btnAgregarReservacion = new System.Windows.Forms.Button();
            this.btnActualizarClintes = new System.Windows.Forms.Button();
            this.btnActulizarCuartos = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuartosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.BackColor = System.Drawing.SystemColors.Info;
            this.lblNombreSistema.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.Location = new System.Drawing.Point(255, 29);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(342, 27);
            this.lblNombreSistema.TabIndex = 0;
            this.lblNombreSistema.Text = "ADD HOTEL RESERVATIONS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvClientes);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 148);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes en el sistema:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 21);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(655, 110);
            this.dgvClientes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCuartosDisponibles);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 157);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuartos disponibles:";
            // 
            // dgvCuartosDisponibles
            // 
            this.dgvCuartosDisponibles.AllowUserToAddRows = false;
            this.dgvCuartosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuartosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuartosDisponibles.Location = new System.Drawing.Point(6, 21);
            this.dgvCuartosDisponibles.Name = "dgvCuartosDisponibles";
            this.dgvCuartosDisponibles.ReadOnly = true;
            this.dgvCuartosDisponibles.Size = new System.Drawing.Size(655, 121);
            this.dgvCuartosDisponibles.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 11);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleccione un cliente y un cuarto para reservacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de salida:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Location = new System.Drawing.Point(161, 78);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(215, 22);
            this.dtpFechaIngreso.TabIndex = 16;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(526, 78);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(217, 22);
            this.dtpFechaSalida.TabIndex = 17;
            // 
            // btnVerReservaciones
            // 
            this.btnVerReservaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReservaciones.Location = new System.Drawing.Point(434, 495);
            this.btnVerReservaciones.Name = "btnVerReservaciones";
            this.btnVerReservaciones.Size = new System.Drawing.Size(187, 37);
            this.btnVerReservaciones.TabIndex = 19;
            this.btnVerReservaciones.Text = "VER RESERVACIONES";
            this.btnVerReservaciones.UseVisualStyleBackColor = true;
            this.btnVerReservaciones.Click += new System.EventHandler(this.btnVerReservaciones_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(722, 173);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(98, 23);
            this.btnAgregarCliente.TabIndex = 20;
            this.btnAgregarCliente.Text = "AGREGAR";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarCuarto
            // 
            this.btnAgregarCuarto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuarto.Location = new System.Drawing.Point(722, 327);
            this.btnAgregarCuarto.Name = "btnAgregarCuarto";
            this.btnAgregarCuarto.Size = new System.Drawing.Size(98, 23);
            this.btnAgregarCuarto.TabIndex = 21;
            this.btnAgregarCuarto.Text = "AGREGAR";
            this.btnAgregarCuarto.UseVisualStyleBackColor = true;
            this.btnAgregarCuarto.Click += new System.EventHandler(this.btnAgregarCuarto_Click);
            // 
            // btnAgregarReservacion
            // 
            this.btnAgregarReservacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReservacion.Location = new System.Drawing.Point(208, 495);
            this.btnAgregarReservacion.Name = "btnAgregarReservacion";
            this.btnAgregarReservacion.Size = new System.Drawing.Size(187, 37);
            this.btnAgregarReservacion.TabIndex = 22;
            this.btnAgregarReservacion.Text = "AGREGAR RESERVACION";
            this.btnAgregarReservacion.UseVisualStyleBackColor = true;
            this.btnAgregarReservacion.Click += new System.EventHandler(this.btnAgregarReservacion_Click);
            // 
            // btnActualizarClintes
            // 
            this.btnActualizarClintes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClintes.Location = new System.Drawing.Point(722, 202);
            this.btnActualizarClintes.Name = "btnActualizarClintes";
            this.btnActualizarClintes.Size = new System.Drawing.Size(98, 23);
            this.btnActualizarClintes.TabIndex = 23;
            this.btnActualizarClintes.Text = "ACTUALIZAR";
            this.btnActualizarClintes.UseVisualStyleBackColor = true;
            this.btnActualizarClintes.Click += new System.EventHandler(this.btnActualizarClintes_Click);
            // 
            // btnActulizarCuartos
            // 
            this.btnActulizarCuartos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizarCuartos.Location = new System.Drawing.Point(722, 356);
            this.btnActulizarCuartos.Name = "btnActulizarCuartos";
            this.btnActulizarCuartos.Size = new System.Drawing.Size(98, 23);
            this.btnActulizarCuartos.TabIndex = 24;
            this.btnActulizarCuartos.Text = "ACTUALIZAR";
            this.btnActulizarCuartos.UseVisualStyleBackColor = true;
            this.btnActulizarCuartos.Click += new System.EventHandler(this.btnActulizarCuartos_Click);
            // 
            // AgregarReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 578);
            this.Controls.Add(this.btnActulizarCuartos);
            this.Controls.Add(this.btnActualizarClintes);
            this.Controls.Add(this.btnAgregarReservacion);
            this.Controls.Add(this.btnAgregarCuarto);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnVerReservaciones);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNombreSistema);
            this.Name = "AgregarReservacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AgregarReservacion_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuartosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCuartosDisponibles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Button btnVerReservaciones;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnAgregarCuarto;
        private System.Windows.Forms.Button btnAgregarReservacion;
        private System.Windows.Forms.Button btnActualizarClintes;
        private System.Windows.Forms.Button btnActulizarCuartos;
    }
}


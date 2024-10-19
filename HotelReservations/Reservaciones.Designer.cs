namespace HotelReservations
{
    partial class Reservaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReservaciones = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchRoom = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.searchDateTime = new System.Windows.Forms.Button();
            this.btnGenerarReportePDF = new System.Windows.Forms.Button();
            this.searchCustomer = new System.Windows.Forms.Button();
            this.cmbCuartos = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporteExcel = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.BackColor = System.Drawing.SystemColors.Info;
            this.lblNombreSistema.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.Location = new System.Drawing.Point(417, 34);
            this.lblNombreSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(231, 34);
            this.lblNombreSistema.TabIndex = 1;
            this.lblNombreSistema.Text = "RESERVATIONS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReservaciones);
            this.groupBox1.Location = new System.Drawing.Point(49, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(972, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservaciones";
            // 
            // dgvReservaciones
            // 
            this.dgvReservaciones.AllowUserToAddRows = false;
            this.dgvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaciones.Location = new System.Drawing.Point(8, 23);
            this.dgvReservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservaciones.Name = "dgvReservaciones";
            this.dgvReservaciones.ReadOnly = true;
            this.dgvReservaciones.RowHeadersWidth = 51;
            this.dgvReservaciones.Size = new System.Drawing.Size(956, 159);
            this.dgvReservaciones.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchRoom);
            this.groupBox2.Controls.Add(this.dtpFechaFin);
            this.groupBox2.Controls.Add(this.searchDateTime);
            this.groupBox2.Controls.Add(this.btnGenerarReportePDF);
            this.groupBox2.Controls.Add(this.searchCustomer);
            this.groupBox2.Controls.Add(this.cmbCuartos);
            this.groupBox2.Controls.Add(this.cmbClientes);
            this.groupBox2.Controls.Add(this.btnGenerarReporteExcel);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(213, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(747, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // searchRoom
            // 
            this.searchRoom.Location = new System.Drawing.Point(453, 70);
            this.searchRoom.Name = "searchRoom";
            this.searchRoom.Size = new System.Drawing.Size(146, 35);
            this.searchRoom.TabIndex = 15;
            this.searchRoom.Text = "Buscar Habitación";
            this.searchRoom.UseVisualStyleBackColor = true;
            this.searchRoom.Click += new System.EventHandler(this.searchRoom_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(353, 144);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaFin.TabIndex = 13;
            // 
            // searchDateTime
            // 
            this.searchDateTime.Location = new System.Drawing.Point(611, 133);
            this.searchDateTime.Name = "searchDateTime";
            this.searchDateTime.Size = new System.Drawing.Size(115, 46);
            this.searchDateTime.TabIndex = 12;
            this.searchDateTime.Text = "Buscar reservaciones";
            this.searchDateTime.UseVisualStyleBackColor = true;
            this.searchDateTime.Click += new System.EventHandler(this.searchDateTime_Click);
            // 
            // btnGenerarReportePDF
            // 
            this.btnGenerarReportePDF.Location = new System.Drawing.Point(279, 191);
            this.btnGenerarReportePDF.Name = "btnGenerarReportePDF";
            this.btnGenerarReportePDF.Size = new System.Drawing.Size(253, 28);
            this.btnGenerarReportePDF.TabIndex = 11;
            this.btnGenerarReportePDF.Text = "GENERAR REPORTE PDF";
            this.btnGenerarReportePDF.UseVisualStyleBackColor = true;
            this.btnGenerarReportePDF.Click += new System.EventHandler(this.btnGenerarReportePDF_Click);
            // 
            // searchCustomer
            // 
            this.searchCustomer.Location = new System.Drawing.Point(453, 22);
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.Size = new System.Drawing.Size(146, 31);
            this.searchCustomer.TabIndex = 10;
            this.searchCustomer.Text = "Buscar Cliente";
            this.searchCustomer.UseVisualStyleBackColor = true;
            this.searchCustomer.Click += new System.EventHandler(this.searchCustomer_Click);
            // 
            // cmbCuartos
            // 
            this.cmbCuartos.FormattingEnabled = true;
            this.cmbCuartos.Location = new System.Drawing.Point(259, 82);
            this.cmbCuartos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCuartos.Name = "cmbCuartos";
            this.cmbCuartos.Size = new System.Drawing.Size(160, 24);
            this.cmbCuartos.TabIndex = 9;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(259, 29);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(160, 24);
            this.cmbClientes.TabIndex = 8;
            // 
            // btnGenerarReporteExcel
            // 
            this.btnGenerarReporteExcel.Location = new System.Drawing.Point(28, 191);
            this.btnGenerarReporteExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarReporteExcel.Name = "btnGenerarReporteExcel";
            this.btnGenerarReporteExcel.Size = new System.Drawing.Size(216, 28);
            this.btnGenerarReporteExcel.TabIndex = 7;
            this.btnGenerarReporteExcel.Text = "GENERAR REPORTE EXCEL";
            this.btnGenerarReporteExcel.UseVisualStyleBackColor = true;
            this.btnGenerarReporteExcel.Click += new System.EventHandler(this.btnGenerarReporteExcel_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(81, 143);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Habitaciones ocupadas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombreSistema);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reservaciones";
            this.Text = "Reservaciones";
            this.Load += new System.EventHandler(this.Reservaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReservaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerarReporteExcel;
        private System.Windows.Forms.ComboBox cmbCuartos;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button searchCustomer;
        private System.Windows.Forms.Button searchDateTime;
        private System.Windows.Forms.Button btnGenerarReportePDF;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button searchRoom;
    }
}
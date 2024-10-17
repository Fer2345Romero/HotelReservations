namespace HotelReservations
{
    partial class AgregarCuarto
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
            this.btnAgregarCuarto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrecioPorNoche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoCuarto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCuarto
            // 
            this.btnAgregarCuarto.Location = new System.Drawing.Point(185, 189);
            this.btnAgregarCuarto.Name = "btnAgregarCuarto";
            this.btnAgregarCuarto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCuarto.TabIndex = 14;
            this.btnAgregarCuarto.Text = "AGREGAR";
            this.btnAgregarCuarto.UseVisualStyleBackColor = true;
            this.btnAgregarCuarto.Click += new System.EventHandler(this.btnAgregarCuarto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPrecioPorNoche);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTipoCuarto);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(33, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 94);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar cuarto:";
            // 
            // txtPrecioPorNoche
            // 
            this.txtPrecioPorNoche.Location = new System.Drawing.Point(152, 47);
            this.txtPrecioPorNoche.Name = "txtPrecioPorNoche";
            this.txtPrecioPorNoche.Size = new System.Drawing.Size(156, 20);
            this.txtPrecioPorNoche.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio por noche:";
            // 
            // txtTipoCuarto
            // 
            this.txtTipoCuarto.Location = new System.Drawing.Point(152, 21);
            this.txtTipoCuarto.Name = "txtTipoCuarto";
            this.txtTipoCuarto.Size = new System.Drawing.Size(156, 20);
            this.txtTipoCuarto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo de cuarto:";
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.BackColor = System.Drawing.SystemColors.Info;
            this.lblNombreSistema.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.Location = new System.Drawing.Point(128, 30);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(222, 27);
            this.lblNombreSistema.TabIndex = 15;
            this.lblNombreSistema.Text = "AGREGAR CUARTO";
            // 
            // AgregarCuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 239);
            this.Controls.Add(this.lblNombreSistema);
            this.Controls.Add(this.btnAgregarCuarto);
            this.Controls.Add(this.groupBox4);
            this.Name = "AgregarCuarto";
            this.Text = "AgregarCuarto";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCuarto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPrecioPorNoche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoCuarto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombreSistema;
    }
}
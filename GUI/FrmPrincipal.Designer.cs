
namespace TPI_PII.GUI
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelTransaccionDropDown = new System.Windows.Forms.Panel();
            this.btnDestinatarios = new TPI_PII.Resources.RButton();
            this.btnTransferencia = new TPI_PII.Resources.RButton();
            this.btnTransacciones = new TPI_PII.Resources.RButton();
            this.btnReporte = new TPI_PII.Resources.RButton();
            this.btnCerrarSesion = new TPI_PII.Resources.RButton();
            this.btnSoporte = new TPI_PII.Resources.RButton();
            this.btnArchivo = new TPI_PII.Resources.RButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelTransaccionDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PanelTransaccionDropDown);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnSoporte);
            this.panel1.Controls.Add(this.btnArchivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 411);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 100);
            this.panel2.TabIndex = 1;
            // 
            // PanelTransaccionDropDown
            // 
            this.PanelTransaccionDropDown.BackColor = System.Drawing.SystemColors.Control;
            this.PanelTransaccionDropDown.Controls.Add(this.btnDestinatarios);
            this.PanelTransaccionDropDown.Controls.Add(this.btnTransferencia);
            this.PanelTransaccionDropDown.Controls.Add(this.btnTransacciones);
            this.PanelTransaccionDropDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTransaccionDropDown.Location = new System.Drawing.Point(16, 160);
            this.PanelTransaccionDropDown.MaximumSize = new System.Drawing.Size(200, 160);
            this.PanelTransaccionDropDown.MinimumSize = new System.Drawing.Size(200, 40);
            this.PanelTransaccionDropDown.Name = "PanelTransaccionDropDown";
            this.PanelTransaccionDropDown.Size = new System.Drawing.Size(200, 40);
            this.PanelTransaccionDropDown.TabIndex = 1;
            // 
            // btnDestinatarios
            // 
            this.btnDestinatarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnDestinatarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnDestinatarios.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDestinatarios.BorderRadius = 20;
            this.btnDestinatarios.BorderSize = 0;
            this.btnDestinatarios.FlatAppearance.BorderSize = 0;
            this.btnDestinatarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinatarios.ForeColor = System.Drawing.Color.White;
            this.btnDestinatarios.Location = new System.Drawing.Point(0, 112);
            this.btnDestinatarios.Name = "btnDestinatarios";
            this.btnDestinatarios.Size = new System.Drawing.Size(200, 40);
            this.btnDestinatarios.TabIndex = 3;
            this.btnDestinatarios.Text = "Destinatarios";
            this.btnDestinatarios.TextColor = System.Drawing.Color.White;
            this.btnDestinatarios.UseVisualStyleBackColor = false;
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTransferencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTransferencia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTransferencia.BorderRadius = 20;
            this.btnTransferencia.BorderSize = 0;
            this.btnTransferencia.FlatAppearance.BorderSize = 0;
            this.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnTransferencia.Location = new System.Drawing.Point(0, 56);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(200, 40);
            this.btnTransferencia.TabIndex = 2;
            this.btnTransferencia.Text = "Nueva Transferencia";
            this.btnTransferencia.TextColor = System.Drawing.Color.White;
            this.btnTransferencia.UseVisualStyleBackColor = false;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTransacciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTransacciones.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTransacciones.BorderRadius = 20;
            this.btnTransacciones.BorderSize = 0;
            this.btnTransacciones.FlatAppearance.BorderSize = 0;
            this.btnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacciones.ForeColor = System.Drawing.Color.White;
            this.btnTransacciones.Image = global::TPI_PII.Properties.Resources.amplia;
            this.btnTransacciones.Location = new System.Drawing.Point(0, 0);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(200, 40);
            this.btnTransacciones.TabIndex = 1;
            this.btnTransacciones.Text = "Transacciones";
            this.btnTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransacciones.TextColor = System.Drawing.Color.White;
            this.btnTransacciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransacciones.UseVisualStyleBackColor = false;
            this.btnTransacciones.Click += new System.EventHandler(this.rButton5_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnReporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReporte.BorderRadius = 20;
            this.btnReporte.BorderSize = 0;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(16, 224);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 40);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextColor = System.Drawing.Color.White;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnCerrarSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrarSesion.BorderRadius = 20;
            this.btnCerrarSesion.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(16, 360);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 40);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnSoporte
            // 
            this.btnSoporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnSoporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnSoporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSoporte.BorderRadius = 20;
            this.btnSoporte.BorderSize = 0;
            this.btnSoporte.FlatAppearance.BorderSize = 0;
            this.btnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoporte.ForeColor = System.Drawing.Color.White;
            this.btnSoporte.Location = new System.Drawing.Point(16, 96);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(200, 40);
            this.btnSoporte.TabIndex = 1;
            this.btnSoporte.Text = "Soporte";
            this.btnSoporte.TextColor = System.Drawing.Color.White;
            this.btnSoporte.UseVisualStyleBackColor = false;
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnArchivo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnArchivo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnArchivo.BorderRadius = 20;
            this.btnArchivo.BorderSize = 0;
            this.btnArchivo.FlatAppearance.BorderSize = 0;
            this.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.ForeColor = System.Drawing.Color.White;
            this.btnArchivo.Location = new System.Drawing.Point(16, 32);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(200, 40);
            this.btnArchivo.TabIndex = 0;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.TextColor = System.Drawing.Color.White;
            this.btnArchivo.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pContainer
            // 
            this.pContainer.BackgroundImage = global::TPI_PII.Properties.Resources.background;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(232, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(685, 411);
            this.pContainer.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPI_PII.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(917, 411);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.panel1.ResumeLayout(false);
            this.PanelTransaccionDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelTransaccionDropDown;
        private Resources.RButton btnDestinatarios;
        private Resources.RButton btnTransferencia;
        private Resources.RButton btnTransacciones;
        private Resources.RButton btnReporte;
        private Resources.RButton btnCerrarSesion;
        private Resources.RButton btnSoporte;
        private Resources.RButton btnArchivo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pContainer;
    }
}
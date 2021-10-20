
namespace TPI_PII.GUI
{
    partial class FrmNuevaTransferencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rButton3 = new TPI_PII.Resources.RButton();
            this.rButton2 = new TPI_PII.Resources.RButton();
            this.rButton1 = new TPI_PII.Resources.RButton();
            this.rTextBox2 = new TPI_PII.Resources.RTextBox();
            this.rTextBox1 = new TPI_PII.Resources.RTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rButton3);
            this.panel1.Controls.Add(this.rButton2);
            this.panel1.Controls.Add(this.rButton1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.rTextBox2);
            this.panel1.Controls.Add(this.rTextBox1);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(144, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 392);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 19;
            this.comboBox1.Location = new System.Drawing.Point(96, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 27);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Seleccionar cuenta origen...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo disponible $";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(120, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(145, 19);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "*carga fecha actual*";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 19;
            this.comboBox2.Location = new System.Drawing.Point(96, 240);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 27);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "Seleccionar destinatario...";
            // 
            // rButton3
            // 
            this.rButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton3.BorderRadius = 15;
            this.rButton3.BorderSize = 0;
            this.rButton3.FlatAppearance.BorderSize = 0;
            this.rButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton3.ForeColor = System.Drawing.Color.White;
            this.rButton3.Location = new System.Drawing.Point(200, 336);
            this.rButton3.Name = "rButton3";
            this.rButton3.Size = new System.Drawing.Size(168, 38);
            this.rButton3.TabIndex = 13;
            this.rButton3.Text = "Cancelar";
            this.rButton3.TextColor = System.Drawing.Color.White;
            this.rButton3.UseVisualStyleBackColor = false;
            // 
            // rButton2
            // 
            this.rButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.rButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.rButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton2.BorderRadius = 15;
            this.rButton2.BorderSize = 0;
            this.rButton2.FlatAppearance.BorderSize = 0;
            this.rButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton2.ForeColor = System.Drawing.Color.White;
            this.rButton2.Location = new System.Drawing.Point(16, 336);
            this.rButton2.Name = "rButton2";
            this.rButton2.Size = new System.Drawing.Size(168, 38);
            this.rButton2.TabIndex = 12;
            this.rButton2.Text = "Confirmar";
            this.rButton2.TextColor = System.Drawing.Color.White;
            this.rButton2.UseVisualStyleBackColor = false;
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.rButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.rButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton1.BorderRadius = 15;
            this.rButton1.BorderSize = 0;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.ForeColor = System.Drawing.Color.White;
            this.rButton1.Location = new System.Drawing.Point(120, 280);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(150, 30);
            this.rButton1.TabIndex = 11;
            this.rButton1.Text = "Nuevo destinatario";
            this.rButton1.TextColor = System.Drawing.Color.White;
            this.rButton1.UseVisualStyleBackColor = false;
            // 
            // rTextBox2
            // 
            this.rTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rTextBox2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rTextBox2.BorderFocusColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rTextBox2.BorderRadius = 0;
            this.rTextBox2.BorderSize = 2;
            this.rTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rTextBox2.Location = new System.Drawing.Point(96, 112);
            this.rTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rTextBox2.Multiline = false;
            this.rTextBox2.Name = "rTextBox2";
            this.rTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rTextBox2.PasswordChar = false;
            this.rTextBox2.PlaceholderColor = System.Drawing.Color.Black;
            this.rTextBox2.PlaceholderText = "Concepto";
            this.rTextBox2.Size = new System.Drawing.Size(200, 31);
            this.rTextBox2.TabIndex = 9;
            this.rTextBox2.Texts = "";
            this.rTextBox2.UnderlinedStyle = true;
            // 
            // rTextBox1
            // 
            this.rTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rTextBox1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rTextBox1.BorderFocusColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rTextBox1.BorderRadius = 0;
            this.rTextBox1.BorderSize = 2;
            this.rTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rTextBox1.Location = new System.Drawing.Point(96, 64);
            this.rTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rTextBox1.Multiline = false;
            this.rTextBox1.Name = "rTextBox1";
            this.rTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rTextBox1.PasswordChar = false;
            this.rTextBox1.PlaceholderColor = System.Drawing.Color.Black;
            this.rTextBox1.PlaceholderText = "Importe";
            this.rTextBox1.Size = new System.Drawing.Size(200, 31);
            this.rTextBox1.TabIndex = 8;
            this.rTextBox1.Texts = "";
            this.rTextBox1.UnderlinedStyle = true;
            // 
            // FrmNuevaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPI_PII.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(685, 411);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevaTransferencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmNuevaTransferencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Resources.RButton rButton1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Resources.RTextBox rTextBox2;
        private Resources.RTextBox rTextBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private Resources.RButton rButton2;
        private Resources.RButton rButton3;
    }
}

namespace TPI_PII
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTextBox2 = new TPI_PII.Resources.RTextBox();
            this.rTextBox1 = new TPI_PII.Resources.RTextBox();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new TPI_PII.Resources.RButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rTextBox2);
            this.panel1.Controls.Add(this.rTextBox1);
            this.panel1.Controls.Add(this.lnkRegistro);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(472, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 411);
            this.panel1.TabIndex = 0;
            // 
            // rTextBox2
            // 
            this.rTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.rTextBox2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rTextBox2.BorderRadius = 0;
            this.rTextBox2.BorderSize = 2;
            this.rTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rTextBox2.Location = new System.Drawing.Point(48, 152);
            this.rTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rTextBox2.Multiline = false;
            this.rTextBox2.Name = "rTextBox2";
            this.rTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rTextBox2.PasswordChar = true;
            this.rTextBox2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rTextBox2.PlaceholderText = "Clave";
            this.rTextBox2.Size = new System.Drawing.Size(192, 34);
            this.rTextBox2.TabIndex = 3;
            this.rTextBox2.Texts = "";
            this.rTextBox2.UnderlinedStyle = true;
            // 
            // rTextBox1
            // 
            this.rTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.rTextBox1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rTextBox1.BorderRadius = 0;
            this.rTextBox1.BorderSize = 2;
            this.rTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rTextBox1.Location = new System.Drawing.Point(48, 88);
            this.rTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rTextBox1.Multiline = false;
            this.rTextBox1.Name = "rTextBox1";
            this.rTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rTextBox1.PasswordChar = false;
            this.rTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rTextBox1.PlaceholderText = "DNI";
            this.rTextBox1.Size = new System.Drawing.Size(192, 34);
            this.rTextBox1.TabIndex = 2;
            this.rTextBox1.Texts = "";
            this.rTextBox1.UnderlinedStyle = true;
            // 
            // lnkRegistro
            // 
            this.lnkRegistro.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.lnkRegistro.AutoSize = true;
            this.lnkRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lnkRegistro.CausesValidation = false;
            this.lnkRegistro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lnkRegistro.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.lnkRegistro.Location = new System.Drawing.Point(72, 352);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(140, 19);
            this.lnkRegistro.TabIndex = 1;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = "No estoy registrado";
            this.lnkRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRegistro.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(24, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPI_PII.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkRegistro;
        private Resources.RButton btnLogin;
        private Resources.RTextBox rTextBox1;
        private Resources.RTextBox rTextBox2;
    }
}


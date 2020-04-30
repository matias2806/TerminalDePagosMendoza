namespace Cable_Mendoza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.groupBoxDNI = new System.Windows.Forms.GroupBox();
            this.btnDNI = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.groupBoxDNI.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 96F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.Location = new System.Drawing.Point(221, 89);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(991, 156);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Pagos";
            this.lblTitulo.UseWaitCursor = true;
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(552, 321);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(393, 78);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Ingresar con :";
            this.lblOpciones.UseWaitCursor = true;
            // 
            // groupBoxDNI
            // 
            this.groupBoxDNI.Controls.Add(this.lblDNI);
            this.groupBoxDNI.Controls.Add(this.txtDNI);
            this.groupBoxDNI.Controls.Add(this.btnDNI);
            this.groupBoxDNI.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Italic);
            this.groupBoxDNI.Location = new System.Drawing.Point(787, 444);
            this.groupBoxDNI.Name = "groupBoxDNI";
            this.groupBoxDNI.Size = new System.Drawing.Size(449, 265);
            this.groupBoxDNI.TabIndex = 5;
            this.groupBoxDNI.TabStop = false;
            this.groupBoxDNI.Text = "DNI";
            this.groupBoxDNI.UseWaitCursor = true;
            // 
            // btnDNI
            // 
            this.btnDNI.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnDNI.Location = new System.Drawing.Point(158, 159);
            this.btnDNI.Name = "btnDNI";
            this.btnDNI.Size = new System.Drawing.Size(127, 54);
            this.btnDNI.TabIndex = 5;
            this.btnDNI.Text = "Enviar numero de DNI";
            this.btnDNI.UseVisualStyleBackColor = true;
            this.btnDNI.UseWaitCursor = true;
            this.btnDNI.Click += new System.EventHandler(this.btnDNI_Click);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.lblCliente);
            this.groupBoxCliente.Controls.Add(this.txtCliente);
            this.groupBoxCliente.Controls.Add(this.btnCliente);
            this.groupBoxCliente.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Italic);
            this.groupBoxCliente.Location = new System.Drawing.Point(231, 444);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(449, 265);
            this.groupBoxCliente.TabIndex = 6;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Numero de Cliente";
            this.groupBoxCliente.UseWaitCursor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.btnCliente.Location = new System.Drawing.Point(146, 159);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(127, 54);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Enviar numero de cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.UseWaitCursor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.txtCliente.Location = new System.Drawing.Point(93, 78);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(236, 34);
            this.txtCliente.TabIndex = 6;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCliente.UseWaitCursor = true;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.txtDNI.Location = new System.Drawing.Point(102, 78);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(236, 34);
            this.txtDNI.TabIndex = 7;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNI.UseWaitCursor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Italic);
            this.lblCliente.Location = new System.Drawing.Point(88, 115);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 29);
            this.lblCliente.TabIndex = 7;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Italic);
            this.lblDNI.ForeColor = System.Drawing.Color.Red;
            this.lblDNI.Location = new System.Drawing.Point(153, 115);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(0, 29);
            this.lblDNI.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 746);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBoxDNI);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Pagos empresa de cable Mendoza";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDNI.ResumeLayout(false);
            this.groupBoxDNI.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.GroupBox groupBoxDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnDNI;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDNI;
    }
}


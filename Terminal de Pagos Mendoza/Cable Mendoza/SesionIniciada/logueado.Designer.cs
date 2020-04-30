namespace SesionIniciada
{
    partial class MiSesionIniciada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnFin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.lblFijoDni = new System.Windows.Forms.Label();
            this.lblFijoNumCliente = new System.Windows.Forms.Label();
            this.lblNumCliente = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(36, 46);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(0, 13);
            this.lblDNI.TabIndex = 0;
            // 
            // btnFin
            // 
            this.btnFin.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.btnFin.Location = new System.Drawing.Point(1068, 767);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(232, 91);
            this.btnFin.TabIndex = 2;
            this.btnFin.Text = "Finalizar Consulta";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 210);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.lbl_DNI.Location = new System.Drawing.Point(559, 122);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(0, 27);
            this.lbl_DNI.TabIndex = 4;
            // 
            // lblFijoDni
            // 
            this.lblFijoDni.AutoSize = true;
            this.lblFijoDni.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.lblFijoDni.Location = new System.Drawing.Point(397, 122);
            this.lblFijoDni.Name = "lblFijoDni";
            this.lblFijoDni.Size = new System.Drawing.Size(156, 27);
            this.lblFijoDni.TabIndex = 5;
            this.lblFijoDni.Text = "Numero de DNI :";
            // 
            // lblFijoNumCliente
            // 
            this.lblFijoNumCliente.AutoSize = true;
            this.lblFijoNumCliente.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.lblFijoNumCliente.Location = new System.Drawing.Point(858, 122);
            this.lblFijoNumCliente.Name = "lblFijoNumCliente";
            this.lblFijoNumCliente.Size = new System.Drawing.Size(184, 27);
            this.lblFijoNumCliente.TabIndex = 6;
            this.lblFijoNumCliente.Text = "Numero de Cliente :";
            // 
            // lblNumCliente
            // 
            this.lblNumCliente.AutoSize = true;
            this.lblNumCliente.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.lblNumCliente.Location = new System.Drawing.Point(1063, 122);
            this.lblNumCliente.Name = "lblNumCliente";
            this.lblNumCliente.Size = new System.Drawing.Size(0, 27);
            this.lblNumCliente.TabIndex = 7;
            // 
            // grilla
            // 
            this.grilla.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1, 1, 1, 4);
            this.grilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.grilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grilla.ColumnHeadersHeight = 50;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grilla.EnableHeadersVisualStyles = false;
            this.grilla.GridColor = System.Drawing.Color.DarkBlue;
            this.grilla.Location = new System.Drawing.Point(39, 348);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grilla.RowHeadersVisible = false;
            this.grilla.RowHeadersWidth = 90;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1, 1, 1, 4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.grilla.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grilla.RowTemplate.Height = 36;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(1261, 303);
            this.grilla.TabIndex = 8;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(260, 799);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(0, 26);
            this.lblTotalAPagar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 799);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Monto total a abonar :";
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Italic);
            this.btnPagar.Location = new System.Drawing.Point(368, 767);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(232, 91);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "Abonar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // MiSesionIniciada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 881);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.lblNumCliente);
            this.Controls.Add(this.lblFijoNumCliente);
            this.Controls.Add(this.lblFijoDni);
            this.Controls.Add(this.lbl_DNI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.lblDNI);
            this.Name = "MiSesionIniciada";
            this.Text = "Sesion Iniciada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.Label lblFijoDni;
        private System.Windows.Forms.Label lblFijoNumCliente;
        private System.Windows.Forms.Label lblNumCliente;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPagar;
    }
}


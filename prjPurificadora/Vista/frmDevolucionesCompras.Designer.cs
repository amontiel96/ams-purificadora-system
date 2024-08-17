namespace prjPurificadora.Vista
{
    partial class frmDevolucionesCompras
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tblCompras = new System.Windows.Forms.DataGridView();
            this.txtPreCompra = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidaDev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuedan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComfirmarDev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(362, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Día final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(94, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "Día inicial:";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(418, 35);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFinal.TabIndex = 101;
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Location = new System.Drawing.Point(156, 36);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicial.TabIndex = 100;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(625, 34);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 98;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // tblCompras
            // 
            this.tblCompras.AllowUserToAddRows = false;
            this.tblCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblCompras.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCompras.Location = new System.Drawing.Point(71, 199);
            this.tblCompras.Name = "tblCompras";
            this.tblCompras.ReadOnly = true;
            this.tblCompras.Size = new System.Drawing.Size(835, 143);
            this.tblCompras.TabIndex = 105;
            // 
            // txtPreCompra
            // 
            this.txtPreCompra.Enabled = false;
            this.txtPreCompra.Location = new System.Drawing.Point(166, 386);
            this.txtPreCompra.MaxLength = 6;
            this.txtPreCompra.Name = "txtPreCompra";
            this.txtPreCompra.Size = new System.Drawing.Size(263, 20);
            this.txtPreCompra.TabIndex = 112;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(166, 412);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(263, 20);
            this.txtCantidad.TabIndex = 111;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(166, 360);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(75, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Precio compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(75, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Cantidad compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(75, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nom_Producto:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(643, 412);
            this.txtSubtotal.MaxLength = 6;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(263, 20);
            this.txtSubtotal.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(541, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Subtotal:";
            // 
            // txtCantidaDev
            // 
            this.txtCantidaDev.Enabled = false;
            this.txtCantidaDev.Location = new System.Drawing.Point(643, 360);
            this.txtCantidaDev.MaxLength = 6;
            this.txtCantidaDev.Name = "txtCantidaDev";
            this.txtCantidaDev.Size = new System.Drawing.Size(263, 20);
            this.txtCantidaDev.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(541, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Cantidad a devoler:";
            // 
            // txtQuedan
            // 
            this.txtQuedan.Enabled = false;
            this.txtQuedan.Location = new System.Drawing.Point(643, 386);
            this.txtQuedan.MaxLength = 6;
            this.txtQuedan.Name = "txtQuedan";
            this.txtQuedan.Size = new System.Drawing.Size(263, 20);
            this.txtQuedan.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(541, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 117;
            this.label6.Text = "Quedan:";
            // 
            // btnComfirmarDev
            // 
            this.btnComfirmarDev.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmarDev.FlatAppearance.BorderSize = 0;
            this.btnComfirmarDev.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnComfirmarDev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnComfirmarDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmarDev.ForeColor = System.Drawing.Color.Black;
            this.btnComfirmarDev.Location = new System.Drawing.Point(643, 455);
            this.btnComfirmarDev.Name = "btnComfirmarDev";
            this.btnComfirmarDev.Size = new System.Drawing.Size(263, 23);
            this.btnComfirmarDev.TabIndex = 104;
            this.btnComfirmarDev.Text = "Comfirmar devolución...";
            this.btnComfirmarDev.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtFechaInicial);
            this.groupBox1.Controls.Add(this.dtFechaFinal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(71, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 82);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indique la fecha en que se realizo la compra a devolver";
            // 
            // frmDevolucionesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnComfirmarDev);
            this.Controls.Add(this.txtQuedan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidaDev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreCompra);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblCompras);
            this.Name = "frmDevolucionesCompras";
            this.Text = "Devoluciones de compras";
            this.Controls.SetChildIndex(this.tblCompras, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtPreCompra, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSubtotal, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCantidaDev, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtQuedan, 0);
            this.Controls.SetChildIndex(this.btnComfirmarDev, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblCompras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtFechaFinal;
        public System.Windows.Forms.DateTimePicker dtFechaInicial;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.DataGridView tblCompras;
        public System.Windows.Forms.TextBox txtPreCompra;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCantidaDev;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtQuedan;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnComfirmarDev;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
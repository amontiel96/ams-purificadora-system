namespace prjPurificadora.Vista
{
    partial class frmCompraBote
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
            this.btnComfirmar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPreCompra = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblBotellones = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnComfirmarCompras = new System.Windows.Forms.Button();
            this.tblAgrega = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGastoCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblBotellones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAgrega)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComfirmar
            // 
            this.btnComfirmar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmar.FlatAppearance.BorderSize = 0;
            this.btnComfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmar.Location = new System.Drawing.Point(766, 303);
            this.btnComfirmar.Name = "btnComfirmar";
            this.btnComfirmar.Size = new System.Drawing.Size(146, 23);
            this.btnComfirmar.TabIndex = 77;
            this.btnComfirmar.Text = "Agregar";
            this.btnComfirmar.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(649, 236);
            this.txtCantidad.MaxLength = 6;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(263, 20);
            this.txtCantidad.TabIndex = 75;
            // 
            // txtPreCompra
            // 
            this.txtPreCompra.Location = new System.Drawing.Point(164, 284);
            this.txtPreCompra.MaxLength = 6;
            this.txtPreCompra.Name = "txtPreCompra";
            this.txtPreCompra.Size = new System.Drawing.Size(263, 20);
            this.txtPreCompra.TabIndex = 74;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Enabled = false;
            this.txtExistencia.Location = new System.Drawing.Point(164, 259);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(263, 20);
            this.txtExistencia.TabIndex = 73;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(164, 236);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(527, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Cantidad a comprar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(77, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Precio compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(77, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nom_Producto:";
            // 
            // tblBotellones
            // 
            this.tblBotellones.AllowUserToAddRows = false;
            this.tblBotellones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblBotellones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblBotellones.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblBotellones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblBotellones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBotellones.Location = new System.Drawing.Point(61, 116);
            this.tblBotellones.Name = "tblBotellones";
            this.tblBotellones.ReadOnly = true;
            this.tblBotellones.Size = new System.Drawing.Size(851, 105);
            this.tblBotellones.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Subtotal:  $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(201, 474);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 79;
            this.lblTotal.Text = "00.00";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(164, 309);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(263, 21);
            this.cmbProveedor.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(77, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Proveedor:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(61, 21);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 87;
            this.dtFecha.Visible = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(645, 307);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 20);
            this.lblSubtotal.TabIndex = 94;
            this.lblSubtotal.Text = "00.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 93;
            this.label8.Text = "Total compra:  $";
            // 
            // btnComfirmarCompras
            // 
            this.btnComfirmarCompras.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmarCompras.Enabled = false;
            this.btnComfirmarCompras.FlatAppearance.BorderSize = 0;
            this.btnComfirmarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmarCompras.Location = new System.Drawing.Point(665, 466);
            this.btnComfirmarCompras.Name = "btnComfirmarCompras";
            this.btnComfirmarCompras.Size = new System.Drawing.Size(247, 28);
            this.btnComfirmarCompras.TabIndex = 89;
            this.btnComfirmarCompras.Text = "comfirmar compra";
            this.btnComfirmarCompras.UseVisualStyleBackColor = false;
            // 
            // tblAgrega
            // 
            this.tblAgrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblAgrega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblAgrega.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblAgrega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblAgrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAgrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.tblAgrega.Location = new System.Drawing.Point(61, 355);
            this.tblAgrega.Name = "tblAgrega";
            this.tblAgrega.ReadOnly = true;
            this.tblAgrega.Size = new System.Drawing.Size(851, 105);
            this.tblAgrega.TabIndex = 88;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id_Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id_Proveedor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subtotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtGastoCompra
            // 
            this.txtGastoCompra.Location = new System.Drawing.Point(649, 262);
            this.txtGastoCompra.MaxLength = 6;
            this.txtGastoCompra.Name = "txtGastoCompra";
            this.txtGastoCompra.Size = new System.Drawing.Size(263, 20);
            this.txtGastoCompra.TabIndex = 99;
            this.txtGastoCompra.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(527, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Gasto de compra:";
            // 
            // frmCompraBote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.txtGastoCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnComfirmarCompras);
            this.Controls.Add(this.tblAgrega);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnComfirmar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPreCompra);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblBotellones);
            this.Name = "frmCompraBote";
            this.Text = "Comprar botellones";
            this.Controls.SetChildIndex(this.tblBotellones, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtExistencia, 0);
            this.Controls.SetChildIndex(this.txtPreCompra, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.btnComfirmar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.cmbProveedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.tblAgrega, 0);
            this.Controls.SetChildIndex(this.btnComfirmarCompras, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtGastoCompra, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblBotellones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAgrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnComfirmar;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtPreCompra;
        public System.Windows.Forms.TextBox txtExistencia;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView tblBotellones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.ComboBox cmbProveedor;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnComfirmarCompras;
        public System.Windows.Forms.DataGridView tblAgrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.TextBox txtGastoCompra;
        private System.Windows.Forms.Label label7;
    }
}
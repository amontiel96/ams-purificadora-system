namespace prjPurificadora.Vista
{
    partial class frmCompras
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnComfirmar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPreCompra = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblAgrega = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tblAgrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(732, 309);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(162, 23);
            this.btnAgregar.TabIndex = 62;
            this.btnAgregar.Text = "Agregar a compra";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnComfirmar
            // 
            this.btnComfirmar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmar.Enabled = false;
            this.btnComfirmar.FlatAppearance.BorderSize = 0;
            this.btnComfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmar.Location = new System.Drawing.Point(663, 459);
            this.btnComfirmar.Name = "btnComfirmar";
            this.btnComfirmar.Size = new System.Drawing.Size(247, 30);
            this.btnComfirmar.TabIndex = 61;
            this.btnComfirmar.Text = "comfirmar compra";
            this.btnComfirmar.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(631, 281);
            this.txtCantidad.MaxLength = 6;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(263, 20);
            this.txtCantidad.TabIndex = 60;
            // 
            // txtPreCompra
            // 
            this.txtPreCompra.Enabled = false;
            this.txtPreCompra.Location = new System.Drawing.Point(163, 281);
            this.txtPreCompra.Name = "txtPreCompra";
            this.txtPreCompra.Size = new System.Drawing.Size(263, 20);
            this.txtPreCompra.TabIndex = 59;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(163, 240);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(509, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Cantidad a comprar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(76, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Precio compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(76, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nom_Producto:";
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
            this.tblAgrega.Location = new System.Drawing.Point(59, 338);
            this.tblAgrega.Name = "tblAgrega";
            this.tblAgrega.ReadOnly = true;
            this.tblAgrega.Size = new System.Drawing.Size(851, 105);
            this.tblAgrega.TabIndex = 49;
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
            // tblProductos
            // 
            this.tblProductos.AllowUserToAddRows = false;
            this.tblProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblProductos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Location = new System.Drawing.Point(59, 117);
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.ReadOnly = true;
            this.tblProductos.Size = new System.Drawing.Size(851, 105);
            this.tblProductos.TabIndex = 48;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(627, 314);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 20);
            this.lblSubtotal.TabIndex = 81;
            this.lblSubtotal.Text = "00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Subtotal:  $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(199, 469);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 83;
            this.lblTotal.Text = "00.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Total compra:  $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(509, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(631, 240);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(263, 21);
            this.cmbProveedor.TabIndex = 84;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(59, 91);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 86;
            this.dtFecha.Visible = false;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 498);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnComfirmar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPreCompra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblAgrega);
            this.Controls.Add(this.tblProductos);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Controls.SetChildIndex(this.tblProductos, 0);
            this.Controls.SetChildIndex(this.tblAgrega, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtPreCompra, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.btnComfirmar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.cmbProveedor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblAgrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnComfirmar;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtPreCompra;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.DataGridView tblAgrega;
        public System.Windows.Forms.DataGridView tblProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblSubtotal;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.ComboBox cmbProveedor;
        public System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
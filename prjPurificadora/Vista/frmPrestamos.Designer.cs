namespace prjPurificadora.Vista
{
    partial class frmPrestamos
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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.tblPrestamos = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtRegresar = new System.Windows.Forms.TextBox();
            this.txtPrestar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(714, 484);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 107;
            this.dtFecha.Visible = false;
            // 
            // tblPrestamos
            // 
            this.tblPrestamos.AllowUserToAddRows = false;
            this.tblPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPrestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblPrestamos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPrestamos.Location = new System.Drawing.Point(85, 293);
            this.tblPrestamos.Name = "tblPrestamos";
            this.tblPrestamos.ReadOnly = true;
            this.tblPrestamos.Size = new System.Drawing.Size(794, 150);
            this.tblPrestamos.TabIndex = 106;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(690, 455);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(189, 23);
            this.btnRegistrar.TabIndex = 105;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtRegresar
            // 
            this.txtRegresar.Enabled = false;
            this.txtRegresar.Location = new System.Drawing.Point(517, 462);
            this.txtRegresar.MaxLength = 3;
            this.txtRegresar.Name = "txtRegresar";
            this.txtRegresar.Size = new System.Drawing.Size(100, 20);
            this.txtRegresar.TabIndex = 104;
            this.txtRegresar.Text = "0";
            // 
            // txtPrestar
            // 
            this.txtPrestar.Enabled = false;
            this.txtPrestar.Location = new System.Drawing.Point(187, 462);
            this.txtPrestar.MaxLength = 3;
            this.txtPrestar.Name = "txtPrestar";
            this.txtPrestar.Size = new System.Drawing.Size(100, 20);
            this.txtPrestar.TabIndex = 103;
            this.txtPrestar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(387, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Unidades a regresar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(87, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Unidades a prestar:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(369, 124);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 100;
            this.btnAceptar.Text = "Aceptar...";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Vendedor:";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Items.AddRange(new object[] {
            "Beto",
            "Felipe",
            "Mundo"});
            this.cmbVendedor.Location = new System.Drawing.Point(152, 126);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(192, 21);
            this.cmbVendedor.TabIndex = 98;
            // 
            // tblClientes
            // 
            this.tblClientes.AllowUserToAddRows = false;
            this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblClientes.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.Location = new System.Drawing.Point(15, 21);
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.ReadOnly = true;
            this.tblClientes.Size = new System.Drawing.Size(295, 104);
            this.tblClientes.TabIndex = 108;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnContinuar);
            this.groupBox1.Controls.Add(this.tblClientes);
            this.groupBox1.Location = new System.Drawing.Point(553, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 184);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un cliente...!";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnContinuar.Enabled = false;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.Location = new System.Drawing.Point(133, 141);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(189, 23);
            this.btnContinuar.TabIndex = 110;
            this.btnContinuar.Text = "Continuar...";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Visible = false;
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.tblPrestamos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtRegresar);
            this.Controls.Add(this.txtPrestar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrestamos";
            this.Text = "Prestamos";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmbVendedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPrestar, 0);
            this.Controls.SetChildIndex(this.txtRegresar, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.tblPrestamos, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.DataGridView tblPrestamos;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.TextBox txtRegresar;
        public System.Windows.Forms.TextBox txtPrestar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.DataGridView tblClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnContinuar;
    }
}
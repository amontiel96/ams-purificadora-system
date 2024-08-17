namespace prjPurificadora.Vista
{
    partial class frmClientesUnidades
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
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.tblUnidades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaf = new System.Windows.Forms.DateTimePicker();
            this.dtFechai = new System.Windows.Forms.DateTimePicker();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.tblReporte = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnidades
            // 
            this.txtUnidades.Enabled = false;
            this.txtUnidades.Location = new System.Drawing.Point(795, 232);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(162, 20);
            this.txtUnidades.TabIndex = 127;
            this.txtUnidades.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(795, 194);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(162, 20);
            this.txtCliente.TabIndex = 126;
            this.txtCliente.Visible = false;
            // 
            // tblUnidades
            // 
            this.tblUnidades.AllowUserToAddRows = false;
            this.tblUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblUnidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblUnidades.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblUnidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUnidades.Enabled = false;
            this.tblUnidades.Location = new System.Drawing.Point(785, 284);
            this.tblUnidades.Name = "tblUnidades";
            this.tblUnidades.ReadOnly = true;
            this.tblUnidades.Size = new System.Drawing.Size(103, 132);
            this.tblUnidades.TabIndex = 125;
            this.tblUnidades.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Día final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Día inicial:";
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(286, 139);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 119;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(27, 139);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 118;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(795, 258);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 117;
            this.dtFecha.Visible = false;
            // 
            // tblReporte
            // 
            this.tblReporte.AllowUserToAddRows = false;
            this.tblReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblReporte.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReporte.Location = new System.Drawing.Point(12, 206);
            this.tblReporte.Name = "tblReporte";
            this.tblReporte.ReadOnly = true;
            this.tblReporte.Size = new System.Drawing.Size(698, 323);
            this.tblReporte.TabIndex = 116;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(727, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 115;
            this.btnAceptar.Text = "Aceptar...";
            this.btnAceptar.UseVisualStyleBackColor = false;
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
            this.cmbVendedor.Location = new System.Drawing.Point(534, 141);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(176, 21);
            this.cmbVendedor.TabIndex = 114;
            // 
            // tblClientes
            // 
            this.tblClientes.AllowUserToAddRows = false;
            this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblClientes.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.Enabled = false;
            this.tblClientes.Location = new System.Drawing.Point(785, 422);
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.ReadOnly = true;
            this.tblClientes.Size = new System.Drawing.Size(103, 132);
            this.tblClientes.TabIndex = 128;
            this.tblClientes.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Location = new System.Drawing.Point(487, 563);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(223, 23);
            this.btnPDF.TabIndex = 129;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // frmClientesUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.tblClientes);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.tblUnidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.tblReporte);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbVendedor);
            this.Name = "frmClientesUnidades";
            this.Text = "Reporte de clientes";
            this.Controls.SetChildIndex(this.cmbVendedor, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.tblReporte, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tblUnidades, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtUnidades, 0);
            this.Controls.SetChildIndex(this.tblClientes, 0);
            this.Controls.SetChildIndex(this.btnPDF, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUnidades;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.DataGridView tblUnidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtFechaf;
        public System.Windows.Forms.DateTimePicker dtFechai;
        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.DataGridView tblReporte;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.DataGridView tblClientes;
        public System.Windows.Forms.Button btnPDF;
    }
}
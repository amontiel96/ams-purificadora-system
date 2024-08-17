namespace prjPurificadora.Vista
{
    partial class frmVentClientes
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
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaf = new System.Windows.Forms.DateTimePicker();
            this.dtFechai = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tblUnidades = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(598, 374);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 103;
            this.dtFecha.Visible = false;
            // 
            // tblClientes
            // 
            this.tblClientes.AllowUserToAddRows = false;
            this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblClientes.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.Location = new System.Drawing.Point(12, 210);
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.ReadOnly = true;
            this.tblClientes.Size = new System.Drawing.Size(474, 363);
            this.tblClientes.TabIndex = 102;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(727, 143);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 101;
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
            this.cmbVendedor.Location = new System.Drawing.Point(534, 145);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(176, 21);
            this.cmbVendedor.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Día final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Día inicial:";
            // 
            // dtFechaf
            // 
            this.dtFechaf.Location = new System.Drawing.Point(286, 143);
            this.dtFechaf.Name = "dtFechaf";
            this.dtFechaf.Size = new System.Drawing.Size(200, 20);
            this.dtFechaf.TabIndex = 105;
            // 
            // dtFechai
            // 
            this.dtFechai.Location = new System.Drawing.Point(27, 143);
            this.dtFechai.Name = "dtFechai";
            this.dtFechai.Size = new System.Drawing.Size(200, 20);
            this.dtFechai.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Ruta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Total de Unidades:";
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
            this.tblUnidades.Location = new System.Drawing.Point(562, 441);
            this.tblUnidades.Name = "tblUnidades";
            this.tblUnidades.ReadOnly = true;
            this.tblUnidades.Size = new System.Drawing.Size(228, 132);
            this.tblUnidades.TabIndex = 111;
            this.tblUnidades.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(640, 207);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(162, 20);
            this.txtCliente.TabIndex = 112;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Enabled = false;
            this.txtUnidades.Location = new System.Drawing.Point(640, 245);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(162, 20);
            this.txtUnidades.TabIndex = 113;
            // 
            // frmVentClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 598);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.tblUnidades);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaf);
            this.Controls.Add(this.dtFechai);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.tblClientes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbVendedor);
            this.Name = "frmVentClientes";
            this.Text = "Reporte de clientes";
            this.Controls.SetChildIndex(this.cmbVendedor, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.tblClientes, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.dtFechai, 0);
            this.Controls.SetChildIndex(this.dtFechaf, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tblUnidades, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtUnidades, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.DataGridView tblClientes;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtFechaf;
        public System.Windows.Forms.DateTimePicker dtFechai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView tblUnidades;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtUnidades;
    }
}
namespace prjPurificadora.Vista
{
    partial class frmCargas
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
            this.tblCargas = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDescarga = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tblCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCargas
            // 
            this.tblCargas.AllowUserToAddRows = false;
            this.tblCargas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCargas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblCargas.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblCargas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCargas.Location = new System.Drawing.Point(99, 207);
            this.tblCargas.Name = "tblCargas";
            this.tblCargas.ReadOnly = true;
            this.tblCargas.Size = new System.Drawing.Size(794, 150);
            this.tblCargas.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(704, 390);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(189, 23);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtDescarga
            // 
            this.txtDescarga.Enabled = false;
            this.txtDescarga.Location = new System.Drawing.Point(531, 397);
            this.txtDescarga.MaxLength = 3;
            this.txtDescarga.Name = "txtDescarga";
            this.txtDescarga.Size = new System.Drawing.Size(100, 20);
            this.txtDescarga.TabIndex = 20;
            this.txtDescarga.Text = "0";
            // 
            // txtCarga
            // 
            this.txtCarga.Enabled = false;
            this.txtCarga.Location = new System.Drawing.Point(196, 397);
            this.txtCarga.MaxLength = 3;
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 19;
            this.txtCarga.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(401, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cantidad de descarga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(101, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad de carga:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(389, 122);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar...";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(98, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
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
            this.cmbVendedor.Location = new System.Drawing.Point(172, 124);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(192, 21);
            this.cmbVendedor.TabIndex = 14;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(693, 122);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 23;
            this.dtFecha.Visible = false;
            // 
            // frmCargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 498);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.tblCargas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDescarga);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendedor);
            this.Name = "frmCargas";
            this.Text = "Carga y descargas de garrafones";
            this.Controls.SetChildIndex(this.cmbVendedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCarga, 0);
            this.Controls.SetChildIndex(this.txtDescarga, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.tblCargas, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tblCargas;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.TextBox txtDescarga;
        public System.Windows.Forms.TextBox txtCarga;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.DateTimePicker dtFecha;
    }
}
namespace prjPurificadora.Vista
{
    partial class frmClientes
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.chbTipoCliente = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(153, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(246, 20);
            this.txtid.TabIndex = 61;
            this.txtid.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(74, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Buscar:";
            this.label7.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(775, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 23);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(636, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 23);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(493, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 23);
            this.btnEliminar.TabIndex = 57;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(352, 202);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 23);
            this.btnModificar.TabIndex = 56;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(214, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 23);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(77, 202);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 23);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(153, 131);
            this.txtNombre.MaxLength = 19;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // tblClientes
            // 
            this.tblClientes.AllowUserToAddRows = false;
            this.tblClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblClientes.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.Location = new System.Drawing.Point(77, 254);
            this.tblClientes.Name = "tblClientes";
            this.tblClientes.ReadOnly = true;
            this.tblClientes.Size = new System.Drawing.Size(818, 150);
            this.tblClientes.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(406, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ruta:";
            // 
            // cmbRuta
            // 
            this.cmbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuta.Enabled = false;
            this.cmbRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(466, 131);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(202, 21);
            this.cmbRuta.TabIndex = 64;
            // 
            // chbTipoCliente
            // 
            this.chbTipoCliente.AutoSize = true;
            this.chbTipoCliente.BackColor = System.Drawing.Color.Transparent;
            this.chbTipoCliente.Enabled = false;
            this.chbTipoCliente.Location = new System.Drawing.Point(775, 135);
            this.chbTipoCliente.Name = "chbTipoCliente";
            this.chbTipoCliente.Size = new System.Drawing.Size(90, 17);
            this.chbTipoCliente.TabIndex = 99;
            this.chbTipoCliente.Text = "Dependencia";
            this.chbTipoCliente.UseVisualStyleBackColor = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 498);
            this.Controls.Add(this.chbTipoCliente);
            this.Controls.Add(this.cmbRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.tblClientes);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tblClientes, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtid, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbRuta, 0);
            this.Controls.SetChildIndex(this.chbTipoCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.DataGridView tblClientes;
        public System.Windows.Forms.ComboBox cmbRuta;
        public System.Windows.Forms.CheckBox chbTipoCliente;
    }
}
namespace prjPurificadora.Vista
{
    partial class frmBotellones
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(775, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 23);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(444, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 23);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(77, 236);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 23);
            this.btnModificar.TabIndex = 54;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(775, 155);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 23);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Location = new System.Drawing.Point(603, 155);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 23);
            this.btnNuevo.TabIndex = 52;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Visible = false;
            // 
            // tblProductos
            // 
            this.tblProductos.AllowUserToAddRows = false;
            this.tblProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblProductos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Location = new System.Drawing.Point(77, 284);
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.ReadOnly = true;
            this.tblProductos.Size = new System.Drawing.Size(818, 189);
            this.tblProductos.TabIndex = 51;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(632, 117);
            this.txtPrecio.MaxLength = 6;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(263, 20);
            this.txtPrecio.TabIndex = 48;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Enabled = false;
            this.txtExistencia.Location = new System.Drawing.Point(156, 152);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(263, 20);
            this.txtExistencia.TabIndex = 47;
            this.txtExistencia.Text = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(156, 117);
            this.txtNombre.MaxLength = 24;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(545, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Precio compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(69, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(69, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nom_Producto:";
            // 
            // frmBotellones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tblProductos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmBotellones";
            this.Text = "Botellones";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtExistencia, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.tblProductos, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.DataGridView tblProductos;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtExistencia;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
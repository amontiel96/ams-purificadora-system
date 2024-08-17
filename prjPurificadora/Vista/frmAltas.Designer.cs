namespace prjPurificadora.Vista
{
    partial class frmAltas
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
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComfirmar
            // 
            this.btnComfirmar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmar.Enabled = false;
            this.btnComfirmar.FlatAppearance.BorderSize = 0;
            this.btnComfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmar.Location = new System.Drawing.Point(636, 350);
            this.btnComfirmar.Name = "btnComfirmar";
            this.btnComfirmar.Size = new System.Drawing.Size(263, 23);
            this.btnComfirmar.TabIndex = 109;
            this.btnComfirmar.Text = "Agregar al inventario...";
            this.btnComfirmar.UseVisualStyleBackColor = false;
            // 
            // tblProductos
            // 
            this.tblProductos.AllowUserToAddRows = false;
            this.tblProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblProductos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Location = new System.Drawing.Point(81, 116);
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.ReadOnly = true;
            this.tblProductos.Size = new System.Drawing.Size(818, 149);
            this.tblProductos.TabIndex = 104;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(160, 298);
            this.txtNombre.MaxLength = 24;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nom_Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(489, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Unidades que se agregarán:";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Enabled = false;
            this.txtUnidades.Location = new System.Drawing.Point(636, 298);
            this.txtUnidades.MaxLength = 6;
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(263, 20);
            this.txtUnidades.TabIndex = 102;
            this.txtUnidades.Text = "0";
            // 
            // frmAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.btnComfirmar);
            this.Controls.Add(this.tblProductos);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmAltas";
            this.Text = "Altas al inventario";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtUnidades, 0);
            this.Controls.SetChildIndex(this.tblProductos, 0);
            this.Controls.SetChildIndex(this.btnComfirmar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnComfirmar;
        public System.Windows.Forms.DataGridView tblProductos;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUnidades;
    }
}
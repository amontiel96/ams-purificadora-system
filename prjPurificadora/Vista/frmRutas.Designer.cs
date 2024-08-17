namespace prjPurificadora.Vista
{
    partial class frmRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblRutas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreRuta = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-214, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 78);
            this.panel1.TabIndex = 101;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::prjPurificadora.Properties.Resources.carro;
            this.pictureBox3.Location = new System.Drawing.Point(205, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjPurificadora.Properties.Resources.mejorado_editar_hoy_copia_copia;
            this.pictureBox1.Location = new System.Drawing.Point(621, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::prjPurificadora.Properties.Resources.Titulo;
            this.pictureBox2.Location = new System.Drawing.Point(307, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tblRutas
            // 
            this.tblRutas.AllowUserToAddRows = false;
            this.tblRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblRutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblRutas.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tblRutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRutas.Location = new System.Drawing.Point(73, 222);
            this.tblRutas.Name = "tblRutas";
            this.tblRutas.ReadOnly = true;
            this.tblRutas.Size = new System.Drawing.Size(356, 130);
            this.tblRutas.TabIndex = 108;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(272, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 23);
            this.btnEliminar.TabIndex = 107;
            this.btnEliminar.Text = "Eliminar Ruta Seleccionada";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(73, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 23);
            this.btnAgregar.TabIndex = 106;
            this.btnAgregar.Text = "Agregar Nueva Ruta";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Nombre Ruta:";
            // 
            // txtNombreRuta
            // 
            this.txtNombreRuta.Location = new System.Drawing.Point(158, 136);
            this.txtNombreRuta.MaxLength = 24;
            this.txtNombreRuta.Name = "txtNombreRuta";
            this.txtNombreRuta.Size = new System.Drawing.Size(271, 20);
            this.txtNombreRuta.TabIndex = 111;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(272, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 23);
            this.btnCancelar.TabIndex = 112;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjPurificadora.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 454);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNombreRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblRutas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de rutas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView tblRutas;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNombreRuta;
        public System.Windows.Forms.Button btnCancelar;
    }
}
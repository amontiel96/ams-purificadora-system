namespace prjPurificadora.Vista
{
    partial class frmInventarioInicial
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
            this.txtBote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSello = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTapon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComfirmar
            // 
            this.btnComfirmar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComfirmar.FlatAppearance.BorderSize = 0;
            this.btnComfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirmar.Location = new System.Drawing.Point(494, 425);
            this.btnComfirmar.Name = "btnComfirmar";
            this.btnComfirmar.Size = new System.Drawing.Size(263, 23);
            this.btnComfirmar.TabIndex = 114;
            this.btnComfirmar.Text = "Confirmar inventario inicial...";
            this.btnComfirmar.UseVisualStyleBackColor = false;
            // 
            // txtBote
            // 
            this.txtBote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBote.Location = new System.Drawing.Point(216, 47);
            this.txtBote.MaxLength = 6;
            this.txtBote.Name = "txtBote";
            this.txtBote.Size = new System.Drawing.Size(216, 29);
            this.txtBote.TabIndex = 112;
            this.txtBote.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 110;
            this.label2.Text = "Botellones:";
            // 
            // txtSello
            // 
            this.txtSello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSello.Location = new System.Drawing.Point(216, 101);
            this.txtSello.MaxLength = 6;
            this.txtSello.Name = "txtSello";
            this.txtSello.Size = new System.Drawing.Size(216, 29);
            this.txtSello.TabIndex = 116;
            this.txtSello.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 115;
            this.label1.Text = "Sellos:";
            // 
            // txtTapon
            // 
            this.txtTapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTapon.Location = new System.Drawing.Point(216, 168);
            this.txtTapon.MaxLength = 6;
            this.txtTapon.Name = "txtTapon";
            this.txtTapon.Size = new System.Drawing.Size(216, 29);
            this.txtTapon.TabIndex = 118;
            this.txtTapon.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 117;
            this.label3.Text = "Tapones:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.txtTapon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSello);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(214, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 259);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indique la cantidad de unidades que tiene actualmente en su almacen";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(214, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(263, 23);
            this.btnCancelar.TabIndex = 120;
            this.btnCancelar.Text = "En otro momento";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmInventarioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnComfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioInicial";
            this.Text = "Configurar inventario inicial";
            this.Controls.SetChildIndex(this.btnComfirmar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnComfirmar;
        public System.Windows.Forms.TextBox txtBote;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSello;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTapon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnCancelar;
    }
}
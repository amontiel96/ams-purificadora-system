namespace prjPurificadora.Vista
{
    partial class frmDtsConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDtsConexion));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtBd = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(114, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnConexion.FlatAppearance.BorderSize = 0;
            this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConexion.Location = new System.Drawing.Point(114, 218);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(179, 23);
            this.btnConexion.TabIndex = 18;
            this.btnConexion.Text = "Probar conexion";
            this.btnConexion.UseVisualStyleBackColor = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(114, 175);
            this.txtPwd.MaxLength = 19;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(179, 20);
            this.txtPwd.TabIndex = 17;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(114, 138);
            this.txtUser.MaxLength = 25;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(179, 20);
            this.txtUser.TabIndex = 16;
            // 
            // txtBd
            // 
            this.txtBd.Location = new System.Drawing.Point(114, 103);
            this.txtBd.MaxLength = 25;
            this.txtBd.Name = "txtBd";
            this.txtBd.Size = new System.Drawing.Size(179, 20);
            this.txtBd.TabIndex = 15;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(114, 67);
            this.txtServidor.MaxLength = 25;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(179, 20);
            this.txtServidor.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Base de datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Passowrd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servidor:";
            // 
            // frmDtsConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjPurificadora.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtBd);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDtsConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Conexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnConexion;
        public System.Windows.Forms.TextBox txtPwd;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtBd;
        public System.Windows.Forms.TextBox txtServidor;
    }
}
namespace prjPurificadora.Vista
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUser = new System.Windows.Forms.DataGridView();
            this.btnConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(59, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(197, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Location = new System.Drawing.Point(59, 165);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(197, 23);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar...";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(59, 111);
            this.txtPwd.MaxLength = 15;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(197, 20);
            this.txtPwd.TabIndex = 9;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(59, 53);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(197, 20);
            this.txtUser.TabIndex = 8;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(128, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(137, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // tblUser
            // 
            this.tblUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUser.Location = new System.Drawing.Point(340, 265);
            this.tblUser.Name = "tblUser";
            this.tblUser.ReadOnly = true;
            this.tblUser.Size = new System.Drawing.Size(197, 75);
            this.tblUser.TabIndex = 12;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfig.Location = new System.Drawing.Point(59, 259);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(197, 23);
            this.btnConfig.TabIndex = 13;
            this.btnConfig.Text = "Datos de conexion";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjPurificadora.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.tblUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.tblUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnIniciar;
        public System.Windows.Forms.TextBox txtPwd;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.DataGridView tblUser;
        public System.Windows.Forms.Button btnConfig;
    }
}
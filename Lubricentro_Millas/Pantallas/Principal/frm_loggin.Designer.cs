namespace Lubricentro_Millas.Pantallas.Principal
{
    partial class frm_loggin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loggin));
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_inic_sesion = new System.Windows.Forms.Button();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_line1 = new System.Windows.Forms.Label();
            this.lbl_line2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Contrasena = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.cmb_roles = new System.Windows.Forms.ComboBox();
            this.erp_Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(90, 262);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(74, 26);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.txt_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasena.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasena.ForeColor = System.Drawing.Color.Black;
            this.txt_contrasena.Location = new System.Drawing.Point(33, 147);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contrasena.Multiline = true;
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(190, 25);
            this.txt_contrasena.TabIndex = 1;
            this.txt_contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(30, 80);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(190, 25);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_inic_sesion
            // 
            this.btn_inic_sesion.BackColor = System.Drawing.Color.Teal;
            this.btn_inic_sesion.FlatAppearance.BorderSize = 0;
            this.btn_inic_sesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_inic_sesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_inic_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inic_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inic_sesion.ForeColor = System.Drawing.Color.Transparent;
            this.btn_inic_sesion.Location = new System.Drawing.Point(33, 226);
            this.btn_inic_sesion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_inic_sesion.Name = "btn_inic_sesion";
            this.btn_inic_sesion.Size = new System.Drawing.Size(184, 32);
            this.btn_inic_sesion.TabIndex = 3;
            this.btn_inic_sesion.Text = "Iniciar Sesión";
            this.btn_inic_sesion.UseVisualStyleBackColor = false;
            this.btn_inic_sesion.Click += new System.EventHandler(this.btn_inic_sesion_Click);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_inicio.Location = new System.Drawing.Point(60, 32);
            this.lbl_inicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(154, 18);
            this.lbl_inicio.TabIndex = 0;
            this.lbl_inicio.Text = "INICIAR SESIÓN";
            // 
            // lbl_line1
            // 
            this.lbl_line1.Enabled = false;
            this.lbl_line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_line1.Location = new System.Drawing.Point(33, 98);
            this.lbl_line1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_line1.Name = "lbl_line1";
            this.lbl_line1.Size = new System.Drawing.Size(190, 25);
            this.lbl_line1.TabIndex = 0;
            this.lbl_line1.Text = "_________________________________________________\r\n";
            // 
            // lbl_line2
            // 
            this.lbl_line2.Enabled = false;
            this.lbl_line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_line2.Location = new System.Drawing.Point(30, 165);
            this.lbl_line2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_line2.Name = "lbl_line2";
            this.lbl_line2.Size = new System.Drawing.Size(190, 25);
            this.lbl_line2.TabIndex = 1;
            this.lbl_line2.Text = "_________________________________________________\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_line2);
            this.groupBox1.Controls.Add(this.lbl_Contrasena);
            this.groupBox1.Controls.Add(this.lbl_Usuario);
            this.groupBox1.Controls.Add(this.txt_contrasena);
            this.groupBox1.Controls.Add(this.cmb_roles);
            this.groupBox1.Controls.Add(this.lbl_line1);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.btn_inic_sesion);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(249, 292);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erp_Error.SetIconAlignment(this.lbl_Contrasena, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lbl_Contrasena.Location = new System.Drawing.Point(69, 118);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(95, 18);
            this.lbl_Contrasena.TabIndex = 9;
            this.lbl_Contrasena.Text = "Contraseña";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erp_Error.SetIconAlignment(this.lbl_Usuario, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lbl_Usuario.Location = new System.Drawing.Point(85, 52);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(67, 18);
            this.lbl_Usuario.TabIndex = 8;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // cmb_roles
            // 
            this.cmb_roles.DisplayMember = "Admin";
            this.cmb_roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_roles.FormattingEnabled = true;
            this.cmb_roles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_roles.Items.AddRange(new object[] {
            "Admin",
            "Inventario",
            "Recursos Humanos",
            "Servicio al Cliente",
            "Servicio Operario"});
            this.cmb_roles.Location = new System.Drawing.Point(36, 200);
            this.cmb_roles.Name = "cmb_roles";
            this.cmb_roles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_roles.Size = new System.Drawing.Size(168, 21);
            this.cmb_roles.Sorted = true;
            this.cmb_roles.TabIndex = 2;
            this.cmb_roles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_roles_KeyPress);
            // 
            // erp_Error
            // 
            this.erp_Error.ContainerControl = this;
            // 
            // frm_loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 313);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_loggin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taller Lubricentro Millas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_inic_sesion;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_line1;
        private System.Windows.Forms.Label lbl_line2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_roles;
        private System.Windows.Forms.ErrorProvider erp_Error;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contrasena;
    }
}
namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_recupera_contrase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_recupera_contrase));
            this.gbx_recupera_contrase = new System.Windows.Forms.GroupBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.lbl_nomb_Usua = new System.Windows.Forms.Label();
            this.txt_nomb_Usua = new System.Windows.Forms.TextBox();
            this.btn_guardar_contrase = new System.Windows.Forms.Button();
            this.btn_cancela_contrase = new System.Windows.Forms.Button();
            this.tTip_recupera = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_recupera_contrase.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_recupera_contrase
            // 
            this.gbx_recupera_contrase.Controls.Add(this.lbl_contrasena);
            this.gbx_recupera_contrase.Controls.Add(this.txt_contrasena);
            this.gbx_recupera_contrase.Controls.Add(this.lbl_nomb_Usua);
            this.gbx_recupera_contrase.Controls.Add(this.txt_nomb_Usua);
            this.gbx_recupera_contrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_recupera_contrase.ForeColor = System.Drawing.Color.Green;
            this.gbx_recupera_contrase.Location = new System.Drawing.Point(39, 71);
            this.gbx_recupera_contrase.Name = "gbx_recupera_contrase";
            this.gbx_recupera_contrase.Size = new System.Drawing.Size(558, 168);
            this.gbx_recupera_contrase.TabIndex = 0;
            this.gbx_recupera_contrase.TabStop = false;
            this.gbx_recupera_contrase.Text = "Recuperación de Contraseña";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_contrasena.Location = new System.Drawing.Point(98, 102);
            this.lbl_contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(91, 17);
            this.lbl_contrasena.TabIndex = 3;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(224, 97);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contrasena.MaxLength = 16;
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(307, 22);
            this.txt_contrasena.TabIndex = 4;
            // 
            // lbl_nomb_Usua
            // 
            this.lbl_nomb_Usua.AutoSize = true;
            this.lbl_nomb_Usua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomb_Usua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_nomb_Usua.Location = new System.Drawing.Point(41, 58);
            this.lbl_nomb_Usua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomb_Usua.Name = "lbl_nomb_Usua";
            this.lbl_nomb_Usua.Size = new System.Drawing.Size(148, 17);
            this.lbl_nomb_Usua.TabIndex = 1;
            this.lbl_nomb_Usua.Text = "Nombre de Usuario";
            // 
            // txt_nomb_Usua
            // 
            this.txt_nomb_Usua.Location = new System.Drawing.Point(224, 53);
            this.txt_nomb_Usua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomb_Usua.MaxLength = 30;
            this.txt_nomb_Usua.Name = "txt_nomb_Usua";
            this.txt_nomb_Usua.Size = new System.Drawing.Size(307, 22);
            this.txt_nomb_Usua.TabIndex = 2;
            // 
            // btn_guardar_contrase
            // 
            this.btn_guardar_contrase.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_contrase.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar_contrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_contrase.FlatAppearance.BorderSize = 0;
            this.btn_guardar_contrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_contrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_contrase.Location = new System.Drawing.Point(323, 256);
            this.btn_guardar_contrase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar_contrase.Name = "btn_guardar_contrase";
            this.btn_guardar_contrase.Size = new System.Drawing.Size(52, 39);
            this.btn_guardar_contrase.TabIndex = 5;
            this.tTip_recupera.SetToolTip(this.btn_guardar_contrase, "Guardar ");
            this.btn_guardar_contrase.UseVisualStyleBackColor = false;
            this.btn_guardar_contrase.Click += new System.EventHandler(this.btn_guardar_contrase_Click);
            // 
            // btn_cancela_contrase
            // 
            this.btn_cancela_contrase.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancela_contrase.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancela_contrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancela_contrase.FlatAppearance.BorderSize = 0;
            this.btn_cancela_contrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancela_contrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancela_contrase.Location = new System.Drawing.Point(248, 256);
            this.btn_cancela_contrase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancela_contrase.Name = "btn_cancela_contrase";
            this.btn_cancela_contrase.Size = new System.Drawing.Size(52, 39);
            this.btn_cancela_contrase.TabIndex = 6;
            this.tTip_recupera.SetToolTip(this.btn_cancela_contrase, "Cancelar");
            this.btn_cancela_contrase.UseVisualStyleBackColor = false;
            this.btn_cancela_contrase.Click += new System.EventHandler(this.btn_cancela_contrase_Click);
            // 
            // frm_recupera_contrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 375);
            this.Controls.Add(this.gbx_recupera_contrase);
            this.Controls.Add(this.btn_guardar_contrase);
            this.Controls.Add(this.btn_cancela_contrase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_recupera_contrase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbx_recupera_contrase.ResumeLayout(false);
            this.gbx_recupera_contrase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_recupera_contrase;
        private System.Windows.Forms.Label lbl_nomb_Usua;
        private System.Windows.Forms.TextBox txt_nomb_Usua;
        private System.Windows.Forms.Button btn_guardar_contrase;
        private System.Windows.Forms.Button btn_cancela_contrase;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.ToolTip tTip_recupera;
    }
}
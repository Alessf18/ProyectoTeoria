namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_agrega_rol
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
            this.btn_guardar_contrase = new System.Windows.Forms.Button();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.gbx_datos3 = new System.Windows.Forms.GroupBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_numParte = new System.Windows.Forms.Label();
            this.gbx_datos3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar_contrase
            // 
            this.btn_guardar_contrase.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar_contrase.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar_contrase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_contrase.FlatAppearance.BorderSize = 0;
            this.btn_guardar_contrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_contrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_contrase.Location = new System.Drawing.Point(313, 238);
            this.btn_guardar_contrase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar_contrase.Name = "btn_guardar_contrase";
            this.btn_guardar_contrase.Size = new System.Drawing.Size(52, 39);
            this.btn_guardar_contrase.TabIndex = 7;
            this.btn_guardar_contrase.UseVisualStyleBackColor = false;
            // 
            // btn_cancela
            // 
            this.btn_cancela.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancela.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancela.FlatAppearance.BorderSize = 0;
            this.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancela.Location = new System.Drawing.Point(238, 238);
            this.btn_cancela.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(52, 39);
            this.btn_cancela.TabIndex = 8;
            this.btn_cancela.UseVisualStyleBackColor = false;
            this.btn_cancela.Click += new System.EventHandler(this.btn_cancela_Click);
            // 
            // gbx_datos3
            // 
            this.gbx_datos3.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos3.Controls.Add(this.txt_descrip);
            this.gbx_datos3.Controls.Add(this.txt_nombre);
            this.gbx_datos3.Controls.Add(this.txt_Id);
            this.gbx_datos3.Controls.Add(this.lbl_cant);
            this.gbx_datos3.Controls.Add(this.lbl_descripcion);
            this.gbx_datos3.Controls.Add(this.lbl_numParte);
            this.gbx_datos3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos3.ForeColor = System.Drawing.Color.Green;
            this.gbx_datos3.Location = new System.Drawing.Point(55, 27);
            this.gbx_datos3.Name = "gbx_datos3";
            this.gbx_datos3.Size = new System.Drawing.Size(492, 187);
            this.gbx_datos3.TabIndex = 0;
            this.gbx_datos3.TabStop = false;
            this.gbx_datos3.Text = "Agregar Rol";
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.White;
            this.txt_descrip.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip.Location = new System.Drawing.Point(183, 125);
            this.txt_descrip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descrip.MaxLength = 9;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(232, 23);
            this.txt_descrip.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(183, 94);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(232, 23);
            this.txt_nombre.TabIndex = 4;
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.White;
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.ForeColor = System.Drawing.Color.Black;
            this.txt_Id.Location = new System.Drawing.Point(183, 63);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id.MaxLength = 25;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(232, 23);
            this.txt_Id.TabIndex = 2;
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cant.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_cant.Location = new System.Drawing.Point(54, 128);
            this.lbl_cant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(97, 17);
            this.lbl_cant.TabIndex = 5;
            this.lbl_cant.Text = "Descripción";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(82, 97);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(69, 17);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Nombre";
            // 
            // lbl_numParte
            // 
            this.lbl_numParte.AutoSize = true;
            this.lbl_numParte.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numParte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numParte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_numParte.Location = new System.Drawing.Point(124, 66);
            this.lbl_numParte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numParte.Name = "lbl_numParte";
            this.lbl_numParte.Size = new System.Drawing.Size(27, 17);
            this.lbl_numParte.TabIndex = 1;
            this.lbl_numParte.Text = "ID";
            // 
            // frm_agrega_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 299);
            this.Controls.Add(this.btn_guardar_contrase);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.gbx_datos3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_agrega_rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_agrega_rol";
            this.gbx_datos3.ResumeLayout(false);
            this.gbx_datos3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar_contrase;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.GroupBox gbx_datos3;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_numParte;
    }
}
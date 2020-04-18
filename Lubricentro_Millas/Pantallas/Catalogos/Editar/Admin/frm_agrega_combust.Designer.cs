namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_agrega_combust
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
            this.btn_guardar_contrase = new System.Windows.Forms.Button();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.gbx_datos3 = new System.Windows.Forms.GroupBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_numParte = new System.Windows.Forms.Label();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbx_datos3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
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
            this.btn_guardar_contrase.Location = new System.Drawing.Point(250, 236);
            this.btn_guardar_contrase.Name = "btn_guardar_contrase";
            this.btn_guardar_contrase.Size = new System.Drawing.Size(39, 32);
            this.btn_guardar_contrase.TabIndex = 9;
            this.btn_guardar_contrase.UseVisualStyleBackColor = false;
            this.btn_guardar_contrase.Click += new System.EventHandler(this.btn_guardar_contrase_Click);
            // 
            // btn_cancela
            // 
            this.btn_cancela.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancela.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancela.FlatAppearance.BorderSize = 0;
            this.btn_cancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancela.Location = new System.Drawing.Point(194, 236);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(39, 32);
            this.btn_cancela.TabIndex = 10;
            this.btn_cancela.UseVisualStyleBackColor = false;
            this.btn_cancela.Click += new System.EventHandler(this.btn_cancela_Click);
            // 
            // gbx_datos3
            // 
            this.gbx_datos3.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos3.Controls.Add(this.cbx_estado);
            this.gbx_datos3.Controls.Add(this.txt_descrip);
            this.gbx_datos3.Controls.Add(this.txt_id);
            this.gbx_datos3.Controls.Add(this.lbl_unidad);
            this.gbx_datos3.Controls.Add(this.lbl_descripcion);
            this.gbx_datos3.Controls.Add(this.lbl_numParte);
            this.gbx_datos3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos3.ForeColor = System.Drawing.Color.Green;
            this.gbx_datos3.Location = new System.Drawing.Point(28, 27);
            this.gbx_datos3.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_datos3.Name = "gbx_datos3";
            this.gbx_datos3.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_datos3.Size = new System.Drawing.Size(380, 185);
            this.gbx_datos3.TabIndex = 11;
            this.gbx_datos3.TabStop = false;
            this.gbx_datos3.Text = "Agregr Combustible";
            // 
            // cbx_estado
            // 
            this.cbx_estado.BackColor = System.Drawing.Color.White;
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.ForeColor = System.Drawing.Color.Black;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(166, 126);
            this.cbx_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(114, 20);
            this.cbx_estado.TabIndex = 8;
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.White;
            this.txt_descrip.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip.Location = new System.Drawing.Point(166, 91);
            this.txt_descrip.MaxLength = 50;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(175, 20);
            this.txt_descrip.TabIndex = 31;
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descrip_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(166, 51);
            this.txt_id.MaxLength = 1;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(175, 20);
            this.txt_id.TabIndex = 23;
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unidad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_unidad.Location = new System.Drawing.Point(96, 128);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(51, 13);
            this.lbl_unidad.TabIndex = 26;
            this.lbl_unidad.Text = "Estado";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(69, 94);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(83, 13);
            this.lbl_descripcion.TabIndex = 22;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_numParte
            // 
            this.lbl_numParte.AutoSize = true;
            this.lbl_numParte.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numParte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numParte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_numParte.Location = new System.Drawing.Point(122, 53);
            this.lbl_numParte.Name = "lbl_numParte";
            this.lbl_numParte.Size = new System.Drawing.Size(22, 13);
            this.lbl_numParte.TabIndex = 20;
            this.lbl_numParte.Text = "ID";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // frm_agrega_combust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.btn_guardar_contrase);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.gbx_datos3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_agrega_combust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_agrega_combust";
            this.Load += new System.EventHandler(this.frm_agrega_combust_Load);
            this.gbx_datos3.ResumeLayout(false);
            this.gbx_datos3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar_contrase;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.GroupBox gbx_datos3;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_numParte;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}
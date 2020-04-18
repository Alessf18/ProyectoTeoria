namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_cant_aceite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cant_aceite));
            this.gbx_cant = new System.Windows.Forms.GroupBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_esatdo = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_idMotor = new System.Windows.Forms.Label();
            this.txt_IdMotor = new System.Windows.Forms.TextBox();
            this.lbl_idUnidad = new System.Windows.Forms.Label();
            this.txt_id_unidad = new System.Windows.Forms.TextBox();
            this.gbx_cant.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_cant
            // 
            this.gbx_cant.Controls.Add(this.lbl_idUnidad);
            this.gbx_cant.Controls.Add(this.txt_id_unidad);
            this.gbx_cant.Controls.Add(this.lbl_idMotor);
            this.gbx_cant.Controls.Add(this.txt_IdMotor);
            this.gbx_cant.Controls.Add(this.cbx_estado);
            this.gbx_cant.Controls.Add(this.lbl_esatdo);
            this.gbx_cant.Controls.Add(this.lbl_cant);
            this.gbx_cant.Controls.Add(this.txt_cantidad);
            this.gbx_cant.Controls.Add(this.lbl_id);
            this.gbx_cant.Controls.Add(this.txt_id);
            this.gbx_cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_cant.ForeColor = System.Drawing.Color.Green;
            this.gbx_cant.Location = new System.Drawing.Point(51, 45);
            this.gbx_cant.Name = "gbx_cant";
            this.gbx_cant.Size = new System.Drawing.Size(558, 279);
            this.gbx_cant.TabIndex = 9;
            this.gbx_cant.TabStop = false;
            this.gbx_cant.Text = "Cantidad de Aceite Por Motor";
            // 
            // cbx_estado
            // 
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(224, 221);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(307, 24);
            this.cbx_estado.TabIndex = 6;
            // 
            // lbl_esatdo
            // 
            this.lbl_esatdo.AutoSize = true;
            this.lbl_esatdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_esatdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_esatdo.Location = new System.Drawing.Point(108, 224);
            this.lbl_esatdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_esatdo.Name = "lbl_esatdo";
            this.lbl_esatdo.Size = new System.Drawing.Size(58, 17);
            this.lbl_esatdo.TabIndex = 5;
            this.lbl_esatdo.Text = "Estado";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_cant.Location = new System.Drawing.Point(94, 182);
            this.lbl_cant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(72, 17);
            this.lbl_cant.TabIndex = 3;
            this.lbl_cant.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(224, 179);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.MaxLength = 25;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(307, 22);
            this.txt_cantidad.TabIndex = 4;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_id.Location = new System.Drawing.Point(143, 56);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(23, 17);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(224, 53);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.MaxLength = 30;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(307, 22);
            this.txt_id.TabIndex = 2;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(330, 354);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(52, 39);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(255, 354);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(52, 39);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_idMotor
            // 
            this.lbl_idMotor.AutoSize = true;
            this.lbl_idMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idMotor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_idMotor.Location = new System.Drawing.Point(97, 99);
            this.lbl_idMotor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idMotor.Name = "lbl_idMotor";
            this.lbl_idMotor.Size = new System.Drawing.Size(69, 17);
            this.lbl_idMotor.TabIndex = 7;
            this.lbl_idMotor.Text = "ID Motor";
            // 
            // txt_IdMotor
            // 
            this.txt_IdMotor.Enabled = false;
            this.txt_IdMotor.Location = new System.Drawing.Point(224, 94);
            this.txt_IdMotor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdMotor.MaxLength = 30;
            this.txt_IdMotor.Name = "txt_IdMotor";
            this.txt_IdMotor.Size = new System.Drawing.Size(307, 22);
            this.txt_IdMotor.TabIndex = 8;
            // 
            // lbl_idUnidad
            // 
            this.lbl_idUnidad.AutoSize = true;
            this.lbl_idUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_idUnidad.Location = new System.Drawing.Point(30, 138);
            this.lbl_idUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idUnidad.Name = "lbl_idUnidad";
            this.lbl_idUnidad.Size = new System.Drawing.Size(136, 17);
            this.lbl_idUnidad.TabIndex = 9;
            this.lbl_idUnidad.Text = "ID Unidad Medida";
            // 
            // txt_id_unidad
            // 
            this.txt_id_unidad.Enabled = false;
            this.txt_id_unidad.Location = new System.Drawing.Point(224, 133);
            this.txt_id_unidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_unidad.MaxLength = 30;
            this.txt_id_unidad.Name = "txt_id_unidad";
            this.txt_id_unidad.Size = new System.Drawing.Size(307, 22);
            this.txt_id_unidad.TabIndex = 10;
            // 
            // frm_cant_aceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 427);
            this.Controls.Add(this.gbx_cant);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cant_aceite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbx_cant.ResumeLayout(false);
            this.gbx_cant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_cant;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_esatdo;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_idUnidad;
        private System.Windows.Forms.TextBox txt_id_unidad;
        private System.Windows.Forms.Label lbl_idMotor;
        private System.Windows.Forms.TextBox txt_IdMotor;
    }
}
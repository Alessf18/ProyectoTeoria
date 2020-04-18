namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_hist_emplea
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.gbx_datos3 = new System.Windows.Forms.GroupBox();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_numParte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbx_datos3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(276, 265);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(52, 39);
            this.btn_volver.TabIndex = 28;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // gbx_datos3
            // 
            this.gbx_datos3.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos3.Controls.Add(this.textBox1);
            this.gbx_datos3.Controls.Add(this.txt_cant);
            this.gbx_datos3.Controls.Add(this.txt_descrip);
            this.gbx_datos3.Controls.Add(this.txt_id_empleado);
            this.gbx_datos3.Controls.Add(this.lbl_unidad);
            this.gbx_datos3.Controls.Add(this.lbl_cant);
            this.gbx_datos3.Controls.Add(this.lbl_descripcion);
            this.gbx_datos3.Controls.Add(this.lbl_numParte);
            this.gbx_datos3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos3.ForeColor = System.Drawing.Color.Green;
            this.gbx_datos3.Location = new System.Drawing.Point(58, 31);
            this.gbx_datos3.Name = "gbx_datos3";
            this.gbx_datos3.Size = new System.Drawing.Size(492, 218);
            this.gbx_datos3.TabIndex = 27;
            this.gbx_datos3.TabStop = false;
            this.gbx_datos3.Text = "Historial de Empleado";
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.Color.White;
            this.txt_cant.Enabled = false;
            this.txt_cant.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant.ForeColor = System.Drawing.Color.Black;
            this.txt_cant.Location = new System.Drawing.Point(183, 125);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant.MaxLength = 9;
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(232, 23);
            this.txt_cant.TabIndex = 25;
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.White;
            this.txt_descrip.Enabled = false;
            this.txt_descrip.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip.Location = new System.Drawing.Point(183, 94);
            this.txt_descrip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descrip.MaxLength = 25;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(232, 23);
            this.txt_descrip.TabIndex = 31;
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.BackColor = System.Drawing.Color.White;
            this.txt_id_empleado.Enabled = false;
            this.txt_id_empleado.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empleado.ForeColor = System.Drawing.Color.Black;
            this.txt_id_empleado.Location = new System.Drawing.Point(183, 63);
            this.txt_id_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_empleado.MaxLength = 25;
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(232, 23);
            this.txt_id_empleado.TabIndex = 23;
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unidad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_unidad.Location = new System.Drawing.Point(91, 162);
            this.lbl_unidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(60, 17);
            this.lbl_unidad.TabIndex = 26;
            this.lbl_unidad.Text = "Motivo";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cant.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_cant.Location = new System.Drawing.Point(47, 128);
            this.lbl_cant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(104, 17);
            this.lbl_cant.TabIndex = 24;
            this.lbl_cant.Text = "Fecha Salida";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(31, 97);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(120, 17);
            this.lbl_descripcion.TabIndex = 22;
            this.lbl_descripcion.Text = "Fecha Ingreso";
            // 
            // lbl_numParte
            // 
            this.lbl_numParte.AutoSize = true;
            this.lbl_numParte.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numParte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numParte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_numParte.Location = new System.Drawing.Point(43, 66);
            this.lbl_numParte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numParte.Name = "lbl_numParte";
            this.lbl_numParte.Size = new System.Drawing.Size(108, 17);
            this.lbl_numParte.TabIndex = 20;
            this.lbl_numParte.Text = "ID Empleado";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(183, 159);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 32;
            // 
            // frm_hist_emplea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 335);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.gbx_datos3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_hist_emplea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_hist_emplea";
            this.gbx_datos3.ResumeLayout(false);
            this.gbx_datos3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.GroupBox gbx_datos3;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_numParte;
        private System.Windows.Forms.TextBox textBox1;
    }
}
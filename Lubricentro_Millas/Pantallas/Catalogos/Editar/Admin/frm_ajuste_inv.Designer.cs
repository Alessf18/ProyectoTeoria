namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_ajuste_inv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ajuste_inv));
            this.lbl_title = new System.Windows.Forms.Label();
            this.gbx_datos3 = new System.Windows.Forms.GroupBox();
            this.cbx_ubica3 = new System.Windows.Forms.ComboBox();
            this.cbx_ubica2 = new System.Windows.Forms.ComboBox();
            this.cbx_ubica1 = new System.Windows.Forms.ComboBox();
            this.txt_unidad3 = new System.Windows.Forms.TextBox();
            this.txt_unidad2 = new System.Windows.Forms.TextBox();
            this.txt_unidad1 = new System.Windows.Forms.TextBox();
            this.txt_cant3 = new System.Windows.Forms.TextBox();
            this.txt_cant2 = new System.Windows.Forms.TextBox();
            this.txt_cant1 = new System.Windows.Forms.TextBox();
            this.txt_descrip3 = new System.Windows.Forms.TextBox();
            this.txt_descrip2 = new System.Windows.Forms.TextBox();
            this.txt_descrip1 = new System.Windows.Forms.TextBox();
            this.cbx_numParte3 = new System.Windows.Forms.ComboBox();
            this.cbx_numParte2 = new System.Windows.Forms.ComboBox();
            this.cbx_numParte1 = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_numParte = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_datos3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(13, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(862, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "AJUSTE DE INVENTARIO";
            // 
            // gbx_datos3
            // 
            this.gbx_datos3.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos3.Controls.Add(this.cbx_ubica3);
            this.gbx_datos3.Controls.Add(this.cbx_ubica2);
            this.gbx_datos3.Controls.Add(this.cbx_ubica1);
            this.gbx_datos3.Controls.Add(this.txt_unidad3);
            this.gbx_datos3.Controls.Add(this.txt_unidad2);
            this.gbx_datos3.Controls.Add(this.txt_unidad1);
            this.gbx_datos3.Controls.Add(this.txt_cant3);
            this.gbx_datos3.Controls.Add(this.txt_cant2);
            this.gbx_datos3.Controls.Add(this.txt_cant1);
            this.gbx_datos3.Controls.Add(this.txt_descrip3);
            this.gbx_datos3.Controls.Add(this.txt_descrip2);
            this.gbx_datos3.Controls.Add(this.txt_descrip1);
            this.gbx_datos3.Controls.Add(this.cbx_numParte3);
            this.gbx_datos3.Controls.Add(this.cbx_numParte2);
            this.gbx_datos3.Controls.Add(this.cbx_numParte1);
            this.gbx_datos3.Controls.Add(this.lbl_tipo);
            this.gbx_datos3.Controls.Add(this.lbl_unidad);
            this.gbx_datos3.Controls.Add(this.lbl_cant);
            this.gbx_datos3.Controls.Add(this.lbl_descripcion);
            this.gbx_datos3.Controls.Add(this.lbl_numParte);
            this.gbx_datos3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbx_datos3.Location = new System.Drawing.Point(62, 90);
            this.gbx_datos3.Name = "gbx_datos3";
            this.gbx_datos3.Size = new System.Drawing.Size(761, 193);
            this.gbx_datos3.TabIndex = 1;
            this.gbx_datos3.TabStop = false;
            // 
            // cbx_ubica3
            // 
            this.cbx_ubica3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_ubica3.ForeColor = System.Drawing.Color.White;
            this.cbx_ubica3.FormattingEnabled = true;
            this.cbx_ubica3.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.cbx_ubica3.Location = new System.Drawing.Point(599, 138);
            this.cbx_ubica3.Name = "cbx_ubica3";
            this.cbx_ubica3.Size = new System.Drawing.Size(121, 24);
            this.cbx_ubica3.TabIndex = 39;
            // 
            // cbx_ubica2
            // 
            this.cbx_ubica2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_ubica2.ForeColor = System.Drawing.Color.White;
            this.cbx_ubica2.FormattingEnabled = true;
            this.cbx_ubica2.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.cbx_ubica2.Location = new System.Drawing.Point(600, 100);
            this.cbx_ubica2.Name = "cbx_ubica2";
            this.cbx_ubica2.Size = new System.Drawing.Size(121, 24);
            this.cbx_ubica2.TabIndex = 34;
            // 
            // cbx_ubica1
            // 
            this.cbx_ubica1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_ubica1.ForeColor = System.Drawing.Color.White;
            this.cbx_ubica1.FormattingEnabled = true;
            this.cbx_ubica1.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.cbx_ubica1.Location = new System.Drawing.Point(599, 62);
            this.cbx_ubica1.Name = "cbx_ubica1";
            this.cbx_ubica1.Size = new System.Drawing.Size(121, 24);
            this.cbx_ubica1.TabIndex = 29;
            // 
            // txt_unidad3
            // 
            this.txt_unidad3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_unidad3.Enabled = false;
            this.txt_unidad3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidad3.ForeColor = System.Drawing.Color.Black;
            this.txt_unidad3.Location = new System.Drawing.Point(495, 138);
            this.txt_unidad3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_unidad3.MaxLength = 3;
            this.txt_unidad3.Multiline = true;
            this.txt_unidad3.Name = "txt_unidad3";
            this.txt_unidad3.Size = new System.Drawing.Size(63, 30);
            this.txt_unidad3.TabIndex = 38;
            // 
            // txt_unidad2
            // 
            this.txt_unidad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_unidad2.Enabled = false;
            this.txt_unidad2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidad2.ForeColor = System.Drawing.Color.Black;
            this.txt_unidad2.Location = new System.Drawing.Point(495, 100);
            this.txt_unidad2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_unidad2.MaxLength = 3;
            this.txt_unidad2.Multiline = true;
            this.txt_unidad2.Name = "txt_unidad2";
            this.txt_unidad2.Size = new System.Drawing.Size(63, 30);
            this.txt_unidad2.TabIndex = 33;
            // 
            // txt_unidad1
            // 
            this.txt_unidad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_unidad1.Enabled = false;
            this.txt_unidad1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidad1.ForeColor = System.Drawing.Color.Black;
            this.txt_unidad1.Location = new System.Drawing.Point(495, 62);
            this.txt_unidad1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_unidad1.MaxLength = 3;
            this.txt_unidad1.Multiline = true;
            this.txt_unidad1.Name = "txt_unidad1";
            this.txt_unidad1.Size = new System.Drawing.Size(63, 30);
            this.txt_unidad1.TabIndex = 27;
            // 
            // txt_cant3
            // 
            this.txt_cant3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_cant3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant3.ForeColor = System.Drawing.Color.Black;
            this.txt_cant3.Location = new System.Drawing.Point(386, 138);
            this.txt_cant3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant3.MaxLength = 9;
            this.txt_cant3.Multiline = true;
            this.txt_cant3.Name = "txt_cant3";
            this.txt_cant3.Size = new System.Drawing.Size(63, 30);
            this.txt_cant3.TabIndex = 37;
            // 
            // txt_cant2
            // 
            this.txt_cant2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_cant2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant2.ForeColor = System.Drawing.Color.Black;
            this.txt_cant2.Location = new System.Drawing.Point(386, 100);
            this.txt_cant2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant2.MaxLength = 9;
            this.txt_cant2.Multiline = true;
            this.txt_cant2.Name = "txt_cant2";
            this.txt_cant2.Size = new System.Drawing.Size(63, 30);
            this.txt_cant2.TabIndex = 32;
            // 
            // txt_cant1
            // 
            this.txt_cant1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_cant1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cant1.ForeColor = System.Drawing.Color.Black;
            this.txt_cant1.Location = new System.Drawing.Point(386, 62);
            this.txt_cant1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant1.MaxLength = 9;
            this.txt_cant1.Multiline = true;
            this.txt_cant1.Name = "txt_cant1";
            this.txt_cant1.Size = new System.Drawing.Size(63, 30);
            this.txt_cant1.TabIndex = 25;
            // 
            // txt_descrip3
            // 
            this.txt_descrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_descrip3.Enabled = false;
            this.txt_descrip3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip3.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip3.Location = new System.Drawing.Point(175, 138);
            this.txt_descrip3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descrip3.MaxLength = 25;
            this.txt_descrip3.Multiline = true;
            this.txt_descrip3.Name = "txt_descrip3";
            this.txt_descrip3.Size = new System.Drawing.Size(156, 30);
            this.txt_descrip3.TabIndex = 36;
            // 
            // txt_descrip2
            // 
            this.txt_descrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_descrip2.Enabled = false;
            this.txt_descrip2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip2.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip2.Location = new System.Drawing.Point(175, 100);
            this.txt_descrip2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descrip2.MaxLength = 25;
            this.txt_descrip2.Multiline = true;
            this.txt_descrip2.Name = "txt_descrip2";
            this.txt_descrip2.Size = new System.Drawing.Size(156, 30);
            this.txt_descrip2.TabIndex = 31;
            // 
            // txt_descrip1
            // 
            this.txt_descrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_descrip1.Enabled = false;
            this.txt_descrip1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip1.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip1.Location = new System.Drawing.Point(175, 62);
            this.txt_descrip1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descrip1.MaxLength = 25;
            this.txt_descrip1.Multiline = true;
            this.txt_descrip1.Name = "txt_descrip1";
            this.txt_descrip1.Size = new System.Drawing.Size(156, 30);
            this.txt_descrip1.TabIndex = 23;
            // 
            // cbx_numParte3
            // 
            this.cbx_numParte3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_numParte3.ForeColor = System.Drawing.Color.White;
            this.cbx_numParte3.FormattingEnabled = true;
            this.cbx_numParte3.Items.AddRange(new object[] {
            "C000001",
            "C000002"});
            this.cbx_numParte3.Location = new System.Drawing.Point(14, 138);
            this.cbx_numParte3.Name = "cbx_numParte3";
            this.cbx_numParte3.Size = new System.Drawing.Size(121, 24);
            this.cbx_numParte3.TabIndex = 35;
            // 
            // cbx_numParte2
            // 
            this.cbx_numParte2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_numParte2.ForeColor = System.Drawing.Color.White;
            this.cbx_numParte2.FormattingEnabled = true;
            this.cbx_numParte2.Items.AddRange(new object[] {
            "F000001",
            "F000002"});
            this.cbx_numParte2.Location = new System.Drawing.Point(15, 100);
            this.cbx_numParte2.Name = "cbx_numParte2";
            this.cbx_numParte2.Size = new System.Drawing.Size(121, 24);
            this.cbx_numParte2.TabIndex = 30;
            // 
            // cbx_numParte1
            // 
            this.cbx_numParte1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_numParte1.ForeColor = System.Drawing.Color.White;
            this.cbx_numParte1.FormattingEnabled = true;
            this.cbx_numParte1.Items.AddRange(new object[] {
            "A000001",
            "A000002"});
            this.cbx_numParte1.Location = new System.Drawing.Point(14, 62);
            this.cbx_numParte1.Name = "cbx_numParte1";
            this.cbx_numParte1.Size = new System.Drawing.Size(121, 24);
            this.cbx_numParte1.TabIndex = 21;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_tipo.Location = new System.Drawing.Point(599, 23);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(121, 17);
            this.lbl_tipo.TabIndex = 28;
            this.lbl_tipo.Text = "Tipo de Ajuste";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unidad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_unidad.Location = new System.Drawing.Point(502, 23);
            this.lbl_unidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(42, 17);
            this.lbl_unidad.TabIndex = 26;
            this.lbl_unidad.Text = "U/M";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cant.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_cant.Location = new System.Drawing.Point(383, 23);
            this.lbl_cant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(77, 17);
            this.lbl_cant.TabIndex = 24;
            this.lbl_cant.Text = "Cantidad";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(199, 23);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(97, 17);
            this.lbl_descripcion.TabIndex = 22;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_numParte
            // 
            this.lbl_numParte.AutoSize = true;
            this.lbl_numParte.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numParte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numParte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_numParte.Location = new System.Drawing.Point(12, 23);
            this.lbl_numParte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numParte.Name = "lbl_numParte";
            this.lbl_numParte.Size = new System.Drawing.Size(139, 17);
            this.lbl_numParte.TabIndex = 20;
            this.lbl_numParte.Text = "Número de Parte";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(450, 307);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 45);
            this.btn_guardar.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btn_guardar, "Realizar Ajuste");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(357, 307);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 45);
            this.btn_cancelar.TabIndex = 46;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_ajuste_inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gbx_datos3);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ajuste_inv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbx_datos3.ResumeLayout(false);
            this.gbx_datos3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gbx_datos3;
        private System.Windows.Forms.ComboBox cbx_ubica3;
        private System.Windows.Forms.ComboBox cbx_ubica2;
        private System.Windows.Forms.ComboBox cbx_ubica1;
        private System.Windows.Forms.TextBox txt_unidad3;
        private System.Windows.Forms.TextBox txt_unidad2;
        private System.Windows.Forms.TextBox txt_unidad1;
        private System.Windows.Forms.TextBox txt_cant3;
        private System.Windows.Forms.TextBox txt_cant2;
        private System.Windows.Forms.TextBox txt_cant1;
        private System.Windows.Forms.TextBox txt_descrip3;
        private System.Windows.Forms.TextBox txt_descrip2;
        private System.Windows.Forms.TextBox txt_descrip1;
        private System.Windows.Forms.ComboBox cbx_numParte3;
        private System.Windows.Forms.ComboBox cbx_numParte2;
        private System.Windows.Forms.ComboBox cbx_numParte1;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_numParte;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
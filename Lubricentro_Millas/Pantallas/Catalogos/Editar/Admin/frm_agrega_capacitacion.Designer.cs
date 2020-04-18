namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_agrega_capacitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_agrega_capacitacion));
            this.gbx_capac = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.cbx_puesto = new System.Windows.Forms.ComboBox();
            this.lbl_puesto = new System.Windows.Forms.Label();
            this.lbl_descrip = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_direcc = new System.Windows.Forms.Label();
            this.txt_direcc = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dtp_hora_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_hora_fin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_cant_parti = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbx_capac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_parti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_capac
            // 
            this.gbx_capac.Controls.Add(this.label5);
            this.gbx_capac.Controls.Add(this.cbx_estado);
            this.gbx_capac.Controls.Add(this.cbx_puesto);
            this.gbx_capac.Controls.Add(this.lbl_puesto);
            this.gbx_capac.Controls.Add(this.lbl_descrip);
            this.gbx_capac.Controls.Add(this.txt_descripcion);
            this.gbx_capac.Controls.Add(this.lbl_direcc);
            this.gbx_capac.Controls.Add(this.txt_direcc);
            this.gbx_capac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_capac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_capac.Location = new System.Drawing.Point(16, 32);
            this.gbx_capac.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_capac.Name = "gbx_capac";
            this.gbx_capac.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_capac.Size = new System.Drawing.Size(372, 194);
            this.gbx_capac.TabIndex = 0;
            this.gbx_capac.TabStop = false;
            this.gbx_capac.Text = "Crear Nueva Capacitación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(41, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // cbx_estado
            // 
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(121, 166);
            this.cbx_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(231, 21);
            this.cbx_estado.TabIndex = 7;
            // 
            // cbx_puesto
            // 
            this.cbx_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_puesto.FormattingEnabled = true;
            this.cbx_puesto.Items.AddRange(new object[] {
            "Representante de servicio al Cliente.",
            "Personal de Servicios operativos.",
            "Encargado del Inventario.",
            "Cajero.",
            "Personal de Recursos Humanos.",
            "Administrador del sistema."});
            this.cbx_puesto.Location = new System.Drawing.Point(121, 132);
            this.cbx_puesto.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_puesto.Name = "cbx_puesto";
            this.cbx_puesto.Size = new System.Drawing.Size(231, 21);
            this.cbx_puesto.TabIndex = 6;
            // 
            // lbl_puesto
            // 
            this.lbl_puesto.AutoSize = true;
            this.lbl_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_puesto.Location = new System.Drawing.Point(35, 135);
            this.lbl_puesto.Name = "lbl_puesto";
            this.lbl_puesto.Size = new System.Drawing.Size(52, 13);
            this.lbl_puesto.TabIndex = 5;
            this.lbl_puesto.Text = "Puestos";
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_descrip.Location = new System.Drawing.Point(15, 67);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(74, 13);
            this.lbl_descrip.TabIndex = 1;
            this.lbl_descrip.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(121, 64);
            this.txt_descripcion.MaxLength = 25;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(231, 19);
            this.txt_descripcion.TabIndex = 2;
            // 
            // lbl_direcc
            // 
            this.lbl_direcc.AutoSize = true;
            this.lbl_direcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_direcc.Location = new System.Drawing.Point(34, 98);
            this.lbl_direcc.Name = "lbl_direcc";
            this.lbl_direcc.Size = new System.Drawing.Size(54, 13);
            this.lbl_direcc.TabIndex = 3;
            this.lbl_direcc.Text = "Direción";
            // 
            // txt_direcc
            // 
            this.txt_direcc.Location = new System.Drawing.Point(121, 89);
            this.txt_direcc.MaxLength = 50;
            this.txt_direcc.Multiline = true;
            this.txt_direcc.Name = "txt_direcc";
            this.txt_direcc.Size = new System.Drawing.Size(231, 39);
            this.txt_direcc.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(349, 249);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(39, 32);
            this.btn_guardar.TabIndex = 16;
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
            this.btn_cancelar.Location = new System.Drawing.Point(292, 249);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(39, 32);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dtp_hora_inicio
            // 
            this.dtp_hora_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora_inicio.Location = new System.Drawing.Point(26, 109);
            this.dtp_hora_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_hora_inicio.Name = "dtp_hora_inicio";
            this.dtp_hora_inicio.Size = new System.Drawing.Size(76, 20);
            this.dtp_hora_inicio.TabIndex = 11;
            // 
            // dtp_hora_fin
            // 
            this.dtp_hora_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora_fin.Location = new System.Drawing.Point(148, 109);
            this.dtp_hora_fin.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_hora_fin.Name = "dtp_hora_fin";
            this.dtp_hora_fin.Size = new System.Drawing.Size(76, 20);
            this.dtp_hora_fin.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hora Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(70, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cant. Participantes";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(58, 41);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(133, 20);
            this.dtp_fecha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(154, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hora Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(98, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha";
            // 
            // nud_cant_parti
            // 
            this.nud_cant_parti.Location = new System.Drawing.Point(100, 167);
            this.nud_cant_parti.Margin = new System.Windows.Forms.Padding(2);
            this.nud_cant_parti.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_cant_parti.Name = "nud_cant_parti";
            this.nud_cant_parti.Size = new System.Drawing.Size(52, 20);
            this.nud_cant_parti.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_cant_parti);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_hora_fin);
            this.groupBox1.Controls.Add(this.dtp_hora_inicio);
            this.groupBox1.Location = new System.Drawing.Point(429, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(270, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // frm_agrega_capacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 305);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_capac);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_agrega_capacitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_agrega_capacitacion_Load);
            this.gbx_capac.ResumeLayout(false);
            this.gbx_capac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant_parti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_capac;
        private System.Windows.Forms.ComboBox cbx_puesto;
        private System.Windows.Forms.Label lbl_puesto;
        private System.Windows.Forms.Label lbl_descrip;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_direcc;
        private System.Windows.Forms.TextBox txt_direcc;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.DateTimePicker dtp_hora_inicio;
        private System.Windows.Forms.DateTimePicker dtp_hora_fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_cant_parti;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
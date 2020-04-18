namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    partial class frm_factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_factura));
            this.lbl_factura = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_nomb_taller = new System.Windows.Forms.Label();
            this.lbl_ced_tall = new System.Windows.Forms.Label();
            this.lbl_direc = new System.Windows.Forms.Label();
            this.txt_tot_pagar = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.txt_impuesto = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_orden = new System.Windows.Forms.Label();
            this.lbl_telefs = new System.Windows.Forms.Label();
            this.lbl_ced_taller = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefonos = new System.Windows.Forms.Label();
            this.lbl_numfact = new System.Windows.Forms.Label();
            this.lbl_fact = new System.Windows.Forms.Label();
            this.lbl_nuord = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_dat = new System.Windows.Forms.Label();
            this.dgv_factura = new System.Windows.Forms.DataGridView();
            this.col_descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_preci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_factura
            // 
            this.lbl_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_factura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_factura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_factura.Location = new System.Drawing.Point(436, 24);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_factura.Size = new System.Drawing.Size(308, 27);
            this.lbl_factura.TabIndex = 8;
            this.lbl_factura.Text = "Factura";
            this.lbl_factura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(379, 486);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(45, 37);
            this.btn_guardar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(321, 486);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(45, 37);
            this.btn_cancelar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.Logo_Taller_Autom;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 104);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_nomb_taller
            // 
            this.lbl_nomb_taller.AutoSize = true;
            this.lbl_nomb_taller.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomb_taller.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomb_taller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_nomb_taller.Location = new System.Drawing.Point(197, 18);
            this.lbl_nomb_taller.Name = "lbl_nomb_taller";
            this.lbl_nomb_taller.Size = new System.Drawing.Size(193, 17);
            this.lbl_nomb_taller.TabIndex = 1;
            this.lbl_nomb_taller.Text = "Taller Lubricentro Millas\r\n";
            // 
            // lbl_ced_tall
            // 
            this.lbl_ced_tall.AutoSize = true;
            this.lbl_ced_tall.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ced_tall.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ced_tall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ced_tall.Location = new System.Drawing.Point(142, 58);
            this.lbl_ced_tall.Name = "lbl_ced_tall";
            this.lbl_ced_tall.Size = new System.Drawing.Size(106, 13);
            this.lbl_ced_tall.TabIndex = 2;
            this.lbl_ced_tall.Text = "Cédula Jurídica\r\n";
            // 
            // lbl_direc
            // 
            this.lbl_direc.AutoSize = true;
            this.lbl_direc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direc.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_direc.Location = new System.Drawing.Point(178, 85);
            this.lbl_direc.Name = "lbl_direc";
            this.lbl_direc.Size = new System.Drawing.Size(68, 13);
            this.lbl_direc.TabIndex = 6;
            this.lbl_direc.Text = "Dirección";
            // 
            // txt_tot_pagar
            // 
            this.txt_tot_pagar.Location = new System.Drawing.Point(460, 218);
            this.txt_tot_pagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tot_pagar.Name = "txt_tot_pagar";
            this.txt_tot_pagar.Size = new System.Drawing.Size(105, 20);
            this.txt_tot_pagar.TabIndex = 26;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(460, 197);
            this.txt_descuento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(105, 20);
            this.txt_descuento.TabIndex = 24;
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.Location = new System.Drawing.Point(460, 176);
            this.txt_impuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.Size = new System.Drawing.Size(105, 20);
            this.txt_impuesto.TabIndex = 22;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(460, 153);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(105, 20);
            this.txt_total.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(356, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Total a Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(371, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Impuestos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(373, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(404, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total";
            // 
            // lbl_orden
            // 
            this.lbl_orden.BackColor = System.Drawing.Color.Transparent;
            this.lbl_orden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_orden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_orden.Location = new System.Drawing.Point(572, 89);
            this.lbl_orden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(172, 18);
            this.lbl_orden.TabIndex = 12;
            // 
            // lbl_telefs
            // 
            this.lbl_telefs.AutoSize = true;
            this.lbl_telefs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefs.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telefs.Location = new System.Drawing.Point(174, 72);
            this.lbl_telefs.Name = "lbl_telefs";
            this.lbl_telefs.Size = new System.Drawing.Size(71, 13);
            this.lbl_telefs.TabIndex = 4;
            this.lbl_telefs.Text = "Teléfonos";
            // 
            // lbl_ced_taller
            // 
            this.lbl_ced_taller.AutoSize = true;
            this.lbl_ced_taller.Location = new System.Drawing.Point(252, 58);
            this.lbl_ced_taller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ced_taller.Name = "lbl_ced_taller";
            this.lbl_ced_taller.Size = new System.Drawing.Size(67, 13);
            this.lbl_ced_taller.TabIndex = 3;
            this.lbl_ced_taller.Text = "2034505493";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(252, 85);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(161, 26);
            this.lbl_direccion.TabIndex = 7;
            this.lbl_direccion.Text = "Santo Domingo de Heredia, \r\nPlaza Comercial Mingo, local#12\r\n";
            // 
            // lbl_telefonos
            // 
            this.lbl_telefonos.AutoSize = true;
            this.lbl_telefonos.Location = new System.Drawing.Point(252, 72);
            this.lbl_telefonos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefonos.Name = "lbl_telefonos";
            this.lbl_telefonos.Size = new System.Drawing.Size(157, 13);
            this.lbl_telefonos.TabIndex = 5;
            this.lbl_telefonos.Text = "+50622447698  +50622447676\r\n";
            // 
            // lbl_numfact
            // 
            this.lbl_numfact.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numfact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_numfact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_numfact.Location = new System.Drawing.Point(572, 63);
            this.lbl_numfact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numfact.Name = "lbl_numfact";
            this.lbl_numfact.Size = new System.Drawing.Size(172, 18);
            this.lbl_numfact.TabIndex = 10;
            // 
            // lbl_fact
            // 
            this.lbl_fact.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fact.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_fact.Location = new System.Drawing.Point(434, 67);
            this.lbl_fact.Name = "lbl_fact";
            this.lbl_fact.Size = new System.Drawing.Size(117, 14);
            this.lbl_fact.TabIndex = 9;
            this.lbl_fact.Text = "Número de Factura\r\n\r\n";
            // 
            // lbl_nuord
            // 
            this.lbl_nuord.AutoSize = true;
            this.lbl_nuord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nuord.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nuord.Location = new System.Drawing.Point(441, 93);
            this.lbl_nuord.Name = "lbl_nuord";
            this.lbl_nuord.Size = new System.Drawing.Size(110, 13);
            this.lbl_nuord.TabIndex = 11;
            this.lbl_nuord.Text = "Orden de Servicio";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cliente.Location = new System.Drawing.Point(572, 134);
            this.lbl_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(172, 18);
            this.lbl_cliente.TabIndex = 16;
            this.lbl_cliente.Text = "\r\n";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_fecha.Location = new System.Drawing.Point(572, 112);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(172, 18);
            this.lbl_fecha.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(504, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cliente";
            // 
            // lbl_dat
            // 
            this.lbl_dat.AutoSize = true;
            this.lbl_dat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dat.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_dat.Location = new System.Drawing.Point(510, 116);
            this.lbl_dat.Name = "lbl_dat";
            this.lbl_dat.Size = new System.Drawing.Size(40, 13);
            this.lbl_dat.TabIndex = 13;
            this.lbl_dat.Text = "Fecha";
            // 
            // dgv_factura
            // 
            this.dgv_factura.AllowUserToAddRows = false;
            this.dgv_factura.AllowUserToDeleteRows = false;
            this.dgv_factura.BackgroundColor = System.Drawing.Color.White;
            this.dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_descr,
            this.col_cat,
            this.col_unit,
            this.col_preci});
            this.dgv_factura.Location = new System.Drawing.Point(27, 17);
            this.dgv_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_factura.Name = "dgv_factura";
            this.dgv_factura.ReadOnly = true;
            this.dgv_factura.RowTemplate.Height = 24;
            this.dgv_factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_factura.Size = new System.Drawing.Size(538, 122);
            this.dgv_factura.TabIndex = 18;
            // 
            // col_descr
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.col_descr.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_descr.HeaderText = "Descripción";
            this.col_descr.Name = "col_descr";
            this.col_descr.ReadOnly = true;
            // 
            // col_cat
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.col_cat.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_cat.HeaderText = "Cantidad";
            this.col_cat.Name = "col_cat";
            this.col_cat.ReadOnly = true;
            // 
            // col_unit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.col_unit.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_unit.HeaderText = "U/M";
            this.col_unit.Name = "col_unit";
            this.col_unit.ReadOnly = true;
            // 
            // col_preci
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.col_preci.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_preci.HeaderText = "Precio";
            this.col_preci.Name = "col_preci";
            this.col_preci.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tot_pagar);
            this.groupBox2.Controls.Add(this.dgv_factura);
            this.groupBox2.Controls.Add(this.txt_impuesto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_descuento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_total);
            this.groupBox2.Location = new System.Drawing.Point(83, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(590, 276);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 580);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 14);
            this.label6.TabIndex = 62;
            this.label6.Text = "GRACIAS POR PREFERIRNOS!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 613);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_dat);
            this.Controls.Add(this.lbl_nuord);
            this.Controls.Add(this.lbl_fact);
            this.Controls.Add(this.lbl_numfact);
            this.Controls.Add(this.lbl_telefonos);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_ced_taller);
            this.Controls.Add(this.lbl_orden);
            this.Controls.Add(this.lbl_telefs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_direc);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_factura);
            this.Controls.Add(this.lbl_ced_tall);
            this.Controls.Add(this.lbl_nomb_taller);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factura)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_factura;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_direc;
        private System.Windows.Forms.Label lbl_ced_tall;
        private System.Windows.Forms.Label lbl_nomb_taller;
        private System.Windows.Forms.Label lbl_orden;
        private System.Windows.Forms.Label lbl_telefs;
        private System.Windows.Forms.Label lbl_ced_taller;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefonos;
        private System.Windows.Forms.Label lbl_numfact;
        private System.Windows.Forms.Label lbl_fact;
        private System.Windows.Forms.Label lbl_nuord;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_dat;
        private System.Windows.Forms.DataGridView dgv_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_preci;
        private System.Windows.Forms.TextBox txt_tot_pagar;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.TextBox txt_impuesto;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}
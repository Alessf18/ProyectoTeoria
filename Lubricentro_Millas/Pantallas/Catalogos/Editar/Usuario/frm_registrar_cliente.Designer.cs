namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    partial class frm_registrar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrar_cliente));
            this.lbl_citas = new System.Windows.Forms.Label();
            this.gbx_datos_person = new System.Windows.Forms.GroupBox();
            this.msk_Telefono2 = new System.Windows.Forms.MaskedTextBox();
            this.msk_telefono1 = new System.Windows.Forms.MaskedTextBox();
            this.msk_Identi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telef2 = new System.Windows.Forms.Label();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.rbtn_cedula = new System.Windows.Forms.RadioButton();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_seg_ape = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_prim_ape = new System.Windows.Forms.TextBox();
            this.lbl_seg_ape = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.rbtn_residencia = new System.Windows.Forms.RadioButton();
            this.lbl_prim_ape = new System.Windows.Forms.Label();
            this.lbl_telef1 = new System.Windows.Forms.Label();
            this.rbtn_pasaporte = new System.Windows.Forms.RadioButton();
            this.gbx_datos_vehic = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AñadirMarca = new System.Windows.Forms.Label();
            this.cmb_Modelo = new System.Windows.Forms.ComboBox();
            this.cmb_Marca = new System.Windows.Forms.ComboBox();
            this.txt_comentario = new System.Windows.Forms.TextBox();
            this.cbx_combus = new System.Windows.Forms.ComboBox();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.lbl_annio = new System.Windows.Forms.Label();
            this.lbl_coments = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.cbx_tipos = new System.Windows.Forms.ComboBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.gbx_dat_tecnic = new System.Windows.Forms.GroupBox();
            this.rbtn_coolFresh = new System.Windows.Forms.RadioButton();
            this.rbtn_resFresh = new System.Windows.Forms.RadioButton();
            this.rbtn_castroler = new System.Windows.Forms.RadioButton();
            this.rbtn_penzoil = new System.Windows.Forms.RadioButton();
            this.lbl_tip_aceite = new System.Windows.Forms.Label();
            this.lbl_tip_coolant = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbx_datos_person.SuspendLayout();
            this.gbx_datos_vehic.SuspendLayout();
            this.gbx_dat_tecnic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_citas
            // 
            this.lbl_citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_citas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_citas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_citas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_citas.Location = new System.Drawing.Point(10, 7);
            this.lbl_citas.Name = "lbl_citas";
            this.lbl_citas.Size = new System.Drawing.Size(897, 28);
            this.lbl_citas.TabIndex = 48;
            this.lbl_citas.Text = "REGISTRAR CLIENTE";
            // 
            // gbx_datos_person
            // 
            this.gbx_datos_person.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbx_datos_person.Controls.Add(this.msk_Telefono2);
            this.gbx_datos_person.Controls.Add(this.msk_telefono1);
            this.gbx_datos_person.Controls.Add(this.msk_Identi);
            this.gbx_datos_person.Controls.Add(this.lbl_telef2);
            this.gbx_datos_person.Controls.Add(this.btn_verificar);
            this.gbx_datos_person.Controls.Add(this.rbtn_cedula);
            this.gbx_datos_person.Controls.Add(this.txt_direccion);
            this.gbx_datos_person.Controls.Add(this.txt_nombre);
            this.gbx_datos_person.Controls.Add(this.txt_seg_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_nombre);
            this.gbx_datos_person.Controls.Add(this.txt_prim_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_seg_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_direccion);
            this.gbx_datos_person.Controls.Add(this.txt_correo);
            this.gbx_datos_person.Controls.Add(this.lbl_correo);
            this.gbx_datos_person.Controls.Add(this.rbtn_residencia);
            this.gbx_datos_person.Controls.Add(this.lbl_prim_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_telef1);
            this.gbx_datos_person.Controls.Add(this.rbtn_pasaporte);
            this.gbx_datos_person.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos_person.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_datos_person.Location = new System.Drawing.Point(11, 55);
            this.gbx_datos_person.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_datos_person.Name = "gbx_datos_person";
            this.gbx_datos_person.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_datos_person.Size = new System.Drawing.Size(441, 461);
            this.gbx_datos_person.TabIndex = 0;
            this.gbx_datos_person.TabStop = false;
            this.gbx_datos_person.Text = "Datos Personales";
            // 
            // msk_Telefono2
            // 
            this.msk_Telefono2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msk_Telefono2.Culture = new System.Globalization.CultureInfo("");
            this.msk_Telefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Telefono2.Location = new System.Drawing.Point(154, 303);
            this.msk_Telefono2.Mask = "00-00-00-00";
            this.msk_Telefono2.Name = "msk_Telefono2";
            this.msk_Telefono2.Size = new System.Drawing.Size(271, 22);
            this.msk_Telefono2.TabIndex = 51;
            // 
            // msk_telefono1
            // 
            this.msk_telefono1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msk_telefono1.Culture = new System.Globalization.CultureInfo("");
            this.msk_telefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telefono1.Location = new System.Drawing.Point(154, 264);
            this.msk_telefono1.Mask = "00-00-00-00";
            this.msk_telefono1.Name = "msk_telefono1";
            this.msk_telefono1.Size = new System.Drawing.Size(271, 22);
            this.msk_telefono1.TabIndex = 50;
            // 
            // msk_Identi
            // 
            this.msk_Identi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msk_Identi.Culture = new System.Globalization.CultureInfo("");
            this.msk_Identi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Identi.Location = new System.Drawing.Point(154, 69);
            this.msk_Identi.Mask = "0-0000-0000";
            this.msk_Identi.Name = "msk_Identi";
            this.msk_Identi.Size = new System.Drawing.Size(271, 22);
            this.msk_Identi.TabIndex = 49;
            this.msk_Identi.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_telef2
            // 
            this.lbl_telef2.AutoSize = true;
            this.lbl_telef2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telef2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telef2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telef2.Location = new System.Drawing.Point(50, 309);
            this.lbl_telef2.Name = "lbl_telef2";
            this.lbl_telef2.Size = new System.Drawing.Size(76, 13);
            this.lbl_telef2.TabIndex = 14;
            this.lbl_telef2.Text = "Telefono 2";
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_verificar.BackgroundImage")));
            this.btn_verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verificar.ForeColor = System.Drawing.Color.White;
            this.btn_verificar.Location = new System.Drawing.Point(262, 109);
            this.btn_verificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(45, 37);
            this.btn_verificar.TabIndex = 5;
            this.btn_verificar.UseVisualStyleBackColor = true;
            // 
            // rbtn_cedula
            // 
            this.rbtn_cedula.AutoSize = true;
            this.rbtn_cedula.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_cedula.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_cedula.Location = new System.Drawing.Point(121, 37);
            this.rbtn_cedula.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_cedula.Name = "rbtn_cedula";
            this.rbtn_cedula.Size = new System.Drawing.Size(69, 17);
            this.rbtn_cedula.TabIndex = 1;
            this.rbtn_cedula.TabStop = true;
            this.rbtn_cedula.Text = "Cédula";
            this.rbtn_cedula.UseVisualStyleBackColor = false;
            this.rbtn_cedula.CheckedChanged += new System.EventHandler(this.rbtn_cedula_CheckedChanged);
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(154, 374);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direccion.MaxLength = 125;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(271, 70);
            this.txt_direccion.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(154, 154);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(271, 25);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_seg_ape
            // 
            this.txt_seg_ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_seg_ape.Enabled = false;
            this.txt_seg_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seg_ape.ForeColor = System.Drawing.Color.Black;
            this.txt_seg_ape.Location = new System.Drawing.Point(154, 233);
            this.txt_seg_ape.MaxLength = 25;
            this.txt_seg_ape.Multiline = true;
            this.txt_seg_ape.Name = "txt_seg_ape";
            this.txt_seg_ape.Size = new System.Drawing.Size(271, 25);
            this.txt_seg_ape.TabIndex = 8;
            this.txt_seg_ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_seg_ape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_seg_ape_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nombre.Location = new System.Drawing.Point(63, 164);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(58, 13);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_prim_ape
            // 
            this.txt_prim_ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_prim_ape.Enabled = false;
            this.txt_prim_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prim_ape.ForeColor = System.Drawing.Color.Black;
            this.txt_prim_ape.Location = new System.Drawing.Point(154, 202);
            this.txt_prim_ape.MaxLength = 25;
            this.txt_prim_ape.Multiline = true;
            this.txt_prim_ape.Name = "txt_prim_ape";
            this.txt_prim_ape.Size = new System.Drawing.Size(271, 25);
            this.txt_prim_ape.TabIndex = 7;
            this.txt_prim_ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_prim_ape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prim_ape_KeyPress);
            // 
            // lbl_seg_ape
            // 
            this.lbl_seg_ape.AutoSize = true;
            this.lbl_seg_ape.BackColor = System.Drawing.Color.Transparent;
            this.lbl_seg_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seg_ape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_seg_ape.Location = new System.Drawing.Point(10, 244);
            this.lbl_seg_ape.Name = "lbl_seg_ape";
            this.lbl_seg_ape.Size = new System.Drawing.Size(120, 13);
            this.lbl_seg_ape.TabIndex = 10;
            this.lbl_seg_ape.Text = "Segundo Apellido";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_direccion.Location = new System.Drawing.Point(54, 399);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(68, 13);
            this.lbl_direccion.TabIndex = 18;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_correo.Enabled = false;
            this.txt_correo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(154, 335);
            this.txt_correo.MaxLength = 25;
            this.txt_correo.Multiline = true;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(271, 25);
            this.txt_correo.TabIndex = 11;
            this.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_correo.Location = new System.Drawing.Point(5, 345);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(128, 13);
            this.lbl_correo.TabIndex = 16;
            this.lbl_correo.Text = "Correo Electrónico";
            // 
            // rbtn_residencia
            // 
            this.rbtn_residencia.AutoSize = true;
            this.rbtn_residencia.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_residencia.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_residencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_residencia.Location = new System.Drawing.Point(310, 37);
            this.rbtn_residencia.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_residencia.Name = "rbtn_residencia";
            this.rbtn_residencia.Size = new System.Drawing.Size(127, 17);
            this.rbtn_residencia.TabIndex = 3;
            this.rbtn_residencia.TabStop = true;
            this.rbtn_residencia.Text = "# ID Residencia";
            this.rbtn_residencia.UseVisualStyleBackColor = false;
            this.rbtn_residencia.CheckedChanged += new System.EventHandler(this.rbtn_residencia_CheckedChanged);
            // 
            // lbl_prim_ape
            // 
            this.lbl_prim_ape.AutoSize = true;
            this.lbl_prim_ape.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prim_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prim_ape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_prim_ape.Location = new System.Drawing.Point(22, 205);
            this.lbl_prim_ape.Name = "lbl_prim_ape";
            this.lbl_prim_ape.Size = new System.Drawing.Size(108, 13);
            this.lbl_prim_ape.TabIndex = 8;
            this.lbl_prim_ape.Text = "Primer Apellido";
            // 
            // lbl_telef1
            // 
            this.lbl_telef1.AutoSize = true;
            this.lbl_telef1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telef1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telef1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telef1.Location = new System.Drawing.Point(50, 275);
            this.lbl_telef1.Name = "lbl_telef1";
            this.lbl_telef1.Size = new System.Drawing.Size(76, 13);
            this.lbl_telef1.TabIndex = 12;
            this.lbl_telef1.Text = "Teléfono 1";
            // 
            // rbtn_pasaporte
            // 
            this.rbtn_pasaporte.AutoSize = true;
            this.rbtn_pasaporte.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_pasaporte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_pasaporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_pasaporte.Location = new System.Drawing.Point(200, 37);
            this.rbtn_pasaporte.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_pasaporte.Name = "rbtn_pasaporte";
            this.rbtn_pasaporte.Size = new System.Drawing.Size(104, 17);
            this.rbtn_pasaporte.TabIndex = 2;
            this.rbtn_pasaporte.TabStop = true;
            this.rbtn_pasaporte.Text = "# Pasaporte";
            this.rbtn_pasaporte.UseVisualStyleBackColor = false;
            this.rbtn_pasaporte.CheckedChanged += new System.EventHandler(this.rbtn_pasaporte_CheckedChanged);
            // 
            // gbx_datos_vehic
            // 
            this.gbx_datos_vehic.Controls.Add(this.textBox1);
            this.gbx_datos_vehic.Controls.Add(this.AñadirMarca);
            this.gbx_datos_vehic.Controls.Add(this.cmb_Modelo);
            this.gbx_datos_vehic.Controls.Add(this.cmb_Marca);
            this.gbx_datos_vehic.Controls.Add(this.txt_comentario);
            this.gbx_datos_vehic.Controls.Add(this.cbx_combus);
            this.gbx_datos_vehic.Controls.Add(this.lbl_motor);
            this.gbx_datos_vehic.Controls.Add(this.lbl_annio);
            this.gbx_datos_vehic.Controls.Add(this.lbl_coments);
            this.gbx_datos_vehic.Controls.Add(this.lbl_modelo);
            this.gbx_datos_vehic.Controls.Add(this.lbl_marca);
            this.gbx_datos_vehic.Controls.Add(this.cbx_tipos);
            this.gbx_datos_vehic.Controls.Add(this.txt_placa);
            this.gbx_datos_vehic.Controls.Add(this.lbl_tipo);
            this.gbx_datos_vehic.Controls.Add(this.lbl_placa);
            this.gbx_datos_vehic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos_vehic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_datos_vehic.Location = new System.Drawing.Point(458, 55);
            this.gbx_datos_vehic.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_datos_vehic.Name = "gbx_datos_vehic";
            this.gbx_datos_vehic.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_datos_vehic.Size = new System.Drawing.Size(434, 299);
            this.gbx_datos_vehic.TabIndex = 20;
            this.gbx_datos_vehic.TabStop = false;
            this.gbx_datos_vehic.Text = "Datos del Vehículo";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(58, 156);
            this.textBox1.MaxLength = 9;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 25);
            this.textBox1.TabIndex = 16;
            // 
            // AñadirMarca
            // 
            this.AñadirMarca.AutoSize = true;
            this.AñadirMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirMarca.Location = new System.Drawing.Point(164, 113);
            this.AñadirMarca.Name = "AñadirMarca";
            this.AñadirMarca.Size = new System.Drawing.Size(33, 33);
            this.AñadirMarca.TabIndex = 38;
            this.AñadirMarca.Text = "+";
            this.AñadirMarca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AñadirMarca_MouseClick);
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmb_Modelo.ForeColor = System.Drawing.Color.White;
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Items.AddRange(new object[] {
            "Sedán",
            "Cupé",
            "Deportivo",
            "Crossover",
            "Hatchback",
            "SUV",
            "Camioneta",
            "Utilitario",
            "Compacto",
            "PickUp",
            "Microbus pequeña"});
            this.cmb_Modelo.Location = new System.Drawing.Point(286, 120);
            this.cmb_Modelo.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(110, 21);
            this.cmb_Modelo.TabIndex = 17;
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmb_Marca.ForeColor = System.Drawing.Color.White;
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Items.AddRange(new object[] {
            "Sedán",
            "Cupé",
            "Deportivo",
            "Crossover",
            "Hatchback",
            "SUV",
            "Camioneta",
            "Utilitario",
            "Compacto",
            "PickUp",
            "Microbus pequeña"});
            this.cmb_Marca.Location = new System.Drawing.Point(60, 120);
            this.cmb_Marca.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(99, 21);
            this.cmb_Marca.TabIndex = 15;
            // 
            // txt_comentario
            // 
            this.txt_comentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_comentario.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comentario.ForeColor = System.Drawing.Color.Black;
            this.txt_comentario.Location = new System.Drawing.Point(103, 230);
            this.txt_comentario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_comentario.MaxLength = 125;
            this.txt_comentario.Multiline = true;
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(271, 48);
            this.txt_comentario.TabIndex = 19;
            // 
            // cbx_combus
            // 
            this.cbx_combus.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_combus.ForeColor = System.Drawing.Color.White;
            this.cbx_combus.FormattingEnabled = true;
            this.cbx_combus.Items.AddRange(new object[] {
            "1600cc",
            "1800cc",
            "2000cc",
            "2200cc",
            "2400cc",
            "2500cc",
            "3000cc",
            "3600cc",
            "4000cc",
            "4500cc",
            "5000cc",
            "5600cc",
            "6000cc"});
            this.cbx_combus.Location = new System.Drawing.Point(284, 160);
            this.cbx_combus.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_combus.Name = "cbx_combus";
            this.cbx_combus.Size = new System.Drawing.Size(114, 21);
            this.cbx_combus.TabIndex = 18;
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_motor.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_motor.Location = new System.Drawing.Point(192, 164);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(87, 13);
            this.lbl_motor.TabIndex = 31;
            this.lbl_motor.Text = "Combustible";
            // 
            // lbl_annio
            // 
            this.lbl_annio.AutoSize = true;
            this.lbl_annio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_annio.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_annio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_annio.Location = new System.Drawing.Point(20, 164);
            this.lbl_annio.Name = "lbl_annio";
            this.lbl_annio.Size = new System.Drawing.Size(32, 13);
            this.lbl_annio.TabIndex = 29;
            this.lbl_annio.Text = "Año";
            // 
            // lbl_coments
            // 
            this.lbl_coments.AutoSize = true;
            this.lbl_coments.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coments.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_coments.Location = new System.Drawing.Point(9, 233);
            this.lbl_coments.Name = "lbl_coments";
            this.lbl_coments.Size = new System.Drawing.Size(89, 13);
            this.lbl_coments.TabIndex = 33;
            this.lbl_coments.Text = "Comentarios";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modelo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_modelo.Location = new System.Drawing.Point(226, 121);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(53, 13);
            this.lbl_modelo.TabIndex = 27;
            this.lbl_modelo.Text = "Modelo";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_marca.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_marca.Location = new System.Drawing.Point(9, 124);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(46, 13);
            this.lbl_marca.TabIndex = 25;
            this.lbl_marca.Text = "Marca";
            // 
            // cbx_tipos
            // 
            this.cbx_tipos.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_tipos.ForeColor = System.Drawing.Color.White;
            this.cbx_tipos.FormattingEnabled = true;
            this.cbx_tipos.Items.AddRange(new object[] {
            "Sedán",
            "Cupé",
            "Deportivo",
            "Crossover",
            "Hatchback",
            "SUV",
            "Camioneta",
            "Utilitario",
            "Compacto",
            "PickUp",
            "Microbus pequeña"});
            this.cbx_tipos.Location = new System.Drawing.Point(170, 63);
            this.cbx_tipos.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_tipos.Name = "cbx_tipos";
            this.cbx_tipos.Size = new System.Drawing.Size(169, 21);
            this.cbx_tipos.TabIndex = 14;
            // 
            // txt_placa
            // 
            this.txt_placa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_placa.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placa.ForeColor = System.Drawing.Color.Black;
            this.txt_placa.Location = new System.Drawing.Point(170, 18);
            this.txt_placa.MaxLength = 9;
            this.txt_placa.Multiline = true;
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(170, 25);
            this.txt_placa.TabIndex = 13;
            this.txt_placa.Leave += new System.EventHandler(this.txt_placa_Leave);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_tipo.Location = new System.Drawing.Point(25, 69);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(114, 13);
            this.lbl_tipo.TabIndex = 23;
            this.lbl_tipo.Text = "Tipo de Vehículo";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_placa.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_placa.Location = new System.Drawing.Point(23, 28);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(117, 13);
            this.lbl_placa.TabIndex = 21;
            this.lbl_placa.Text = "Número de Placa";
            // 
            // gbx_dat_tecnic
            // 
            this.gbx_dat_tecnic.Controls.Add(this.rbtn_coolFresh);
            this.gbx_dat_tecnic.Controls.Add(this.rbtn_resFresh);
            this.gbx_dat_tecnic.Controls.Add(this.rbtn_castroler);
            this.gbx_dat_tecnic.Controls.Add(this.rbtn_penzoil);
            this.gbx_dat_tecnic.Controls.Add(this.lbl_tip_aceite);
            this.gbx_dat_tecnic.Controls.Add(this.lbl_tip_coolant);
            this.gbx_dat_tecnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_dat_tecnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_dat_tecnic.Location = new System.Drawing.Point(536, 358);
            this.gbx_dat_tecnic.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_dat_tecnic.Name = "gbx_dat_tecnic";
            this.gbx_dat_tecnic.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_dat_tecnic.Size = new System.Drawing.Size(320, 158);
            this.gbx_dat_tecnic.TabIndex = 35;
            this.gbx_dat_tecnic.TabStop = false;
            this.gbx_dat_tecnic.Text = "Datos Técnicos";
            // 
            // rbtn_coolFresh
            // 
            this.rbtn_coolFresh.AutoSize = true;
            this.rbtn_coolFresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_coolFresh.Location = new System.Drawing.Point(212, 124);
            this.rbtn_coolFresh.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_coolFresh.Name = "rbtn_coolFresh";
            this.rbtn_coolFresh.Size = new System.Drawing.Size(78, 17);
            this.rbtn_coolFresh.TabIndex = 23;
            this.rbtn_coolFresh.TabStop = true;
            this.rbtn_coolFresh.Text = "Coolfresh";
            this.rbtn_coolFresh.UseVisualStyleBackColor = true;
            // 
            // rbtn_resFresh
            // 
            this.rbtn_resFresh.AutoSize = true;
            this.rbtn_resFresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_resFresh.Location = new System.Drawing.Point(214, 73);
            this.rbtn_resFresh.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_resFresh.Name = "rbtn_resFresh";
            this.rbtn_resFresh.Size = new System.Drawing.Size(78, 17);
            this.rbtn_resFresh.TabIndex = 21;
            this.rbtn_resFresh.TabStop = true;
            this.rbtn_resFresh.Text = "ResFresh";
            this.rbtn_resFresh.UseVisualStyleBackColor = true;
            // 
            // rbtn_castroler
            // 
            this.rbtn_castroler.AutoSize = true;
            this.rbtn_castroler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_castroler.Location = new System.Drawing.Point(50, 117);
            this.rbtn_castroler.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_castroler.Name = "rbtn_castroler";
            this.rbtn_castroler.Size = new System.Drawing.Size(129, 30);
            this.rbtn_castroler.TabIndex = 22;
            this.rbtn_castroler.TabStop = true;
            this.rbtn_castroler.Text = "Castroler 20W/50 \r\n5000k ";
            this.rbtn_castroler.UseVisualStyleBackColor = true;
            // 
            // rbtn_penzoil
            // 
            this.rbtn_penzoil.AutoSize = true;
            this.rbtn_penzoil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_penzoil.Location = new System.Drawing.Point(50, 66);
            this.rbtn_penzoil.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_penzoil.Name = "rbtn_penzoil";
            this.rbtn_penzoil.Size = new System.Drawing.Size(127, 30);
            this.rbtn_penzoil.TabIndex = 20;
            this.rbtn_penzoil.TabStop = true;
            this.rbtn_penzoil.Text = "Penzoiler 20W/40\r\n 3000k ";
            this.rbtn_penzoil.UseVisualStyleBackColor = true;
            // 
            // lbl_tip_aceite
            // 
            this.lbl_tip_aceite.AutoSize = true;
            this.lbl_tip_aceite.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tip_aceite.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip_aceite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_tip_aceite.Location = new System.Drawing.Point(60, 41);
            this.lbl_tip_aceite.Name = "lbl_tip_aceite";
            this.lbl_tip_aceite.Size = new System.Drawing.Size(100, 13);
            this.lbl_tip_aceite.TabIndex = 36;
            this.lbl_tip_aceite.Text = "Tipo de Aceite";
            // 
            // lbl_tip_coolant
            // 
            this.lbl_tip_coolant.AutoSize = true;
            this.lbl_tip_coolant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tip_coolant.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip_coolant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_tip_coolant.Location = new System.Drawing.Point(210, 41);
            this.lbl_tip_coolant.Name = "lbl_tip_coolant";
            this.lbl_tip_coolant.Size = new System.Drawing.Size(108, 13);
            this.lbl_tip_coolant.TabIndex = 39;
            this.lbl_tip_coolant.Text = "Tipo de Coolant";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(458, 555);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(45, 37);
            this.btn_guardar.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar Registro");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Location = new System.Drawing.Point(388, 555);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(45, 37);
            this.btn_atras.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btn_atras, "Cancelar Registro");
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // frm_registrar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 633);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.gbx_dat_tecnic);
            this.Controls.Add(this.gbx_datos_vehic);
            this.Controls.Add(this.gbx_datos_person);
            this.Controls.Add(this.lbl_citas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_registrar_cliente";
            this.Text = "frm_registrar_cliente";
            this.Load += new System.EventHandler(this.frm_registrar_cliente_Load);
            this.gbx_datos_person.ResumeLayout(false);
            this.gbx_datos_person.PerformLayout();
            this.gbx_datos_vehic.ResumeLayout(false);
            this.gbx_datos_vehic.PerformLayout();
            this.gbx_dat_tecnic.ResumeLayout(false);
            this.gbx_dat_tecnic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_citas;
        private System.Windows.Forms.GroupBox gbx_datos_person;
        private System.Windows.Forms.Label lbl_telef2;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.RadioButton rbtn_cedula;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_seg_ape;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_prim_ape;
        private System.Windows.Forms.Label lbl_seg_ape;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.RadioButton rbtn_residencia;
        private System.Windows.Forms.Label lbl_prim_ape;
        private System.Windows.Forms.Label lbl_telef1;
        private System.Windows.Forms.RadioButton rbtn_pasaporte;
        private System.Windows.Forms.GroupBox gbx_datos_vehic;
        private System.Windows.Forms.ComboBox cbx_tipos;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.GroupBox gbx_dat_tecnic;
        private System.Windows.Forms.RadioButton rbtn_coolFresh;
        private System.Windows.Forms.RadioButton rbtn_resFresh;
        private System.Windows.Forms.RadioButton rbtn_castroler;
        private System.Windows.Forms.RadioButton rbtn_penzoil;
        private System.Windows.Forms.Label lbl_tip_aceite;
        private System.Windows.Forms.Label lbl_tip_coolant;
        private System.Windows.Forms.TextBox txt_comentario;
        private System.Windows.Forms.ComboBox cbx_combus;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.Label lbl_annio;
        private System.Windows.Forms.Label lbl_coments;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label AñadirMarca;
        private System.Windows.Forms.ComboBox cmb_Modelo;
        private System.Windows.Forms.ComboBox cmb_Marca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.MaskedTextBox msk_Identi;
        private System.Windows.Forms.MaskedTextBox msk_telefono1;
        private System.Windows.Forms.MaskedTextBox msk_Telefono2;
    }
}
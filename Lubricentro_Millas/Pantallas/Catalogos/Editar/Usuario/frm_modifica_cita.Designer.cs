namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    partial class frm_modifica_cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modifica_cita));
            this.lbl_modifica_citas = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_horario = new System.Windows.Forms.GroupBox();
            this.txt_fecha_cita = new System.Windows.Forms.TextBox();
            this.txt_hora_cita = new System.Windows.Forms.TextBox();
            this.lbl_hora_cita = new System.Windows.Forms.Label();
            this.lbl_fecha_cita = new System.Windows.Forms.Label();
            this.txt_lineas = new System.Windows.Forms.TextBox();
            this.lbl_lineas = new System.Windows.Forms.Label();
            this.gbx_datos_vehiculo = new System.Windows.Forms.GroupBox();
            this.ckbx_cargaAC = new System.Windows.Forms.CheckBox();
            this.ckbx_f_aire = new System.Windows.Forms.CheckBox();
            this.ckbx_coolant = new System.Windows.Forms.CheckBox();
            this.ckbx_alineamiento = new System.Windows.Forms.CheckBox();
            this.ckbx_aceite = new System.Windows.Forms.CheckBox();
            this.cbx_placa = new System.Windows.Forms.ComboBox();
            this.lbl_servicios = new System.Windows.Forms.Label();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.gbx_datos_person = new System.Windows.Forms.GroupBox();
            this.txt_telefono2 = new System.Windows.Forms.TextBox();
            this.lbl_telef2 = new System.Windows.Forms.Label();
            this.rbtn_cedula = new System.Windows.Forms.RadioButton();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_identifica = new System.Windows.Forms.TextBox();
            this.txt_seg_ape = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_prim_ape = new System.Windows.Forms.TextBox();
            this.lbl_seg_ape = new System.Windows.Forms.Label();
            this.txt_telefono1 = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.rbtn_residencia = new System.Windows.Forms.RadioButton();
            this.lbl_prim_ape = new System.Windows.Forms.Label();
            this.lbl_telef1 = new System.Windows.Forms.Label();
            this.rbtn_pasaporte = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_horario = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.gbx_horario.SuspendLayout();
            this.gbx_datos_vehiculo.SuspendLayout();
            this.gbx_datos_person.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_modifica_citas
            // 
            this.lbl_modifica_citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_modifica_citas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_modifica_citas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modifica_citas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_modifica_citas.Location = new System.Drawing.Point(13, 9);
            this.lbl_modifica_citas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modifica_citas.Name = "lbl_modifica_citas";
            this.lbl_modifica_citas.Size = new System.Drawing.Size(1196, 35);
            this.lbl_modifica_citas.TabIndex = 51;
            this.lbl_modifica_citas.Text = "MODIFICAR CITAS";
            // 
            // gbx_horario
            // 
            this.gbx_horario.BackColor = System.Drawing.Color.Transparent;
            this.gbx_horario.Controls.Add(this.btn_horario);
            this.gbx_horario.Controls.Add(this.txt_fecha_cita);
            this.gbx_horario.Controls.Add(this.txt_hora_cita);
            this.gbx_horario.Controls.Add(this.lbl_hora_cita);
            this.gbx_horario.Controls.Add(this.lbl_fecha_cita);
            this.gbx_horario.Controls.Add(this.txt_lineas);
            this.gbx_horario.Controls.Add(this.lbl_lineas);
            this.gbx_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_horario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_horario.Location = new System.Drawing.Point(786, 431);
            this.gbx_horario.Name = "gbx_horario";
            this.gbx_horario.Size = new System.Drawing.Size(364, 242);
            this.gbx_horario.TabIndex = 54;
            this.gbx_horario.TabStop = false;
            this.gbx_horario.Text = "Detalles de Cita";
            // 
            // txt_fecha_cita
            // 
            this.txt_fecha_cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_fecha_cita.Enabled = false;
            this.txt_fecha_cita.Location = new System.Drawing.Point(178, 110);
            this.txt_fecha_cita.Name = "txt_fecha_cita";
            this.txt_fecha_cita.Size = new System.Drawing.Size(166, 22);
            this.txt_fecha_cita.TabIndex = 32;
            // 
            // txt_hora_cita
            // 
            this.txt_hora_cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_hora_cita.Enabled = false;
            this.txt_hora_cita.Location = new System.Drawing.Point(178, 184);
            this.txt_hora_cita.Name = "txt_hora_cita";
            this.txt_hora_cita.Size = new System.Drawing.Size(166, 22);
            this.txt_hora_cita.TabIndex = 36;
            // 
            // lbl_hora_cita
            // 
            this.lbl_hora_cita.AutoSize = true;
            this.lbl_hora_cita.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora_cita.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora_cita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hora_cita.Location = new System.Drawing.Point(27, 187);
            this.lbl_hora_cita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora_cita.Name = "lbl_hora_cita";
            this.lbl_hora_cita.Size = new System.Drawing.Size(122, 17);
            this.lbl_hora_cita.TabIndex = 35;
            this.lbl_hora_cita.Text = "Hora de la Cita";
            // 
            // lbl_fecha_cita
            // 
            this.lbl_fecha_cita.AutoSize = true;
            this.lbl_fecha_cita.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_cita.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_cita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_fecha_cita.Location = new System.Drawing.Point(19, 111);
            this.lbl_fecha_cita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_cita.Name = "lbl_fecha_cita";
            this.lbl_fecha_cita.Size = new System.Drawing.Size(130, 17);
            this.lbl_fecha_cita.TabIndex = 31;
            this.lbl_fecha_cita.Text = "Fecha de la Cita";
            // 
            // txt_lineas
            // 
            this.txt_lineas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_lineas.Enabled = false;
            this.txt_lineas.Location = new System.Drawing.Point(178, 148);
            this.txt_lineas.Name = "txt_lineas";
            this.txt_lineas.Size = new System.Drawing.Size(166, 22);
            this.txt_lineas.TabIndex = 34;
            // 
            // lbl_lineas
            // 
            this.lbl_lineas.AutoSize = true;
            this.lbl_lineas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lineas.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lineas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_lineas.Location = new System.Drawing.Point(8, 151);
            this.lbl_lineas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lineas.Name = "lbl_lineas";
            this.lbl_lineas.Size = new System.Drawing.Size(141, 17);
            this.lbl_lineas.TabIndex = 33;
            this.lbl_lineas.Text = "Líneas Asignadas";
            // 
            // gbx_datos_vehiculo
            // 
            this.gbx_datos_vehiculo.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos_vehiculo.Controls.Add(this.ckbx_cargaAC);
            this.gbx_datos_vehiculo.Controls.Add(this.ckbx_f_aire);
            this.gbx_datos_vehiculo.Controls.Add(this.ckbx_coolant);
            this.gbx_datos_vehiculo.Controls.Add(this.ckbx_alineamiento);
            this.gbx_datos_vehiculo.Controls.Add(this.ckbx_aceite);
            this.gbx_datos_vehiculo.Controls.Add(this.cbx_placa);
            this.gbx_datos_vehiculo.Controls.Add(this.lbl_servicios);
            this.gbx_datos_vehiculo.Controls.Add(this.lbl_placa);
            this.gbx_datos_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_datos_vehiculo.Location = new System.Drawing.Point(786, 106);
            this.gbx_datos_vehiculo.Name = "gbx_datos_vehiculo";
            this.gbx_datos_vehiculo.Size = new System.Drawing.Size(364, 300);
            this.gbx_datos_vehiculo.TabIndex = 53;
            this.gbx_datos_vehiculo.TabStop = false;
            this.gbx_datos_vehiculo.Text = "Datos del vehículo";
            // 
            // ckbx_cargaAC
            // 
            this.ckbx_cargaAC.AutoSize = true;
            this.ckbx_cargaAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbx_cargaAC.Location = new System.Drawing.Point(210, 234);
            this.ckbx_cargaAC.Name = "ckbx_cargaAC";
            this.ckbx_cargaAC.Size = new System.Drawing.Size(126, 21);
            this.ckbx_cargaAC.TabIndex = 28;
            this.ckbx_cargaAC.Text = "Carga de A/C";
            this.ckbx_cargaAC.UseVisualStyleBackColor = true;
            // 
            // ckbx_f_aire
            // 
            this.ckbx_f_aire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbx_f_aire.Location = new System.Drawing.Point(210, 180);
            this.ckbx_f_aire.Name = "ckbx_f_aire";
            this.ckbx_f_aire.Size = new System.Drawing.Size(123, 48);
            this.ckbx_f_aire.TabIndex = 27;
            this.ckbx_f_aire.Text = "Cambio Filtro Aire";
            this.ckbx_f_aire.UseVisualStyleBackColor = true;
            // 
            // ckbx_coolant
            // 
            this.ckbx_coolant.AutoSize = true;
            this.ckbx_coolant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbx_coolant.Location = new System.Drawing.Point(34, 207);
            this.ckbx_coolant.Name = "ckbx_coolant";
            this.ckbx_coolant.Size = new System.Drawing.Size(166, 21);
            this.ckbx_coolant.TabIndex = 25;
            this.ckbx_coolant.Text = "Cambio de Coolant";
            this.ckbx_coolant.UseVisualStyleBackColor = true;
            // 
            // ckbx_alineamiento
            // 
            this.ckbx_alineamiento.AutoSize = true;
            this.ckbx_alineamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbx_alineamiento.Location = new System.Drawing.Point(34, 234);
            this.ckbx_alineamiento.Name = "ckbx_alineamiento";
            this.ckbx_alineamiento.Size = new System.Drawing.Size(123, 21);
            this.ckbx_alineamiento.TabIndex = 26;
            this.ckbx_alineamiento.Text = "Alineamiento";
            this.ckbx_alineamiento.UseVisualStyleBackColor = true;
            // 
            // ckbx_aceite
            // 
            this.ckbx_aceite.AutoSize = true;
            this.ckbx_aceite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbx_aceite.Location = new System.Drawing.Point(34, 180);
            this.ckbx_aceite.Name = "ckbx_aceite";
            this.ckbx_aceite.Size = new System.Drawing.Size(156, 21);
            this.ckbx_aceite.TabIndex = 24;
            this.ckbx_aceite.Text = "Cambio de Aceite";
            this.ckbx_aceite.UseVisualStyleBackColor = true;
            // 
            // cbx_placa
            // 
            this.cbx_placa.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_placa.ForeColor = System.Drawing.Color.White;
            this.cbx_placa.FormattingEnabled = true;
            this.cbx_placa.Location = new System.Drawing.Point(112, 88);
            this.cbx_placa.Name = "cbx_placa";
            this.cbx_placa.Size = new System.Drawing.Size(162, 24);
            this.cbx_placa.TabIndex = 22;
            // 
            // lbl_servicios
            // 
            this.lbl_servicios.AutoSize = true;
            this.lbl_servicios.BackColor = System.Drawing.Color.Transparent;
            this.lbl_servicios.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_servicios.Location = new System.Drawing.Point(122, 145);
            this.lbl_servicios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_servicios.Name = "lbl_servicios";
            this.lbl_servicios.Size = new System.Drawing.Size(148, 17);
            this.lbl_servicios.TabIndex = 23;
            this.lbl_servicios.Text = "Tipos de Servicios";
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_placa.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_placa.Location = new System.Drawing.Point(122, 50);
            this.lbl_placa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(138, 17);
            this.lbl_placa.TabIndex = 21;
            this.lbl_placa.Text = "Número de Placa";
            // 
            // gbx_datos_person
            // 
            this.gbx_datos_person.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbx_datos_person.Controls.Add(this.txt_telefono2);
            this.gbx_datos_person.Controls.Add(this.lbl_telef2);
            this.gbx_datos_person.Controls.Add(this.btn_verificar);
            this.gbx_datos_person.Controls.Add(this.rbtn_cedula);
            this.gbx_datos_person.Controls.Add(this.txt_direccion);
            this.gbx_datos_person.Controls.Add(this.txt_nombre);
            this.gbx_datos_person.Controls.Add(this.txt_identifica);
            this.gbx_datos_person.Controls.Add(this.txt_seg_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_nombre);
            this.gbx_datos_person.Controls.Add(this.txt_prim_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_seg_ape);
            this.gbx_datos_person.Controls.Add(this.txt_telefono1);
            this.gbx_datos_person.Controls.Add(this.lbl_direccion);
            this.gbx_datos_person.Controls.Add(this.txt_correo);
            this.gbx_datos_person.Controls.Add(this.lbl_correo);
            this.gbx_datos_person.Controls.Add(this.rbtn_residencia);
            this.gbx_datos_person.Controls.Add(this.lbl_prim_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_telef1);
            this.gbx_datos_person.Controls.Add(this.rbtn_pasaporte);
            this.gbx_datos_person.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos_person.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_datos_person.Location = new System.Drawing.Point(72, 106);
            this.gbx_datos_person.Name = "gbx_datos_person";
            this.gbx_datos_person.Size = new System.Drawing.Size(588, 567);
            this.gbx_datos_person.TabIndex = 52;
            this.gbx_datos_person.TabStop = false;
            this.gbx_datos_person.Text = "Datos Personales";
            // 
            // txt_telefono2
            // 
            this.txt_telefono2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telefono2.Enabled = false;
            this.txt_telefono2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono2.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono2.Location = new System.Drawing.Point(205, 367);
            this.txt_telefono2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono2.MaxLength = 25;
            this.txt_telefono2.Multiline = true;
            this.txt_telefono2.Name = "txt_telefono2";
            this.txt_telefono2.Size = new System.Drawing.Size(360, 30);
            this.txt_telefono2.TabIndex = 15;
            this.txt_telefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_telef2
            // 
            this.lbl_telef2.AutoSize = true;
            this.lbl_telef2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telef2.Enabled = false;
            this.lbl_telef2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telef2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telef2.Location = new System.Drawing.Point(67, 380);
            this.lbl_telef2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telef2.Name = "lbl_telef2";
            this.lbl_telef2.Size = new System.Drawing.Size(91, 17);
            this.lbl_telef2.TabIndex = 14;
            this.lbl_telef2.Text = "Telefono 2";
            // 
            // rbtn_cedula
            // 
            this.rbtn_cedula.AutoSize = true;
            this.rbtn_cedula.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_cedula.Enabled = false;
            this.rbtn_cedula.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_cedula.Location = new System.Drawing.Point(161, 46);
            this.rbtn_cedula.Name = "rbtn_cedula";
            this.rbtn_cedula.Size = new System.Drawing.Size(82, 21);
            this.rbtn_cedula.TabIndex = 1;
            this.rbtn_cedula.TabStop = true;
            this.rbtn_cedula.Text = "Cédula";
            this.rbtn_cedula.UseVisualStyleBackColor = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(205, 460);
            this.txt_direccion.MaxLength = 125;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(360, 85);
            this.txt_direccion.TabIndex = 19;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(205, 189);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(360, 30);
            this.txt_nombre.TabIndex = 7;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_identifica
            // 
            this.txt_identifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_identifica.Enabled = false;
            this.txt_identifica.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identifica.ForeColor = System.Drawing.Color.Black;
            this.txt_identifica.Location = new System.Drawing.Point(205, 97);
            this.txt_identifica.Margin = new System.Windows.Forms.Padding(4);
            this.txt_identifica.MaxLength = 9;
            this.txt_identifica.Multiline = true;
            this.txt_identifica.Name = "txt_identifica";
            this.txt_identifica.Size = new System.Drawing.Size(360, 30);
            this.txt_identifica.TabIndex = 4;
            this.txt_identifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_seg_ape
            // 
            this.txt_seg_ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_seg_ape.Enabled = false;
            this.txt_seg_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seg_ape.ForeColor = System.Drawing.Color.Black;
            this.txt_seg_ape.Location = new System.Drawing.Point(205, 287);
            this.txt_seg_ape.Margin = new System.Windows.Forms.Padding(4);
            this.txt_seg_ape.MaxLength = 25;
            this.txt_seg_ape.Multiline = true;
            this.txt_seg_ape.Name = "txt_seg_ape";
            this.txt_seg_ape.Size = new System.Drawing.Size(360, 30);
            this.txt_seg_ape.TabIndex = 11;
            this.txt_seg_ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Enabled = false;
            this.lbl_nombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nombre.Location = new System.Drawing.Point(84, 202);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(69, 17);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_prim_ape
            // 
            this.txt_prim_ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_prim_ape.Enabled = false;
            this.txt_prim_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prim_ape.ForeColor = System.Drawing.Color.Black;
            this.txt_prim_ape.Location = new System.Drawing.Point(205, 249);
            this.txt_prim_ape.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prim_ape.MaxLength = 25;
            this.txt_prim_ape.Multiline = true;
            this.txt_prim_ape.Name = "txt_prim_ape";
            this.txt_prim_ape.Size = new System.Drawing.Size(360, 30);
            this.txt_prim_ape.TabIndex = 9;
            this.txt_prim_ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_seg_ape
            // 
            this.lbl_seg_ape.AutoSize = true;
            this.lbl_seg_ape.BackColor = System.Drawing.Color.Transparent;
            this.lbl_seg_ape.Enabled = false;
            this.lbl_seg_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seg_ape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_seg_ape.Location = new System.Drawing.Point(14, 300);
            this.lbl_seg_ape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_seg_ape.Name = "lbl_seg_ape";
            this.lbl_seg_ape.Size = new System.Drawing.Size(144, 17);
            this.lbl_seg_ape.TabIndex = 10;
            this.lbl_seg_ape.Text = "Segundo Apellido";
            // 
            // txt_telefono1
            // 
            this.txt_telefono1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telefono1.Enabled = false;
            this.txt_telefono1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono1.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono1.Location = new System.Drawing.Point(205, 325);
            this.txt_telefono1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono1.MaxLength = 10;
            this.txt_telefono1.Multiline = true;
            this.txt_telefono1.Name = "txt_telefono1";
            this.txt_telefono1.Size = new System.Drawing.Size(360, 30);
            this.txt_telefono1.TabIndex = 13;
            this.txt_telefono1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Enabled = false;
            this.lbl_direccion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_direccion.Location = new System.Drawing.Point(72, 491);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(79, 17);
            this.lbl_direccion.TabIndex = 18;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_correo.Enabled = false;
            this.txt_correo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(205, 412);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.MaxLength = 25;
            this.txt_correo.Multiline = true;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(360, 30);
            this.txt_correo.TabIndex = 17;
            this.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Enabled = false;
            this.lbl_correo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_correo.Location = new System.Drawing.Point(7, 425);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(153, 17);
            this.lbl_correo.TabIndex = 16;
            this.lbl_correo.Text = "Correo Electrónico";
            // 
            // rbtn_residencia
            // 
            this.rbtn_residencia.AutoSize = true;
            this.rbtn_residencia.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_residencia.Enabled = false;
            this.rbtn_residencia.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_residencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_residencia.Location = new System.Drawing.Point(413, 46);
            this.rbtn_residencia.Name = "rbtn_residencia";
            this.rbtn_residencia.Size = new System.Drawing.Size(152, 21);
            this.rbtn_residencia.TabIndex = 3;
            this.rbtn_residencia.TabStop = true;
            this.rbtn_residencia.Text = "# ID Residencia";
            this.rbtn_residencia.UseVisualStyleBackColor = false;
            // 
            // lbl_prim_ape
            // 
            this.lbl_prim_ape.AutoSize = true;
            this.lbl_prim_ape.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prim_ape.Enabled = false;
            this.lbl_prim_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prim_ape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_prim_ape.Location = new System.Drawing.Point(30, 262);
            this.lbl_prim_ape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prim_ape.Name = "lbl_prim_ape";
            this.lbl_prim_ape.Size = new System.Drawing.Size(126, 17);
            this.lbl_prim_ape.TabIndex = 8;
            this.lbl_prim_ape.Text = "Primer Apellido";
            // 
            // lbl_telef1
            // 
            this.lbl_telef1.AutoSize = true;
            this.lbl_telef1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telef1.Enabled = false;
            this.lbl_telef1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telef1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telef1.Location = new System.Drawing.Point(67, 338);
            this.lbl_telef1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telef1.Name = "lbl_telef1";
            this.lbl_telef1.Size = new System.Drawing.Size(91, 17);
            this.lbl_telef1.TabIndex = 12;
            this.lbl_telef1.Text = "Teléfono 1";
            // 
            // rbtn_pasaporte
            // 
            this.rbtn_pasaporte.AutoSize = true;
            this.rbtn_pasaporte.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_pasaporte.Enabled = false;
            this.rbtn_pasaporte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_pasaporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_pasaporte.Location = new System.Drawing.Point(266, 46);
            this.rbtn_pasaporte.Name = "rbtn_pasaporte";
            this.rbtn_pasaporte.Size = new System.Drawing.Size(124, 21);
            this.rbtn_pasaporte.TabIndex = 2;
            this.rbtn_pasaporte.TabStop = true;
            this.rbtn_pasaporte.Text = "# Pasaporte";
            this.rbtn_pasaporte.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(634, 694);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 45);
            this.btn_guardar.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar Cambios");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(541, 694);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 45);
            this.btn_cancelar.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_horario
            // 
            this.btn_horario.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.calendar;
            this.btn_horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_horario.FlatAppearance.BorderSize = 0;
            this.btn_horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_horario.Location = new System.Drawing.Point(191, 18);
            this.btn_horario.Name = "btn_horario";
            this.btn_horario.Size = new System.Drawing.Size(87, 71);
            this.btn_horario.TabIndex = 30;
            this.btn_horario.UseVisualStyleBackColor = true;
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_verificar.BackgroundImage")));
            this.btn_verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verificar.Enabled = false;
            this.btn_verificar.ForeColor = System.Drawing.Color.White;
            this.btn_verificar.Location = new System.Drawing.Point(349, 134);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(60, 45);
            this.btn_verificar.TabIndex = 5;
            this.btn_verificar.UseVisualStyleBackColor = true;
            // 
            // frm_modifica_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.ControlBox = false;
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gbx_horario);
            this.Controls.Add(this.gbx_datos_vehiculo);
            this.Controls.Add(this.gbx_datos_person);
            this.Controls.Add(this.lbl_modifica_citas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_modifica_cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_modifica_cita";
            this.gbx_horario.ResumeLayout(false);
            this.gbx_horario.PerformLayout();
            this.gbx_datos_vehiculo.ResumeLayout(false);
            this.gbx_datos_vehiculo.PerformLayout();
            this.gbx_datos_person.ResumeLayout(false);
            this.gbx_datos_person.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_modifica_citas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbx_horario;
        private System.Windows.Forms.Button btn_horario;
        private System.Windows.Forms.TextBox txt_fecha_cita;
        private System.Windows.Forms.TextBox txt_hora_cita;
        private System.Windows.Forms.Label lbl_hora_cita;
        private System.Windows.Forms.Label lbl_fecha_cita;
        private System.Windows.Forms.TextBox txt_lineas;
        private System.Windows.Forms.Label lbl_lineas;
        private System.Windows.Forms.GroupBox gbx_datos_vehiculo;
        private System.Windows.Forms.CheckBox ckbx_cargaAC;
        private System.Windows.Forms.CheckBox ckbx_f_aire;
        private System.Windows.Forms.CheckBox ckbx_coolant;
        private System.Windows.Forms.CheckBox ckbx_alineamiento;
        private System.Windows.Forms.CheckBox ckbx_aceite;
        private System.Windows.Forms.ComboBox cbx_placa;
        private System.Windows.Forms.Label lbl_servicios;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.GroupBox gbx_datos_person;
        private System.Windows.Forms.TextBox txt_telefono2;
        private System.Windows.Forms.Label lbl_telef2;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.RadioButton rbtn_cedula;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_identifica;
        private System.Windows.Forms.TextBox txt_seg_ape;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_prim_ape;
        private System.Windows.Forms.Label lbl_seg_ape;
        private System.Windows.Forms.TextBox txt_telefono1;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.RadioButton rbtn_residencia;
        private System.Windows.Forms.Label lbl_prim_ape;
        private System.Windows.Forms.Label lbl_telef1;
        private System.Windows.Forms.RadioButton rbtn_pasaporte;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
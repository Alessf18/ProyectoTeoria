namespace Lubricentro_Millas.Pantallas.Principal
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.mst_principal = new System.Windows.Forms.MenuStrip();
            this.tst_seguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_recupera_contrase = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_cambia_contrase = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_Servicios_Ope = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_citas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_crear_cita = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_modif_cita = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_cancela_cita = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_registra_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_modif_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_ordenServ_mecan = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_catalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_vehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_modelos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_motor_tam = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_tipoVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_cantidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_unidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_insumos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_roles = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_servicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_estados = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_mant_ubica = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_mante_material = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_puestos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_tip_Identif = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_RH = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_nomina = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_reclutamiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_capacitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_capac = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_report = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_recibo_provee = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_inv_sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_conteo_ciclico = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_ajuste_inv = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_punto_reorden = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_orden_ser_inv = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_Factura = new System.Windows.Forms.ToolStripMenuItem();
            this.tstItem_facturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.tstItem_combustib = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst_principal
            // 
            this.mst_principal.AutoSize = false;
            this.mst_principal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mst_principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mst_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_seguridad,
            this.tst_Servicios_Ope,
            this.tst_catalogos,
            this.tst_RH,
            this.tst_Inventario,
            this.tst_Factura});
            this.mst_principal.Location = new System.Drawing.Point(0, 0);
            this.mst_principal.Name = "mst_principal";
            this.mst_principal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mst_principal.Size = new System.Drawing.Size(1226, 69);
            this.mst_principal.TabIndex = 0;
            // 
            // tst_seguridad
            // 
            this.tst_seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_recupera_contrase,
            this.tstItem_cambia_contrase});
            this.tst_seguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tst_seguridad.Image = global::Lubricentro_Millas.Properties.Resources.Orden__meca;
            this.tst_seguridad.Name = "tst_seguridad";
            this.tst_seguridad.Size = new System.Drawing.Size(137, 65);
            this.tst_seguridad.Text = "Seguridad";
            // 
            // tstItem_recupera_contrase
            // 
            this.tstItem_recupera_contrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_recupera_contrase.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_recupera_contrase.ForeColor = System.Drawing.Color.Black;
            this.tstItem_recupera_contrase.Image = global::Lubricentro_Millas.Properties.Resources.recoverPassw;
            this.tstItem_recupera_contrase.Name = "tstItem_recupera_contrase";
            this.tstItem_recupera_contrase.Size = new System.Drawing.Size(329, 26);
            this.tstItem_recupera_contrase.Text = "Recuperacion de Contraseña";
            this.tstItem_recupera_contrase.Click += new System.EventHandler(this.tstItem_recupera_contrase_Click);
            // 
            // tstItem_cambia_contrase
            // 
            this.tstItem_cambia_contrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tstItem_cambia_contrase.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_cambia_contrase.ForeColor = System.Drawing.Color.Black;
            this.tstItem_cambia_contrase.Image = global::Lubricentro_Millas.Properties.Resources.cambioPassw;
            this.tstItem_cambia_contrase.Name = "tstItem_cambia_contrase";
            this.tstItem_cambia_contrase.Size = new System.Drawing.Size(329, 26);
            this.tstItem_cambia_contrase.Text = "Cambiar Contraseña";
            this.tstItem_cambia_contrase.Click += new System.EventHandler(this.tstItem_cambia_contrase_Click);
            // 
            // tst_Servicios_Ope
            // 
            this.tst_Servicios_Ope.BackColor = System.Drawing.Color.White;
            this.tst_Servicios_Ope.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_citas,
            this.tstItem_cliente,
            this.tstItem_ordenServ_mecan});
            this.tst_Servicios_Ope.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tst_Servicios_Ope.Image = global::Lubricentro_Millas.Properties.Resources.servicOper;
            this.tst_Servicios_Ope.Name = "tst_Servicios_Ope";
            this.tst_Servicios_Ope.Size = new System.Drawing.Size(236, 65);
            this.tst_Servicios_Ope.Text = "Servicios Operativos";
            // 
            // tstItem_citas
            // 
            this.tstItem_citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_citas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_crear_cita,
            this.tstItem_modif_cita,
            this.tstItem_cancela_cita});
            this.tstItem_citas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_citas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_citas.Image = global::Lubricentro_Millas.Properties.Resources.calendar;
            this.tstItem_citas.Name = "tstItem_citas";
            this.tstItem_citas.Size = new System.Drawing.Size(237, 26);
            this.tstItem_citas.Text = "Citas";
            // 
            // tstItem_crear_cita
            // 
            this.tstItem_crear_cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_crear_cita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_crear_cita.Image = global::Lubricentro_Millas.Properties.Resources.add;
            this.tstItem_crear_cita.Name = "tstItem_crear_cita";
            this.tstItem_crear_cita.Size = new System.Drawing.Size(210, 26);
            this.tstItem_crear_cita.Text = "Crear Cita";
            this.tstItem_crear_cita.Click += new System.EventHandler(this.tstItem_crear_cita_Click);
            // 
            // tstItem_modif_cita
            // 
            this.tstItem_modif_cita.ForeColor = System.Drawing.Color.Black;
            this.tstItem_modif_cita.Image = global::Lubricentro_Millas.Properties.Resources.update;
            this.tstItem_modif_cita.Name = "tstItem_modif_cita";
            this.tstItem_modif_cita.Size = new System.Drawing.Size(210, 26);
            this.tstItem_modif_cita.Text = "Modificar Citas";
            this.tstItem_modif_cita.Click += new System.EventHandler(this.tstItem_modif_cita_Click);
            // 
            // tstItem_cancela_cita
            // 
            this.tstItem_cancela_cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_cancela_cita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_cancela_cita.Image = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.tstItem_cancela_cita.Name = "tstItem_cancela_cita";
            this.tstItem_cancela_cita.Size = new System.Drawing.Size(210, 26);
            this.tstItem_cancela_cita.Text = "Cancelar Citas";
            this.tstItem_cancela_cita.Click += new System.EventHandler(this.tstItem_cancela_cita_Click);
            // 
            // tstItem_cliente
            // 
            this.tstItem_cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_registra_cliente,
            this.tstItem_modif_cliente,
            this.tstItem_clientes});
            this.tstItem_cliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_cliente.ForeColor = System.Drawing.Color.Black;
            this.tstItem_cliente.Image = global::Lubricentro_Millas.Properties.Resources.users;
            this.tstItem_cliente.Name = "tstItem_cliente";
            this.tstItem_cliente.Size = new System.Drawing.Size(237, 26);
            this.tstItem_cliente.Text = "Cliente";
            // 
            // tstItem_registra_cliente
            // 
            this.tstItem_registra_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_registra_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_registra_cliente.Image = global::Lubricentro_Millas.Properties.Resources.adduser;
            this.tstItem_registra_cliente.Name = "tstItem_registra_cliente";
            this.tstItem_registra_cliente.Size = new System.Drawing.Size(228, 26);
            this.tstItem_registra_cliente.Text = "Registrar Cliente";
            this.tstItem_registra_cliente.Click += new System.EventHandler(this.tstItem_registra_cliente_Click);
            // 
            // tstItem_modif_cliente
            // 
            this.tstItem_modif_cliente.Image = global::Lubricentro_Millas.Properties.Resources.update;
            this.tstItem_modif_cliente.Name = "tstItem_modif_cliente";
            this.tstItem_modif_cliente.Size = new System.Drawing.Size(228, 26);
            this.tstItem_modif_cliente.Text = "Modificar Cliente";
            this.tstItem_modif_cliente.Click += new System.EventHandler(this.tstItem_modif_cliente_Click);
            // 
            // tstItem_clientes
            // 
            this.tstItem_clientes.Image = global::Lubricentro_Millas.Properties.Resources.users;
            this.tstItem_clientes.Name = "tstItem_clientes";
            this.tstItem_clientes.Size = new System.Drawing.Size(228, 26);
            this.tstItem_clientes.Text = "Lista Clientes";
            this.tstItem_clientes.Click += new System.EventHandler(this.tstItem_clientes_Click);
            // 
            // tstItem_ordenServ_mecan
            // 
            this.tstItem_ordenServ_mecan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_ordenServ_mecan.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_ordenServ_mecan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_ordenServ_mecan.Image = global::Lubricentro_Millas.Properties.Resources.Orden__meca;
            this.tstItem_ordenServ_mecan.Name = "tstItem_ordenServ_mecan";
            this.tstItem_ordenServ_mecan.Size = new System.Drawing.Size(237, 26);
            this.tstItem_ordenServ_mecan.Text = "Orden de Servicio";
            this.tstItem_ordenServ_mecan.Click += new System.EventHandler(this.tstItem_ordenServ_mecan_Click);
            // 
            // tst_catalogos
            // 
            this.tst_catalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_vehiculo,
            this.tstItem_cantidad,
            this.tstItem_unidad,
            this.tstItem_insumos,
            this.tstItem_roles,
            this.tstItem_servicios,
            this.tstItem_estados,
            this.tstItem_mant_ubica,
            this.tstItem_mante_material,
            this.tstItem_puestos,
            this.tstItem_tip_Identif,
            this.tstItem_combustib});
            this.tst_catalogos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tst_catalogos.Image = global::Lubricentro_Millas.Properties.Resources.add_admin;
            this.tst_catalogos.Name = "tst_catalogos";
            this.tst_catalogos.Size = new System.Drawing.Size(141, 65);
            this.tst_catalogos.Text = "Catálogos ";
            // 
            // tstItem_vehiculo
            // 
            this.tstItem_vehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_vehiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_modelos,
            this.tstItem_marcas,
            this.tstItem_motor_tam,
            this.tstItem_tipoVehiculo});
            this.tstItem_vehiculo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_vehiculo.Name = "tstItem_vehiculo";
            this.tstItem_vehiculo.Size = new System.Drawing.Size(346, 26);
            this.tstItem_vehiculo.Text = "Vehículos";
            // 
            // tstItem_modelos
            // 
            this.tstItem_modelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_modelos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_modelos.Name = "tstItem_modelos";
            this.tstItem_modelos.Size = new System.Drawing.Size(231, 26);
            this.tstItem_modelos.Text = "Modelos";
            this.tstItem_modelos.Click += new System.EventHandler(this.tstItem_modelos_Click);
            // 
            // tstItem_marcas
            // 
            this.tstItem_marcas.ForeColor = System.Drawing.Color.Black;
            this.tstItem_marcas.Name = "tstItem_marcas";
            this.tstItem_marcas.Size = new System.Drawing.Size(231, 26);
            this.tstItem_marcas.Text = "Marcas";
            this.tstItem_marcas.Click += new System.EventHandler(this.tstItem_marcas_Click);
            // 
            // tstItem_motor_tam
            // 
            this.tstItem_motor_tam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_motor_tam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_motor_tam.Name = "tstItem_motor_tam";
            this.tstItem_motor_tam.Size = new System.Drawing.Size(231, 26);
            this.tstItem_motor_tam.Text = "Tamaño de Motor";
            this.tstItem_motor_tam.Click += new System.EventHandler(this.tstItem_motor_tam_Click);
            // 
            // tstItem_tipoVehiculo
            // 
            this.tstItem_tipoVehiculo.ForeColor = System.Drawing.Color.Black;
            this.tstItem_tipoVehiculo.Name = "tstItem_tipoVehiculo";
            this.tstItem_tipoVehiculo.Size = new System.Drawing.Size(231, 26);
            this.tstItem_tipoVehiculo.Text = "Tipo de Vehículo";
            this.tstItem_tipoVehiculo.Click += new System.EventHandler(this.tstItem_tipoVehiculo_Click);
            // 
            // tstItem_cantidad
            // 
            this.tstItem_cantidad.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_cantidad.ForeColor = System.Drawing.Color.Black;
            this.tstItem_cantidad.Name = "tstItem_cantidad";
            this.tstItem_cantidad.Size = new System.Drawing.Size(346, 26);
            this.tstItem_cantidad.Text = "Cantidad Aceite Por Motor";
            this.tstItem_cantidad.Click += new System.EventHandler(this.tstItem_cantidad_Click);
            // 
            // tstItem_unidad
            // 
            this.tstItem_unidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_unidad.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_unidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_unidad.Name = "tstItem_unidad";
            this.tstItem_unidad.Size = new System.Drawing.Size(346, 26);
            this.tstItem_unidad.Text = "Unidad de Medida";
            this.tstItem_unidad.Click += new System.EventHandler(this.tstItem_unidad_Click);
            // 
            // tstItem_insumos
            // 
            this.tstItem_insumos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_insumos.ForeColor = System.Drawing.Color.Black;
            this.tstItem_insumos.Name = "tstItem_insumos";
            this.tstItem_insumos.Size = new System.Drawing.Size(346, 26);
            this.tstItem_insumos.Text = "Insumos";
            this.tstItem_insumos.Click += new System.EventHandler(this.tstItem_insumos_Click);
            // 
            // tstItem_roles
            // 
            this.tstItem_roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_roles.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_roles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_roles.Name = "tstItem_roles";
            this.tstItem_roles.Size = new System.Drawing.Size(346, 26);
            this.tstItem_roles.Text = "Roles";
            this.tstItem_roles.Click += new System.EventHandler(this.tstItem_roles_Click);
            // 
            // tstItem_servicios
            // 
            this.tstItem_servicios.BackColor = System.Drawing.Color.White;
            this.tstItem_servicios.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_servicios.ForeColor = System.Drawing.Color.Black;
            this.tstItem_servicios.Name = "tstItem_servicios";
            this.tstItem_servicios.Size = new System.Drawing.Size(346, 26);
            this.tstItem_servicios.Text = "Servicios";
            this.tstItem_servicios.Click += new System.EventHandler(this.tstItem_servicios_Click);
            // 
            // tstItem_estados
            // 
            this.tstItem_estados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_estados.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_estados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_estados.Name = "tstItem_estados";
            this.tstItem_estados.Size = new System.Drawing.Size(346, 26);
            this.tstItem_estados.Text = "Estados";
            this.tstItem_estados.Click += new System.EventHandler(this.tstItem_estados_Click);
            // 
            // tstItem_mant_ubica
            // 
            this.tstItem_mant_ubica.BackColor = System.Drawing.Color.White;
            this.tstItem_mant_ubica.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_mant_ubica.ForeColor = System.Drawing.Color.Black;
            this.tstItem_mant_ubica.Image = global::Lubricentro_Millas.Properties.Resources.estante;
            this.tstItem_mant_ubica.Name = "tstItem_mant_ubica";
            this.tstItem_mant_ubica.Size = new System.Drawing.Size(346, 26);
            this.tstItem_mant_ubica.Text = "Mantenimiento de Ubicaciones";
            // 
            // tstItem_mante_material
            // 
            this.tstItem_mante_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_mante_material.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_mante_material.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_mante_material.Image = global::Lubricentro_Millas.Properties.Resources.insumo;
            this.tstItem_mante_material.Name = "tstItem_mante_material";
            this.tstItem_mante_material.Size = new System.Drawing.Size(346, 26);
            this.tstItem_mante_material.Text = "Mantenimiento de Materiales";
            // 
            // tstItem_puestos
            // 
            this.tstItem_puestos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_puestos.Name = "tstItem_puestos";
            this.tstItem_puestos.Size = new System.Drawing.Size(346, 26);
            this.tstItem_puestos.Text = "Puestos de Trabajo";
            this.tstItem_puestos.Click += new System.EventHandler(this.tstItem_puestos_Click);
            // 
            // tstItem_tip_Identif
            // 
            this.tstItem_tip_Identif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_tip_Identif.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_tip_Identif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_tip_Identif.Name = "tstItem_tip_Identif";
            this.tstItem_tip_Identif.Size = new System.Drawing.Size(346, 26);
            this.tstItem_tip_Identif.Text = "Tipos de Indentificaciones";
            this.tstItem_tip_Identif.Click += new System.EventHandler(this.tstItem_tip_Identif_Click);
            // 
            // tst_RH
            // 
            this.tst_RH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_nomina,
            this.tstItem_reclutamiento,
            this.tstItem_capacitacion});
            this.tst_RH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tst_RH.Image = global::Lubricentro_Millas.Properties.Resources.RH;
            this.tst_RH.Name = "tst_RH";
            this.tst_RH.Size = new System.Drawing.Size(222, 65);
            this.tst_RH.Text = "Recursos Humanos";
            // 
            // tstItem_nomina
            // 
            this.tstItem_nomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_nomina.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_nomina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_nomina.Image = global::Lubricentro_Millas.Properties.Resources.nomina;
            this.tstItem_nomina.Name = "tstItem_nomina";
            this.tstItem_nomina.Size = new System.Drawing.Size(311, 26);
            this.tstItem_nomina.Text = "Nómina";
            this.tstItem_nomina.Click += new System.EventHandler(this.tstItem_nomina_Click);
            // 
            // tstItem_reclutamiento
            // 
            this.tstItem_reclutamiento.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_reclutamiento.ForeColor = System.Drawing.Color.Black;
            this.tstItem_reclutamiento.Image = global::Lubricentro_Millas.Properties.Resources.search;
            this.tstItem_reclutamiento.Name = "tstItem_reclutamiento";
            this.tstItem_reclutamiento.Size = new System.Drawing.Size(311, 26);
            this.tstItem_reclutamiento.Text = "Reclutamiento y Selección";
            this.tstItem_reclutamiento.Click += new System.EventHandler(this.tstItem_reclutamiento_Click);
            // 
            // tstItem_capacitacion
            // 
            this.tstItem_capacitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_capacitacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_capac,
            this.tstItem_report,
            this.tstItem_proveedor});
            this.tstItem_capacitacion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_capacitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_capacitacion.Image = global::Lubricentro_Millas.Properties.Resources.capacitac;
            this.tstItem_capacitacion.Name = "tstItem_capacitacion";
            this.tstItem_capacitacion.Size = new System.Drawing.Size(311, 26);
            this.tstItem_capacitacion.Text = "Capacitación y Desarrollo";
            // 
            // tstItem_capac
            // 
            this.tstItem_capac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_capac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_capac.Image = global::Lubricentro_Millas.Properties.Resources.capacitac;
            this.tstItem_capac.Name = "tstItem_capac";
            this.tstItem_capac.Size = new System.Drawing.Size(212, 26);
            this.tstItem_capac.Text = "Capacitaciones";
            this.tstItem_capac.Click += new System.EventHandler(this.tstItem_capac_Click);
            // 
            // tstItem_report
            // 
            this.tstItem_report.ForeColor = System.Drawing.Color.Black;
            this.tstItem_report.Image = global::Lubricentro_Millas.Properties.Resources.report;
            this.tstItem_report.Name = "tstItem_report";
            this.tstItem_report.Size = new System.Drawing.Size(212, 26);
            this.tstItem_report.Text = "Reportes";
            this.tstItem_report.Click += new System.EventHandler(this.tstItem_report_Click);
            // 
            // tstItem_proveedor
            // 
            this.tstItem_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_proveedor.Image = global::Lubricentro_Millas.Properties.Resources.users;
            this.tstItem_proveedor.Name = "tstItem_proveedor";
            this.tstItem_proveedor.Size = new System.Drawing.Size(212, 26);
            this.tstItem_proveedor.Text = "Proveedores";
            this.tstItem_proveedor.Click += new System.EventHandler(this.tstItem_proveedor_Click);
            // 
            // tst_Inventario
            // 
            this.tst_Inventario.BackColor = System.Drawing.Color.White;
            this.tst_Inventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_recibo_provee,
            this.tstItem_inv_sistema,
            this.tstItem_conteo_ciclico,
            this.tstItem_ajuste_inv,
            this.tstItem_punto_reorden,
            this.tstItem_orden_ser_inv});
            this.tst_Inventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tst_Inventario.Image = global::Lubricentro_Millas.Properties.Resources.inventario;
            this.tst_Inventario.Name = "tst_Inventario";
            this.tst_Inventario.Size = new System.Drawing.Size(141, 65);
            this.tst_Inventario.Text = "Inventario";
            // 
            // tstItem_recibo_provee
            // 
            this.tstItem_recibo_provee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_recibo_provee.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_recibo_provee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tstItem_recibo_provee.Image = global::Lubricentro_Millas.Properties.Resources.orden_invent;
            this.tstItem_recibo_provee.Name = "tstItem_recibo_provee";
            this.tstItem_recibo_provee.Size = new System.Drawing.Size(278, 26);
            this.tstItem_recibo_provee.Text = "Recibo de Proveedores";
            this.tstItem_recibo_provee.Click += new System.EventHandler(this.tstItem_recibo_provee_Click);
            // 
            // tstItem_inv_sistema
            // 
            this.tstItem_inv_sistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tstItem_inv_sistema.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_inv_sistema.ForeColor = System.Drawing.Color.Black;
            this.tstItem_inv_sistema.Image = global::Lubricentro_Millas.Properties.Resources.inventario;
            this.tstItem_inv_sistema.Name = "tstItem_inv_sistema";
            this.tstItem_inv_sistema.Size = new System.Drawing.Size(278, 26);
            this.tstItem_inv_sistema.Text = "Inventario en Sistema";
            this.tstItem_inv_sistema.Click += new System.EventHandler(this.tstItem_inv_sistema_Click);
            // 
            // tstItem_conteo_ciclico
            // 
            this.tstItem_conteo_ciclico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_conteo_ciclico.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_conteo_ciclico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tstItem_conteo_ciclico.Image = global::Lubricentro_Millas.Properties.Resources.conteo;
            this.tstItem_conteo_ciclico.Name = "tstItem_conteo_ciclico";
            this.tstItem_conteo_ciclico.Size = new System.Drawing.Size(278, 26);
            this.tstItem_conteo_ciclico.Text = "Conteo Cíclico";
            this.tstItem_conteo_ciclico.Click += new System.EventHandler(this.tstItem_conteo_ciclico_Click);
            // 
            // tstItem_ajuste_inv
            // 
            this.tstItem_ajuste_inv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tstItem_ajuste_inv.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_ajuste_inv.ForeColor = System.Drawing.Color.Black;
            this.tstItem_ajuste_inv.Image = global::Lubricentro_Millas.Properties.Resources.ajust_inve;
            this.tstItem_ajuste_inv.Name = "tstItem_ajuste_inv";
            this.tstItem_ajuste_inv.Size = new System.Drawing.Size(278, 26);
            this.tstItem_ajuste_inv.Text = "Ajustes de Inventario";
            this.tstItem_ajuste_inv.Click += new System.EventHandler(this.tstItem_ajuste_inv_Click);
            // 
            // tstItem_punto_reorden
            // 
            this.tstItem_punto_reorden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_punto_reorden.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_punto_reorden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tstItem_punto_reorden.Image = global::Lubricentro_Millas.Properties.Resources.reorden;
            this.tstItem_punto_reorden.Name = "tstItem_punto_reorden";
            this.tstItem_punto_reorden.Size = new System.Drawing.Size(278, 26);
            this.tstItem_punto_reorden.Text = "Puntos de Re-Orden";
            this.tstItem_punto_reorden.Click += new System.EventHandler(this.tstItem_punto_reorden_Click);
            // 
            // tstItem_orden_ser_inv
            // 
            this.tstItem_orden_ser_inv.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_orden_ser_inv.ForeColor = System.Drawing.Color.Black;
            this.tstItem_orden_ser_inv.Image = global::Lubricentro_Millas.Properties.Resources.orden_invent;
            this.tstItem_orden_ser_inv.Name = "tstItem_orden_ser_inv";
            this.tstItem_orden_ser_inv.Size = new System.Drawing.Size(278, 26);
            this.tstItem_orden_ser_inv.Text = "Orden de Servicio";
            this.tstItem_orden_ser_inv.Click += new System.EventHandler(this.tstItem_orden_ser_inv_Click);
            // 
            // tst_Factura
            // 
            this.tst_Factura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstItem_facturacion});
            this.tst_Factura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tst_Factura.Image = global::Lubricentro_Millas.Properties.Resources.factura;
            this.tst_Factura.Name = "tst_Factura";
            this.tst_Factura.Size = new System.Drawing.Size(152, 65);
            this.tst_Factura.Text = "Facturación";
            // 
            // tstItem_facturacion
            // 
            this.tstItem_facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.tstItem_facturacion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_facturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tstItem_facturacion.Image = global::Lubricentro_Millas.Properties.Resources.factura;
            this.tstItem_facturacion.Name = "tstItem_facturacion";
            this.tstItem_facturacion.Size = new System.Drawing.Size(221, 26);
            this.tstItem_facturacion.Text = "Generar Factura";
            this.tstItem_facturacion.Click += new System.EventHandler(this.tstItem_facturacion_Click);
            // 
            // pnl_principal
            // 
            this.pnl_principal.BackColor = System.Drawing.Color.Transparent;
            this.pnl_principal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_principal.Location = new System.Drawing.Point(0, 66);
            this.pnl_principal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(1222, 779);
            this.pnl_principal.TabIndex = 1;
            // 
            // tstItem_combustib
            // 
            this.tstItem_combustib.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstItem_combustib.Name = "tstItem_combustib";
            this.tstItem_combustib.Size = new System.Drawing.Size(346, 26);
            this.tstItem_combustib.Text = "Combustibles";
            this.tstItem_combustib.Click += new System.EventHandler(this.tstItem_combustib_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.Untitled_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 839);
            this.Controls.Add(this.pnl_principal);
            this.Controls.Add(this.mst_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taller Lubricentro Millas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_principal_FormClosing);
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.mst_principal.ResumeLayout(false);
            this.mst_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mst_principal;
        private System.Windows.Forms.ToolStripMenuItem tst_seguridad;
        private System.Windows.Forms.ToolStripMenuItem tst_Inventario;
        private System.Windows.Forms.ToolStripMenuItem tstItem_recibo_provee;
        private System.Windows.Forms.ToolStripMenuItem tstItem_inv_sistema;
        private System.Windows.Forms.ToolStripMenuItem tstItem_conteo_ciclico;
        private System.Windows.Forms.ToolStripMenuItem tstItem_ajuste_inv;
        private System.Windows.Forms.ToolStripMenuItem tstItem_punto_reorden;
        private System.Windows.Forms.ToolStripMenuItem tst_Factura;
        private System.Windows.Forms.ToolStripMenuItem tstItem_recupera_contrase;
        private System.Windows.Forms.ToolStripMenuItem tstItem_cambia_contrase;
        private System.Windows.Forms.ToolStripMenuItem tst_Servicios_Ope;
        private System.Windows.Forms.ToolStripMenuItem tstItem_citas;
        private System.Windows.Forms.ToolStripMenuItem tstItem_cliente;
        private System.Windows.Forms.ToolStripMenuItem tstItem_ordenServ_mecan;
        private System.Windows.Forms.ToolStripMenuItem tst_RH;
        private System.Windows.Forms.ToolStripMenuItem tstItem_nomina;
        private System.Windows.Forms.ToolStripMenuItem tstItem_reclutamiento;
        private System.Windows.Forms.ToolStripMenuItem tstItem_capacitacion;
        private System.Windows.Forms.ToolStripMenuItem tst_catalogos;
        private System.Windows.Forms.ToolStripMenuItem tstItem_vehiculo;
        private System.Windows.Forms.ToolStripMenuItem tstItem_cantidad;
        private System.Windows.Forms.ToolStripMenuItem tstItem_unidad;
        private System.Windows.Forms.ToolStripMenuItem tstItem_insumos;
        private System.Windows.Forms.ToolStripMenuItem tstItem_servicios;
        private System.Windows.Forms.ToolStripMenuItem tstItem_estados;
        private System.Windows.Forms.ToolStripMenuItem tstItem_orden_ser_inv;
        private System.Windows.Forms.ToolStripMenuItem tstItem_crear_cita;
        private System.Windows.Forms.ToolStripMenuItem tstItem_modif_cita;
        private System.Windows.Forms.ToolStripMenuItem tstItem_cancela_cita;
        private System.Windows.Forms.ToolStripMenuItem tstItem_registra_cliente;
        private System.Windows.Forms.ToolStripMenuItem tstItem_modif_cliente;
        private System.Windows.Forms.ToolStripMenuItem tstItem_facturacion;
        private System.Windows.Forms.ToolStripMenuItem tstItem_modelos;
        private System.Windows.Forms.ToolStripMenuItem tstItem_marcas;
        private System.Windows.Forms.ToolStripMenuItem tstItem_motor_tam;
        private System.Windows.Forms.ToolStripMenuItem tstItem_tipoVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tstItem_clientes;
        private System.Windows.Forms.ToolStripMenuItem tstItem_mant_ubica;
        private System.Windows.Forms.ToolStripMenuItem tstItem_mante_material;
        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.ToolStripMenuItem tstItem_capac;
        private System.Windows.Forms.ToolStripMenuItem tstItem_report;
        private System.Windows.Forms.ToolStripMenuItem tstItem_proveedor;
        private System.Windows.Forms.ToolStripMenuItem tstItem_roles;
        private System.Windows.Forms.ToolStripMenuItem tstItem_puestos;
        private System.Windows.Forms.ToolStripMenuItem tstItem_tip_Identif;
        private System.Windows.Forms.ToolStripMenuItem tstItem_combustib;
    }
}
namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_modifica_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modifica_empleado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_identifica = new System.Windows.Forms.TextBox();
            this.rbtn_pasaporte = new System.Windows.Forms.RadioButton();
            this.rbtn_residencia = new System.Windows.Forms.RadioButton();
            this.rbtn_cedula = new System.Windows.Forms.RadioButton();
            this.gbx_datos_vehic = new System.Windows.Forms.GroupBox();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_puesto = new System.Windows.Forms.Label();
            this.gbx_datos_person = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telef2 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_seg_ape = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_prim_ape = new System.Windows.Forms.TextBox();
            this.lbl_seg_ape = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_prim_ape = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_horas_extr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbx_datos_vehic.SuspendLayout();
            this.gbx_datos_person.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_identifica);
            this.groupBox1.Controls.Add(this.rbtn_pasaporte);
            this.groupBox1.Controls.Add(this.rbtn_residencia);
            this.groupBox1.Controls.Add(this.rbtn_cedula);
            this.groupBox1.Controls.Add(this.btn_verificar);
            this.groupBox1.Location = new System.Drawing.Point(50, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_identifica
            // 
            this.txt_identifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_identifica.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identifica.ForeColor = System.Drawing.Color.Black;
            this.txt_identifica.Location = new System.Drawing.Point(77, 44);
            this.txt_identifica.Margin = new System.Windows.Forms.Padding(4);
            this.txt_identifica.MaxLength = 9;
            this.txt_identifica.Multiline = true;
            this.txt_identifica.Name = "txt_identifica";
            this.txt_identifica.Size = new System.Drawing.Size(360, 30);
            this.txt_identifica.TabIndex = 4;
            this.txt_identifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtn_pasaporte
            // 
            this.rbtn_pasaporte.AutoSize = true;
            this.rbtn_pasaporte.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_pasaporte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_pasaporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_pasaporte.Location = new System.Drawing.Point(157, 19);
            this.rbtn_pasaporte.Name = "rbtn_pasaporte";
            this.rbtn_pasaporte.Size = new System.Drawing.Size(124, 21);
            this.rbtn_pasaporte.TabIndex = 2;
            this.rbtn_pasaporte.TabStop = true;
            this.rbtn_pasaporte.Text = "# Pasaporte";
            this.rbtn_pasaporte.UseVisualStyleBackColor = false;
            // 
            // rbtn_residencia
            // 
            this.rbtn_residencia.AutoSize = true;
            this.rbtn_residencia.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_residencia.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_residencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_residencia.Location = new System.Drawing.Point(304, 19);
            this.rbtn_residencia.Name = "rbtn_residencia";
            this.rbtn_residencia.Size = new System.Drawing.Size(152, 21);
            this.rbtn_residencia.TabIndex = 3;
            this.rbtn_residencia.TabStop = true;
            this.rbtn_residencia.Text = "# ID Residencia";
            this.rbtn_residencia.UseVisualStyleBackColor = false;
            // 
            // rbtn_cedula
            // 
            this.rbtn_cedula.AutoSize = true;
            this.rbtn_cedula.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_cedula.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbtn_cedula.Location = new System.Drawing.Point(52, 19);
            this.rbtn_cedula.Name = "rbtn_cedula";
            this.rbtn_cedula.Size = new System.Drawing.Size(82, 21);
            this.rbtn_cedula.TabIndex = 1;
            this.rbtn_cedula.TabStop = true;
            this.rbtn_cedula.Text = "Cédula";
            this.rbtn_cedula.UseVisualStyleBackColor = false;
            // 
            // gbx_datos_vehic
            // 
            this.gbx_datos_vehic.Controls.Add(this.txt_salario);
            this.gbx_datos_vehic.Controls.Add(this.cbx_estado);
            this.gbx_datos_vehic.Controls.Add(this.lbl_estado);
            this.gbx_datos_vehic.Controls.Add(this.txt_puesto);
            this.gbx_datos_vehic.Controls.Add(this.lbl_salario);
            this.gbx_datos_vehic.Controls.Add(this.lbl_puesto);
            this.gbx_datos_vehic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos_vehic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_datos_vehic.Location = new System.Drawing.Point(50, 390);
            this.gbx_datos_vehic.Name = "gbx_datos_vehic";
            this.gbx_datos_vehic.Size = new System.Drawing.Size(468, 147);
            this.gbx_datos_vehic.TabIndex = 23;
            this.gbx_datos_vehic.TabStop = false;
            this.gbx_datos_vehic.Text = "Datos del Laborales";
            // 
            // txt_salario
            // 
            this.txt_salario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_salario.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salario.ForeColor = System.Drawing.Color.Black;
            this.txt_salario.Location = new System.Drawing.Point(190, 76);
            this.txt_salario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salario.MaxLength = 9;
            this.txt_salario.Multiline = true;
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(225, 30);
            this.txt_salario.TabIndex = 27;
            // 
            // cbx_estado
            // 
            this.cbx_estado.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbx_estado.ForeColor = System.Drawing.Color.White;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(190, 112);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(225, 24);
            this.cbx_estado.TabIndex = 29;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_estado.Location = new System.Drawing.Point(95, 115);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(61, 17);
            this.lbl_estado.TabIndex = 28;
            this.lbl_estado.Text = "Estado";
            // 
            // txt_puesto
            // 
            this.txt_puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_puesto.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puesto.ForeColor = System.Drawing.Color.Black;
            this.txt_puesto.Location = new System.Drawing.Point(190, 38);
            this.txt_puesto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_puesto.MaxLength = 9;
            this.txt_puesto.Multiline = true;
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(225, 30);
            this.txt_puesto.TabIndex = 25;
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salario.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_salario.Location = new System.Drawing.Point(95, 79);
            this.lbl_salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(61, 17);
            this.lbl_salario.TabIndex = 26;
            this.lbl_salario.Text = "Salario";
            // 
            // lbl_puesto
            // 
            this.lbl_puesto.AutoSize = true;
            this.lbl_puesto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_puesto.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_puesto.Location = new System.Drawing.Point(95, 41);
            this.lbl_puesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_puesto.Name = "lbl_puesto";
            this.lbl_puesto.Size = new System.Drawing.Size(61, 17);
            this.lbl_puesto.TabIndex = 24;
            this.lbl_puesto.Text = "Puesto";
            // 
            // gbx_datos_person
            // 
            this.gbx_datos_person.BackColor = System.Drawing.Color.Transparent;
            this.gbx_datos_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbx_datos_person.Controls.Add(this.txt_id);
            this.gbx_datos_person.Controls.Add(this.label1);
            this.gbx_datos_person.Controls.Add(this.txt_telefono);
            this.gbx_datos_person.Controls.Add(this.lbl_telef2);
            this.gbx_datos_person.Controls.Add(this.txt_direccion);
            this.gbx_datos_person.Controls.Add(this.txt_nombre);
            this.gbx_datos_person.Controls.Add(this.txt_seg_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_nombre);
            this.gbx_datos_person.Controls.Add(this.txt_prim_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_seg_ape);
            this.gbx_datos_person.Controls.Add(this.txt_edad);
            this.gbx_datos_person.Controls.Add(this.lbl_direccion);
            this.gbx_datos_person.Controls.Add(this.txt_correo);
            this.gbx_datos_person.Controls.Add(this.lbl_correo);
            this.gbx_datos_person.Controls.Add(this.lbl_prim_ape);
            this.gbx_datos_person.Controls.Add(this.lbl_edad);
            this.gbx_datos_person.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos_person.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_datos_person.Location = new System.Drawing.Point(575, 113);
            this.gbx_datos_person.Name = "gbx_datos_person";
            this.gbx_datos_person.Size = new System.Drawing.Size(588, 424);
            this.gbx_datos_person.TabIndex = 6;
            this.gbx_datos_person.TabStop = false;
            this.gbx_datos_person.Text = "Datos Personales";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(209, 25);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.MaxLength = 25;
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(360, 30);
            this.txt_id.TabIndex = 8;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(128, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telefono.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono.Location = new System.Drawing.Point(209, 219);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefono.MaxLength = 25;
            this.txt_telefono.Multiline = true;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(360, 30);
            this.txt_telefono.TabIndex = 18;
            this.txt_telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_telef2
            // 
            this.lbl_telef2.AutoSize = true;
            this.lbl_telef2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telef2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telef2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_telef2.Location = new System.Drawing.Point(81, 232);
            this.lbl_telef2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telef2.Name = "lbl_telef2";
            this.lbl_telef2.Size = new System.Drawing.Size(76, 17);
            this.lbl_telef2.TabIndex = 17;
            this.lbl_telef2.Text = "Teléfono";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_direccion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.Color.Black;
            this.txt_direccion.Location = new System.Drawing.Point(209, 312);
            this.txt_direccion.MaxLength = 125;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(360, 85);
            this.txt_direccion.TabIndex = 22;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(209, 63);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(360, 30);
            this.txt_nombre.TabIndex = 10;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_seg_ape
            // 
            this.txt_seg_ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_seg_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seg_ape.ForeColor = System.Drawing.Color.Black;
            this.txt_seg_ape.Location = new System.Drawing.Point(209, 139);
            this.txt_seg_ape.Margin = new System.Windows.Forms.Padding(4);
            this.txt_seg_ape.MaxLength = 25;
            this.txt_seg_ape.Multiline = true;
            this.txt_seg_ape.Name = "txt_seg_ape";
            this.txt_seg_ape.Size = new System.Drawing.Size(360, 30);
            this.txt_seg_ape.TabIndex = 14;
            this.txt_seg_ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_nombre.Location = new System.Drawing.Point(88, 76);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(69, 17);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_prim_ape
            // 
            this.txt_prim_ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_prim_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prim_ape.ForeColor = System.Drawing.Color.Black;
            this.txt_prim_ape.Location = new System.Drawing.Point(209, 101);
            this.txt_prim_ape.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prim_ape.MaxLength = 25;
            this.txt_prim_ape.Multiline = true;
            this.txt_prim_ape.Name = "txt_prim_ape";
            this.txt_prim_ape.Size = new System.Drawing.Size(360, 30);
            this.txt_prim_ape.TabIndex = 12;
            this.txt_prim_ape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_seg_ape
            // 
            this.lbl_seg_ape.AutoSize = true;
            this.lbl_seg_ape.BackColor = System.Drawing.Color.Transparent;
            this.lbl_seg_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seg_ape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_seg_ape.Location = new System.Drawing.Point(18, 152);
            this.lbl_seg_ape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_seg_ape.Name = "lbl_seg_ape";
            this.lbl_seg_ape.Size = new System.Drawing.Size(144, 17);
            this.lbl_seg_ape.TabIndex = 13;
            this.lbl_seg_ape.Text = "Segundo Apellido";
            // 
            // txt_edad
            // 
            this.txt_edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_edad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.ForeColor = System.Drawing.Color.Black;
            this.txt_edad.Location = new System.Drawing.Point(209, 177);
            this.txt_edad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_edad.MaxLength = 10;
            this.txt_edad.Multiline = true;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(360, 30);
            this.txt_edad.TabIndex = 16;
            this.txt_edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_direccion.Location = new System.Drawing.Point(76, 343);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(79, 17);
            this.lbl_direccion.TabIndex = 21;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_correo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(209, 264);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.MaxLength = 25;
            this.txt_correo.Multiline = true;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(360, 30);
            this.txt_correo.TabIndex = 20;
            this.txt_correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_correo.Location = new System.Drawing.Point(11, 277);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(153, 17);
            this.lbl_correo.TabIndex = 19;
            this.lbl_correo.Text = "Correo Electrónico";
            // 
            // lbl_prim_ape
            // 
            this.lbl_prim_ape.AutoSize = true;
            this.lbl_prim_ape.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prim_ape.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prim_ape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_prim_ape.Location = new System.Drawing.Point(34, 114);
            this.lbl_prim_ape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prim_ape.Name = "lbl_prim_ape";
            this.lbl_prim_ape.Size = new System.Drawing.Size(126, 17);
            this.lbl_prim_ape.TabIndex = 11;
            this.lbl_prim_ape.Text = "Primer Apellido";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_edad.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_edad.Location = new System.Drawing.Point(113, 190);
            this.lbl_edad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(47, 17);
            this.lbl_edad.TabIndex = 15;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(13, 30);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1196, 35);
            this.lbl_title.TabIndex = 60;
            this.lbl_title.Text = "MODIFICAR EMPLEADO";
            // 
            // btn_horas_extr
            // 
            this.btn_horas_extr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.btn_horas_extr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_horas_extr.FlatAppearance.BorderSize = 0;
            this.btn_horas_extr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_horas_extr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_horas_extr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_horas_extr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_horas_extr.Location = new System.Drawing.Point(533, 570);
            this.btn_horas_extr.Name = "btn_horas_extr";
            this.btn_horas_extr.Size = new System.Drawing.Size(144, 45);
            this.btn_horas_extr.TabIndex = 30;
            this.btn_horas_extr.Text = "Horas Extras";
            this.toolTip1.SetToolTip(this.btn_horas_extr, "Ver Detalle de Horas");
            this.btn_horas_extr.UseVisualStyleBackColor = false;
            this.btn_horas_extr.Click += new System.EventHandler(this.btn_horas_extr_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_verificar.BackgroundImage")));
            this.btn_verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verificar.ForeColor = System.Drawing.Color.White;
            this.btn_verificar.Location = new System.Drawing.Point(221, 81);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(60, 45);
            this.btn_verificar.TabIndex = 5;
            this.btn_verificar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(617, 660);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 45);
            this.btn_guardar.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar Cambios");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Location = new System.Drawing.Point(537, 660);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(60, 45);
            this.btn_atras.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btn_atras, "Cancelar");
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // frm_modifica_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.Controls.Add(this.btn_horas_extr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.gbx_datos_vehic);
            this.Controls.Add(this.gbx_datos_person);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_modifica_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_modifica_empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_datos_vehic.ResumeLayout(false);
            this.gbx_datos_vehic.PerformLayout();
            this.gbx_datos_person.ResumeLayout(false);
            this.gbx_datos_person.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_identifica;
        private System.Windows.Forms.RadioButton rbtn_pasaporte;
        private System.Windows.Forms.RadioButton rbtn_residencia;
        private System.Windows.Forms.RadioButton rbtn_cedula;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.GroupBox gbx_datos_vehic;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_puesto;
        private System.Windows.Forms.GroupBox gbx_datos_person;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telef2;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_seg_ape;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_prim_ape;
        private System.Windows.Forms.Label lbl_seg_ape;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_prim_ape;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_horas_extr;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
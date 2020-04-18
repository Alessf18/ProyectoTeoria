namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_modelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modelos));
            this.gbx_modelos = new System.Windows.Forms.GroupBox();
            this.cmb_Combustible = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Marca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Combustible = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Coolant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Aceite = new System.Windows.Forms.TextBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_descrip = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Motor = new System.Windows.Forms.TextBox();
            this.gbx_modelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_modelos
            // 
            this.gbx_modelos.Controls.Add(this.label6);
            this.gbx_modelos.Controls.Add(this.txt_Motor);
            this.gbx_modelos.Controls.Add(this.cmb_Combustible);
            this.gbx_modelos.Controls.Add(this.label5);
            this.gbx_modelos.Controls.Add(this.cmb_Marca);
            this.gbx_modelos.Controls.Add(this.label4);
            this.gbx_modelos.Controls.Add(this.label3);
            this.gbx_modelos.Controls.Add(this.txt_Combustible);
            this.gbx_modelos.Controls.Add(this.label2);
            this.gbx_modelos.Controls.Add(this.txt_Coolant);
            this.gbx_modelos.Controls.Add(this.label1);
            this.gbx_modelos.Controls.Add(this.txt_Aceite);
            this.gbx_modelos.Controls.Add(this.cbx_estado);
            this.gbx_modelos.Controls.Add(this.lbl_estado);
            this.gbx_modelos.Controls.Add(this.lbl_descrip);
            this.gbx_modelos.Controls.Add(this.txt_descripcion);
            this.gbx_modelos.Controls.Add(this.lbl_id);
            this.gbx_modelos.Controls.Add(this.txt_id);
            this.gbx_modelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_modelos.ForeColor = System.Drawing.Color.Green;
            this.gbx_modelos.Location = new System.Drawing.Point(36, 37);
            this.gbx_modelos.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_modelos.Name = "gbx_modelos";
            this.gbx_modelos.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_modelos.Size = new System.Drawing.Size(391, 363);
            this.gbx_modelos.TabIndex = 0;
            this.gbx_modelos.TabStop = false;
            this.gbx_modelos.Text = "Crear Nuevo Modelo";
            // 
            // cmb_Combustible
            // 
            this.cmb_Combustible.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cmb_Combustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Combustible.FormattingEnabled = true;
            this.cmb_Combustible.Location = new System.Drawing.Point(155, 290);
            this.cmb_Combustible.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Combustible.Name = "cmb_Combustible";
            this.cmb_Combustible.Size = new System.Drawing.Size(159, 21);
            this.cmb_Combustible.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo de Combustible";
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cmb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Location = new System.Drawing.Point(155, 258);
            this.cmb_Marca.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(159, 21);
            this.cmb_Marca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(79, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(-3, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad de Combustible";
            // 
            // txt_Combustible
            // 
            this.txt_Combustible.Location = new System.Drawing.Point(155, 220);
            this.txt_Combustible.MaxLength = 10;
            this.txt_Combustible.Name = "txt_Combustible";
            this.txt_Combustible.Size = new System.Drawing.Size(159, 19);
            this.txt_Combustible.TabIndex = 6;
            this.txt_Combustible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Combustible_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad de Coolant";
            // 
            // txt_Coolant
            // 
            this.txt_Coolant.Location = new System.Drawing.Point(155, 185);
            this.txt_Coolant.MaxLength = 10;
            this.txt_Coolant.Name = "txt_Coolant";
            this.txt_Coolant.Size = new System.Drawing.Size(159, 19);
            this.txt_Coolant.TabIndex = 5;
            this.txt_Coolant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Coolant_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de Aceite";
            // 
            // txt_Aceite
            // 
            this.txt_Aceite.Location = new System.Drawing.Point(155, 150);
            this.txt_Aceite.MaxLength = 10;
            this.txt_Aceite.Name = "txt_Aceite";
            this.txt_Aceite.Size = new System.Drawing.Size(159, 19);
            this.txt_Aceite.TabIndex = 4;
            this.txt_Aceite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Aceite_KeyPress);
            // 
            // cbx_estado
            // 
            this.cbx_estado.AutoCompleteCustomSource.AddRange(new string[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(155, 108);
            this.cbx_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(159, 21);
            this.cbx_estado.TabIndex = 3;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_estado.Location = new System.Drawing.Point(79, 111);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(46, 13);
            this.lbl_estado.TabIndex = 5;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_descrip.Location = new System.Drawing.Point(58, 77);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(74, 13);
            this.lbl_descrip.TabIndex = 3;
            this.lbl_descrip.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(155, 74);
            this.txt_descripcion.MaxLength = 25;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(159, 19);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_id.Location = new System.Drawing.Point(105, 41);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(155, 38);
            this.txt_id.MaxLength = 30;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(159, 19);
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
            this.btn_guardar.Location = new System.Drawing.Point(215, 405);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(39, 32);
            this.btn_guardar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar Modelo");
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
            this.btn_cancelar.Location = new System.Drawing.Point(159, 405);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(39, 32);
            this.btn_cancelar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(58, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Motor";
            // 
            // txt_Motor
            // 
            this.txt_Motor.Location = new System.Drawing.Point(155, 323);
            this.txt_Motor.MaxLength = 10;
            this.txt_Motor.Name = "txt_Motor";
            this.txt_Motor.Size = new System.Drawing.Size(159, 19);
            this.txt_Motor.TabIndex = 16;
            this.txt_Motor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Motor_KeyPress);
            // 
            // frm_modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 449);
            this.ControlBox = false;
            this.Controls.Add(this.gbx_modelos);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_modelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_modelos_Load);
            this.gbx_modelos.ResumeLayout(false);
            this.gbx_modelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_modelos;
        private System.Windows.Forms.Label lbl_descrip;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmb_Combustible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Combustible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Coolant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Aceite;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Motor;
    }
}
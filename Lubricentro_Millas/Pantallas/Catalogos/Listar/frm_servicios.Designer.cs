namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_servicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lklbl_modificar = new System.Windows.Forms.LinkLabel();
            this.lbL_servicio = new System.Windows.Forms.Label();
            this.gbx_servicio = new System.Windows.Forms.GroupBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtrar_servicio = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_servicios = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_servicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).BeginInit();
            this.SuspendLayout();
            // 
            // lklbl_modificar
            // 
            this.lklbl_modificar.AutoSize = true;
            this.lklbl_modificar.Location = new System.Drawing.Point(475, 705);
            this.lklbl_modificar.Name = "lklbl_modificar";
            this.lklbl_modificar.Size = new System.Drawing.Size(65, 17);
            this.lklbl_modificar.TabIndex = 7;
            this.lklbl_modificar.TabStop = true;
            this.lklbl_modificar.Text = "Modificar";
            this.lklbl_modificar.Click += new System.EventHandler(this.lklbl_modificar_Click);
            // 
            // lbL_servicio
            // 
            this.lbL_servicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbL_servicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbL_servicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL_servicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbL_servicio.Location = new System.Drawing.Point(13, 22);
            this.lbL_servicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbL_servicio.Name = "lbL_servicio";
            this.lbL_servicio.Size = new System.Drawing.Size(1196, 35);
            this.lbL_servicio.TabIndex = 0;
            this.lbL_servicio.Text = "SERVICIOS";
            // 
            // gbx_servicio
            // 
            this.gbx_servicio.BackColor = System.Drawing.Color.Transparent;
            this.gbx_servicio.Controls.Add(this.lbl_filtrar);
            this.gbx_servicio.Controls.Add(this.txt_filtrar_servicio);
            this.gbx_servicio.Controls.Add(this.btn_agregar);
            this.gbx_servicio.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_servicio.ForeColor = System.Drawing.Color.White;
            this.gbx_servicio.Location = new System.Drawing.Point(130, 82);
            this.gbx_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_servicio.Name = "gbx_servicio";
            this.gbx_servicio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_servicio.Size = new System.Drawing.Size(968, 71);
            this.gbx_servicio.TabIndex = 1;
            this.gbx_servicio.TabStop = false;
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_filtrar.Location = new System.Drawing.Point(49, 27);
            this.lbl_filtrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(74, 25);
            this.lbl_filtrar.TabIndex = 2;
            this.lbl_filtrar.Text = "Filtrar";
            // 
            // txt_filtrar_servicio
            // 
            this.txt_filtrar_servicio.Location = new System.Drawing.Point(131, 27);
            this.txt_filtrar_servicio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtrar_servicio.MaxLength = 25;
            this.txt_filtrar_servicio.Multiline = true;
            this.txt_filtrar_servicio.Name = "txt_filtrar_servicio";
            this.txt_filtrar_servicio.Size = new System.Drawing.Size(683, 30);
            this.txt_filtrar_servicio.TabIndex = 3;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.add;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(875, 22);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(44, 33);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_servicios
            // 
            this.dgv_servicios.AllowUserToAddRows = false;
            this.dgv_servicios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_servicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_servicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_servicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_servicios.Location = new System.Drawing.Point(315, 167);
            this.dgv_servicios.MultiSelect = false;
            this.dgv_servicios.Name = "dgv_servicios";
            this.dgv_servicios.ReadOnly = true;
            this.dgv_servicios.RowTemplate.Height = 24;
            this.dgv_servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servicios.Size = new System.Drawing.Size(538, 495);
            this.dgv_servicios.TabIndex = 4;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(619, 692);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 45);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.ControlBox = false;
            this.Controls.Add(this.lklbl_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbL_servicio);
            this.Controls.Add(this.gbx_servicio);
            this.Controls.Add(this.dgv_servicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_servicios";
            this.Text = "frm_servicios";
            this.Load += new System.EventHandler(this.frm_servicios_Load);
            this.gbx_servicio.ResumeLayout(false);
            this.gbx_servicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklbl_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbL_servicio;
        private System.Windows.Forms.GroupBox gbx_servicio;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtrar_servicio;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_servicios;
    }
}
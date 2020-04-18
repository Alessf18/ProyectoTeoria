namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_estados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lklbl_modificar = new System.Windows.Forms.LinkLabel();
            this.lbL_estados = new System.Windows.Forms.Label();
            this.gbx_servicio = new System.Windows.Forms.GroupBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtrar_estados = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_estados = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_servicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estados)).BeginInit();
            this.SuspendLayout();
            // 
            // lklbl_modificar
            // 
            this.lklbl_modificar.AutoSize = true;
            this.lklbl_modificar.Location = new System.Drawing.Point(328, 588);
            this.lklbl_modificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklbl_modificar.Name = "lklbl_modificar";
            this.lklbl_modificar.Size = new System.Drawing.Size(50, 13);
            this.lklbl_modificar.TabIndex = 12;
            this.lklbl_modificar.TabStop = true;
            this.lklbl_modificar.Text = "Modificar";
            // 
            // lbL_estados
            // 
            this.lbL_estados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbL_estados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbL_estados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL_estados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbL_estados.Location = new System.Drawing.Point(10, 18);
            this.lbL_estados.Name = "lbL_estados";
            this.lbL_estados.Size = new System.Drawing.Size(897, 28);
            this.lbL_estados.TabIndex = 8;
            this.lbL_estados.Text = "ESTADOS";
            // 
            // gbx_servicio
            // 
            this.gbx_servicio.BackColor = System.Drawing.Color.Transparent;
            this.gbx_servicio.Controls.Add(this.lbl_filtrar);
            this.gbx_servicio.Controls.Add(this.txt_filtrar_estados);
            this.gbx_servicio.Controls.Add(this.btn_agregar);
            this.gbx_servicio.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_servicio.ForeColor = System.Drawing.Color.White;
            this.gbx_servicio.Location = new System.Drawing.Point(98, 67);
            this.gbx_servicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_servicio.Name = "gbx_servicio";
            this.gbx_servicio.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_servicio.Size = new System.Drawing.Size(726, 58);
            this.gbx_servicio.TabIndex = 9;
            this.gbx_servicio.TabStop = false;
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_filtrar.Location = new System.Drawing.Point(37, 22);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(56, 20);
            this.lbl_filtrar.TabIndex = 2;
            this.lbl_filtrar.Text = "Filtrar";
            // 
            // txt_filtrar_estados
            // 
            this.txt_filtrar_estados.Location = new System.Drawing.Point(98, 22);
            this.txt_filtrar_estados.MaxLength = 25;
            this.txt_filtrar_estados.Multiline = true;
            this.txt_filtrar_estados.Name = "txt_filtrar_estados";
            this.txt_filtrar_estados.Size = new System.Drawing.Size(513, 25);
            this.txt_filtrar_estados.TabIndex = 3;
            this.txt_filtrar_estados.TextChanged += new System.EventHandler(this.txt_filtrar_estados_TextChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.add;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(656, 18);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(33, 27);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_estados
            // 
            this.dgv_estados.AllowUserToAddRows = false;
            this.dgv_estados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_estados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_estados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_estados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_estados.Location = new System.Drawing.Point(44, 146);
            this.dgv_estados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_estados.MultiSelect = false;
            this.dgv_estados.Name = "dgv_estados";
            this.dgv_estados.ReadOnly = true;
            this.dgv_estados.RowTemplate.Height = 24;
            this.dgv_estados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estados.Size = new System.Drawing.Size(827, 402);
            this.dgv_estados.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(436, 578);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(45, 37);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 633);
            this.ControlBox = false;
            this.Controls.Add(this.lklbl_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbL_estados);
            this.Controls.Add(this.gbx_servicio);
            this.Controls.Add(this.dgv_estados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_estados";
            this.Text = "frm_estados";
            this.Load += new System.EventHandler(this.frm_estados_Load);
            this.gbx_servicio.ResumeLayout(false);
            this.gbx_servicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklbl_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbL_estados;
        private System.Windows.Forms.GroupBox gbx_servicio;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtrar_estados;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_estados;
    }
}
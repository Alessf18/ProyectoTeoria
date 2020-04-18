namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_listar_nonima
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gbx_empleados = new System.Windows.Forms.GroupBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtra_empleados = new System.Windows.Forms.TextBox();
            this.btn_agreg_emple = new System.Windows.Forms.Button();
            this.dgv_citas = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lkl_modificar = new System.Windows.Forms.LinkLabel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lklbl_ver_historial = new System.Windows.Forms.LinkLabel();
            this.gbx_empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(13, 22);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1196, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "EMPLEADOS";
            // 
            // gbx_empleados
            // 
            this.gbx_empleados.BackColor = System.Drawing.Color.Transparent;
            this.gbx_empleados.Controls.Add(this.lbl_filtrar);
            this.gbx_empleados.Controls.Add(this.txt_filtra_empleados);
            this.gbx_empleados.Controls.Add(this.btn_agreg_emple);
            this.gbx_empleados.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_empleados.ForeColor = System.Drawing.Color.White;
            this.gbx_empleados.Location = new System.Drawing.Point(125, 82);
            this.gbx_empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_empleados.Name = "gbx_empleados";
            this.gbx_empleados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_empleados.Size = new System.Drawing.Size(968, 71);
            this.gbx_empleados.TabIndex = 1;
            this.gbx_empleados.TabStop = false;
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_filtrar.Location = new System.Drawing.Point(49, 27);
            this.lbl_filtrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(75, 25);
            this.lbl_filtrar.TabIndex = 2;
            this.lbl_filtrar.Text = "Filtrar";
            // 
            // txt_filtra_empleados
            // 
            this.txt_filtra_empleados.Location = new System.Drawing.Point(131, 27);
            this.txt_filtra_empleados.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtra_empleados.Multiline = true;
            this.txt_filtra_empleados.Name = "txt_filtra_empleados";
            this.txt_filtra_empleados.Size = new System.Drawing.Size(683, 30);
            this.txt_filtra_empleados.TabIndex = 3;
            // 
            // btn_agreg_emple
            // 
            this.btn_agreg_emple.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.adduser;
            this.btn_agreg_emple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agreg_emple.FlatAppearance.BorderSize = 0;
            this.btn_agreg_emple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agreg_emple.ForeColor = System.Drawing.Color.Black;
            this.btn_agreg_emple.Location = new System.Drawing.Point(875, 27);
            this.btn_agreg_emple.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agreg_emple.Name = "btn_agreg_emple";
            this.btn_agreg_emple.Size = new System.Drawing.Size(44, 33);
            this.btn_agreg_emple.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_agreg_emple, "Agregar Nuevo Empleado");
            this.btn_agreg_emple.UseVisualStyleBackColor = true;
            this.btn_agreg_emple.Click += new System.EventHandler(this.btn_agreg_emple_Click);
            // 
            // dgv_citas
            // 
            this.dgv_citas.AllowUserToAddRows = false;
            this.dgv_citas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_citas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_citas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_citas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_citas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_citas.Location = new System.Drawing.Point(59, 185);
            this.dgv_citas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_citas.MultiSelect = false;
            this.dgv_citas.Name = "dgv_citas";
            this.dgv_citas.ReadOnly = true;
            this.dgv_citas.RowTemplate.Height = 24;
            this.dgv_citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_citas.Size = new System.Drawing.Size(1103, 495);
            this.dgv_citas.TabIndex = 4;
            // 
            // lkl_modificar
            // 
            this.lkl_modificar.AutoSize = true;
            this.lkl_modificar.Location = new System.Drawing.Point(461, 725);
            this.lkl_modificar.Name = "lkl_modificar";
            this.lkl_modificar.Size = new System.Drawing.Size(65, 17);
            this.lkl_modificar.TabIndex = 6;
            this.lkl_modificar.TabStop = true;
            this.lkl_modificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.lkl_modificar, "Simula el Evento Doble Click en el DataGriedView");
            this.lkl_modificar.Click += new System.EventHandler(this.lkl_modificar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(581, 711);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 46);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lklbl_ver_historial
            // 
            this.lklbl_ver_historial.AutoSize = true;
            this.lklbl_ver_historial.Location = new System.Drawing.Point(253, 725);
            this.lklbl_ver_historial.Name = "lklbl_ver_historial";
            this.lklbl_ver_historial.Size = new System.Drawing.Size(152, 17);
            this.lklbl_ver_historial.TabIndex = 8;
            this.lklbl_ver_historial.TabStop = true;
            this.lklbl_ver_historial.Text = "Ver Historial Empleado";
            this.lklbl_ver_historial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_ver_historial_LinkClicked);
            // 
            // frm_listar_nonima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.Controls.Add(this.lklbl_ver_historial);
            this.Controls.Add(this.lkl_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.gbx_empleados);
            this.Controls.Add(this.dgv_citas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_listar_nonima";
            this.Text = "frm_listar_nonima";
            this.Load += new System.EventHandler(this.frm_listar_nonima_Load);
            this.gbx_empleados.ResumeLayout(false);
            this.gbx_empleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gbx_empleados;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtra_empleados;
        private System.Windows.Forms.Button btn_agreg_emple;
        private System.Windows.Forms.DataGridView dgv_citas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lkl_modificar;
        private System.Windows.Forms.LinkLabel lklbl_ver_historial;
    }
}
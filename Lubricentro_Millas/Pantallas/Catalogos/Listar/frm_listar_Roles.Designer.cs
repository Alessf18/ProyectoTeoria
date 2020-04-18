namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_listar_Roles
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
            this.dgv_rol = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gbx_roles = new System.Windows.Forms.GroupBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtrar_roles = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rol)).BeginInit();
            this.gbx_roles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_rol
            // 
            this.dgv_rol.AllowUserToAddRows = false;
            this.dgv_rol.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_rol.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rol.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_rol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_rol.Location = new System.Drawing.Point(303, 182);
            this.dgv_rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_rol.MultiSelect = false;
            this.dgv_rol.Name = "dgv_rol";
            this.dgv_rol.ReadOnly = true;
            this.dgv_rol.RowTemplate.Height = 24;
            this.dgv_rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rol.Size = new System.Drawing.Size(565, 495);
            this.dgv_rol.TabIndex = 13;
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
            this.lbl_title.TabIndex = 15;
            this.lbl_title.Text = "Roles";
            // 
            // gbx_roles
            // 
            this.gbx_roles.BackColor = System.Drawing.Color.Transparent;
            this.gbx_roles.Controls.Add(this.lbl_filtrar);
            this.gbx_roles.Controls.Add(this.txt_filtrar_roles);
            this.gbx_roles.Controls.Add(this.btn_agregar);
            this.gbx_roles.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_roles.ForeColor = System.Drawing.Color.White;
            this.gbx_roles.Location = new System.Drawing.Point(131, 82);
            this.gbx_roles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_roles.Name = "gbx_roles";
            this.gbx_roles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_roles.Size = new System.Drawing.Size(968, 71);
            this.gbx_roles.TabIndex = 16;
            this.gbx_roles.TabStop = false;
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
            // txt_filtrar_roles
            // 
            this.txt_filtrar_roles.Location = new System.Drawing.Point(131, 27);
            this.txt_filtrar_roles.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtrar_roles.MaxLength = 25;
            this.txt_filtrar_roles.Multiline = true;
            this.txt_filtrar_roles.Name = "txt_filtrar_roles";
            this.txt_filtrar_roles.Size = new System.Drawing.Size(683, 30);
            this.txt_filtrar_roles.TabIndex = 3;
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
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // frm_listar_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.Controls.Add(this.gbx_roles);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv_rol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_listar_Roles";
            this.Text = "frm_listar_Roles";
            this.Load += new System.EventHandler(this.frm_listar_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rol)).EndInit();
            this.gbx_roles.ResumeLayout(false);
            this.gbx_roles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rol;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gbx_roles;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtrar_roles;
        private System.Windows.Forms.Button btn_agregar;
    }
}
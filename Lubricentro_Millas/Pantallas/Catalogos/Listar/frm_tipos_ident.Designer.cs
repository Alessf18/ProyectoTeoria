﻿namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_tipos_ident
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
            this.lbL_tipo = new System.Windows.Forms.Label();
            this.gbx_tipo = new System.Windows.Forms.GroupBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtrar_tipo_ident = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_tipo_ident = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_tipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_ident)).BeginInit();
            this.SuspendLayout();
            // 
            // lklbl_modificar
            // 
            this.lklbl_modificar.AutoSize = true;
            this.lklbl_modificar.Location = new System.Drawing.Point(478, 713);
            this.lklbl_modificar.Name = "lklbl_modificar";
            this.lklbl_modificar.Size = new System.Drawing.Size(65, 17);
            this.lklbl_modificar.TabIndex = 12;
            this.lklbl_modificar.TabStop = true;
            this.lklbl_modificar.Text = "Modificar";
            // 
            // lbL_tipo
            // 
            this.lbL_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbL_tipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbL_tipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbL_tipo.Location = new System.Drawing.Point(13, 32);
            this.lbL_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbL_tipo.Name = "lbL_tipo";
            this.lbL_tipo.Size = new System.Drawing.Size(1196, 34);
            this.lbL_tipo.TabIndex = 8;
            this.lbL_tipo.Text = "TIPO DE IDENTIFICACIÓN";
            // 
            // gbx_tipo
            // 
            this.gbx_tipo.BackColor = System.Drawing.Color.Transparent;
            this.gbx_tipo.Controls.Add(this.lbl_filtrar);
            this.gbx_tipo.Controls.Add(this.txt_filtrar_tipo_ident);
            this.gbx_tipo.Controls.Add(this.btn_agregar);
            this.gbx_tipo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_tipo.ForeColor = System.Drawing.Color.White;
            this.gbx_tipo.Location = new System.Drawing.Point(131, 92);
            this.gbx_tipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_tipo.Name = "gbx_tipo";
            this.gbx_tipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_tipo.Size = new System.Drawing.Size(968, 71);
            this.gbx_tipo.TabIndex = 9;
            this.gbx_tipo.TabStop = false;
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
            // txt_filtrar_tipo_ident
            // 
            this.txt_filtrar_tipo_ident.Location = new System.Drawing.Point(131, 27);
            this.txt_filtrar_tipo_ident.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtrar_tipo_ident.MaxLength = 25;
            this.txt_filtrar_tipo_ident.Multiline = true;
            this.txt_filtrar_tipo_ident.Name = "txt_filtrar_tipo_ident";
            this.txt_filtrar_tipo_ident.Size = new System.Drawing.Size(683, 30);
            this.txt_filtrar_tipo_ident.TabIndex = 3;
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
            // dgv_tipo_ident
            // 
            this.dgv_tipo_ident.AllowUserToAddRows = false;
            this.dgv_tipo_ident.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_tipo_ident.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tipo_ident.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_tipo_ident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipo_ident.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tipo_ident.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_tipo_ident.Location = new System.Drawing.Point(262, 177);
            this.dgv_tipo_ident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tipo_ident.MultiSelect = false;
            this.dgv_tipo_ident.Name = "dgv_tipo_ident";
            this.dgv_tipo_ident.ReadOnly = true;
            this.dgv_tipo_ident.RowTemplate.Height = 24;
            this.dgv_tipo_ident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tipo_ident.Size = new System.Drawing.Size(683, 495);
            this.dgv_tipo_ident.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(622, 700);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 46);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_tipos_ident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.Controls.Add(this.lklbl_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbL_tipo);
            this.Controls.Add(this.gbx_tipo);
            this.Controls.Add(this.dgv_tipo_ident);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_tipos_ident";
            this.Text = "frm_tipos_ident";
            this.Load += new System.EventHandler(this.frm_tipos_ident_Load);
            this.gbx_tipo.ResumeLayout(false);
            this.gbx_tipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_ident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklbl_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbL_tipo;
        private System.Windows.Forms.GroupBox gbx_tipo;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtrar_tipo_ident;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_tipo_ident;
    }
}
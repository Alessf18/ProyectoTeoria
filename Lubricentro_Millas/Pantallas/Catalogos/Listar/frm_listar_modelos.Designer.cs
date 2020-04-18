namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_listar_modelos
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
            this.lbl_modelos = new System.Windows.Forms.Label();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtra_modelo = new System.Windows.Forms.TextBox();
            this.dgv_modelos = new System.Windows.Forms.DataGridView();
            this.gbx_modelos = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lklbl_modifica = new System.Windows.Forms.LinkLabel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelos)).BeginInit();
            this.gbx_modelos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_modelos
            // 
            this.lbl_modelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_modelos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_modelos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_modelos.Location = new System.Drawing.Point(10, 18);
            this.lbl_modelos.Name = "lbl_modelos";
            this.lbl_modelos.Size = new System.Drawing.Size(897, 28);
            this.lbl_modelos.TabIndex = 1;
            this.lbl_modelos.Text = "MODELOS";
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_filtrar.Location = new System.Drawing.Point(37, 22);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(56, 20);
            this.lbl_filtrar.TabIndex = 3;
            this.lbl_filtrar.Text = "Filtrar";
            // 
            // txt_filtra_modelo
            // 
            this.txt_filtra_modelo.Location = new System.Drawing.Point(98, 22);
            this.txt_filtra_modelo.MaxLength = 25;
            this.txt_filtra_modelo.Multiline = true;
            this.txt_filtra_modelo.Name = "txt_filtra_modelo";
            this.txt_filtra_modelo.Size = new System.Drawing.Size(513, 25);
            this.txt_filtra_modelo.TabIndex = 4;
            this.txt_filtra_modelo.TextChanged += new System.EventHandler(this.txt_filtra_modelo_TextChanged);
            // 
            // dgv_modelos
            // 
            this.dgv_modelos.AllowUserToAddRows = false;
            this.dgv_modelos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_modelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_modelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_modelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modelos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_modelos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_modelos.Location = new System.Drawing.Point(44, 146);
            this.dgv_modelos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_modelos.MultiSelect = false;
            this.dgv_modelos.Name = "dgv_modelos";
            this.dgv_modelos.ReadOnly = true;
            this.dgv_modelos.RowTemplate.Height = 24;
            this.dgv_modelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_modelos.Size = new System.Drawing.Size(827, 402);
            this.dgv_modelos.TabIndex = 5;
            // 
            // gbx_modelos
            // 
            this.gbx_modelos.BackColor = System.Drawing.Color.Transparent;
            this.gbx_modelos.Controls.Add(this.lbl_filtrar);
            this.gbx_modelos.Controls.Add(this.txt_filtra_modelo);
            this.gbx_modelos.Controls.Add(this.btn_agregar);
            this.gbx_modelos.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_modelos.ForeColor = System.Drawing.Color.White;
            this.gbx_modelos.Location = new System.Drawing.Point(98, 67);
            this.gbx_modelos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_modelos.Name = "gbx_modelos";
            this.gbx_modelos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_modelos.Size = new System.Drawing.Size(726, 58);
            this.gbx_modelos.TabIndex = 2;
            this.gbx_modelos.TabStop = false;
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
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lklbl_modifica
            // 
            this.lklbl_modifica.AutoSize = true;
            this.lklbl_modifica.Location = new System.Drawing.Point(328, 588);
            this.lklbl_modifica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lklbl_modifica.Name = "lklbl_modifica";
            this.lklbl_modifica.Size = new System.Drawing.Size(50, 13);
            this.lklbl_modifica.TabIndex = 8;
            this.lklbl_modifica.TabStop = true;
            this.lklbl_modifica.Text = "Modificar";
            this.lklbl_modifica.Click += new System.EventHandler(this.lklbl_modifica_Click);
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
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_listar_modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 633);
            this.Controls.Add(this.lklbl_modifica);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_modelos);
            this.Controls.Add(this.gbx_modelos);
            this.Controls.Add(this.dgv_modelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_listar_modelos";
            this.Load += new System.EventHandler(this.frm_listar_modelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelos)).EndInit();
            this.gbx_modelos.ResumeLayout(false);
            this.gbx_modelos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_modelos;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtra_modelo;
        private System.Windows.Forms.DataGridView dgv_modelos;
        private System.Windows.Forms.GroupBox gbx_modelos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.LinkLabel lklbl_modifica;
    }
}
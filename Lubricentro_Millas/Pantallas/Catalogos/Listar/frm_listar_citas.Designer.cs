namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_listar_citas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listar_citas));
            this.dgv_citas = new System.Windows.Forms.DataGridView();
            this.txt_filtra_cita = new System.Windows.Forms.TextBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.gbx_citas = new System.Windows.Forms.GroupBox();
            this.btn_cancel_cita = new System.Windows.Forms.Button();
            this.btn_modif_cita = new System.Windows.Forms.Button();
            this.lbl_citas = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).BeginInit();
            this.gbx_citas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_citas
            // 
            this.dgv_citas.AllowUserToAddRows = false;
            this.dgv_citas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_citas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_citas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_citas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_citas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_citas.Location = new System.Drawing.Point(44, 139);
            this.dgv_citas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_citas.MultiSelect = false;
            this.dgv_citas.Name = "dgv_citas";
            this.dgv_citas.ReadOnly = true;
            this.dgv_citas.RowTemplate.Height = 24;
            this.dgv_citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_citas.Size = new System.Drawing.Size(827, 402);
            this.dgv_citas.TabIndex = 4;
            // 
            // txt_filtra_cita
            // 
            this.txt_filtra_cita.Location = new System.Drawing.Point(98, 22);
            this.txt_filtra_cita.Multiline = true;
            this.txt_filtra_cita.Name = "txt_filtra_cita";
            this.txt_filtra_cita.Size = new System.Drawing.Size(513, 25);
            this.txt_filtra_cita.TabIndex = 3;
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
            // gbx_citas
            // 
            this.gbx_citas.BackColor = System.Drawing.Color.Transparent;
            this.gbx_citas.Controls.Add(this.btn_cancel_cita);
            this.gbx_citas.Controls.Add(this.lbl_filtrar);
            this.gbx_citas.Controls.Add(this.txt_filtra_cita);
            this.gbx_citas.Controls.Add(this.btn_modif_cita);
            this.gbx_citas.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_citas.ForeColor = System.Drawing.Color.White;
            this.gbx_citas.Location = new System.Drawing.Point(94, 56);
            this.gbx_citas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_citas.Name = "gbx_citas";
            this.gbx_citas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_citas.Size = new System.Drawing.Size(726, 58);
            this.gbx_citas.TabIndex = 1;
            this.gbx_citas.TabStop = false;
            // 
            // btn_cancel_cita
            // 
            this.btn_cancel_cita.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.delete;
            this.btn_cancel_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel_cita.FlatAppearance.BorderSize = 0;
            this.btn_cancel_cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_cita.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel_cita.Location = new System.Drawing.Point(632, 22);
            this.btn_cancel_cita.Name = "btn_cancel_cita";
            this.btn_cancel_cita.Size = new System.Drawing.Size(33, 27);
            this.btn_cancel_cita.TabIndex = 6;
            this.btn_cancel_cita.UseVisualStyleBackColor = true;
            this.btn_cancel_cita.Click += new System.EventHandler(this.btn_cancel_cita_Click);
            // 
            // btn_modif_cita
            // 
            this.btn_modif_cita.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.update;
            this.btn_modif_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modif_cita.FlatAppearance.BorderSize = 0;
            this.btn_modif_cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modif_cita.ForeColor = System.Drawing.Color.Black;
            this.btn_modif_cita.Location = new System.Drawing.Point(670, 22);
            this.btn_modif_cita.Name = "btn_modif_cita";
            this.btn_modif_cita.Size = new System.Drawing.Size(33, 27);
            this.btn_modif_cita.TabIndex = 5;
            this.btn_modif_cita.UseVisualStyleBackColor = true;
            this.btn_modif_cita.Click += new System.EventHandler(this.btn_modif_cita_Click);
            // 
            // lbl_citas
            // 
            this.lbl_citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_citas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_citas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_citas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_citas.Location = new System.Drawing.Point(10, 7);
            this.lbl_citas.Name = "lbl_citas";
            this.lbl_citas.Size = new System.Drawing.Size(897, 28);
            this.lbl_citas.TabIndex = 0;
            this.lbl_citas.Text = " CITAS";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(436, 567);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(45, 37);
            this.btn_cancelar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cerrar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_listar_citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 633);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_citas);
            this.Controls.Add(this.gbx_citas);
            this.Controls.Add(this.dgv_citas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_listar_citas";
            this.Load += new System.EventHandler(this.frm_listar_citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_citas)).EndInit();
            this.gbx_citas.ResumeLayout(false);
            this.gbx_citas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_citas;
        private System.Windows.Forms.Button btn_modif_cita;
        private System.Windows.Forms.TextBox txt_filtra_cita;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.GroupBox gbx_citas;
        private System.Windows.Forms.Label lbl_citas;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_cancel_cita;
    }
}
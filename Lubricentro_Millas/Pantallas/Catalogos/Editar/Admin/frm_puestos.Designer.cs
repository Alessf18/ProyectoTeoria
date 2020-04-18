namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_puestos
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
            this.lkl_modificar = new System.Windows.Forms.LinkLabel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gbx_capacit = new System.Windows.Forms.GroupBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtra_puestos = new System.Windows.Forms.TextBox();
            this.btn_agrega_puesto = new System.Windows.Forms.Button();
            this.dgv_puestos = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_capacit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).BeginInit();
            this.SuspendLayout();
            // 
            // lkl_modificar
            // 
            this.lkl_modificar.AutoSize = true;
            this.lkl_modificar.Location = new System.Drawing.Point(524, 724);
            this.lkl_modificar.Name = "lkl_modificar";
            this.lkl_modificar.Size = new System.Drawing.Size(65, 17);
            this.lkl_modificar.TabIndex = 11;
            this.lkl_modificar.TabStop = true;
            this.lkl_modificar.Text = "Modificar";
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(12, 22);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1196, 34);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "Puestos de Trabajo";
            // 
            // gbx_capacit
            // 
            this.gbx_capacit.BackColor = System.Drawing.Color.Transparent;
            this.gbx_capacit.Controls.Add(this.lbl_filtrar);
            this.gbx_capacit.Controls.Add(this.txt_filtra_puestos);
            this.gbx_capacit.Controls.Add(this.btn_agrega_puesto);
            this.gbx_capacit.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_capacit.ForeColor = System.Drawing.Color.White;
            this.gbx_capacit.Location = new System.Drawing.Point(124, 82);
            this.gbx_capacit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_capacit.Name = "gbx_capacit";
            this.gbx_capacit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_capacit.Size = new System.Drawing.Size(968, 71);
            this.gbx_capacit.TabIndex = 9;
            this.gbx_capacit.TabStop = false;
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
            // txt_filtra_puestos
            // 
            this.txt_filtra_puestos.Location = new System.Drawing.Point(131, 27);
            this.txt_filtra_puestos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtra_puestos.Multiline = true;
            this.txt_filtra_puestos.Name = "txt_filtra_puestos";
            this.txt_filtra_puestos.Size = new System.Drawing.Size(683, 30);
            this.txt_filtra_puestos.TabIndex = 3;
            // 
            // btn_agrega_puesto
            // 
            this.btn_agrega_puesto.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.add;
            this.btn_agrega_puesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agrega_puesto.FlatAppearance.BorderSize = 0;
            this.btn_agrega_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agrega_puesto.ForeColor = System.Drawing.Color.Black;
            this.btn_agrega_puesto.Location = new System.Drawing.Point(872, 27);
            this.btn_agrega_puesto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agrega_puesto.Name = "btn_agrega_puesto";
            this.btn_agrega_puesto.Size = new System.Drawing.Size(44, 33);
            this.btn_agrega_puesto.TabIndex = 5;
            this.btn_agrega_puesto.UseVisualStyleBackColor = true;
            this.btn_agrega_puesto.Click += new System.EventHandler(this.btn_agrega_puesto_Click);
            // 
            // dgv_puestos
            // 
            this.dgv_puestos.AllowUserToAddRows = false;
            this.dgv_puestos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_puestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_puestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_puestos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_puestos.Location = new System.Drawing.Point(58, 185);
            this.dgv_puestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_puestos.Name = "dgv_puestos";
            this.dgv_puestos.ReadOnly = true;
            this.dgv_puestos.RowTemplate.Height = 24;
            this.dgv_puestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_puestos.Size = new System.Drawing.Size(1103, 495);
            this.dgv_puestos.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(658, 710);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 46);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 779);
            this.Controls.Add(this.lkl_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.gbx_capacit);
            this.Controls.Add(this.dgv_puestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_puestos";
            this.Text = "frm_puestos";
            this.Load += new System.EventHandler(this.frm_puestos_Load);
            this.gbx_capacit.ResumeLayout(false);
            this.gbx_capacit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkl_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gbx_capacit;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtra_puestos;
        private System.Windows.Forms.Button btn_agrega_puesto;
        private System.Windows.Forms.DataGridView dgv_puestos;
    }
}
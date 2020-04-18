namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_capacitacion
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gbx_capacit = new System.Windows.Forms.GroupBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.txt_filtra_capacita = new System.Windows.Forms.TextBox();
            this.btn_agrega_capacit = new System.Windows.Forms.Button();
            this.dgv_capacita = new System.Windows.Forms.DataGridView();
            this.lkl_modificar = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_capacit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_capacita)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(494, 577);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(45, 37);
            this.btn_cancelar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(10, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(897, 28);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "CAPACITACIÓN Y DESARROLLO";
            // 
            // gbx_capacit
            // 
            this.gbx_capacit.BackColor = System.Drawing.Color.Transparent;
            this.gbx_capacit.Controls.Add(this.lbl_filtrar);
            this.gbx_capacit.Controls.Add(this.txt_filtra_capacita);
            this.gbx_capacit.Controls.Add(this.btn_agrega_capacit);
            this.gbx_capacit.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_capacit.ForeColor = System.Drawing.Color.White;
            this.gbx_capacit.Location = new System.Drawing.Point(94, 67);
            this.gbx_capacit.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_capacit.Name = "gbx_capacit";
            this.gbx_capacit.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_capacit.Size = new System.Drawing.Size(726, 58);
            this.gbx_capacit.TabIndex = 1;
            this.gbx_capacit.TabStop = false;
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
            // txt_filtra_capacita
            // 
            this.txt_filtra_capacita.Location = new System.Drawing.Point(98, 22);
            this.txt_filtra_capacita.Multiline = true;
            this.txt_filtra_capacita.Name = "txt_filtra_capacita";
            this.txt_filtra_capacita.Size = new System.Drawing.Size(513, 25);
            this.txt_filtra_capacita.TabIndex = 3;
            // 
            // btn_agrega_capacit
            // 
            this.btn_agrega_capacit.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.add;
            this.btn_agrega_capacit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agrega_capacit.FlatAppearance.BorderSize = 0;
            this.btn_agrega_capacit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agrega_capacit.ForeColor = System.Drawing.Color.Black;
            this.btn_agrega_capacit.Location = new System.Drawing.Point(654, 22);
            this.btn_agrega_capacit.Name = "btn_agrega_capacit";
            this.btn_agrega_capacit.Size = new System.Drawing.Size(33, 27);
            this.btn_agrega_capacit.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_agrega_capacit, "Agregar Nueva Capacitación");
            this.btn_agrega_capacit.UseVisualStyleBackColor = true;
            this.btn_agrega_capacit.Click += new System.EventHandler(this.btn_agrega_capacit_Click);
            // 
            // dgv_capacita
            // 
            this.dgv_capacita.AllowUserToAddRows = false;
            this.dgv_capacita.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_capacita.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_capacita.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_capacita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_capacita.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_capacita.Location = new System.Drawing.Point(44, 150);
            this.dgv_capacita.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_capacita.Name = "dgv_capacita";
            this.dgv_capacita.ReadOnly = true;
            this.dgv_capacita.RowTemplate.Height = 24;
            this.dgv_capacita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_capacita.Size = new System.Drawing.Size(827, 402);
            this.dgv_capacita.TabIndex = 4;
            this.dgv_capacita.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_capacita_MouseDoubleClick);
            // 
            // lkl_modificar
            // 
            this.lkl_modificar.AutoSize = true;
            this.lkl_modificar.Location = new System.Drawing.Point(394, 588);
            this.lkl_modificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lkl_modificar.Name = "lkl_modificar";
            this.lkl_modificar.Size = new System.Drawing.Size(50, 13);
            this.lkl_modificar.TabIndex = 6;
            this.lkl_modificar.TabStop = true;
            this.lkl_modificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.lkl_modificar, "Simula el Evento Doble Click en el DataGriedView");
            this.lkl_modificar.Click += new System.EventHandler(this.lkl_modificar_Click);
            // 
            // frm_capacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 633);
            this.ControlBox = false;
            this.Controls.Add(this.lkl_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.gbx_capacit);
            this.Controls.Add(this.dgv_capacita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_capacitacion";
            this.Text = "frm_capacitacion";
            this.Load += new System.EventHandler(this.frm_capacitacion_Load);
            this.gbx_capacit.ResumeLayout(false);
            this.gbx_capacit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_capacita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gbx_capacit;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.TextBox txt_filtra_capacita;
        private System.Windows.Forms.Button btn_agrega_capacit;
        private System.Windows.Forms.DataGridView dgv_capacita;
        private System.Windows.Forms.LinkLabel lkl_modificar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
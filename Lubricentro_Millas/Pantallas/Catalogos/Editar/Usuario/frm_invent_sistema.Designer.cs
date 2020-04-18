namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    partial class frm_invent_sistema
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
            this.gbx_invent = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.txt_num_parte = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv_invent = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_invent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_invent
            // 
            this.gbx_invent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.gbx_invent.Controls.Add(this.btn_buscar);
            this.gbx_invent.Controls.Add(this.lbl_busqueda);
            this.gbx_invent.Controls.Add(this.txt_num_parte);
            this.gbx_invent.Location = new System.Drawing.Point(205, 122);
            this.gbx_invent.Name = "gbx_invent";
            this.gbx_invent.Size = new System.Drawing.Size(657, 76);
            this.gbx_invent.TabIndex = 1;
            this.gbx_invent.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.search;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_buscar.Location = new System.Drawing.Point(532, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(60, 45);
            this.btn_buscar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AutoSize = true;
            this.lbl_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_busqueda.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_busqueda.Location = new System.Drawing.Point(73, 30);
            this.lbl_busqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(139, 17);
            this.lbl_busqueda.TabIndex = 2;
            this.lbl_busqueda.Text = "Número de Parte";
            // 
            // txt_num_parte
            // 
            this.txt_num_parte.BackColor = System.Drawing.Color.White;
            this.txt_num_parte.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_parte.ForeColor = System.Drawing.Color.Black;
            this.txt_num_parte.Location = new System.Drawing.Point(233, 27);
            this.txt_num_parte.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_parte.MaxLength = 25;
            this.txt_num_parte.Multiline = true;
            this.txt_num_parte.Name = "txt_num_parte";
            this.txt_num_parte.Size = new System.Drawing.Size(240, 30);
            this.txt_num_parte.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_title.Location = new System.Drawing.Point(13, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1196, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "INVENTARIO EN SISTEMA";
            // 
            // dgv_invent
            // 
            this.dgv_invent.AllowUserToAddRows = false;
            this.dgv_invent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_invent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_invent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_invent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_invent.Location = new System.Drawing.Point(59, 233);
            this.dgv_invent.Name = "dgv_invent";
            this.dgv_invent.ReadOnly = true;
            this.dgv_invent.RowTemplate.Height = 24;
            this.dgv_invent.Size = new System.Drawing.Size(1103, 495);
            this.dgv_invent.TabIndex = 5;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.atras;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(906, 138);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(60, 45);
            this.btn_salir.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_salir, "Cerrar");
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_invent_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgv_invent);
            this.Controls.Add(this.gbx_invent);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_invent_sistema";
            this.gbx_invent.ResumeLayout(false);
            this.gbx_invent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_invent;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.TextBox txt_num_parte;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv_invent;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
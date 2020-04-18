namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    partial class frm_recibo_proveedor
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.gbx_orden = new System.Windows.Forms.GroupBox();
            this.lbl_orden = new System.Windows.Forms.Label();
            this.txt_num_orden = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.double_click_test = new System.Windows.Forms.LinkLabel();
            this.gbx_orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "RECIBO DE PROVEEDOR";
            // 
            // gbx_orden
            // 
            this.gbx_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.gbx_orden.Controls.Add(this.btn_verificar);
            this.gbx_orden.Controls.Add(this.lbl_orden);
            this.gbx_orden.Controls.Add(this.txt_num_orden);
            this.gbx_orden.Location = new System.Drawing.Point(266, 83);
            this.gbx_orden.Name = "gbx_orden";
            this.gbx_orden.Size = new System.Drawing.Size(657, 76);
            this.gbx_orden.TabIndex = 3;
            this.gbx_orden.TabStop = false;
            // 
            // lbl_orden
            // 
            this.lbl_orden.AutoSize = true;
            this.lbl_orden.BackColor = System.Drawing.Color.Transparent;
            this.lbl_orden.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_orden.Location = new System.Drawing.Point(73, 30);
            this.lbl_orden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(146, 17);
            this.lbl_orden.TabIndex = 44;
            this.lbl_orden.Text = "Orden de Compra";
            // 
            // txt_num_orden
            // 
            this.txt_num_orden.BackColor = System.Drawing.Color.White;
            this.txt_num_orden.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_orden.ForeColor = System.Drawing.Color.Black;
            this.txt_num_orden.Location = new System.Drawing.Point(233, 27);
            this.txt_num_orden.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_orden.MaxLength = 25;
            this.txt_num_orden.Multiline = true;
            this.txt_num_orden.Name = "txt_num_orden";
            this.txt_num_orden.Size = new System.Drawing.Size(240, 30);
            this.txt_num_orden.TabIndex = 4;
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.AllowUserToAddRows = false;
            this.dgv_marcas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_marcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_marcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_marcas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_marcas.Location = new System.Drawing.Point(266, 187);
            this.dgv_marcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_marcas.MultiSelect = false;
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.ReadOnly = true;
            this.dgv_marcas.RowTemplate.Height = 24;
            this.dgv_marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_marcas.Size = new System.Drawing.Size(657, 388);
            this.dgv_marcas.TabIndex = 44;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(614, 596);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 45);
            this.btn_guardar.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btn_guardar, "Confirmar Recibo");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(521, 596);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 45);
            this.btn_cancelar.TabIndex = 43;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar Recibo");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_verificar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.check;
            this.btn_verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_verificar.FlatAppearance.BorderSize = 0;
            this.btn_verificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_verificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verificar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_verificar.Location = new System.Drawing.Point(532, 16);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(60, 45);
            this.btn_verificar.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btn_verificar, "Confirmar");
            this.btn_verificar.UseVisualStyleBackColor = false;
            // 
            // double_click_test
            // 
            this.double_click_test.AutoSize = true;
            this.double_click_test.Location = new System.Drawing.Point(322, 610);
            this.double_click_test.Name = "double_click_test";
            this.double_click_test.Size = new System.Drawing.Size(144, 17);
            this.double_click_test.TabIndex = 45;
            this.double_click_test.TabStop = true;
            this.double_click_test.Text = "Dobleclick Event Test";
            this.double_click_test.Click += new System.EventHandler(this.double_click_test_Click);
            // 
            // frm_recibo_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.ControlBox = false;
            this.Controls.Add(this.double_click_test);
            this.Controls.Add(this.dgv_marcas);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gbx_orden);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_recibo_proveedor";
            this.Text = "frm_recibo_proveedor";
            this.gbx_orden.ResumeLayout(false);
            this.gbx_orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gbx_orden;
        private System.Windows.Forms.TextBox txt_num_orden;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_orden;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.LinkLabel double_click_test;
    }
}
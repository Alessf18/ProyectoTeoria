namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    partial class frm_listar_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listar_clientes));
            this.lbl_cliente_listar = new System.Windows.Forms.Label();
            this.gbx_cliente = new System.Windows.Forms.GroupBox();
            this.lbl_mostrar = new System.Windows.Forms.LinkLabel();
            this.lbl_filtra_cliente = new System.Windows.Forms.Label();
            this.txt_filtracliente = new System.Windows.Forms.TextBox();
            this.btn_agrega_cliente = new System.Windows.Forms.Button();
            this.dgv_lista_cliente = new System.Windows.Forms.DataGridView();
            this.gbx_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cliente_listar
            // 
            this.lbl_cliente_listar.AutoSize = true;
            this.lbl_cliente_listar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cliente_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente_listar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_cliente_listar.Location = new System.Drawing.Point(34, 35);
            this.lbl_cliente_listar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cliente_listar.Name = "lbl_cliente_listar";
            this.lbl_cliente_listar.Size = new System.Drawing.Size(221, 25);
            this.lbl_cliente_listar.TabIndex = 5;
            this.lbl_cliente_listar.Text = "LISTA DE CLIENTES";
            // 
            // gbx_cliente
            // 
            this.gbx_cliente.BackColor = System.Drawing.Color.Transparent;
            this.gbx_cliente.Controls.Add(this.lbl_mostrar);
            this.gbx_cliente.Controls.Add(this.lbl_filtra_cliente);
            this.gbx_cliente.Controls.Add(this.txt_filtracliente);
            this.gbx_cliente.Controls.Add(this.btn_agrega_cliente);
            this.gbx_cliente.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_cliente.ForeColor = System.Drawing.Color.White;
            this.gbx_cliente.Location = new System.Drawing.Point(39, 63);
            this.gbx_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_cliente.Name = "gbx_cliente";
            this.gbx_cliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_cliente.Size = new System.Drawing.Size(1103, 71);
            this.gbx_cliente.TabIndex = 6;
            this.gbx_cliente.TabStop = false;
            // 
            // lbl_mostrar
            // 
            this.lbl_mostrar.AutoSize = true;
            this.lbl_mostrar.Location = new System.Drawing.Point(1002, 30);
            this.lbl_mostrar.Name = "lbl_mostrar";
            this.lbl_mostrar.Size = new System.Drawing.Size(95, 17);
            this.lbl_mostrar.TabIndex = 7;
            this.lbl_mostrar.TabStop = true;
            this.lbl_mostrar.Text = "Mostrar Info";
            // 
            // lbl_filtra_cliente
            // 
            this.lbl_filtra_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtra_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_filtra_cliente.Location = new System.Drawing.Point(49, 27);
            this.lbl_filtra_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filtra_cliente.Name = "lbl_filtra_cliente";
            this.lbl_filtra_cliente.Size = new System.Drawing.Size(74, 25);
            this.lbl_filtra_cliente.TabIndex = 2;
            this.lbl_filtra_cliente.Text = "Filtrar";
            // 
            // txt_filtracliente
            // 
            this.txt_filtracliente.Location = new System.Drawing.Point(185, 27);
            this.txt_filtracliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtracliente.Multiline = true;
            this.txt_filtracliente.Name = "txt_filtracliente";
            this.txt_filtracliente.Size = new System.Drawing.Size(637, 30);
            this.txt_filtracliente.TabIndex = 3;
            // 
            // btn_agrega_cliente
            // 
            this.btn_agrega_cliente.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.adduser;
            this.btn_agrega_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agrega_cliente.FlatAppearance.BorderSize = 0;
            this.btn_agrega_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agrega_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_agrega_cliente.Location = new System.Drawing.Point(929, 22);
            this.btn_agrega_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agrega_cliente.Name = "btn_agrega_cliente";
            this.btn_agrega_cliente.Size = new System.Drawing.Size(44, 33);
            this.btn_agrega_cliente.TabIndex = 5;
            this.btn_agrega_cliente.UseVisualStyleBackColor = true;
            // 
            // dgv_lista_cliente
            // 
            this.dgv_lista_cliente.AllowUserToAddRows = false;
            this.dgv_lista_cliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.dgv_lista_cliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_lista_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgv_lista_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista_cliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_lista_cliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(172)))));
            this.dgv_lista_cliente.Location = new System.Drawing.Point(39, 170);
            this.dgv_lista_cliente.MultiSelect = false;
            this.dgv_lista_cliente.Name = "dgv_lista_cliente";
            this.dgv_lista_cliente.ReadOnly = true;
            this.dgv_lista_cliente.RowTemplate.Height = 24;
            this.dgv_lista_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lista_cliente.Size = new System.Drawing.Size(1103, 495);
            this.dgv_lista_cliente.TabIndex = 7;
            // 
            // frm_listar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 779);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_cliente_listar);
            this.Controls.Add(this.gbx_cliente);
            this.Controls.Add(this.dgv_lista_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_listar_clientes";
            this.Load += new System.EventHandler(this.frm_listar_clientes_Load);
            this.gbx_cliente.ResumeLayout(false);
            this.gbx_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cliente_listar;
        private System.Windows.Forms.GroupBox gbx_cliente;
        private System.Windows.Forms.LinkLabel lbl_mostrar;
        private System.Windows.Forms.Label lbl_filtra_cliente;
        private System.Windows.Forms.TextBox txt_filtracliente;
        private System.Windows.Forms.Button btn_agrega_cliente;
        private System.Windows.Forms.DataGridView dgv_lista_cliente;
    }
}
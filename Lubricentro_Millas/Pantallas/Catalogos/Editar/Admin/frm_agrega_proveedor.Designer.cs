namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_agrega_proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_agrega_proveedor));
            this.gbx_provee = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Capa = new System.Windows.Forms.ComboBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_nomb = new System.Windows.Forms.Label();
            this.txt_nomb = new System.Windows.Forms.TextBox();
            this.lbl_direcc = new System.Windows.Forms.Label();
            this.txt_direcc = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbx_provee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_provee
            // 
            this.gbx_provee.Controls.Add(this.label1);
            this.gbx_provee.Controls.Add(this.cmb_Capa);
            this.gbx_provee.Controls.Add(this.cbx_estado);
            this.gbx_provee.Controls.Add(this.lbl_estado);
            this.gbx_provee.Controls.Add(this.lbl_nomb);
            this.gbx_provee.Controls.Add(this.txt_nomb);
            this.gbx_provee.Controls.Add(this.lbl_direcc);
            this.gbx_provee.Controls.Add(this.txt_direcc);
            this.gbx_provee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_provee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_provee.Location = new System.Drawing.Point(18, 28);
            this.gbx_provee.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_provee.Name = "gbx_provee";
            this.gbx_provee.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_provee.Size = new System.Drawing.Size(572, 194);
            this.gbx_provee.TabIndex = 0;
            this.gbx_provee.TabStop = false;
            this.gbx_provee.Text = "Agregar Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(90, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Capacitación";
            // 
            // cmb_Capa
            // 
            this.cmb_Capa.FormattingEnabled = true;
            this.cmb_Capa.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmb_Capa.Location = new System.Drawing.Point(205, 158);
            this.cmb_Capa.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Capa.Name = "cmb_Capa";
            this.cmb_Capa.Size = new System.Drawing.Size(231, 21);
            this.cmb_Capa.TabIndex = 7;
            // 
            // cbx_estado
            // 
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(205, 121);
            this.cbx_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(231, 21);
            this.cbx_estado.TabIndex = 6;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_estado.Location = new System.Drawing.Point(125, 124);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(46, 13);
            this.lbl_estado.TabIndex = 5;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_nomb
            // 
            this.lbl_nomb.AutoSize = true;
            this.lbl_nomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_nomb.Location = new System.Drawing.Point(121, 57);
            this.lbl_nomb.Name = "lbl_nomb";
            this.lbl_nomb.Size = new System.Drawing.Size(50, 13);
            this.lbl_nomb.TabIndex = 1;
            this.lbl_nomb.Text = "Nombre";
            // 
            // txt_nomb
            // 
            this.txt_nomb.Location = new System.Drawing.Point(205, 53);
            this.txt_nomb.MaxLength = 25;
            this.txt_nomb.Name = "txt_nomb";
            this.txt_nomb.Size = new System.Drawing.Size(231, 19);
            this.txt_nomb.TabIndex = 2;
            this.txt_nomb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomb_KeyPress);
            // 
            // lbl_direcc
            // 
            this.lbl_direcc.AutoSize = true;
            this.lbl_direcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_direcc.Location = new System.Drawing.Point(110, 89);
            this.lbl_direcc.Name = "lbl_direcc";
            this.lbl_direcc.Size = new System.Drawing.Size(61, 13);
            this.lbl_direcc.TabIndex = 3;
            this.lbl_direcc.Text = "Dirección";
            // 
            // txt_direcc
            // 
            this.txt_direcc.Location = new System.Drawing.Point(205, 77);
            this.txt_direcc.MaxLength = 30;
            this.txt_direcc.Multiline = true;
            this.txt_direcc.Name = "txt_direcc";
            this.txt_direcc.Size = new System.Drawing.Size(231, 39);
            this.txt_direcc.TabIndex = 4;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.done;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(300, 236);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(39, 32);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(244, 236);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(39, 32);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // frm_agrega_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 305);
            this.ControlBox = false;
            this.Controls.Add(this.gbx_provee);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_agrega_proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_agrega_proveedor_Load);
            this.gbx_provee.ResumeLayout(false);
            this.gbx_provee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbx_provee;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_nomb;
        private System.Windows.Forms.TextBox txt_nomb;
        private System.Windows.Forms.Label lbl_direcc;
        private System.Windows.Forms.TextBox txt_direcc;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Capa;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}
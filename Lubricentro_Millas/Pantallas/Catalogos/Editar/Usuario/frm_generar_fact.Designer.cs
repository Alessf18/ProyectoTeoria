namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    partial class frm_generar_fact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_generar_fact));
            this.gbx_modelos = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.lbl_num_orden = new System.Windows.Forms.Label();
            this.txt_num_orden = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_modelos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_modelos
            // 
            this.gbx_modelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.gbx_modelos.Controls.Add(this.btn_generar);
            this.gbx_modelos.Controls.Add(this.lbl_num_orden);
            this.gbx_modelos.Controls.Add(this.txt_num_orden);
            this.gbx_modelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_modelos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbx_modelos.Location = new System.Drawing.Point(30, 31);
            this.gbx_modelos.Name = "gbx_modelos";
            this.gbx_modelos.Size = new System.Drawing.Size(514, 181);
            this.gbx_modelos.TabIndex = 1;
            this.gbx_modelos.TabStop = false;
            this.gbx_modelos.Text = "Facturación";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(261, 219);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(52, 39);
            this.btn_cancelar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.Transparent;
            this.btn_generar.BackgroundImage = global::Lubricentro_Millas.Properties.Resources.check;
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_generar.Location = new System.Drawing.Point(223, 110);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(60, 45);
            this.btn_generar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_generar, "Generar Factura");
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lbl_num_orden
            // 
            this.lbl_num_orden.AutoSize = true;
            this.lbl_num_orden.BackColor = System.Drawing.Color.Transparent;
            this.lbl_num_orden.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_orden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_num_orden.Location = new System.Drawing.Point(41, 58);
            this.lbl_num_orden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num_orden.Name = "lbl_num_orden";
            this.lbl_num_orden.Size = new System.Drawing.Size(163, 17);
            this.lbl_num_orden.TabIndex = 2;
            this.lbl_num_orden.Text = "# Orden de Servicio";
            // 
            // txt_num_orden
            // 
            this.txt_num_orden.BackColor = System.Drawing.Color.White;
            this.txt_num_orden.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_orden.ForeColor = System.Drawing.Color.Black;
            this.txt_num_orden.Location = new System.Drawing.Point(223, 55);
            this.txt_num_orden.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_orden.MaxLength = 25;
            this.txt_num_orden.Multiline = true;
            this.txt_num_orden.Name = "txt_num_orden";
            this.txt_num_orden.Size = new System.Drawing.Size(240, 30);
            this.txt_num_orden.TabIndex = 3;
            // 
            // frm_generar_fact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 273);
            this.ControlBox = false;
            this.Controls.Add(this.gbx_modelos);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_generar_fact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_generar_fact";
            this.gbx_modelos.ResumeLayout(false);
            this.gbx_modelos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_modelos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label lbl_num_orden;
        private System.Windows.Forms.TextBox txt_num_orden;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
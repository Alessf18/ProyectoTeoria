namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    partial class frm_roles
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
            this.lbl_descrip = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_direcc = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_descrip.Location = new System.Drawing.Point(72, 111);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(74, 13);
            this.lbl_descrip.TabIndex = 5;
            this.lbl_descrip.Text = "Descripción";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(162, 73);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(221, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // lbl_direcc
            // 
            this.lbl_direcc.AutoSize = true;
            this.lbl_direcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_direcc.Location = new System.Drawing.Point(96, 80);
            this.lbl_direcc.Name = "lbl_direcc";
            this.lbl_direcc.Size = new System.Drawing.Size(50, 13);
            this.lbl_direcc.TabIndex = 7;
            this.lbl_direcc.Text = "Nombre";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(162, 108);
            this.txt_descripcion.MaxLength = 30;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(221, 27);
            this.txt_descripcion.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_descrip);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_direcc);
            this.Controls.Add(this.txt_descripcion);
            this.Name = "frm_roles";
            this.Text = "frm_roles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descrip;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_direcc;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button button1;
    }
}
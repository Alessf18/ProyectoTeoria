﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    public partial class frm_modifica_empleado : Form
    {
        public frm_modifica_empleado()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proceso realizado\nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_horas_extr_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_horas_extra Obj_Horas = new frm_horas_extra();
            Obj_Horas.ShowDialog();
        }
    }
}

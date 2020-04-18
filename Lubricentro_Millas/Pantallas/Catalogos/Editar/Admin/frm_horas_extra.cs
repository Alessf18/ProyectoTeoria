using System;
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
    public partial class frm_horas_extra : Form
    {
        public frm_horas_extra()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proceso realizado\nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_enviar_report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reporte Enviado\nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    public partial class frm_recibo_proveedor : Form
    {
        public frm_recibo_proveedor()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recibo realizado\nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void double_click_test_Click(object sender, EventArgs e)
        {
            frm_recibir_insumo Obj_recibo = new frm_recibir_insumo();
            Obj_recibo.ShowDialog();
        }
    }
}

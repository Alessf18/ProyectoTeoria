using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    public partial class frm_inventario : Form
    {
        public frm_inventario()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_ajustar_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Usuario.frm_punto_reorden Obj_Reorden = new Editar.Usuario.frm_punto_reorden();
            Obj_Reorden.ShowDialog();
        }
    }
}

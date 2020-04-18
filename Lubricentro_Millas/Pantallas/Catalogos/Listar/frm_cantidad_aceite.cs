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
    public partial class frm_cantidad_aceite : Form
    {
        public frm_cantidad_aceite()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_cant_aceite Obj_Cantidad = new Editar.Admin.frm_cant_aceite();
            Obj_Cantidad.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lklbl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_cant_aceite Obj_Cantidad = new Editar.Admin.frm_cant_aceite();
            Obj_Cantidad.ShowDialog();
        }
    }
}

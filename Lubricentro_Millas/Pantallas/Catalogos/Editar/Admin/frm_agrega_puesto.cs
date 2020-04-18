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
    public partial class frm_agrega_puesto : Form
    {
        public frm_agrega_puesto()
        {
            InitializeComponent();
        }

        private void btn_cancela_contrase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

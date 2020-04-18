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
    public partial class frm_cambio_contrase : Form
    {
        public frm_cambio_contrase()
        {
            InitializeComponent();
        }

        private void btn_cancela_contrase_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_guardar_contrase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contraseña Actualizada \n exitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}

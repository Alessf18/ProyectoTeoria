using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Millas_DAL.Catalogos;
using Millas_BLL.Catalogos;

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    public partial class frm_crear_cita : Form
    {
        public frm_crear_cita()
        {
            InitializeComponent();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cita Agendada \nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btn_horario_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Usuario.frm_horario Obj_Horario = new frm_horario();
            Obj_Horario.ShowDialog();
        }

        private void frm_crear_cita_Click(object sender, EventArgs e)
        {

            }

        private void btn_verificar_Click(object sender, EventArgs e)
        {

            if (txt_identifica.Text.Trim() == string.Empty)
            {
                erpErrores.SetError(txt_identifica, "Debe llenar este campo antes de realizar la busqueda");
                txt_identifica.Focus();
            }
            else
            {
                erpErrores.Clear();
                cls_Clientes_BLL Obj_Cliente_BLL = new cls_Clientes_BLL();
                cls_Clientes_DAL Obj_Cliente_DAL = new cls_Clientes_DAL();
                Obj_Cliente_DAL.Siden = txt_identifica.Text.Trim();
                Obj_Cliente_BLL.ObtenerInfo(ref Obj_Cliente_DAL);
                if (Obj_Cliente_DAL.dData != null)
                {

                }
                else
                {
                    MessageBox.Show("No existe un cliente registrado con ese número de identificación", "Cliente no existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_identifica.ResetText();
                    txt_identifica.Focus();
                }
            }
    }
    }
}

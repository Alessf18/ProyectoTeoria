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
using System.Configuration;

namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    public partial class frm_listar_citas : Form
    {
        cls_Citas_BLL Obj_Citas_BLL = new cls_Citas_BLL();
        cls_Citas_DAL Obj_Citas_DAL = new cls_Citas_DAL();

        public frm_listar_citas()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_modif_cita_Click(object sender, EventArgs e)
        {
           Editar.Usuario.frm_modifica_cita Obj_Modificar = new Editar.Usuario.frm_modifica_cita();
            Obj_Modificar.ShowDialog();
        }

        private void btn_cancel_cita_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cita Cancelada exitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void frm_listar_citas_Load(object sender, EventArgs e)
        {
            cargarData();
        }
        public void cargarData()

        {
            Obj_Citas_DAL = new cls_Citas_DAL();

            if (txt_filtra_cita.Text == string.Empty)
            {
                Obj_Citas_BLL.List_Citas(ref Obj_Citas_DAL);
            }
            else
            {
                Obj_Citas_DAL.id_Citas = Convert.ToInt32(txt_filtra_cita.Text);
                Obj_Citas_BLL.Fill_Citas(ref Obj_Citas_DAL);
            }

            if (Obj_Citas_DAL.sMgsError == string.Empty)
            {
                dgv_citas.DataSource = null;

                dgv_citas.DataSource = Obj_Citas_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacitas"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Citas_DAL.sMgsError);
                dgv_citas.DataSource = null;
            }

        }
    }
}

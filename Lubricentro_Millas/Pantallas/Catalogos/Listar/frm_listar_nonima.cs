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
    public partial class frm_listar_nonima : Form
    {
        cls_Usuarios_BLL Obj_Usuario_BLL = new cls_Usuarios_BLL();
        cls_Usuarios_DAL Obj_Usuario_DAL = new cls_Usuarios_DAL();

        public frm_listar_nonima()
        {
            InitializeComponent();
        }

        private void btn_agreg_emple_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_reclutamiento Obj_Agrega = new Editar.Admin.frm_reclutamiento();
            Obj_Agrega.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lkl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_modifica_empleado Obj_Agrega = new Editar.Admin.frm_modifica_empleado();
            Obj_Agrega.ShowDialog();
        }

        public void cargarData()
        {
            Obj_Usuario_DAL = new cls_Usuarios_DAL();

            if (txt_filtra_empleados.Text == string.Empty)
            {
                Obj_Usuario_BLL.List_Usuarios(ref Obj_Usuario_DAL);
            }
            else
            {
                Obj_Usuario_DAL.iID = Convert.ToInt32(txt_filtra_empleados.Text);
                Obj_Usuario_BLL.Fill_Usuarios(ref Obj_Usuario_DAL);
            }

            if (Obj_Usuario_DAL.sMgsError == string.Empty)
            {
                dgv_citas.DataSource = null;

                dgv_citas.DataSource = Obj_Usuario_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaempleados"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Usuario_DAL.sMgsError);
                dgv_citas.DataSource = null;
            }

        }

        private void frm_listar_nonima_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void lklbl_ver_historial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_hist_emplea Obj_Historial = new frm_hist_emplea();
            Obj_Historial.ShowDialog();
        }
    }
}

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
    public partial class frm_listar_Roles : Form
    {
        cls_Roles_BLL Obj_Roles_BLL = new cls_Roles_BLL();
        cls_Roles_DAL Obj_Roles_DAL = new cls_Roles_DAL();

        public frm_listar_Roles()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_roles Obj_Roles = new Editar.Admin.frm_roles();
            Obj_Roles.ShowDialog();
        }

        public void cargarData()
        {
            Obj_Roles_DAL = new cls_Roles_DAL();

            if (txt_filtrar_roles.Text == string.Empty)
            {
                Obj_Roles_BLL.List_Roles(ref Obj_Roles_DAL);
            }
            else
            {
                Obj_Roles_DAL.iId_Rol = Convert.ToInt32(txt_filtrar_roles.Text);
                Obj_Roles_BLL.Fill_Roles(ref Obj_Roles_DAL);
            }

            if (Obj_Roles_DAL.sMgsError == string.Empty)
            {
                dgv_rol.DataSource = null;

                dgv_rol.DataSource = Obj_Roles_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaroles"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Roles_DAL.sMgsError);
                dgv_rol.DataSource = null;
            }

        }

        private void frm_listar_Roles_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            Editar.Admin.frm_agrega_rol Obj_Rol = new Editar.Admin.frm_agrega_rol();
            Obj_Rol.ShowDialog();
        }
    }
}

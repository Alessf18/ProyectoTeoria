using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Millas_BLL.BD;
using Millas_DAL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Catalogos;
using System.Configuration;

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    public partial class frm_roles : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_Roles_DAL obj_Roles_DAL = new cls_Roles_DAL();

        public frm_roles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_Roles_BLL obj_Roles_BLL = new cls_Roles_BLL();
            obj_Roles_DAL.sNombre = txt_nombre.Text;
            obj_Roles_DAL.sDescripcion = txt_descripcion.Text;
            obj_Roles_BLL.Insert_Roles(ref obj_Roles_DAL);
            if (obj_Roles_DAL.sMgsError == string.Empty)
            {
                obj_Roles_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de roles Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Roles_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de roles Fallida \n\n Error:[ " + obj_Roles_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Proveedor Agregado\n exitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}

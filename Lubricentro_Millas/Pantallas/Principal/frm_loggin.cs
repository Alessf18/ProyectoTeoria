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
namespace Lubricentro_Millas.Pantallas.Principal
{

    public partial class frm_loggin : Form
    {
        cls_Login_DAL Obj_Login_DAL = new cls_Login_DAL();



        public frm_loggin()
        {
            InitializeComponent();
            txt_usuario.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del Programa?", "CONFIRMAR"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_inic_sesion_Click(object sender, EventArgs e)
        {
            if ((txt_usuario.Text == String.Empty) || (txt_contrasena.Text == String.Empty) || (cmb_roles.Text == string.Empty))
            {
                erp_Error.SetError(cmb_roles, "Necesita escoger una opción");
                MessageBox.Show("El usuario y/o Contraseña estan vacios, Por favor completarlos", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                erp_Error.Clear();
                cargarData();
            }

        }
        private void cargarData()
        {
            Obj_Login_DAL.sUsuario = txt_usuario.Text;
            Obj_Login_DAL.sContrasena = txt_contrasena.Text;
            Obj_Login_DAL.iPuesto= cmb_roles.SelectedIndex+1;
            cls_Login_BLL obj_Login_bll = new cls_Login_BLL();
            if (obj_Login_bll.EstaRegistrado(ref Obj_Login_DAL))
            {
                frm_principal Obj_MenuPrinc = new frm_principal();
                Obj_MenuPrinc.Obj_DAL = Obj_Login_DAL;
                Obj_MenuPrinc.ShowDialog();
            }
            else {

                txt_usuario.ResetText();
                txt_contrasena.ResetText();
                cmb_roles.SelectedIndex = 0;
                MessageBox.Show(Obj_Login_DAL.sMsgError,"Usuario no Registrado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_usuario.Focus();
            }
           
        }

        private void cmb_roles_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

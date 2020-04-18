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

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    public partial class frm_agrega_combust : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_Combustible_DAL obj_Combustible_DAL = new cls_Combustible_DAL();

        public frm_agrega_combust()
        {
            InitializeComponent();
        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_guardar_contrase_Click(object sender, EventArgs e)
        {

            cls_Combustible_BLL obj_Combustible_BLL = new cls_Combustible_BLL();
            obj_Combustible_DAL.sDescripcion = txt_descrip.Text;
            string tempo = cbx_estado.SelectedItem.ToString();
            if (tempo == "Activo")
            {
                obj_Combustible_DAL.cEstado = '1';
            }
            else
            {
                obj_Combustible_DAL.cEstado = '0';
            }
            obj_Combustible_DAL.iCod_EmpleCreador = 1; //Esta quemado porque no puedo validar aún el usuario
            obj_Combustible_DAL.FechaCreado = DateTime.Today;
            obj_Combustible_BLL.Insert_Combustible(ref obj_Combustible_DAL);
            if (obj_Combustible_DAL.sMgsError == string.Empty)
            {
                obj_Combustible_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de combustible Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Combustible_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de combustible Fallida \n\n Error:[ " + obj_Combustible_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
            this.Dispose();
        }

        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_descrip, "Solo se permiten letras");
                e.Handled = true;
            }
        }

        private void frm_agrega_combust_Load(object sender, EventArgs e)
        {

        }
    }
}

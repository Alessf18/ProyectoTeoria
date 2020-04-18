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
    public partial class frm_modelos : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_ModelosVehi_DAL obj_ModelosVehi_DAL = new cls_ModelosVehi_DAL();

        public frm_modelos()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_ModelosVehi_BLL obj_ModelosVehi_BLL = new cls_ModelosVehi_BLL();
            obj_ModelosVehi_DAL.sDescripcion = txt_descripcion.Text;
            string tempo = cbx_estado.SelectedItem.ToString();
            if (tempo == "Activo")
            {
                obj_ModelosVehi_DAL.cEstado = '1';
            }
            else
            {
                obj_ModelosVehi_DAL.cEstado = '0';
            }
            obj_ModelosVehi_DAL.iMotor = Convert.ToInt32(txt_Motor.Text.ToString());
            obj_ModelosVehi_DAL.fAceite = Convert.ToSingle(txt_Aceite.Text.ToString());
            obj_ModelosVehi_DAL.fGas = Convert.ToSingle(txt_Combustible.Text.ToString());
            obj_ModelosVehi_DAL.ICod_Marca = Convert.ToInt32(cmb_Marca.SelectedValue.ToString());
            obj_ModelosVehi_DAL.ICod_Combustible = Convert.ToInt32(cmb_Combustible.SelectedValue.ToString());
            obj_ModelosVehi_DAL.iCod_EmpleCreador = 1; //Esta quemado porque no puedo validar aún el usuario
            obj_ModelosVehi_DAL.FechaCreado = DateTime.Today;
            obj_ModelosVehi_BLL.Insert_ModelosVehi(ref obj_ModelosVehi_DAL);
            if (obj_ModelosVehi_DAL.sMgsError == string.Empty)
            {
                obj_ModelosVehi_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de modelos Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_ModelosVehi_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de modelos Fallida \n\n Error:[ " + obj_ModelosVehi_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_descripcion, "Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txt_Aceite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_Aceite, "Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txt_Coolant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_Coolant, "Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txt_Combustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_Combustible, "Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txt_Motor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_Motor, "Solo se permiten números");
                e.Handled = true;
            }
        }

        private void frm_modelos_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        public void CargarCombo()
        {
            cls_ModelosVehi_BLL obj_ModelosVehi_BLL = new cls_ModelosVehi_BLL();
            obj_ModelosVehi_BLL.List_Marcas(ref obj_ModelosVehi_DAL);
            cmb_Marca.DataSource = obj_ModelosVehi_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString()].DefaultView;
            cmb_Marca.DisplayMember = obj_ModelosVehi_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString()].Columns["Marca"].ToString();
            cmb_Marca.ValueMember = "Id";//Capacitación

            obj_ModelosVehi_BLL.List_Combustible(ref obj_ModelosVehi_DAL);
            cmb_Combustible.DataSource = obj_ModelosVehi_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacombustibles"].ToString()].DefaultView;
            cmb_Combustible.DisplayMember = obj_ModelosVehi_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacombustibles"].ToString()].Columns["Descripcion"].ToString();
            cmb_Combustible.ValueMember = "Id";//Combustible
        }
    }
}

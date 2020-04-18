using System;
using System.Windows.Forms;
using Millas_BLL.BD;
using Millas_DAL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Catalogos;
using System.Configuration;

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    public partial class frm_insumos : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_Insumos_DAL obj_Insumos_DAL = new cls_Insumos_DAL();

        public frm_insumos()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            cls_Insumos_BLL obj_Insumos_BLL = new cls_Insumos_BLL();
            obj_Insumos_DAL.sDescripcion = txt_descripcion.Text;
            string tempo = cbx_estado.SelectedItem.ToString();
            if (tempo == "Activo")
            {
                obj_Insumos_DAL.cEstado = '1';
            }
            else
            {
                obj_Insumos_DAL.cEstado = '0';
            }
            obj_Insumos_DAL.ICod_Unidades = Convert.ToInt32(cmb_Unidad.SelectedValue.ToString());
            obj_Insumos_DAL.iCod_Emple = 1; //Esta quemado porque no puedo validar aún el usuario
            obj_Insumos_DAL.Fecha = DateTime.Today;
            obj_Insumos_BLL.Insert_Insumos(ref obj_Insumos_DAL);
            if (obj_Insumos_DAL.sMgsError == string.Empty)
            {
                obj_Insumos_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de combustible Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Insumos_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de combustible Fallida \n\n Error:[ " + obj_Insumos_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarCombo()
        {
            cls_Insumos_BLL obj_Insumos_BLL = new cls_Insumos_BLL();
            obj_Insumos_BLL.List_UnidadMedida(ref obj_Insumos_DAL);
            cmb_Unidad.DataSource = obj_Insumos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaunidadesdemedidas"].ToString()].DefaultView;
            cmb_Unidad.DisplayMember = obj_Insumos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaunidadesdemedidas"].ToString()].Columns["Descripcion"].ToString();
            cmb_Unidad.ValueMember = "Id";//UnidadMedida
        }

        private void frm_insumos_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        
    }
}

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
    public partial class frm_marcas : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_Marcas_DAL obj_Marcas_DAL = new cls_Marcas_DAL();
        cls_TiposVehiculos_DAL Obj_TipoVehiculos_DAL = new cls_TiposVehiculos_DAL();
        public frm_marcas()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_Marcas_BLL obj_Marcas_BLL = new cls_Marcas_BLL();
            obj_Marcas_DAL.sDescripcion = txt_descripcion.Text;
            obj_Marcas_DAL.bEstado = Convert.ToBoolean(cbx_estado.Text);
            obj_Marcas_DAL.Id_TiposVehi = 2; //Aquí va el cmbox de tipo de vehículo    Convert.ToInt32(cmb_Tipo.SelectedValue.ToString());
            obj_Marcas_DAL.iCod_Emple = 1; //Se jala automatico
            obj_Marcas_DAL.FechaCreado = DateTime.Today;
            obj_Marcas_BLL.Insert_Marcas(ref obj_Marcas_DAL);
            if (obj_Marcas_DAL.sMgsError == string.Empty)
            {
                obj_Marcas_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de marca Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Marcas_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de marca Fallida \n\n Error:[ " + obj_Marcas_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_marcas_Load(object sender, EventArgs e)
        {

        }
        private void CargarCombo()
        {
            //cls_Proveedor_BLL obj_Proveedor_BLL = new cls_Proveedor_BLL();
            //obj_Proveedor_BLL.Listar_Capacitaciones(ref obj_Proveedor_DAL);
            //cmb_Capa.DataSource = obj_Proveedor_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacapacitacion"].ToString()].DefaultView;
            //cmb_Capa.DisplayMember = obj_Proveedor_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacapacitacion"].ToString()].Columns["Nombre"].ToString();
            //cmb_Capa.ValueMember = "Id";//Capacitación
        }
    }
}

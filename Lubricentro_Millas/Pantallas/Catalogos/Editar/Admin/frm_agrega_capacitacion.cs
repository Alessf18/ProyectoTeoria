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
    public partial class frm_agrega_capacitacion : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        public cls_Capacitacion_DAL Obj_Capacitacion_DAL;

        cls_PuestoTrabajo_DAL obj_Puesto_DAL = new cls_PuestoTrabajo_DAL();

        public frm_agrega_capacitacion()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_Capacitacion_BLL obj_Capacitacion_BLL = new cls_Capacitacion_BLL();
            Obj_Capacitacion_DAL.sNombre = txt_descripcion.Text;
            Obj_Capacitacion_DAL.sDireccion = txt_direcc.Text;
            Obj_Capacitacion_DAL.iCod_Puesto = Convert.ToInt32(cbx_puesto.SelectedValue.ToString());
            if (cbx_estado.Text == "Activo")
            {
                Obj_Capacitacion_DAL.cEstado = '1';
            }
            else
            {
                Obj_Capacitacion_DAL.cEstado = '0';
            }
            obj_Capacitacion_BLL.Insert_Capacitacion(ref Obj_Capacitacion_DAL);
            if (Obj_Capacitacion_DAL.sMgsError == string.Empty)
            {
                Obj_Capacitacion_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de proveedor Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Obj_Capacitacion_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de proveedor Fallida \n\n Error:[ " + Obj_Capacitacion_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargaData();
            this.Dispose();
        }
        private void CargarCombo()
        {
            cls_Capacitacion_BLL obj_Capacitacion_BLL = new cls_Capacitacion_BLL();
            obj_Capacitacion_BLL.List_PuestoTrabajo(ref Obj_Capacitacion_DAL);
            cbx_puesto.DataSource = Obj_Capacitacion_DAL.dData.Tables[ConfigurationManager.AppSettings["tablapuestotrabajo"].ToString()].DefaultView;
            cbx_puesto.DisplayMember = Obj_Capacitacion_DAL.dData.Tables[ConfigurationManager.AppSettings["tablapuestotrabajo"].ToString()].Columns["Nombre"].ToString();
            cbx_puesto.ValueMember = "Id";//Capacitación
        }
        public void cargaData()
        {
            if (Obj_Capacitacion_DAL.cBanOpc == 'U')
            {
                gbx_capac.Text = "Modificación de Capacitación";
                txt_descripcion.Text = Obj_Capacitacion_DAL.sNombre.ToString();
                txt_direcc.Text = Obj_Capacitacion_DAL.sDireccion;
                cbx_puesto.Text = Obj_Capacitacion_DAL.iCod_Puesto.ToString();
            }
            else
            {
                gbx_capac.Text = "Crear Nueva Capacitación";
                txt_descripcion.Text = string.Empty;
                txt_direcc.Text = string.Empty;
            }
        }

        private void frm_agrega_capacitacion_Load(object sender, EventArgs e)
        {
            cls_Capacitacion_DAL obj_Capa = new cls_Capacitacion_DAL();
            obj_Capa.cBanOpc = 'I';
            Obj_Capacitacion_DAL = obj_Capa;
            CargarCombo();
            cargaData();
        }
    }
}

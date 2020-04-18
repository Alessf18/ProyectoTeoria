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
    public partial class frm_agrega_proveedor : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_Proveedor_DAL obj_Proveedor_DAL = new cls_Proveedor_DAL();
        cls_Capacitacion_DAL Obj_Capacitacion_DAL = new cls_Capacitacion_DAL();


        public frm_agrega_proveedor()
        {
            InitializeComponent();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_Proveedor_BLL obj_Proveedor_BLL = new cls_Proveedor_BLL();
            obj_Proveedor_DAL.sNombre = txt_nomb.Text;
            obj_Proveedor_DAL.sDireccion = txt_direcc.Text;
            string tempo = cbx_estado.SelectedItem.ToString();
            if (tempo == "Activo")
            {
                obj_Proveedor_DAL.cEstado = '1';
            }
            else
            {
                obj_Proveedor_DAL.cEstado = '0';
            }
            obj_Proveedor_DAL.iId_Capa = Convert.ToInt32(cmb_Capa.SelectedValue.ToString());
            obj_Proveedor_BLL.Insert_Proveedor(ref obj_Proveedor_DAL);
            if (obj_Proveedor_DAL.sMgsError == string.Empty)
            {
                obj_Proveedor_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de proveedor Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Proveedor_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de proveedor Fallida \n\n Error:[ " + obj_Proveedor_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
                cargaData();
            //MessageBox.Show("Proveedor Agregado\n exitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_agrega_proveedor_Load(object sender, EventArgs e)
        {
            CargarCombo();
            cargaData();
        }
        private void CargarCombo()
        {
            cls_Proveedor_BLL obj_Proveedor_BLL = new cls_Proveedor_BLL();
            obj_Proveedor_BLL.Listar_Capacitaciones(ref obj_Proveedor_DAL);
            cmb_Capa.DataSource = obj_Proveedor_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacapacitacion"].ToString()].DefaultView;
            cmb_Capa.DisplayMember = obj_Proveedor_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacapacitacion"].ToString()].Columns["Nombre"].ToString();
            cmb_Capa.ValueMember = "Id";//Capacitación
        }

        private void cargaData()
        {
        }

        private void txt_nomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_nomb, "Solo se permiten letras");
                e.Handled = true;
            }
        }
    }
}

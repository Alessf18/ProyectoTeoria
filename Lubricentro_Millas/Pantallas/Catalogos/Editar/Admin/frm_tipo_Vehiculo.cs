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
    public partial class frm_tipo_Vehiculo : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_TiposVehiculos_DAL obj_TiposVehiculos_DAL = new cls_TiposVehiculos_DAL();

        public DateTime hoy = DateTime.Today;

        public frm_tipo_Vehiculo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_TiposVehiculos_BLL obj_TiposVehiculos_BLL = new cls_TiposVehiculos_BLL();
            obj_TiposVehiculos_DAL.sNombre = txt_nombre.Text;
            obj_TiposVehiculos_DAL.bEstado = Convert.ToBoolean(cbx_estado.Text);
            obj_TiposVehiculos_DAL.iId_Empleado = 2;
            obj_TiposVehiculos_DAL.Fecha = hoy;
            obj_TiposVehiculos_BLL.Insert_TiposVehiculos(ref obj_TiposVehiculos_DAL);
            if (obj_TiposVehiculos_DAL.sMgsError == string.Empty)
            {
                obj_TiposVehiculos_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de proveedor Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_TiposVehiculos_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de proveedor Fallida \n\n Error:[ " + obj_TiposVehiculos_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_tipo_Vehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}

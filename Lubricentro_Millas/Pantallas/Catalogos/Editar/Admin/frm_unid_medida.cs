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

//AGREGARRRRR
namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    public partial class frm_unid_medida : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();
        
        cls_UnidadMedida_DAL obj_UnidadMedida_DAL = new cls_UnidadMedida_DAL();

        public DateTime hoy = DateTime.Today;
        //cls_Capacitacion_DAL Obj_Capacitacion_DAL = new cls_Capacitacion_DAL();
        public frm_unid_medida()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //BLL
            cls_UnidadMedida_BLL obj_UnidadMedida_BLL = new cls_UnidadMedida_BLL();
            obj_UnidadMedida_DAL.sDescripcion = txt_descripcion.Text;
            obj_UnidadMedida_DAL.fPrecio = Convert.ToSingle(txt_precio.Text);
            obj_UnidadMedida_DAL.bEstado = Convert.ToBoolean(cbx_estado.Text);
            obj_UnidadMedida_DAL.iId_Empleado = 2;
            obj_UnidadMedida_DAL.fecha = hoy;
            obj_UnidadMedida_BLL.Insert_UnidadMedida(ref obj_UnidadMedida_DAL);
            if (obj_UnidadMedida_DAL.sMgsError == string.Empty)
            {
                obj_UnidadMedida_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de proveedor Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_UnidadMedida_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de proveedor Fallida \n\n Error:[ " + obj_UnidadMedida_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //MessageBox.Show("Unidad de Medida Agregado\n exitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

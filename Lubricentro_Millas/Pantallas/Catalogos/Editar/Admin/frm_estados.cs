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
    public partial class frm_estados : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        cls_EstadosCitas_DAL obj_EstadosCitas_DAL = new cls_EstadosCitas_DAL();

        public frm_estados()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            cls_EstadosCitas_BLL obj_EstadosCitas_BLL = new cls_EstadosCitas_BLL();
            obj_EstadosCitas_DAL.sDescripcion = txt_descripcion.Text;
            string tempo = cbx_estado.SelectedItem.ToString();
            if (tempo == "Activo")
            {
                obj_EstadosCitas_DAL.cEstado= '1';
            }
            else
            {
                obj_EstadosCitas_DAL.cEstado = '0';
            }
            obj_EstadosCitas_DAL.iCod_Emple = 1; //Esta quemado porque no puedo validar aún el usuario
            obj_EstadosCitas_DAL.Fecha = DateTime.Today;
            obj_EstadosCitas_BLL.Insert_EstadosCitas(ref obj_EstadosCitas_DAL);
            if (obj_EstadosCitas_DAL.sMgsError == string.Empty)
            {
                obj_EstadosCitas_DAL.cBanOpc = 'U';
                MessageBox.Show("Creación de estados Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_EstadosCitas_DAL.cBanOpc = 'I';
                MessageBox.Show("Creación de estados Fallida \n\n Error:[ " + obj_EstadosCitas_DAL.sMgsError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //cargaData();
            //MessageBox.Show("Proveedor Agregado\n exitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8))
            {
                erpError.Clear();
                e.Handled = false;
            }
            else
            {
                erpError.SetError(txt_descripcion, "Solo se permiten letras");
                e.Handled = true;
            }
        }

        private void frm_estados_Load(object sender, EventArgs e)
        {

        }
    }
}

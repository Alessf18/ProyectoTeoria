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
using System.Configuration;

namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    public partial class frm_unid_medida : Form
    {
        cls_UnidadMedida_BLL Obj_UnidadMedida_BLL = new cls_UnidadMedida_BLL();
        cls_UnidadMedida_DAL Obj_UnidadMedida_DAL = new cls_UnidadMedida_DAL();


        public frm_unid_medida()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_unid_medida Obj_Unidad = new Editar.Admin.frm_unid_medida();
            Obj_Unidad.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lklbl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_unid_medida Obj_Unidad = new Editar.Admin.frm_unid_medida();
            Obj_Unidad.ShowDialog();
        }
        public void cargarData()
        {
            Obj_UnidadMedida_DAL = new cls_UnidadMedida_DAL();

            if (txt_filtrar_unidad.Text == string.Empty)
            {
                Obj_UnidadMedida_BLL.List_UnidadMedida(ref Obj_UnidadMedida_DAL);
            }
            else
            {
                Obj_UnidadMedida_DAL.sDescripcion = txt_filtrar_unidad.Text;
                Obj_UnidadMedida_BLL.Fill_Unidades(ref Obj_UnidadMedida_DAL);
            }

            if (Obj_UnidadMedida_DAL.sMgsError == string.Empty)
            {
                dgv_cantidad.DataSource = null;

                dgv_cantidad.DataSource = Obj_UnidadMedida_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaunidadesdemedidas"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_UnidadMedida_DAL.sMgsError);
                dgv_cantidad.DataSource = null;
            }

        }

        private void frm_unid_medida_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

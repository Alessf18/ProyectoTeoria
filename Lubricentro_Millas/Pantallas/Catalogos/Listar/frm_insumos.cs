using System;
using System.Windows.Forms;
using Millas_DAL.Catalogos;
using Millas_BLL.Catalogos;
using System.Configuration;

namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    public partial class frm_insumos : Form
    {
        cls_Insumos_BLL Obj_Insumos_BLL = new cls_Insumos_BLL();
        cls_Insumos_DAL Obj_Insumos_DAL = new cls_Insumos_DAL();
        public frm_insumos()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_insumos Obj_Insumos = new Editar.Admin.frm_insumos();
            Obj_Insumos.ShowDialog();
            cargarData();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lklbl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_insumos Obj_Insumos = new Editar.Admin.frm_insumos();
            Obj_Insumos.ShowDialog();
        }
        public void cargarData()
        {
            Obj_Insumos_DAL = new cls_Insumos_DAL();

            if (txt_filtrar_insumo.Text == string.Empty)
            {
                Obj_Insumos_BLL.List_Insumos(ref Obj_Insumos_DAL);
            }
            else
            {
                Obj_Insumos_DAL.sDescripcion = txt_filtrar_insumo.Text;
                Obj_Insumos_BLL.Fill_Insumos(ref Obj_Insumos_DAL);
            }

            if (Obj_Insumos_DAL.sMgsError == string.Empty)
            {
                dgv_insumo.DataSource = null;

                dgv_insumo.DataSource = Obj_Insumos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablainsumos"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Insumos_DAL.sMgsError);
                dgv_insumo.DataSource = null;
            }

        }

        private void frm_insumos_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

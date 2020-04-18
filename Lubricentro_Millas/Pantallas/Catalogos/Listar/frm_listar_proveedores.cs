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
    public partial class frm_listar_proveedores : Form
    {
        cls_Proveedor_BLL Obj_Proveedor_BLL = new cls_Proveedor_BLL();
        cls_Proveedor_DAL Obj_Proveedor_DAL = new cls_Proveedor_DAL();

        public frm_listar_proveedores()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Admin.frm_agrega_proveedor Obj_Agrega = new Editar.Admin.frm_agrega_proveedor();
            Obj_Agrega.ShowDialog();
            cargarData();
        }

        private void lklbl_modificar_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Admin.frm_agrega_proveedor Obj_Agrega = new Editar.Admin.frm_agrega_proveedor();
            Obj_Agrega.ShowDialog();
        }

        public void cargarData()
        {
            Obj_Proveedor_DAL = new cls_Proveedor_DAL();

            if (txt_filtrar_provee.Text == string.Empty)
            {
                Obj_Proveedor_BLL.List_Proveedor(ref Obj_Proveedor_DAL);
            }
            else
            {
                Obj_Proveedor_DAL.iCod_Provee = Convert.ToInt32(txt_filtrar_provee.Text);
                Obj_Proveedor_BLL.Fill_Proveedor(ref Obj_Proveedor_DAL);
            }

            if (Obj_Proveedor_DAL.sMgsError == string.Empty)
            {
                dgv_proveedor.DataSource = null;

                dgv_proveedor.DataSource = Obj_Proveedor_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaproveedor"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Proveedor_DAL.sMgsError);
                dgv_proveedor.DataSource = null;
            }

        }

        private void frm_listar_proveedores_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }

}

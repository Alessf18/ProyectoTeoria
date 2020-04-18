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
    public partial class frm_listar_marcas : Form
    {
        cls_Marcas_BLL Obj_Marcas_BLL = new cls_Marcas_BLL();
        cls_Marcas_DAL Obj_Marcas_DAL = new cls_Marcas_DAL();

        public frm_listar_marcas()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_marcas Obj_Marcas = new Editar.Admin.frm_marcas();
            Obj_Marcas.ShowDialog();
        }

        private void lklbl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_marcas Obj_Marcas = new Editar.Admin.frm_marcas();
            Obj_Marcas.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void cargarData()
        {
            Obj_Marcas_DAL = new cls_Marcas_DAL();

            if (txt_filtrar_marcas.Text == string.Empty)
            {
                Obj_Marcas_BLL.List_Marcas(ref Obj_Marcas_DAL);
            }
            else
            {
                Obj_Marcas_DAL.sDescripcion = txt_filtrar_marcas.Text;
                Obj_Marcas_BLL.Fill_Marcas(ref Obj_Marcas_DAL);
            }

            if (Obj_Marcas_DAL.sMgsError == string.Empty)
            {
                dgv_marcas.DataSource = null;

                dgv_marcas.DataSource = Obj_Marcas_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Marcas_DAL.sMgsError);
                dgv_marcas.DataSource = null;
            }

        }

        private void frm_listar_marcas_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

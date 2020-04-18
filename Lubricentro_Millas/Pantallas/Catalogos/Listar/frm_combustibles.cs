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
    public partial class frm_combustibles : Form
    {
        cls_Combustible_BLL Obj_Combustible_BLL = new cls_Combustible_BLL();
        cls_Combustible_DAL Obj_Combustible_DAL = new cls_Combustible_DAL();
        public frm_combustibles()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_agrega_combust Obj_Combustible = new Editar.Admin.frm_agrega_combust();
            Obj_Combustible.ShowDialog();
            cargarData();
        }
        public void cargarData()
        {
            Obj_Combustible_DAL = new cls_Combustible_DAL();

            if (txt_filtrar_combust.Text == string.Empty)
            {
                Obj_Combustible_BLL.List_Combustible(ref Obj_Combustible_DAL);
            }
            else
            {
                Obj_Combustible_DAL.sDescripcion = txt_filtrar_combust.Text;
                Obj_Combustible_BLL.Fill_Combustible(ref Obj_Combustible_DAL);
            }

            if (Obj_Combustible_DAL.sMgsError == string.Empty)
            {
                dgv_combustib.DataSource = null;

                dgv_combustib.DataSource = Obj_Combustible_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacombustibles"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Combustible_DAL.sMgsError);
                dgv_combustib.DataSource = null;
            }

        }

        private void frm_combustibles_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void txt_filtrar_combust_TextChanged(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

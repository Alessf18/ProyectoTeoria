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
    public partial class frm_listar_modelos : Form
    {
        cls_ModelosVehi_BLL Obj_Modelos_BLL = new cls_ModelosVehi_BLL();
        cls_ModelosVehi_DAL Obj_Modelos_DAL = new cls_ModelosVehi_DAL();
        public frm_listar_modelos()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_modelos Obj_Modelos = new Editar.Admin.frm_modelos();
            Obj_Modelos.ShowDialog();
            cargarData();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lklbl_modifica_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_modelos Obj_Modelos = new Editar.Admin.frm_modelos();
            Obj_Modelos.ShowDialog();
        }
        public void cargarData()
        {
            Obj_Modelos_DAL = new cls_ModelosVehi_DAL();

            if (txt_filtra_modelo.Text == string.Empty)
            {
                Obj_Modelos_BLL.List_ModelosVehi(ref Obj_Modelos_DAL);
            }
            else
            {
                Obj_Modelos_DAL.sDescripcion = txt_filtra_modelo.Text;
                Obj_Modelos_BLL.Fill_MModelosVehi(ref Obj_Modelos_DAL);
            }

            if (Obj_Modelos_DAL.sMgsError == string.Empty)
            {
                dgv_modelos.DataSource = null;

                dgv_modelos.DataSource = Obj_Modelos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Modelos_DAL.sMgsError);
                dgv_modelos.DataSource = null;
            }

        }
        private void frm_listar_modelos_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void txt_filtra_modelo_TextChanged(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

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

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Admin
{
    public partial class frm_puestos : Form
    {
        cls_PuestoTrabajo_BLL Obj_PuestoTrabajo_BLL = new cls_PuestoTrabajo_BLL();
        cls_PuestoTrabajo_DAL Obj_PuestoTrabajo_DAL = new cls_PuestoTrabajo_DAL();
        public frm_puestos()
        {
            InitializeComponent();
        }

        private void btn_agrega_puesto_Click(object sender, EventArgs e)
        {
            frm_agrega_puesto Obj_Puesto = new frm_agrega_puesto();
            Obj_Puesto.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_puestos_Load(object sender, EventArgs e)
        {
            cargarData();
        }
          public void cargarData()
        {
            Obj_PuestoTrabajo_DAL = new cls_PuestoTrabajo_DAL();

            if (txt_filtra_puestos.Text == string.Empty)
            {
                Obj_PuestoTrabajo_BLL.List_PuestoTrabajon(ref Obj_PuestoTrabajo_DAL);
            }
            else
            {
                Obj_PuestoTrabajo_DAL.iCod_Id = Convert.ToInt32(txt_filtra_puestos.Text);
                Obj_PuestoTrabajo_BLL.List_PuestoTrabajon(ref Obj_PuestoTrabajo_DAL);
            }

            if (Obj_PuestoTrabajo_DAL.sMgsError == string.Empty)
            {
                dgv_puestos.DataSource = null;

                dgv_puestos.DataSource = Obj_PuestoTrabajo_DAL.dData.Tables[ConfigurationManager.AppSettings["tablapuestotrabajo"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_PuestoTrabajo_DAL.sMgsError);
                dgv_puestos.DataSource = null;
            }

        }
    }
}

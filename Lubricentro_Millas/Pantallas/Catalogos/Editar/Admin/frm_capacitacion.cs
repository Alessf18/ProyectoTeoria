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
    public partial class frm_capacitacion : Form
    {
        cls_Capacitacion_BLL Obj_Capacitacion_BLL = new cls_Capacitacion_BLL();
        public cls_Capacitacion_DAL Obj_Capacitacion_DAL;



        public frm_capacitacion()
        {
            InitializeComponent();
        }

        private void btn_agrega_capacit_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_agrega_capacitacion Obj_Agrega = new frm_agrega_capacitacion();
            Obj_Agrega.ShowDialog();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lkl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_agrega_capacitacion Obj_Agrega = new frm_agrega_capacitacion();
            Obj_Agrega.ShowDialog();

        }
        public void cargarData()
        {
            Obj_Capacitacion_DAL = new cls_Capacitacion_DAL();

            if (txt_filtra_capacita.Text == string.Empty)
            {
                Obj_Capacitacion_BLL.List_Capacitacion(ref Obj_Capacitacion_DAL);
            }
            else
            {
                Obj_Capacitacion_DAL.sNombre = txt_filtra_capacita.Text; 
                Obj_Capacitacion_BLL.Fill_Capacitacion(ref Obj_Capacitacion_DAL);
            }

            if (Obj_Capacitacion_DAL.sMgsError == string.Empty)
            {
                dgv_capacita.DataSource = null;

                dgv_capacita.DataSource = Obj_Capacitacion_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacapacitacion"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Capacitacion_DAL.sMgsError);
                dgv_capacita.DataSource = null;
            }

        }



        private void frm_capacitacion_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        private void dgv_capacita_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgv_capacita.Rows.Count >= 1)
            {
                Obj_Capacitacion_DAL.cBanOpc = 'U';
                Obj_Capacitacion_DAL.iCod_Capac = Convert.ToInt32(dgv_capacita.SelectedRows[0].Cells[0].Value.ToString());
                Obj_Capacitacion_DAL.sNombre = dgv_capacita.SelectedRows[0].Cells[1].Value.ToString();
                Obj_Capacitacion_DAL.sDireccion = dgv_capacita.SelectedRows[0].Cells[2].Value.ToString();
                bool tempo= Convert.ToBoolean(dgv_capacita.SelectedRows[0].Cells[3].Value.ToString());
                if(tempo)
                {
                    Obj_Capacitacion_DAL.cEstado = '1';
                }
                else
                {
                    Obj_Capacitacion_DAL.cEstado = '0';
                }
                Obj_Capacitacion_DAL.iCod_Puesto = Convert.ToInt32(dgv_capacita.SelectedRows[0].Cells[4].Value.ToString());

                frm_agrega_capacitacion Pan_Edit = new frm_agrega_capacitacion();
                Pan_Edit.Obj_Capacitacion_DAL = Obj_Capacitacion_DAL;
                Pan_Edit.ShowDialog();

                cargarData();
            }
            else
            {
                MessageBox.Show("Error no hay datos para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

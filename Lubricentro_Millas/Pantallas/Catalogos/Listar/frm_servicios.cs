using System;
using System.Windows.Forms;
using Millas_DAL.Catalogos;
using Millas_BLL.Catalogos;
using System.Configuration;

namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    public partial class frm_servicios : Form
    {
        cls_Servicios_BLL Obj_Servicios_BLL = new cls_Servicios_BLL();
        cls_Servicios_DAL Obj_Servicios_DAL = new cls_Servicios_DAL();
        public frm_servicios()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_servicios Obj_Servicios = new Editar.Admin.frm_servicios();
            Obj_Servicios.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lklbl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_servicios Obj_Servicios = new Editar.Admin.frm_servicios();
            Obj_Servicios.ShowDialog();
        }
        public void cargarData()
        {
            Obj_Servicios_DAL = new cls_Servicios_DAL();

            if (txt_filtrar_servicio.Text == string.Empty)
            {
                Obj_Servicios_BLL.List_Servicios(ref Obj_Servicios_DAL);
            }
            else
            {
                Obj_Servicios_DAL.sDescripcion = txt_filtrar_servicio.Text;
                Obj_Servicios_BLL.Fill_Servicios(ref Obj_Servicios_DAL);
            }

            if (Obj_Servicios_DAL.sMgsError == string.Empty)
            {
                dgv_servicios.DataSource = null;

                dgv_servicios.DataSource = Obj_Servicios_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaservicios"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Servicios_DAL.sMgsError);
                dgv_servicios.DataSource = null;
            }

        }

        private void frm_servicios_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

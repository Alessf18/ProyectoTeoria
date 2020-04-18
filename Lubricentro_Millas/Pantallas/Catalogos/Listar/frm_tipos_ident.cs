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
    public partial class frm_tipos_ident : Form
    {
        cls_TipoIdentificacion_BLL Obj_Identificacion_BLL = new cls_TipoIdentificacion_BLL();
        cls_TipoIdentificacion_DAL Obj_Identificacion_DAL = new cls_TipoIdentificacion_DAL();
        public frm_tipos_ident()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_agrega_tipIdentif Obj_tipoID = new Editar.Admin.frm_agrega_tipIdentif();
            Obj_tipoID.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cargarData()
        {
            Obj_Identificacion_DAL = new cls_TipoIdentificacion_DAL();

            if (txt_filtrar_tipo_ident.Text == string.Empty)
            {
                Obj_Identificacion_BLL.List_Identificacion(ref Obj_Identificacion_DAL);
            }
            else
            {
                Obj_Identificacion_DAL.iCod_Identificacion = Convert.ToInt32(txt_filtrar_tipo_ident.Text);
                Obj_Identificacion_BLL.List_Identificacion(ref Obj_Identificacion_DAL);
            }

            if (Obj_Identificacion_DAL.sMgsError == string.Empty)
            {
                dgv_tipo_ident.DataSource = null;

                dgv_tipo_ident.DataSource = Obj_Identificacion_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaindentificaciones"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Identificacion_DAL.sMgsError);
                dgv_tipo_ident.DataSource = null;
            }

        }

        private void frm_tipos_ident_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

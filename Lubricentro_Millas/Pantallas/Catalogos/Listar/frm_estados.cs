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
    public partial class frm_estados : Form
    {
        cls_EstadosCitas_BLL Obj_EstadosCitas_BLL = new cls_EstadosCitas_BLL();
        cls_EstadosCitas_DAL Obj_EstadosCitas_DAL = new cls_EstadosCitas_DAL();

        public frm_estados()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_estados Obj_Estados = new Editar.Admin.frm_estados();
            Obj_Estados.ShowDialog();
            cargarData();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_estados_Load(object sender, EventArgs e)
        {
            cargarData();
        }

        public void cargarData()
        {
            Obj_EstadosCitas_DAL = new cls_EstadosCitas_DAL();

            if (txt_filtrar_estados.Text == string.Empty)
            {
                Obj_EstadosCitas_BLL.List_EstadosCitas(ref Obj_EstadosCitas_DAL);
            }
            else
            {
                Obj_EstadosCitas_DAL.sDescripcion = txt_filtrar_estados.Text;
                Obj_EstadosCitas_BLL.Fill_EstadosCitas(ref Obj_EstadosCitas_DAL);
            }

            if (Obj_EstadosCitas_DAL.sMgsError == string.Empty)
            {
                dgv_estados.DataSource = null;

                dgv_estados.DataSource = Obj_EstadosCitas_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaestadoscitas"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_EstadosCitas_DAL.sMgsError);
                dgv_estados.DataSource = null;
            }

        }

        private void txt_filtrar_estados_TextChanged(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

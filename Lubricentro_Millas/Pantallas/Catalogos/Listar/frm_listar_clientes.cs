using System;
using System.Windows.Forms;
using Millas_DAL.Catalogos;
using Millas_BLL.Catalogos;
using System.Configuration;

namespace Lubricentro_Millas.Pantallas.Catalogos.Listar
{
    public partial class frm_listar_clientes : Form
    {
        cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();
        cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();
        public frm_listar_clientes()
        {
            InitializeComponent();
        }
        public void cargarData()
        {
            Obj_Clientes_DAL = new cls_Clientes_DAL();

            if (txt_filtracliente.Text == string.Empty)
            {
                Obj_Clientes_BLL.List_Clientes(ref Obj_Clientes_DAL);
            }
            else
            {
                Obj_Clientes_DAL.sNombres = txt_filtracliente.Text;// hay que revisar//
                Obj_Clientes_BLL.Fill_Clientes(ref Obj_Clientes_DAL);
            }

            if (Obj_Clientes_DAL.sMgsError == string.Empty)
            {
                dgv_lista_cliente.DataSource = null;

                dgv_lista_cliente.DataSource = Obj_Clientes_DAL.dData.Tables[ConfigurationManager.AppSettings["tablaclientes"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_Clientes_DAL.sMgsError);
                dgv_lista_cliente.DataSource = null;
            }

        }
        private void frm_listar_clientes_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

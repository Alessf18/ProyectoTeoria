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
    public partial class frm_listar_tipVehic : Form
    {        
        cls_TiposVehiculos_BLL Obj_TiposVehiculos_BLL = new cls_TiposVehiculos_BLL();
        cls_TiposVehiculos_DAL Obj_TiposVehiculos_DAL = new cls_TiposVehiculos_DAL();

        public frm_listar_tipVehic()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_tipo_Vehiculo Obj_Tipo = new Editar.Admin.frm_tipo_Vehiculo();
            Obj_Tipo.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lklbl_modificar_Click(object sender, EventArgs e)
        {
            Editar.Admin.frm_tipo_Vehiculo Obj_Tipo = new Editar.Admin.frm_tipo_Vehiculo();
            Obj_Tipo.ShowDialog();
        }
        public void cargarData()
        {
            Obj_TiposVehiculos_DAL = new cls_TiposVehiculos_DAL();

            if (txt_filtrar_tipo.Text == string.Empty)
            {
                Obj_TiposVehiculos_BLL.List_TiposVehiculos(ref Obj_TiposVehiculos_DAL);
            }
            else
            {
                Obj_TiposVehiculos_DAL.sNombre= txt_filtrar_tipo.Text;
                Obj_TiposVehiculos_BLL.Fill_TiposVehiculos(ref Obj_TiposVehiculos_DAL);
            }

            if (Obj_TiposVehiculos_DAL.sMgsError == string.Empty)
            {
                dgv_tipo.DataSource = null;

                dgv_tipo.DataSource = Obj_TiposVehiculos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString()];
            }
            else
            {
                MessageBox.Show("Error " + Obj_TiposVehiculos_DAL.sMgsError);
                dgv_tipo.DataSource = null;
            }

        }
        private void frm_listar_tipVehic_Load(object sender, EventArgs e)
        {
            cargarData();
        }
    }
}

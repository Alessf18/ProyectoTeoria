using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Millas_BLL.BD;
using Millas_DAL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Catalogos;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    public partial class frm_registrar_cliente : Form
    {
        cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        public cls_Clientes_DAL Obj_Clientes_DAL;
        cls_Marcas_DAL Obj_Marcas_DAL = new cls_Marcas_DAL();
        cls_TiposVehiculos_DAL Obj_TipoVehi_DAL = new cls_TiposVehiculos_DAL();
        cls_ModelosVehi_DAL Obj_Modelos_DAL = new cls_ModelosVehi_DAL();

        public frm_registrar_cliente()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente registrado \nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelar registro !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           this.Dispose();
        }

        private void AñadirMarca_MouseClick(object sender, MouseEventArgs e)
        {
            Editar.Admin.frm_marcas Obj_Marcas = new Editar.Admin.frm_marcas();
            Obj_Marcas.ShowDialog();
        }

        private void frm_registrar_cliente_Load(object sender, EventArgs e)
        {
            cls_Clientes_DAL obj_Cli = new cls_Clientes_DAL();
            obj_Cli.cBanOpc = 'I';
            Obj_Clientes_DAL = obj_Cli;
            CargarCombo();
       
        }

        public void CargarCombo()
        {
            cls_Clientes_BLL obj_Clientes_BLL = new cls_Clientes_BLL();
            obj_Clientes_BLL.List_Marcas(ref Obj_Clientes_DAL);
            cmb_Marca.DataSource = Obj_Clientes_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString()].DefaultView;
          
            cmb_Marca.DisplayMember = Obj_Clientes_DAL.dData.Tables[0].Columns["Marca"].ToString();
                //Obj_Clientes_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString()].Columns["Descripcion"].ToString();
            cmb_Marca.ValueMember = "Id";//Marca

            //obj_Clientes_BLL.List_ModelosVehi(ref obj_Cliente_DAL);
            //cmb_Marca.DataSource = obj_Cliente_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString()].DefaultView;
            //cmb_Marca.DisplayMember = obj_Cliente_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString()].Columns["Descripcion"].ToString();
            //cmb_Marca.ValueMember = "Id";//Modelo

            //obj_Clientes_BLL.List_TiposVehiculos(ref obj_Cliente_DAL);
            //cmb_Marca.DataSource = obj_Cliente_DAL.dData.Tables[ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString()].DefaultView;
            //cmb_Marca.DisplayMember = obj_Cliente_DAL.dData.Tables[ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString()].Columns["Nombre"].ToString();
            //cmb_Marca.ValueMember = "Id";//Tipos
        }


        private void txt_placa_Leave(object sender, EventArgs e)
        {
            Regex regexPlacaV1 = new Regex("^[A-Z]{3,3}\\- [0-9]{3,3}$");
            //Regex regexPlacaV2 = new Regex("^[0-9]{3,3}\\- [A-Z]{3,3]$");
            if (regexPlacaV1.IsMatch(txt_placa.Text.Trim()) == false) {
                erpErrores.SetError(txt_placa,"Formato incorrecto, ej: 123-ABC ó ABC-123");
                txt_placa.ResetText();
                txt_placa.Focus();
            }
        }

        private void txt_identifica_Leave(object sender, EventArgs e)
        {

        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {

        }
    }
}

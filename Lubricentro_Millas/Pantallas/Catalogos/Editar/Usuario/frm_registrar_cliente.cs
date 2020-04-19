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
        //cls_BD_BLL Obj_BLL_DB = new cls_BD_BLL();
        //cls_BD_DAL Obj_CNX_DAL = new cls_BD_DAL();

        public cls_Clientes_DAL Obj_Clientes_DAL;
        public frm_registrar_cliente()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_Clientes_BLL Obj_Cliente_BLL = new cls_Clientes_BLL();
            cls_Clientes_DAL Obj_Cliente_DAL = new cls_Clientes_DAL();
            Obj_Clientes_DAL.sNombres = txt_nombre.Text.Trim();
            Obj_Clientes_DAL.Siden = msk_Identi.Text;
            Obj_Clientes_DAL.sApellidos = txt_prim_ape.Text.Trim() + " " + txt_seg_ape.Text.Trim();
            msk_telefono1.Text = msk_telefono1.Text.Replace("-", "");
            Obj_Clientes_DAL.iNumeroTele = Convert.ToInt32(msk_telefono1.Text.Trim());
            msk_Telefono2.Text = msk_Telefono2.Text.Replace("-", "");
            Obj_Clientes_DAL.iNumeroCel =Convert.ToInt32( msk_Telefono2.Text.Trim());
            Obj_Clientes_DAL.sCorreo = txt_correo.Text.Trim();
            Obj_Clientes_DAL.sDireccion = txt_direccion.Text.Trim();
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
            #region Objetos DAL
            cls_Marcas_DAL Obj_Marcas_DAL = new cls_Marcas_DAL();
            cls_TiposVehiculos_DAL Obj_TipoVehi_DAL = new cls_TiposVehiculos_DAL();
            cls_ModelosVehi_DAL Obj_Modelos_DAL = new cls_ModelosVehi_DAL();
            cls_Combustible_DAL Obj_Combus_DAL = new cls_Combustible_DAL();
            #endregion
            #region Objetos BLL
            cls_Marcas_BLL Obj_Marcacs_BLL = new cls_Marcas_BLL();
            cls_ModelosVehi_BLL Obj_Modelos_BLL = new cls_ModelosVehi_BLL();
            cls_TiposVehiculos_BLL Obj_Tipos_BLL = new cls_TiposVehiculos_BLL();
            cls_Clientes_BLL obj_Clientes_BLL = new cls_Clientes_BLL();
            cls_Combustible_BLL Obj_Combus_BLL=new cls_Combustible_BLL();

            #endregion
            Obj_Marcacs_BLL.List_Marcas(ref Obj_Marcas_DAL);
            cmb_Marca.DataSource = Obj_Marcas_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString()].DefaultView;
            cmb_Marca.DisplayMember = Obj_Marcas_DAL.dData.Tables[0].Columns["Marca"].ToString();
            cmb_Marca.ValueMember = "Id";//Marca

            Obj_Modelos_BLL.List_ModelosVehi(ref Obj_Modelos_DAL);
            cmb_Modelo.DataSource = Obj_Modelos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString()].DefaultView;
            cmb_Modelo.DisplayMember = Obj_Modelos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString()].Columns["Modelo"].ToString();
            cmb_Modelo.ValueMember = "Id";//Modelo

            Obj_Tipos_BLL.List_TiposVehiculos(ref Obj_TipoVehi_DAL);
            cbx_tipos.DataSource = Obj_TipoVehi_DAL.dData.Tables[ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString()].DefaultView;
            cbx_tipos.DisplayMember = Obj_TipoVehi_DAL.dData.Tables[ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString()].Columns["Nombre"].ToString();
            cbx_tipos.ValueMember = "Id";//Tipos

            Obj_Combus_BLL.List_Combustible(ref Obj_Combus_DAL);
            cbx_combus.DataSource = Obj_Combus_DAL.dData.Tables[ConfigurationManager.AppSettings["tablacombustibles"].ToString()].DefaultView;
            cbx_combus.DisplayMember= Obj_Combus_DAL.dData.Tables[0].Columns["Descripcion"].ToString();
            cbx_combus.ValueMember = "Id";// Combustibles
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
        private void rbtn_cedula_CheckedChanged(object sender, EventArgs e)
        {
            msk_Identi.Mask = "0-0000-0000";
            msk_Identi.Focus();

        }

        private void rbtn_pasaporte_CheckedChanged(object sender, EventArgs e)
        {
            msk_Identi.Mask = "AA000000";
            msk_Identi.Focus();

        }

        private void rbtn_residencia_CheckedChanged(object sender, EventArgs e)
        {
            msk_Identi.Mask = "0-0000-0000";
            msk_Identi.Focus();

        }


        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else {
                e.Handled = false;
            }
        }

        private void txt_prim_ape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_seg_ape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}

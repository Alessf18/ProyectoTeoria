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


namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    public partial class frm_registrar_cliente : Form
    {
        #region Variables Globales
        public cls_Clientes_DAL Obj_Cliente_DAL=new cls_Clientes_DAL();
        #endregion
       

        public cls_Clientes_DAL Obj_Clientes_DAL;
        public frm_registrar_cliente()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /*
            
                @Nombre varchar(50),
           @Apellidos varchar(50),
           @id_TiposIdentificaciones int,
           @Identificacion varchar(20),
           @Correo varchar(50),
           @TelefonoCelular int,
           @TelefonoFijo int,
           @Direccion VARCHAR(250),
           @Id_Crea_Empleados int,
           @FechaCreado datetime)
             */
            cls_Clientes_BLL Obj_Cliente_BLL = new cls_Clientes_BLL();
           
            Obj_Clientes_DAL.sNombres = txt_nombre.Text.Trim();
            Obj_Clientes_DAL.sApellidos = txt_prim_ape.Text.Trim() + " " + txt_seg_ape.Text.Trim();
            Obj_Clientes_DAL.Siden = msk_Identi.Text;
            Obj_Clientes_DAL.iNumeroTele = Convert.ToInt32(txt_Telefono1.Text.Trim());
            Obj_Clientes_DAL.iNumeroCel =Convert.ToInt32( txt_Telefono2.Text.Trim());
            Obj_Clientes_DAL.sCorreo = txt_correo.Text.Trim();
            Obj_Clientes_DAL.sDireccion = txt_direccion.Text.Trim();
            Obj_Clientes_DAL.FechaCreado = DateTime.Now;
            Obj_Cliente_BLL.Insert_Clientes(ref Obj_Cliente_DAL);
            if (Obj_Cliente_DAL.iCod_Id != -1) {
                /*
             @Id_Clientes int,
            @Placa varchar(20),
             @Id_TiposVehiculos int,
            @Id_Combustible int,
             @Id_MarcasVehiculos int,
            @Id_ModelosVehiculos int,
            @Anio int,
            @Comentario varchar(50)    
             
             */
                cls_VehiPorClientes_BLL Obj_Vh_BLL = new cls_VehiPorClientes_BLL();
                cls_VehiPorClientes_DAL Obj_Vh_DAL = new cls_VehiPorClientes_DAL();
                Obj_Vh_DAL.iId_Cliente = Obj_Cliente_DAL.iCod_Id;
                Obj_Vh_DAL.sPlaca = msk_placa.Text.Trim();
                Obj_Vh_DAL.iCod_TipoVehiculos = Convert.ToInt32 (cbx_tipos.SelectedValue);
                Obj_Vh_DAL.iCod_Combustible = Convert.ToInt32(cbx_combus.SelectedValue);
                Obj_Vh_DAL.iCod_MarcasVehiculos = Convert.ToInt32(cmb_Marca.SelectedValue);
                Obj_Vh_DAL.iCod_ModelosVehiculos = Convert.ToInt32(cmb_Modelo.SelectedValue);
                Obj_Vh_DAL.iAnio = Convert.ToInt32(nUD_Anio.Value);
                Obj_Vh_DAL.sComentario = txt_comentario.Text.Trim();
                Obj_Vh_BLL.Insert_VehiPorClientes(ref Obj_Vh_DAL);
                if (Obj_Vh_DAL.sMgsError == "") {
                    MessageBox.Show("Cliente registrado \nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{
                    MessageBox.Show(Obj_Vh_DAL.sMgsError, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
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
            nUD_Anio.Maximum = DateTime.Now.Year;
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
           
            cls_Combustible_BLL Obj_Combus_BLL=new cls_Combustible_BLL();

            #endregion
            Obj_Marcacs_BLL.List_Marcas(ref Obj_Marcas_DAL);
            cmb_Marca.DataSource = Obj_Marcas_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString()].DefaultView;
            cmb_Marca.DisplayMember = Obj_Marcas_DAL.dData.Tables[0].Columns["Marca"].ToString();
            cmb_Marca.ValueMember = "Id";//Marca

            Obj_Modelos_BLL.List_ModelosVehi(ref Obj_Modelos_DAL);
            cmb_Modelo.DataSource = Obj_Modelos_DAL.dData.Tables[ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString()].DefaultView;
            cmb_Modelo.DisplayMember = Obj_Modelos_DAL.dData.Tables[0].Columns["Modelo"].ToString();
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


        private void msk_placa_Leave(object sender, EventArgs e)
        {
            if (msk_placa.Text == "") {
                erpErrores.SetError(msk_placa,"debe de llenar este campo");
                msk_placa.Focus();
            }
            else{
                erpErrores.Clear();
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
            Obj_Cliente_DAL.ICod_id_Identificaciones = 1;
        }

        private void rbtn_pasaporte_CheckedChanged(object sender, EventArgs e)
        {
            msk_Identi.Mask = "AA000000";
            msk_Identi.Focus();
            Obj_Cliente_DAL.ICod_id_Identificaciones = 2;
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

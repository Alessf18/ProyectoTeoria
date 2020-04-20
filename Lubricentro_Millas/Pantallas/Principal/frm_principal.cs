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

namespace Lubricentro_Millas.Pantallas.Principal
{
    public partial class frm_principal : Form
    {
        public cls_Login_DAL Obj_DAL;

        public frm_principal()
        {
            InitializeComponent();
            
        }

        
        private void cargarMenu()
        {
            //Lo deje así porque no entrando al switch case porque la opcion trae 0
            //tst_seguridad.Visible = true;
            //tst_Servicios_Ope.Visible = true;
            //tst_catalogos.Visible = true;
            //tst_RH.Visible = true;
            //tst_Inventario.Visible = true;
            //tst_Factura.Visible = true;


            tst_seguridad.Visible = false;
            tst_Servicios_Ope.Visible = false;
            tst_catalogos.Visible = false;
            tst_RH.Visible = false;
            tst_Inventario.Visible = false;
            tst_Factura.Visible = false;

            switch (Obj_DAL.iPuesto)
            {
                case 1: //Admin
                    tst_seguridad.Visible = true;
                    tst_Servicios_Ope.Visible = true;
                    tst_catalogos.Visible = true;
                    tst_RH.Visible = true;
                    tst_Inventario.Visible = true;
                    tst_Factura.Visible = true;
                    break;
                case 2://"Inventario": //Inventario    --- Me falta quitar que apruebe la correción del inventario
                    tst_seguridad.Visible = true;
                    tstItem_recupera_contrase.Visible = false;
                    tst_Inventario.Visible = true;
                    break;
                case 3://Recursos Humanos": //Aqui hay falta poner recursos humanos quien hace que 
                    tst_seguridad.Visible = true;
                    tstItem_recupera_contrase.Visible = false;
                    tst_RH.Visible = true;
                    break;
                case 4: //"Servicio al Cliente": // Servicio al cliente -- Facturación
                    tst_seguridad.Visible = true;
                    tstItem_recupera_contrase.Visible = false;
                    tst_Servicios_Ope.Visible = true;
                    tstItem_ordenServ_mecan.Visible = false;
                    tst_Factura.Visible = true;
                    break;
                case 5:// "Servicio Operario": // Servicio operario
                    tst_seguridad.Visible = true;
                    tstItem_recupera_contrase.Visible = false;
                    tst_Servicios_Ope.Visible = true;
                    tstItem_citas.Visible = false;
                    tstItem_cliente.Visible = false;
                    break;
            }
        }

        private void abrirFormInPanel(object obj_formHijo)
        {
            if (this.pnl_principal.Controls.Count > 0)
                this.pnl_principal.Controls.RemoveAt(0);
            Form fh = obj_formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_principal.Controls.Add(fh);
            this.pnl_principal.Tag = fh;
            fh.Show();
        }

        private void frm_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
                  
        }

        private void tstp_citas_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_citas());
        }

        private void tstp_clientes_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_clientes());
        }
        
        private void tstItem_recupera_contrase_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Admin.frm_recupera_contrase Obj_Recupera = new Catalogos.Editar.Admin.frm_recupera_contrase();
            Obj_Recupera.ShowDialog();
        }

        private void tstItem_cambia_contrase_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Usuario.frm_cambio_contrase Obj_Cambia = new Catalogos.Editar.Usuario.frm_cambio_contrase();
            Obj_Cambia.ShowDialog();
        }

        private void tstItem_crear_cita_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Usuario.frm_crear_cita frm_Crear_Cita = new Catalogos.Editar.Usuario.frm_crear_cita();
            frm_Crear_Cita.Obj_Citas_DAL = new cls_Citas_DAL();
            frm_Crear_Cita.Obj_Citas_DAL.iCod_Emple = Obj_DAL.iUsuario;
            frm_Crear_Cita.ShowDialog();
        }

        private void tstItem_modif_cita_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_citas());
        }

        private void tstItem_cancela_cita_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_citas());
            
        }

        private void tstItem_registra_cliente_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Usuario.frm_registrar_cliente frm_Cliente = new Catalogos.Editar.Usuario.frm_registrar_cliente();
            frm_Cliente.Obj_Cliente_DAL = new cls_Clientes_DAL();
            frm_Cliente.Obj_Cliente_DAL.iCod_EmpleCreador = Obj_DAL.iUsuario;
            frm_Cliente.ShowDialog();

        }

        private void tstItem_modif_cliente_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Usuario.frm_registrar_cliente());
        }

        private void tstItem_ordenServ_mecan_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Usuario.frm_orden_mecanico());
        }

        private void tstItem_modelos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_modelos());
        }

        private void tstItem_clientes_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_clientes());
        }

        private void tstItem_marcas_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_marcas());
        }

        private void tstItem_motor_tam_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_motor());
        }

        private void tstItem_tipoVehiculo_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_tipVehic());
        }

        private void tstItem_cantidad_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_cantidad_aceite());
        }

        private void tstItem_unidad_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_unid_medida());
        }

        private void tstItem_insumos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_insumos());
        }

        private void tstItem_servicios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_servicios());
        }

        private void tstItem_estados_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_estados());
        }

        private void tstItem_recibo_provee_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Usuario.frm_recibo_proveedor());
        }

        private void tstItem_inv_sistema_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Usuario.frm_invent_sistema());
        }

        private void tstItem_conteo_ciclico_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Usuario.frm_conteo_ciclico());
        }

        private void tstItem_ajuste_inv_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Admin.frm_ajuste_inv Obj_Ajuste = new Catalogos.Editar.Admin.frm_ajuste_inv();
            Obj_Ajuste.ShowDialog();
        }

        private void tstItem_punto_reorden_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_inventario());
        }

        private void tstItem_orden_ser_inv_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Usuario.frm_orden_inventario());
        }

        private void tstItem_facturacion_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Usuario.frm_generar_fact Obj_Generar = new Catalogos.Editar.Usuario.frm_generar_fact();
            Obj_Generar.ShowDialog();
        }

        private void tstItem_nomina_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_nonima());
        }

        private void tstItem_reclutamiento_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Admin.frm_reclutamiento());
        }
     
        private void tstItem_capac_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Admin.frm_capacitacion());
        }

        private void tstItem_report_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Admin.frm_reporte_capacita());
        }

        private void tstItem_proveedor_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_proveedores());
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            cargarMenu();
        }

        private void tstItem_roles_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_listar_Roles());
        }

        private void tstItem_puestos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Editar.Admin.frm_puestos());
        }

        private void tstItem_tip_Identif_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_tipos_ident());
        }

        private void tstItem_combustib_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Catalogos.Listar.frm_combustibles());
        }
    }
}

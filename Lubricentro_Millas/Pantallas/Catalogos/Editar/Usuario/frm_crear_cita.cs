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

namespace Lubricentro_Millas.Pantallas.Catalogos.Editar.Usuario
{
    public partial class frm_crear_cita : Form
    {
        #region Variables globales
         private cls_Clientes_BLL Obj_Cliente_BLL = new cls_Clientes_BLL();
         private cls_Clientes_DAL Obj_Cliente_DAL = new cls_Clientes_DAL();
         private List<byte> IdServicios=new List<byte>();
         public cls_Citas_DAL Obj_Citas_DAL = new cls_Citas_DAL();
        #endregion
        public frm_crear_cita()
        {
            InitializeComponent();
            dt_fechaCita.MinDate = DateTime.Now.AddHours(24);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (IdServicios.Count == 0)
            {
                MessageBox.Show("Debe de elegir como minimo un servicio ", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbx_datos_vehiculo.Focus();
            }
            else if (dt_fechaCita.Text == DateTime.Now.ToString() || msk_HoraCita.Text == "")
            {
                MessageBox.Show("Debe de llenar todos lo campos se deben llenar ", "Información incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                cls_Citas_BLL Obj_Citas_BLL = new cls_Citas_BLL();
                
                Obj_Citas_DAL.id_Cliente = Obj_Cliente_DAL.iCod_Id;
                Obj_Citas_DAL.id_VehiculosPorClientes = Convert.ToInt32(cbx_placa.SelectedValue);
                Obj_Citas_DAL.FechaCita = Convert.ToDateTime(dt_fechaCita.Text);
                Obj_Citas_DAL.Hora = Convert.ToDateTime(msk_HoraCita.Text).AddDays(Obj_Citas_DAL.FechaCita.Day-DateTime.Now.Day);
                Obj_Citas_DAL.idEstadosCitas = 2;
                Obj_Citas_DAL.bPromocion = false;
                Obj_Citas_DAL.Fecha = DateTime.Now;
                Obj_Citas_BLL.Insert_Citas(ref Obj_Citas_DAL);
                if (Obj_Citas_DAL.sMgsError == "")
                {
                    cls_ServciosPorCitas_BLL Obj_SPorCitas_BLL = new cls_ServciosPorCitas_BLL();
                    cls_ServciosPorCitas_DAL Obj_SPorCitas_DAL = new cls_ServciosPorCitas_DAL();
                    
                    Obj_SPorCitas_DAL.iIdCitas = Obj_Citas_DAL.id_Citas;
                    Obj_SPorCitas_DAL.iIdEmp = Obj_Citas_DAL.iCod_Emple;
                    Obj_SPorCitas_DAL.datFechaCr = DateTime.Now;
                    for (int i = 0; i < IdServicios.Count; i++)
                    {
                        Obj_SPorCitas_DAL.iIdServicios = IdServicios.ElementAt(i);
                        Obj_SPorCitas_BLL.Insert_ServciosPorCitas(ref Obj_SPorCitas_DAL);
                    }
                    if (Obj_SPorCitas_DAL.sMgsError == "")
                    {
                        MessageBox.Show("Cita agendada de manera correcta", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        msk_Identi.ResetText();
                        txt_nombre.ResetText();
                        txt_apellidos.ResetText();
                        txt_telefono1.ResetText();
                        txt_telefono2.ResetText();
                        txt_correo.ResetText();
                        txt_direccion.ResetText();
                        cbx_placa.ResetText();
                        dt_fechaCita.ResetText();
                        msk_HoraCita.ResetText();
                        ckbx_alineamiento.Checked = false;
                        ckbx_aceite.Checked = false;
                        ckbx_coolant.Checked = false;
                        ckbx_f_aire.Checked = false;
                        ckbx_cargaAC.Checked = false;
                        msk_Identi.Focus();

                    }
                    else {
                        MessageBox.Show(Obj_Citas_DAL.sMgsError, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } 
                else {
                    MessageBox.Show(Obj_Citas_DAL.sMgsError, "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //MessageBox.Show("Cita Agendada \nexitosamente!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Dispose();
        }

        private void btn_horario_Click(object sender, EventArgs e)
        {
            Catalogos.Editar.Usuario.frm_horario Obj_Horario = new frm_horario();
            Obj_Horario.ShowDialog();
        }

        private void frm_crear_cita_Click(object sender, EventArgs e)
        {

            }

        private void btn_verificar_Click(object sender, EventArgs e)
        {

            if (msk_Identi.Text.Trim() == string.Empty)
            {
                erpErrores.SetError(msk_Identi, "Debe llenar este campo antes de realizar la busqueda");
                msk_Identi.Focus();
            }
            else
            {
                erpErrores.Clear();
              
                Obj_Cliente_DAL.Siden = msk_Identi.Text.Trim();
                Obj_Cliente_BLL.ObtenerInfo(ref Obj_Cliente_DAL);
                if (Obj_Cliente_DAL.dData.Tables != null)
                {
                    Obj_Cliente_DAL.iCod_Id =Convert.ToInt32 (Obj_Cliente_DAL.dData.Tables[0].Rows[0].ItemArray[0]);
                    txt_nombre.Text =Obj_Cliente_DAL.dData.Tables[0].Rows[0].ItemArray[1].ToString();
                    txt_apellidos.Text= Obj_Cliente_DAL.dData.Tables[0].Rows[0].ItemArray[2].ToString();
                    txt_telefono1.Text= Obj_Cliente_DAL.dData.Tables[0].Rows[0].ItemArray[3].ToString();
                    txt_telefono2.Text= Obj_Cliente_DAL.dData.Tables[0].Rows[0].ItemArray[4].ToString();
                    txt_correo.Text= Obj_Cliente_DAL.dData.Tables[0].Rows[0].ItemArray[5].ToString();
                    txt_direccion.Text= Obj_Cliente_DAL.dData.Tables[0].Rows[0].ItemArray[6].ToString();
                    cargarCombos();
                }
                else
                {
                    MessageBox.Show("No existe un cliente registrado con ese número de identificación", "Cliente no existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    msk_Identi.ResetText();
                    msk_Identi.Focus();
                }
            }
    }

        private void cargarCombos()
        {
            Obj_Cliente_BLL.ListarVehiClientes(ref Obj_Cliente_DAL);
            if (Obj_Cliente_DAL.sMgsError == "")
            {
                cbx_placa.DataSource = Obj_Cliente_DAL.dData.Tables[ConfigurationManager.AppSettings["tablavehiculosporclientes"].ToString()].DefaultView;
                cbx_placa.DisplayMember = Obj_Cliente_DAL.dData.Tables[0].Columns["Placa"].ToString();
                cbx_placa.ValueMember = "Id";
            }
            else {
                MessageBox.Show(Obj_Cliente_DAL.sMgsError,"Un problema ocurrio",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cbx_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void ckbx_alineamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbx_alineamiento.Checked)
            {
                IdServicios.Add(1);
            }
            else
            {
                IdServicios.Remove(1);
            }
        }

        private void ckbx_aceite_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbx_aceite.Checked)
            {
                IdServicios.Add(2);
            }
            else {
                IdServicios.Remove(2);
            }
              
        }

        private void ckbx_coolant_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbx_coolant.Checked)
            {
                IdServicios.Add(3);
            }
            else
            {
                IdServicios.Remove(3);
            }
        }

        private void ckbx_f_aire_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbx_f_aire.Checked)
            {
                IdServicios.Add(4);
            }
            else
            {
                IdServicios.Remove(4);
            }
        }

        private void ckbx_cargaAC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbx_cargaAC.Checked)
            {
                IdServicios.Add(5);
            }
            else
            {
                IdServicios.Remove(5);
            }
        }

        private void rbtn_cedula_CheckedChanged(object sender, EventArgs e)
        {
            msk_Identi.Mask = "0-0000-0000";
        }

        private void rbtn_pasaporte_CheckedChanged(object sender, EventArgs e)
        {
            msk_Identi.Mask = "AA000000";
        }

        private void rbtn_residencia_CheckedChanged(object sender, EventArgs e)
        {
            msk_Identi.Mask = "0-0000-0000";
        }
    }
}

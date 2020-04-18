using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Millas_DAL.BD;
using Millas_BLL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Generales;

namespace Millas_BLL.Catalogos
{
    public class cls_ModelosVehi_BLL
    {
        #region Listar
        public void List_ModelosVehi(ref cls_ModelosVehi_DAL Obj_Modelos_DAL)
        {
           
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarmodelosvehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Modelos_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Modelos_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Modelos_DAL.dData = null;
                Obj_Modelos_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_MModelosVehi(ref cls_ModelosVehi_DAL Obj_ModelosVehi_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_ModelosVehi_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarmodelosvehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ModelosVehi_DAL.dData = Obj_BD_DAL.Ds;
                Obj_ModelosVehi_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ModelosVehi_DAL.dData = null;
                Obj_ModelosVehi_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_ModelosVehi(ref cls_ModelosVehi_DAL Obj_ModelosVehi_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", Obj_ModelosVehi_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Motor", "2", Obj_ModelosVehi_DAL.iMotor);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadAceite", "4", Obj_ModelosVehi_DAL.fAceite);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadCoolant", "4", Obj_ModelosVehi_DAL.fCoolant);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadGas", "4", Obj_ModelosVehi_DAL.fGas);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_MarcasVehiculos", "2", Obj_ModelosVehi_DAL.ICod_Marca);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Combustibles", "2", Obj_ModelosVehi_DAL.ICod_Combustible);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "3", Obj_ModelosVehi_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_ModelosVehi_DAL.iCod_EmpleCreador);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_ModelosVehi_DAL.FechaCreado);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarmodelosvehiculos"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ModelosVehi_DAL.sMgsError = string.Empty;
                //Obj_Combustible_DAL.iCod_Combustible = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                Obj_ModelosVehi_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //Obj_Combustible_DAL.iCod_Combustible = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_ModelosVehi(ref cls_ModelosVehi_DAL Obj_ModelosVehi_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id", "2", Obj_ModelosVehi_DAL.iCod_Model);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", Obj_ModelosVehi_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Motor", "2", Obj_ModelosVehi_DAL.iMotor);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadAceite", "4", Obj_ModelosVehi_DAL.fAceite);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadCoolant", "4", Obj_ModelosVehi_DAL.fCoolant);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadGas", "4", Obj_ModelosVehi_DAL.fGas);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_MarcasVehiculos", "2", Obj_ModelosVehi_DAL.ICod_Marca);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Combustibles", "2", Obj_ModelosVehi_DAL.ICod_Combustible);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "3", Obj_ModelosVehi_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_ModelosVehi_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_ModelosVehi_DAL.cEstado);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarmodelosvehiculos"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ModelosVehi_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ModelosVehi_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion

        #region Listar Marcas
        public void List_Marcas(ref cls_ModelosVehi_DAL Obj_ModelosVehi_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarmarcavehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ModelosVehi_DAL.dData = Obj_BD_DAL.Ds;
                Obj_ModelosVehi_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ModelosVehi_DAL.dData = null;
                Obj_ModelosVehi_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Listar Combustibles
        public void List_Combustible(ref cls_ModelosVehi_DAL Obj_ModelosVehi_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarcombustibles"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablacombustibles"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ModelosVehi_DAL.dData = Obj_BD_DAL.Ds;
                Obj_ModelosVehi_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ModelosVehi_DAL.dData = null;
                Obj_ModelosVehi_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

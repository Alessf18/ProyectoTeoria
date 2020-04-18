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
    public class cls_Marcas_BLL
    {
        #region Listar
        public void List_Marcas(ref cls_Marcas_DAL Obj_Marcas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarmarcavehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString();
                
            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Marcas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Marcas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Marcas_DAL.dData = null;
                Obj_Marcas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }   
        }
        #endregion
        #region Filtrar
        public void Fill_Marcas(ref cls_Marcas_DAL Obj_Marcas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Marcas_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarmarcavehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Marcas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Marcas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Marcas_DAL.dData = null;
                Obj_Marcas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Marcas(ref cls_Marcas_DAL obj_Marcas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Marcas_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_TiposVehiculos", "2", obj_Marcas_DAL.Id_TiposVehi);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_Marcas_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_Marcas_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_Marcas_DAL.FechaCreado);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarmarcavehiculos"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Marcas_DAL.sMgsError = string.Empty;
                //obj_Marcas_DAL.iCod_Marca = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString()); Problema, lo trae nulo 
            }
            else
            {
                obj_Marcas_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_Marcas_DAL.iCod_Marca = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Marcas(ref cls_Marcas_DAL obj_Marcas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Marcas_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_TiposVehiculos", "2", obj_Marcas_DAL.Id_TiposVehi);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_Marcas_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Actualiza_Empleados", "2", obj_Marcas_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_Marcas_DAL.FechaCreado);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarmarcavehiculos"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Marcas_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_Marcas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millas_DAL.BD;
using Millas_BLL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Generales;
using System.Configuration;

namespace Millas_BLL.Catalogos
{
    public class cls_TiposVehiculos_BLL
    {
        #region Listar
        public void List_TiposVehiculos(ref cls_TiposVehiculos_DAL Obj_TiposVehiculos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listartiposvehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_TiposVehiculos_DAL.dData = Obj_BD_DAL.Ds;
                Obj_TiposVehiculos_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_TiposVehiculos_DAL.dData = null;
                Obj_TiposVehiculos_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_TiposVehiculos(ref cls_TiposVehiculos_DAL Obj_TiposVehiculos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_TiposVehiculos_DAL.sNombre);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrartiposvehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_TiposVehiculos_DAL.dData = Obj_BD_DAL.Ds;
                Obj_TiposVehiculos_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_TiposVehiculos_DAL.dData = null;
                Obj_TiposVehiculos_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_TiposVehiculos(ref cls_TiposVehiculos_DAL obj_TiposVehiculos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_TiposVehiculos_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_TiposVehiculos_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_TiposVehiculos_DAL.iId_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_TiposVehiculos_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertartiposvehiculos"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_TiposVehiculos_DAL.sMgsError = string.Empty;
                //obj_TiposVehiculos_DAL.iCod_TiposVehiculos = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_TiposVehiculos_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_TiposVehiculos_DAL.iCod_TiposVehiculos = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_TiposVehiculos(ref cls_TiposVehiculos_DAL obj_TiposVehiculos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_TiposVehiculos_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_TiposVehiculos_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Actualiza_Empleados", "2", obj_TiposVehiculos_DAL.iId_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", obj_TiposVehiculos_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarcapacitacion"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_TiposVehiculos_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_TiposVehiculos_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

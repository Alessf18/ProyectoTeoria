using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Millas_DAL.BD;
using Millas_BLL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Generales;

namespace Millas_BLL.Catalogos
{
    public class cls_ReciboProveedores_BLL
    {
        #region Listar
        public void List_ReciboProveedores(ref cls_ReciboProveedores_DAL Obj_ReciboProveedores_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarreciboproveedores"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablareciboproveedores"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ReciboProveedores_DAL.dData = Obj_BD_DAL.Ds;
                Obj_ReciboProveedores_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ReciboProveedores_DAL.dData = null;
                Obj_ReciboProveedores_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_ReciboProveedores(ref cls_ReciboProveedores_DAL Obj_ReciboProveedores_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_ReciboProveedores_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarreciboproveedores"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablareciboproveedores"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ReciboProveedores_DAL.dData = Obj_BD_DAL.Ds;
                Obj_ReciboProveedores_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ReciboProveedores_DAL.dData = null;
                Obj_ReciboProveedores_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_ReciboProveedores(ref cls_ReciboProveedores_DAL Obj_ReciboProveedores_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NumeroParte", "1", Obj_ReciboProveedores_DAL.sNumeroParte);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@@DescripcionMaterial", "1", Obj_ReciboProveedores_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Unidad_Medida", "2", Obj_ReciboProveedores_DAL.iId_NumeroMedida);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Cantidad", "2", Obj_ReciboProveedores_DAL.iCantidad);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Ubicacion", "1", Obj_ReciboProveedores_DAL.iUbicacion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_ReciboProveedores_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_ReciboProveedores_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarreciboproveedores"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ReciboProveedores_DAL.sMgsError = string.Empty;
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                Obj_ReciboProveedores_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_ReciboProveedores(ref cls_ReciboProveedores_DAL Obj_ReciboProveedores_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NumeroParte", "1", Obj_ReciboProveedores_DAL.sNumeroParte);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", Obj_ReciboProveedores_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Unidad_Medida", "2", Obj_ReciboProveedores_DAL.iId_NumeroMedida);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Cantidad", "2", Obj_ReciboProveedores_DAL.iCantidad);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Ubicacion", "2", Obj_ReciboProveedores_DAL.iUbicacion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@@Id_Actualiza_Empleados", "2", Obj_ReciboProveedores_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", Obj_ReciboProveedores_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarreciboproveedores"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ReciboProveedores_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ReciboProveedores_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

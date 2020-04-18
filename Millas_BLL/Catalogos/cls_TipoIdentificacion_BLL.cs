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
    public class cls_TipoIdentificacion_BLL
    {
        #region Listar
        public void List_Identificacion(ref cls_TipoIdentificacion_DAL Obj_Identificacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listaridentificaciones"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaindentificaciones"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Identificacion_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Identificacion_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Identificacion_DAL.dData = null;
                Obj_Identificacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Identificacion(ref cls_TipoIdentificacion_DAL Obj_Identificacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Identificacion_DAL.sNombre);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtraridentificaciones"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaindentificaciones"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Identificacion_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Identificacion_DAL.sMgsError = string.Empty;
            }       
            else
            {
                Obj_Identificacion_DAL.dData = null;
                Obj_Identificacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Identificacion(ref cls_TipoIdentificacion_DAL obj_Identificacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Identificacion_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Identificacion_DAL.iCod_Identificacion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertaridentificaciones"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Identificacion_DAL.sMgsError = string.Empty;
                obj_Identificacion_DAL.iCod_Identificacion = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_Identificacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_Identificacion_DAL.iCod_Identificacion = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Identificaciones(ref cls_TipoIdentificacion_DAL obj_Identificaciones_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Identificaciones_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Identificaciones_DAL.iCod_Identificacion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificaridentificaciones"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Identificaciones_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_Identificaciones_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

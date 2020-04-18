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
    public class cls_PuestoTrabajo_BLL
    {
        #region Listar
        public void List_PuestoTrabajon(ref cls_PuestoTrabajo_DAL Obj_PuestoTrabajo_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarpuestotrabajo"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablapuestotrabajo"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_PuestoTrabajo_DAL.dData = Obj_BD_DAL.Ds;
                Obj_PuestoTrabajo_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_PuestoTrabajo_DAL.dData = null;
                Obj_PuestoTrabajo_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_PuestoTrabajo(ref cls_PuestoTrabajo_DAL Obj_PuestoTrabajo_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_PuestoTrabajo_DAL.sNombre);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarpuestotrabajo"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablapuestotrabajo"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_PuestoTrabajo_DAL.dData = Obj_BD_DAL.Ds;
                Obj_PuestoTrabajo_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_PuestoTrabajo_DAL.dData = null;
                Obj_PuestoTrabajo_DAL.sMgsError = Obj_BD_DAL.sMsError;
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

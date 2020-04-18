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
    public class cls_UnidadMedida_BLL
    {
        #region Listar
        public void List_UnidadMedida(ref cls_UnidadMedida_DAL Obj_UnidadMedida_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarunidadesdemedidas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaunidadesdemedidas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_UnidadMedida_DAL.dData = Obj_BD_DAL.Ds;
                Obj_UnidadMedida_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_UnidadMedida_DAL.dData = null;
                Obj_UnidadMedida_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Unidades(ref cls_UnidadMedida_DAL Obj_UnidadMedida_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_UnidadMedida_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarunidadesdemedidas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaunidadesdemedidas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_UnidadMedida_DAL.dData = Obj_BD_DAL.Ds;
                Obj_UnidadMedida_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_UnidadMedida_DAL.dData = null;
                Obj_UnidadMedida_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_UnidadMedida(ref cls_UnidadMedida_DAL obj_UnidadMedida_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_UnidadMedida_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PrecioPorUnidad", "4", obj_UnidadMedida_DAL.fPrecio);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_UnidadMedida_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_UnidadMedida_DAL.iId_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_UnidadMedida_DAL.fecha);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Actualiza_Empleados", "2", obj_UnidadMedida_DAL.iId_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", obj_UnidadMedida_DAL.fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarunidadesdemedidas"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_UnidadMedida_DAL.sMgsError = string.Empty;
                obj_UnidadMedida_DAL.iCod_Unidad = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_UnidadMedida_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_UnidadMedida_DAL.iCod_Unidad = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_UnidadMedida(ref cls_UnidadMedida_DAL obj_UnidadMedida_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_UnidadMedida_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PrecioPorUnidad", "4", obj_UnidadMedida_DAL.fPrecio);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_UnidadMedida_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Actualiza_Empleados", "2", obj_UnidadMedida_DAL.iId_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", obj_UnidadMedida_DAL.fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarcapacitacion"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_UnidadMedida_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_UnidadMedida_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

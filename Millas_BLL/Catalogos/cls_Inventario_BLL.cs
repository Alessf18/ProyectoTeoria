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
    public class cls_Inventario_BLL
    {
        #region Listar
        public void List_Inventario(ref cls_Inventario_DAL Obj_Inventario_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarinventarios"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablainventarios"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Inventario_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Inventario_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Inventario_DAL.dData = null;
                Obj_Inventario_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Inventario(ref cls_Inventario_DAL Obj_Inventario_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Inventario_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarinventarios"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablainventarios"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Inventario_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Inventario_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Inventario_DAL.dData = null;
                Obj_Inventario_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Inventario(ref cls_Inventario_DAL Obj_Inventario_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NumeroParte", "1", Obj_Inventario_DAL.sNumeroParte);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DescripcionMaterial", "1", Obj_Inventario_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadSistema", "2", Obj_Inventario_DAL.iCantidadSistema);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadReservada", "2", Obj_Inventario_DAL.iCantidadReservada);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Ubicacion", "1", Obj_Inventario_DAL.sUbicacion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@EstadoMaterial", "1", Obj_Inventario_DAL.sEstadoMaterial);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Unidad_Medida", "2", Obj_Inventario_DAL.iId_UnidadMedida);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_Inventario_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_Inventario_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarinventarios"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Inventario_DAL.sMgsError = string.Empty;
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                Obj_Inventario_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Inventario(ref cls_Inventario_DAL Obj_Inventario_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NumeroParte", "1", Obj_Inventario_DAL.sNumeroParte);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DescripcionMaterial", "1", Obj_Inventario_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadSistema", "2", Obj_Inventario_DAL.iCantidadSistema);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadReservada", "2", Obj_Inventario_DAL.iCantidadReservada);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Ubicacion", "1", Obj_Inventario_DAL.sUbicacion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@EstadoMaterial", "1", Obj_Inventario_DAL.sEstadoMaterial);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Unidad_Medida", "2", Obj_Inventario_DAL.iId_UnidadMedida);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", Obj_Inventario_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarinventarios"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Inventario_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Inventario_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

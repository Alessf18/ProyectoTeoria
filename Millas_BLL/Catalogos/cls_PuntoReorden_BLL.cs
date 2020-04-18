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
    public class cls_PuntoReorden_BLL
    {
        #region Listar
        public void List_PuntoReorden(ref cls_PuntoReorden_DAL Obj_PuntoReorden_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarpuntoreorden"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablapuntoreorden"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_PuntoReorden_DAL.dData = Obj_BD_DAL.Ds;
                Obj_PuntoReorden_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_PuntoReorden_DAL.dData = null;
                Obj_PuntoReorden_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_PuntoReorden(ref cls_PuntoReorden_DAL Obj_PuntoReorden_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_PuntoReorden_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarpuntoreorden"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablapuntoreorden"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_PuntoReorden_DAL.dData = Obj_BD_DAL.Ds;
                Obj_PuntoReorden_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_PuntoReorden_DAL.dData = null;
                Obj_PuntoReorden_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_PuntoReorden(ref cls_PuntoReorden_DAL Obj_PuntoReorden_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PuntoReordenMaterial", "2", Obj_PuntoReorden_DAL.iCod_PuntoReordenMaterial);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadPedido", "2", Obj_PuntoReorden_DAL.iCantidadPedido);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Inventarios", "2", Obj_PuntoReorden_DAL.iId_Inventarios);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DescripcionEstPuntReorden", "1", Obj_PuntoReorden_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_PuntoReorden_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_PuntoReorden_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarpuntoreorden"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_PuntoReorden_DAL.sMgsError = string.Empty;
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                Obj_PuntoReorden_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_PuntoReorden(ref cls_PuntoReorden_DAL Obj_PuntoReorden_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PuntoReordenMaterial", "2", Obj_PuntoReorden_DAL.iCod_PuntoReordenMaterial);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CantidadPedido", "2", Obj_PuntoReorden_DAL.iCantidadPedido);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Inventarios", "2", Obj_PuntoReorden_DAL.iId_Inventarios);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DescripcionEstPuntReorden", "1", Obj_PuntoReorden_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", Obj_PuntoReorden_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarpuntoreorden"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_PuntoReorden_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_PuntoReorden_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

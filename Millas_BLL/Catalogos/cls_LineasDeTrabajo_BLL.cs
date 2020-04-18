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
    public class cls_LineasDeTrabajo_BLL
    {
        #region Listar
        public void List_LineasDeTrabajo(ref cls_LineasDeTrabajo_DAL Obj_LineasDeTrabajo_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarlineasdetrabajo"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablalineasdetrabajo"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_LineasDeTrabajo_DAL.dData = Obj_BD_DAL.Ds;
                Obj_LineasDeTrabajo_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_LineasDeTrabajo_DAL.dData = null;
                Obj_LineasDeTrabajo_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_LineasDeTrabajo(ref cls_LineasDeTrabajo_DAL Obj_LineasDeTrabajo_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_LineasDeTrabajo_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarlineasdetrabajo"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablalineasdetrabajo"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_LineasDeTrabajo_DAL.dData = Obj_BD_DAL.Ds;
                Obj_LineasDeTrabajo_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_LineasDeTrabajo_DAL.dData = null;
                Obj_LineasDeTrabajo_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_LineasDeTrabajo(ref cls_LineasDeTrabajo_DAL obj_LineasDeTrabajo_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_LineasDeTrabajo_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_LineasDeTrabajo_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Servicios", "2", obj_LineasDeTrabajo_DAL.iID_Servicios);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_LineasDeTrabajo_DAL.iId_Crea_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_LineasDeTrabajo_DAL.fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarlineasdetrabajo"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_LineasDeTrabajo_DAL.sMgsError = string.Empty;
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_LineasDeTrabajo_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_LineasDeTrabajo(ref cls_LineasDeTrabajo_DAL obj_LineasDeTrabajo_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_LineasDeTrabajo_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_LineasDeTrabajo_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Servicios", "2", obj_LineasDeTrabajo_DAL.iID_Servicios);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Actualiza_Empleados", "2", obj_LineasDeTrabajo_DAL.iId_Crea_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", obj_LineasDeTrabajo_DAL.fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarlineasdetrabajo"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_LineasDeTrabajo_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_LineasDeTrabajo_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

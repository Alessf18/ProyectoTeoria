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
    public class cls_InsumosPorServicio_BLL
    {
        #region Listar
        public void List_InsumosPorServicio(ref cls_InsumosPorServicio_DAL Obj_InsumosPorServicio_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarinsumosporservicio"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablainsumosporservicio"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_InsumosPorServicio_DAL.dData = Obj_BD_DAL.Ds;
                Obj_InsumosPorServicio_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_InsumosPorServicio_DAL.dData = null;
                Obj_InsumosPorServicio_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_InsumosPorServicio(ref cls_InsumosPorServicio_DAL Obj_InsumosPorServicio_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_InsumosPorServicio_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarinsumosporservicio"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablainsumosporservicio"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_InsumosPorServicio_DAL.dData = Obj_BD_DAL.Ds;
                Obj_InsumosPorServicio_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_InsumosPorServicio_DAL.dData = null;
                Obj_InsumosPorServicio_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_InsumosPorServicio(ref cls_InsumosPorServicio_DAL obj_InsumosPorServicio_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Servicios", "2", obj_InsumosPorServicio_DAL.iId_Servicios);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_InsumosPorServicio_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Insumos", "2", obj_InsumosPorServicio_DAL.iId_Insumos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_InsumosPorServicio_DAL.iId_Crea_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_InsumosPorServicio_DAL.fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarinsumosporservicio"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_InsumosPorServicio_DAL.sMgsError = string.Empty;
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_InsumosPorServicio_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_InsumosPorServicio(ref cls_InsumosPorServicio_DAL obj_InsumosPorServicio_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Servicios", "1", obj_InsumosPorServicio_DAL.iId_Servicios);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_InsumosPorServicio_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Insumos", "2", obj_InsumosPorServicio_DAL.iId_Insumos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Actualiza_Empleados", "2", obj_InsumosPorServicio_DAL.iId_Crea_Empleado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", obj_InsumosPorServicio_DAL.fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarinsumosporservicio"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_InsumosPorServicio_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_InsumosPorServicio_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion

    }
}

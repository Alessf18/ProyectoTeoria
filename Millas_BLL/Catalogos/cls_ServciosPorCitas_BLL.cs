using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millas_DAL.Catalogos;
using Millas_BLL.BD;
using Millas_DAL.BD;
using System.Configuration;
using Millas_BLL.Generales;

namespace Millas_BLL.Catalogos
{
    public class cls_ServciosPorCitas_BLL
    {
        public void List_ServciosPorCitas(ref cls_ServciosPorCitas_DAL Obj_ServciosPorCitas_DAL)
        {
            #region Listar
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarservicioporcitas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaservicioporcitas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ServciosPorCitas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_ServciosPorCitas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ServciosPorCitas_DAL.dData = null;
                Obj_ServciosPorCitas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_ServciosPorCitas(ref cls_ServciosPorCitas_DAL Obj_ServciosPorCitas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_ServciosPorCitas_DAL.iId); //HAY Q REVISAR//


            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarservicioporcitas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaservicioporcitas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_ServciosPorCitas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_ServciosPorCitas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_ServciosPorCitas_DAL.dData = null;
                Obj_ServciosPorCitas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_ServciosPorCitas(ref cls_ServciosPorCitas_DAL obj_ServciosPorCitas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            /*
                      (@Id_Citas int,
           @Id_Servicios int,
           @Id_Crea_Empleados int,
            @FechaCreado datetime)
                     */
            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Citas", "2", obj_ServciosPorCitas_DAL.iIdCitas);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Servicios", "2", obj_ServciosPorCitas_DAL.iIdServicios);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_ServciosPorCitas_DAL.iIdEmp);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "7", obj_ServciosPorCitas_DAL.datFechaCr);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarservicioporcitas"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_ServciosPorCitas_DAL.sMgsError = string.Empty;

            }
            else
            {
                obj_ServciosPorCitas_DAL.sMgsError = Obj_BD_DAL.sMsError;
               
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

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarservicioporcitas"].ToString();

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

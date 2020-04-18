using System;
using System.Configuration;
using Millas_DAL.BD;
using Millas_BLL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Generales;

namespace Millas_BLL.Catalogos
{
    public class cls_Servicios_BLL
    {
        public void List_Servicios(ref cls_Servicios_DAL Obj_Servicios_DAL)
        {
        #region Listar
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarservicios"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaservicios"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Servicios_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Servicios_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Servicios_DAL.dData = null;
                Obj_Servicios_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Servicios(ref cls_Servicios_DAL Obj_Servicios_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Servicios_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarservicios"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaservicios"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Servicios_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Servicios_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Servicios_DAL.dData = null;
                Obj_Servicios_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Servicios(ref cls_Servicios_DAL obj_Servicios_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Servicios_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PrecioPorManoDeObra", "2", obj_Servicios_DAL.iPrecio);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_Servicios_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_Servicios_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_Servicios_DAL.FechaCreado);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarservicios"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Servicios_DAL.sMgsError = string.Empty;
                //obj_Marcas_DAL.iCod_Marca = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString()); //Problema, lo trae nulo 
            }
            else
            {
                obj_Servicios_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_Servicios_DAL.iCod_Marca = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Servicios(ref cls_Servicios_DAL obj_Servicios_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Servicios_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PrecioPorManoDeObra", "2", obj_Servicios_DAL.iPrecio);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "7", obj_Servicios_DAL.bEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Actualiza_Empleados", "2", obj_Servicios_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_Servicios_DAL.FechaCreado);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarmarservicios"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Servicios_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_Servicios_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion

    }
}


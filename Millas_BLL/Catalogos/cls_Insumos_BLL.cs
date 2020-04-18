using System;
using System.Configuration;
using Millas_DAL.BD;
using Millas_BLL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Generales;

namespace Millas_BLL.Catalogos
{
    public class cls_Insumos_BLL
    {
        #region Listar
        public void List_Insumos(ref cls_Insumos_DAL Obj_Insumos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarinsumos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablainsumos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Insumos_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Insumos_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Insumos_DAL.dData = null;
                Obj_Insumos_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Insumos(ref cls_Insumos_DAL Obj_Insumos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Insumos_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarinsumos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablainsumos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Insumos_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Insumos_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Insumos_DAL.dData = null;
                Obj_Insumos_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Insumos(ref cls_Insumos_DAL obj_Insumos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Insumos_DAL.sDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "3", obj_Insumos_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_UnidadesDeMedidas", "2", obj_Insumos_DAL.ICod_Unidades);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_Insumos_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", obj_Insumos_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarinsumos"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Insumos_DAL.sMgsError = string.Empty;
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_Insumos_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion


        #region Listar UnidadMedida
        public void List_UnidadMedida(ref cls_Insumos_DAL Obj_Insumos_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarunidadesdemedidas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaunidadesdemedidas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Insumos_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Insumos_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Insumos_DAL.dData = null;
                Obj_Insumos_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}


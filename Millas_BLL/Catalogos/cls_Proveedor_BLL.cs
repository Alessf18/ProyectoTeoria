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
    public class cls_Proveedor_BLL
    {
        #region Listar
        public void List_Proveedor(ref cls_Proveedor_DAL Obj_Proveedor_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarproveedor"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaproveedor"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Proveedor_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Proveedor_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Proveedor_DAL.dData = null;
                Obj_Proveedor_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Proveedor(ref cls_Proveedor_DAL Obj_Proveedor_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Proveedor_DAL.iCod_Provee);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarproveedor"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaproveedor"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Proveedor_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Proveedor_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Proveedor_DAL.dData = null;
                Obj_Proveedor_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Proveedor(ref cls_Proveedor_DAL obj_Proveedor_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Proveedor_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Direccion", "1", obj_Proveedor_DAL.sDireccion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "3", obj_Proveedor_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Capacitacion", "2", obj_Proveedor_DAL.iId_Capa);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarproveedor"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Proveedor_DAL.sMgsError = string.Empty;
                //obj_Proveedor_DAL.iCod_Provee = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_Proveedor_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_Proveedor_DAL.iCod_Provee = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Proveedor(ref cls_Proveedor_DAL obj_Proveedor_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Proveedor_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Direccion", "1", obj_Proveedor_DAL.sDireccion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "3", obj_Proveedor_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Capacitación", "2", obj_Proveedor_DAL.iId_Capa);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id", "2", obj_Proveedor_DAL.iCod_Provee);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarproveedor"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Proveedor_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_Proveedor_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion

        #region Listar Capacitaciones
        public void Listar_Capacitaciones(ref cls_Proveedor_DAL Obj_Proveedor_DAL)
        {

            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
           
            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarcapacitacion"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablacapacitacion"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Proveedor_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Proveedor_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Proveedor_DAL.dData = null;
                Obj_Proveedor_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

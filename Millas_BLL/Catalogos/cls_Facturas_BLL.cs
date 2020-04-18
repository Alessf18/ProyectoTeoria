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
    public class cls_Facturas_BLL
    {
        #region Listar
        public void List_Facturas(ref cls_Facturas_DAL Obj_Facturas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarfacturas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablafacturas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Facturas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Facturas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Facturas_DAL.dData = null;
                Obj_Facturas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion 

        #region Filtrar
        public void Fill_Facturas(ref cls_Facturas_DAL Obj_Facturas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Facturas_DAL.sNombreCliente);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarfacturas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablafacturas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Facturas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Facturas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Facturas_DAL.dData = null;
                Obj_Facturas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Facturas(ref cls_Facturas_DAL Obj_Facturas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CedulaJuridicaTaller", "2", Obj_Facturas_DAL.iId_CeduJuridica);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NombreTaller", "1", Obj_Facturas_DAL.sNombreTaller);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DireccionTaller", "1", Obj_Facturas_DAL.sDireccionTaller);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TelefonosTaller", "2", Obj_Facturas_DAL.iTelefono);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaFactura", "6", Obj_Facturas_DAL.Fecha);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NombreCliente", "1", Obj_Facturas_DAL.sNombreCliente);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@IdMaterialDescricion", "1", Obj_Facturas_DAL.sId_MaterialDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@UnidadMedida", "1", Obj_Facturas_DAL.sUnidadMedida); //Varchar de 3
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Cantidad", "1", Obj_Facturas_DAL.iCantidad);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PrecioMaterialFactura", "4", Obj_Facturas_DAL.fPrecioMaterialFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TotalFactura", "4", Obj_Facturas_DAL.fTotalFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@ImpuestosFactura", "4", Obj_Facturas_DAL.fImpuestosFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DescuentoFactura", "4", Obj_Facturas_DAL.fDescuentoFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TotalPagarFactura", "4", Obj_Facturas_DAL.fTotalPagarFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_Facturas_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_Facturas_DAL.sUnidadMedida);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Orden_Servicio", "2", Obj_Facturas_DAL.iId_OrdenServicio);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarfacturas"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Facturas_DAL.sMgsError = string.Empty;
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                Obj_Facturas_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Facturas(ref cls_Facturas_DAL Obj_Facturas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@CedulaJuridicaTaller", "2", Obj_Facturas_DAL.iId_CeduJuridica);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NombreTaller", "1", Obj_Facturas_DAL.sNombreTaller);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DireccionTaller", "1", Obj_Facturas_DAL.sDireccionTaller);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TelefonosTaller", "2", Obj_Facturas_DAL.iTelefono);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaFactura", "6", Obj_Facturas_DAL.Fecha);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@NombreCliente", "1", Obj_Facturas_DAL.sNombreCliente);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@IdMaterialDescricion", "1", Obj_Facturas_DAL.sId_MaterialDescripcion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@UnidadMedida", "1", Obj_Facturas_DAL.sUnidadMedida); //Varchar de 3
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Cantidad", "1", Obj_Facturas_DAL.iCantidad);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@PrecioMaterialFactura", "4", Obj_Facturas_DAL.fPrecioMaterialFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TotalFactura", "4", Obj_Facturas_DAL.fTotalFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@ImpuestosFactura", "4", Obj_Facturas_DAL.fImpuestosFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@DescuentoFactura", "4", Obj_Facturas_DAL.fDescuentoFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TotalPagarFactura", "4", Obj_Facturas_DAL.fTotalPagarFactura);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_Facturas_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_Facturas_DAL.sUnidadMedida);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Orden_Servicio", "2", Obj_Facturas_DAL.iId_OrdenServicio);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarfacturas"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Facturas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Facturas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

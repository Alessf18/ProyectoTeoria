using System;
using System.Configuration;
using Millas_DAL.BD;
using Millas_BLL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Generales;

namespace Millas_BLL.Catalogos
{
    public class cls_Clientes_BLL
    {
        public void List_Clientes(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
        #region Listar
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarclientes"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaclientes"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Clientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Clientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.dData = null;
                Obj_Clientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Clientes(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Clientes_DAL.sNombres); //HAY Q REVISAR//
           

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarclientes"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaclientes"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Clientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Clientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.dData = null;
                Obj_Clientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Clientes(ref cls_Clientes_DAL obj_Clientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Clientes_DAL.sNombres);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Apellidos", "1", obj_Clientes_DAL.sApellidos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@id_TiposIdentificaciones", "2", obj_Clientes_DAL.ICod_id_Identificaciones);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Identificacion", "2", obj_Clientes_DAL.iCedulas);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Correo", "1", obj_Clientes_DAL.sCorreo);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TelefonoCelular", "2", obj_Clientes_DAL.iNumeroCel);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@TelefonoFijo", "2", obj_Clientes_DAL.iNumeroTele);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Direccion", "1", obj_Clientes_DAL.sDireccion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", obj_Clientes_DAL.iCod_EmpleCreador);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@@FechaCreado", "6", obj_Clientes_DAL.FechaCreado);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarmarcavehiculos"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Clientes_DAL.sMgsError = string.Empty;
                //obj_Clientes_DAL.iCod_Id = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString()); //Problema, lo trae nulo 
            }
            else
            {
                obj_Clientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_Clientes_DAL.iCod_Id = -1;
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

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarmarcavehiculos"].ToString();

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

        #region Listar Marcas
        public void List_Marcas(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarmarcavehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablamarcavehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Clientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Clientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.dData = null;
                Obj_Clientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Listar Modelos
        public void List_ModelosVehi(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {

            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarmodelosvehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablamodelosvehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Clientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Clientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.dData = null;
                Obj_Clientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Listar Tipos de Vehículos
        public void List_TiposVehiculos(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listartiposvehiculos"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablatiposvehiculos"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Clientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Clientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.dData = null;
                Obj_Clientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region ObtenerInfo
            public void ObtenerInfo(ref cls_Clientes_DAL Obj_Clientes_DAL ) {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["obtenerInfo"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaclientes"].ToString();
           
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Ident", "1", Obj_Clientes_DAL.Siden);
            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Clientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Clientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.dData = null;
                Obj_Clientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

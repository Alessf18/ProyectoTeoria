using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millas_DAL.BD;
using Millas_BLL.BD;
using Millas_DAL.Catalogos;
using Millas_BLL.Generales;
using System.Configuration;

namespace Millas_BLL.Catalogos
{
    public class cls_VehiPorClientes_BLL
    {
        #region Listar
        public void VehiPorClientes(ref cls_VehiPorClientes_DAL Obj_VehiPorClientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarvehiculosporclientes"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablarvehiculosporclientes"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_VehiPorClientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_VehiPorClientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_VehiPorClientes_DAL.dData = null;
                Obj_VehiPorClientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_VehPorClientes(ref cls_VehiPorClientes_DAL Obj_VehiPorClientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_VehiPorClientes_DAL.sPlaca);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarvehiculosporclientes"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablarvehiculosporclientes"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_VehiPorClientes_DAL.dData = Obj_BD_DAL.Ds;
                Obj_VehiPorClientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_VehiPorClientes_DAL.dData = null;
                Obj_VehiPorClientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_VehiPorClientes(ref cls_VehiPorClientes_DAL obj_VehiPorClientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            /*
             @Id_Clientes int,
           @Placa varchar(20),
           @Id_TiposVehiculos int,
           @Id_Combustible int,
           @Id_MarcasVehiculos int,
           @Id_ModelosVehiculos int,
           @Anio int,
           @Comentario varchar(50
             
             
             */
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Clientes", "2", obj_VehiPorClientes_DAL.iId_Cliente);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Placa", "1", obj_VehiPorClientes_DAL.sPlaca);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_TiposVehiculos", "2", obj_VehiPorClientes_DAL.iCod_TipoVehiculos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Combustible", "2", obj_VehiPorClientes_DAL.iCod_Combustible);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_MarcasVehiculos", "2", obj_VehiPorClientes_DAL.iCod_MarcasVehiculos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_ModelosVehiculos", "2", obj_VehiPorClientes_DAL.iCod_ModelosVehiculos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Anio", "2", obj_VehiPorClientes_DAL.iAnio);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Comentario", "1", obj_VehiPorClientes_DAL.sComentario);



            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarvehiculosporclientes"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_VehiPorClientes_DAL.sMgsError = string.Empty;
                //obj_VehiPorClientes_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_VehiPorClientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_VehiPorClientes_DAL.iCod_VehiPorClientes = -1; // Creo que esto no iría
            }
        }
        #endregion
        #region Actualizar
        public void Update_VehiPorClientes(ref cls_VehiPorClientes_DAL obj_VehiPorClientes_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Clentes", "2", obj_VehiPorClientes_DAL.iId_Cliente);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Placa", "1", obj_VehiPorClientes_DAL.sPlaca);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Anio", "2", obj_VehiPorClientes_DAL.iAnio);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_TiposVehiculos", "2", obj_VehiPorClientes_DAL.iCod_TipoVehiculos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Combustible", "2", obj_VehiPorClientes_DAL.iCod_Combustible);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_MarcasVehiculos", "2", obj_VehiPorClientes_DAL.iCod_MarcasVehiculos);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_ModelosVehiculos", "2", obj_VehiPorClientes_DAL.iCod_ModelosVehiculos);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarroles"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_VehiPorClientes_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_VehiPorClientes_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion


        //FALTAN LOS LISTAR DE CLIENTES, TIPOSVEHICULOS, MARCAS, MODELOS
    }
}

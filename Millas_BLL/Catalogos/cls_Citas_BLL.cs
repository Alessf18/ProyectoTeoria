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
    public class cls_Citas_BLL
    {
        #region Listar
        public void List_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarcitas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablacitas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Citas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Citas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Citas_DAL.dData = null;
                Obj_Citas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            //Se filtra por nombre de tabla clientes o por número de placa de tablas Vehiculos por clientes
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Citas_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarcitas"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablacitas"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Citas_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Citas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Citas_DAL.dData = null;
                Obj_Citas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);
            /*
             * @Id_Clientes int,
               @Id_VehiculosPorClientes int,
               @Id_EstadosCitas int,
               @Fecha date,
               @Hora time(7),
               @AplicoPromocion bit,
               @Id_Crea_Empleados int,
               @FechaCreado datetime
               
            case "1":
                                        DB_TYPE = SqlDbType.NVarChar;
                                        break;
                                    case "2":
                                        DB_TYPE = SqlDbType.Int;
                                        break;
                                    case "3":
                                        DB_TYPE = SqlDbType.Char;
                                        break;
                                    case "4":
                                        DB_TYPE = SqlDbType.Float;
                                        break;
                                    case "5":
                                        DB_TYPE = SqlDbType.Time;
                                        break;
                                    case "6":
                                        DB_TYPE = SqlDbType.DateTime;
                                        break;
                                    case "7":
                                        DB_TYPE = SqlDbType.Bit;
                                        break; 

             */
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Clientes", "2", Obj_Citas_DAL.id_Cliente);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_VehiculosPorClientes", "2", Obj_Citas_DAL.id_VehiculosPorClientes);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_EstadosCitas", "2", Obj_Citas_DAL.idEstadosCitas);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Fecha", "6", Obj_Citas_DAL.FechaCita);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Hora", "5", Obj_Citas_DAL.Hora.TimeOfDay); //Capturar hora
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@AplicoPromocion", "7", Obj_Citas_DAL.bPromocion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Crea_Empleados", "2", Obj_Citas_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaCreado", "6", Obj_Citas_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarcitas"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Citas_DAL.sMgsError = string.Empty;
                Obj_Citas_DAL.id_Citas =    Convert.ToInt32( Obj_BD_DAL.sValorScalar);
                //obj_LineasDeTrabajo_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                Obj_Citas_DAL.sMgsError = Obj_BD_DAL.sMsError;
                //obj_LineasDeTrabajo_DAL.iId_LineasDeTrabajo = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Clientes", "2", Obj_Citas_DAL.id_Cliente);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_VehiculosPorClientes", "2", Obj_Citas_DAL.id_VehiculosPorClientes);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_EstadosCitas", "2", Obj_Citas_DAL.idEstadosCitas);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Fecha", "6", Obj_Citas_DAL.FechaCita);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Hora", "7", Obj_Citas_DAL.Hora); //Capturar hora
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@@Id_Actualiza_Empleados", "2", Obj_Citas_DAL.iCod_Emple);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@FechaActualizado", "6", Obj_Citas_DAL.Fecha);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarcitas"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Citas_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Citas_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

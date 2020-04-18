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
    public class cls_Capacitacion_BLL
    {

        #region Listar
        public void List_Capacitacion(ref cls_Capacitacion_DAL Obj_Capacitacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarcapacitacion"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablacapacitacion"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Capacitacion_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Capacitacion_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Capacitacion_DAL.dData = null;
                Obj_Capacitacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Capacitacion(ref cls_Capacitacion_DAL Obj_Capacitacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Capacitacion_DAL.iCod_Capac);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarcapacitacion"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablacapacitacion"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Capacitacion_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Capacitacion_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Capacitacion_DAL.dData = null;
                Obj_Capacitacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Capacitacion(ref cls_Capacitacion_DAL obj_Capacitacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Capacitacion_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Direccion", "1", obj_Capacitacion_DAL.sDireccion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "3", obj_Capacitacion_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Puesto", "2", obj_Capacitacion_DAL.iCod_Puesto);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarcapacitacion"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Capacitacion_DAL.sMgsError = string.Empty;
                //obj_Capacitacion_DAL.iCod_Capac = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_Capacitacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_Capacitacion_DAL.iCod_Capac = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Capacitacion(ref cls_Capacitacion_DAL obj_Capacitacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Capacitacion_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Direccion", "1", obj_Capacitacion_DAL.sDireccion);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Estado", "3", obj_Capacitacion_DAL.cEstado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id_Puesto", "2", obj_Capacitacion_DAL.iCod_Puesto);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Id", "2", obj_Capacitacion_DAL.iCod_Capac);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarcapacitacion"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Capacitacion_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_Capacitacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion

        #region Listar Puesto Trabajo
        public void List_PuestoTrabajo(ref cls_Capacitacion_DAL Obj_Capacitacion_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarpuestotrabajo"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablapuestotrabajo"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Capacitacion_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Capacitacion_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Capacitacion_DAL.dData = null;
                Obj_Capacitacion_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

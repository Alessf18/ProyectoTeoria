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
        public class cls_Usuarios_BLL
    {
        #region Listar
        public void List_Usuarios(ref cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarempleados"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaempleados"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Usuarios_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Usuarios_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Usuarios_DAL.dData = null;
                Obj_Usuarios_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Usuarios(ref cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Usuarios_DAL.iID);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarempleados"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaempleados"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Usuarios_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Usuarios_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Usuarios_DAL.dData = null;
                Obj_Usuarios_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

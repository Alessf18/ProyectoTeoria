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
    public class cls_Roles_BLL
    {
        #region Listar
        public void List_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["listarroles"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaroles"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Roles_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Roles_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Roles_DAL.dData = null;
                Obj_Roles_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Filtrar
        public void Fill_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@filtro", "1", Obj_Roles_DAL.sNombre);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["filtrarroles"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaroles"].ToString();

            Obj_BD_BLL.Excute_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                Obj_Roles_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Roles_DAL.sMgsError = string.Empty;
            }
            else
            {
                Obj_Roles_DAL.dData = null;
                Obj_Roles_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
        #region Insertar
        public void Insert_Roles(ref cls_Roles_DAL obj_Roles_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Roles_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Roles_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["insertarroles"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Roles_DAL.sMgsError = string.Empty;
                obj_Roles_DAL.iId_Rol = Convert.ToInt32(Obj_BD_DAL.sValorScalar.ToString());
            }
            else
            {
                obj_Roles_DAL.sMgsError = Obj_BD_DAL.sMsError;
                obj_Roles_DAL.iId_Rol = -1;
            }
        }
        #endregion
        #region Actualizar
        public void Update_Roles(ref cls_Roles_DAL obj_Roles_DAL)
        {
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Nombre", "1", obj_Roles_DAL.sNombre);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Descripcion", "1", obj_Roles_DAL.sDescripcion);

            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["modificarroles"].ToString();

            Obj_BD_BLL.Excute_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty)
            {
                obj_Roles_DAL.sMgsError = string.Empty;
            }
            else
            {
                obj_Roles_DAL.sMgsError = Obj_BD_DAL.sMsError;
            }
        }
        #endregion
    }
}

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
    public class cls_Login_BLL
    {
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

        public bool EstaRegistrado(ref cls_Login_DAL Obj_Login_DAL)
        {

            cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();

            Obj_Generales_BLL.CrearDTParametros(ref Obj_BD_DAL);

            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Usuario", "1", Obj_Login_DAL.sUsuario);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Contra", "1", Obj_Login_DAL.sContrasena);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Puesto", "2", Obj_Login_DAL.iPuesto);


            Obj_BD_DAL.sParametro = ConfigurationManager.AppSettings["login"].ToString();
            Obj_BD_DAL.sNombreTabla = ConfigurationManager.AppSettings["tablaempleados"].ToString();

            Obj_BD_BLL.Excute_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsError == string.Empty && Obj_BD_DAL.sValorScalar!="")
            {
                Obj_Login_DAL.dData = Obj_BD_DAL.Ds;
                Obj_Login_DAL.sMsgError = string.Empty;
                Obj_Login_DAL.iUsuario = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
                return true;
            }
            else
            {
                Obj_Login_DAL.dData = null;
                Obj_Login_DAL.sMsgError = "El usuario ingreso no esta registrado en el sistema";
                return false;
            }
        }
    }
}

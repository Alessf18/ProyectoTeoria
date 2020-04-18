using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Millas_DAL.BD;
using System.Data;

namespace Millas_BLL.Generales
{
    public class cls_Generales_BLL
    {
        public void CrearDTParametros(ref cls_BD_DAL Obj_BD_DAL)
        {
            Obj_BD_DAL.Dt_Parametros = new DataTable("Parametros_SP");
            Obj_BD_DAL.Dt_Parametros.Columns.Add("Nombre_Par");
            Obj_BD_DAL.Dt_Parametros.Columns.Add("Tipo_Dato_Par");
            Obj_BD_DAL.Dt_Parametros.Columns.Add("Valor_Par");
        }
    }
}

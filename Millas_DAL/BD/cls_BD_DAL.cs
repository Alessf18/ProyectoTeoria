using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Millas_DAL.BD;
using System.Configuration;

namespace Millas_DAL.BD
{
    public class cls_BD_DAL
    {
        private string _sMsError, _sCadenaCNX, _sParametro, _sNombreTabla, _sValorScalar;

        private DataSet _Ds;

        private DataTable _Dt_Parametros;

        private SqlConnection _Obj_SQL_CNX;// para abrir la base de Datos

        private SqlDataAdapter _Obj_SQL_DAP;//para select

        private SqlCommand _Obj_SQL_CMD;//insert update delete

        public string sMsError
        {
            get
            {
                return _sMsError;
            }

            set
            {
                _sMsError = value;
            }
        }

        public string sCadenaCNX
        {
            get
            {
                return _sCadenaCNX;
            }

            set
            {
                _sCadenaCNX = value;
            }
        }
            
        public string sParametro
        {
            get
            {
                return _sParametro;
            }

            set
            {
                _sParametro = value;
            }
        }

        public string sNombreTabla
        {
            get
            {
                return _sNombreTabla;
            }

            set
            {
                _sNombreTabla = value;
            }
        }

        public string sValorScalar
        {
            get
            {
                return _sValorScalar;
            }

            set
            {
                _sValorScalar = value;
            }
        }

        public DataSet Ds
        {
            get
            {
                return _Ds;
            }

            set
            {
                _Ds = value;
            }
        }

        public DataTable Dt_Parametros
        {
            get
            {
                return _Dt_Parametros;
            }

            set
            {
                _Dt_Parametros = value;
            }
        }

        public SqlConnection Obj_SQL_CNX
        {
            get
            {
                return _Obj_SQL_CNX;
            }

            set
            {
                _Obj_SQL_CNX = value;
            }
        }

        public SqlDataAdapter Obj_SQL_DAP
        {
            get
            {
                return _Obj_SQL_DAP;
            }

            set
            {
                _Obj_SQL_DAP = value;
            }
        }

        public SqlCommand Obj_SQL_CMD
        {
            get
            {
                return _Obj_SQL_CMD;
            }

            set
            {
                _Obj_SQL_CMD = value;
            }
        }
    }
}

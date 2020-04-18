using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Proveedor_DAL
    {
        private int _iCod_Provee, _iId_Capa;
        private string _sNombre, _sMgsError, _sDireccion;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc, _cEstado;

        public int iCod_Provee
        {
            get
            {
                return _iCod_Provee;
            }

            set
            {
                _iCod_Provee = value;
            }
        }

        public string sNombre
        {
            get
            {
                return _sNombre;
            }

            set
            {
                _sNombre = value;
            }
        }

        public string sMgsError
        {
            get
            {
                return _sMgsError;
            }

            set
            {
                _sMgsError = value;
            }
        }

        public string sDireccion
        {
            get
            {
                return _sDireccion;
            }

            set
            {
                _sDireccion = value;
            }
        }



        public DataTable dT_parametros
        {
            get
            {
                return _dT_parametros;
            }

            set
            {
                _dT_parametros = value;
            }
        }

        public char cBanOpc
        {
            get
            {
                return _cBanOpc;
            }

            set
            {
                _cBanOpc = value;
            }
        }

        public int iId_Capa
        {
            get
            {
                return _iId_Capa;
            }

            set
            {
                _iId_Capa = value;
            }
        }

        public char cEstado
        {
            get
            {
                return _cEstado;
            }

            set
            {
                _cEstado = value;
            }
        }

        public DataSet dData
        {
            get
            {
                return _dData;
            }

            set
            {
                _dData = value;
            }
        }
    }
}

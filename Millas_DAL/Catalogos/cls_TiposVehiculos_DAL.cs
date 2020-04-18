using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_TiposVehiculos_DAL
    {
        private int _iCod_TiposVehiculos, _iId_Empleado;
        private string _sNombre, _sMgsError;
        private bool _bEstado;
        private DateTime _fecha;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;

        public int iCod_TiposVehiculos
        {
            get
            {
                return _iCod_TiposVehiculos;
            }

            set
            {
                _iCod_TiposVehiculos = value;
            }
        }

        public int iId_Empleado
        {
            get
            {
                return _iId_Empleado;
            }

            set
            {
                _iId_Empleado = value;
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

        public bool bEstado
        {
            get
            {
                return _bEstado;
            }

            set
            {
                _bEstado = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
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
    }
}

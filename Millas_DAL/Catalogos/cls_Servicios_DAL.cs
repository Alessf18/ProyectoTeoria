using System;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Servicios_DAL
    {
        private int _iCod_Insumo, _iPrecio, _iCod_Emple;
        private string _sMgsError, _sDescripcion;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fechaCreado, fechaActualiza;
        private bool _bEstado;

        public int iCod_Insumo
        {
            get
            {
                return _iCod_Insumo;
            }

            set
            {
                _iCod_Insumo = value;
            }
        }

        public int iPrecio
        {
            get
            {
                return _iPrecio;
            }

            set
            {
                _iPrecio = value;
            }
        }

        public int iCod_Emple
        {
            get
            {
                return _iCod_Emple;
            }

            set
            {
                _iCod_Emple = value;
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

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
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

        public DateTime FechaCreado
        {
            get
            {
                return fechaCreado;
            }

            set
            {
                fechaCreado = value;
            }
        }

        public DateTime FechaActualiza
        {
            get
            {
                return fechaActualiza;
            }

            set
            {
                fechaActualiza = value;
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
    }
}

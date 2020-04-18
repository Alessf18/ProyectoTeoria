using System;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Clientes_DAL
    {
        private int _iCod_Id, _iCedulas, _iNumeroCel, _iNumeroTele, iCod_id_Identificaciones, _iCod_EmpleCreador, iCod_empleActual;
        private string _sMgsError, _sNombres, _sApellidos,_Siden;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private string _sCorreo, _sDireccion;
        private DateTime fechaCreado, fechaActualiza;
        private char _cBanOpc;

        public int iCod_Id
        {
            get
            {
                return _iCod_Id;
            }

            set
            {
                _iCod_Id = value;
            }
        }

        public int iCedulas
        {
            get
            {
                return _iCedulas;
            }

            set
            {
                _iCedulas = value;
            }
        }

        public int iNumeroCel
        {
            get
            {
                return _iNumeroCel;
            }

            set
            {
                _iNumeroCel = value;
            }
        }

        public int iNumeroTele
        {
            get
            {
                return _iNumeroTele;
            }

            set
            {
                _iNumeroTele = value;
            }
        }

        public int ICod_id_Identificaciones
        {
            get
            {
                return iCod_id_Identificaciones;
            }

            set
            {
                iCod_id_Identificaciones = value;
            }
        }

        public int iCod_EmpleCreador
        {
            get
            {
                return _iCod_EmpleCreador;
            }

            set
            {
                _iCod_EmpleCreador = value;
            }
        }

        public int ICod_empleActual
        {
            get
            {
                return iCod_empleActual;
            }

            set
            {
                iCod_empleActual = value;
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

        public string sNombres
        {
            get
            {
                return _sNombres;
            }

            set
            {
                _sNombres = value;
            }
        }

        public string sApellidos
        {
            get
            {
                return _sApellidos;
            }

            set
            {
                _sApellidos = value;
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

        public string sCorreo
        {
            get
            {
                return _sCorreo;
            }

            set
            {
                _sCorreo = value;
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

        public string Siden { get => _Siden; set => _Siden = value; }
    }
}

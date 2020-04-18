using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_ReciboProveedores_DAL
    {
        private int _iCod_ReciboProveedores, _iCantidad, _iUbicacion, _iCod_Emple, _iId_NumeroMedida;
        private string _sMgsError, _sDescripcion, _sNumeroParte;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fecha;

        public int iCod_ReciboProveedores
        {
            get
            {
                return _iCod_ReciboProveedores;
            }

            set
            {
                _iCod_ReciboProveedores = value;
            }
        }

        public int iCantidad
        {
            get
            {
                return _iCantidad;
            }

            set
            {
                _iCantidad = value;
            }
        }

        public int iUbicacion
        {
            get
            {
                return _iUbicacion;
            }

            set
            {
                _iUbicacion = value;
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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public int iId_NumeroMedida
        {
            get
            {
                return _iId_NumeroMedida;
            }

            set
            {
                _iId_NumeroMedida = value;
            }
        }

        public string sNumeroParte
        {
            get
            {
                return _sNumeroParte;
            }

            set
            {
                _sNumeroParte = value;
            }
        }
    }
}

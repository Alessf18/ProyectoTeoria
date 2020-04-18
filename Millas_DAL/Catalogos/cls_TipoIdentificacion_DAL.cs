using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_TipoIdentificacion_DAL
    {
        private int _iCod_Identificacion , _iCod_EmpleCreador, iCod_empleActual, _iCantidad;
        private string _sMgsError, _sNombre;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fechaCreado, fechaActualiza;

        public int iCod_Identificacion
        {
            get
            {
                return _iCod_Identificacion;
            }

            set
            {
                _iCod_Identificacion = value;
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
    }
}

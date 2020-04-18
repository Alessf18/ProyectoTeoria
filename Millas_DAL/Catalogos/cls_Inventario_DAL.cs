using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Inventario_DAL
    {
        private int _iCod_Inventario, _iCod_Emple, _iCantidadSistema, _iCantidadReservada, _iId_UnidadMedida, _iId_ReciboProveedor;
        private string _sMgsError, _sDescripcion, _sNumeroParte, _sUbicacion, _sEstadoMaterial;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fecha;

        public int iCod_Inventario
        {
            get
            {
                return _iCod_Inventario;
            }

            set
            {
                _iCod_Inventario = value;
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

        public int iCantidadSistema
        {
            get
            {
                return _iCantidadSistema;
            }

            set
            {
                _iCantidadSistema = value;
            }
        }

        public int iCantidadReservada
        {
            get
            {
                return _iCantidadReservada;
            }

            set
            {
                _iCantidadReservada = value;
            }
        }

        public int iId_UnidadMedida
        { 
            get
            {
                return _iId_UnidadMedida;
            }

            set
            {
                _iId_UnidadMedida = value;
            }
        }

        public int iId_ReciboProveedor
        {
            get
            {
                return _iId_ReciboProveedor;
            }

            set
            {
                _iId_ReciboProveedor = value;
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

        public string sUbicacion
        {
            get
            {
                return _sUbicacion;
            }

            set
            {
                _sUbicacion = value;
            }
        }

        public string sEstadoMaterial
        {
            get
            {
                return _sEstadoMaterial;
            }

            set
            {
                _sEstadoMaterial = value;
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
    }
}

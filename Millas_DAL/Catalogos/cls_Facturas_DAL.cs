using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Facturas_DAL
    {
        private int _iId_factura, _iId_CeduJuridica, _iTelefono, _iCantidad, _iCod_Emple, _iId_OrdenServicio;
        private float _fPrecioMaterialFactura, _fTotalFactura, _fImpuestosFactura, _fDescuentoFactura, _fTotalPagarFactura;
        private string _sMgsError, _sDireccionTaller, _sNombreTaller, _sNombreCliente, _sId_MaterialDescripcion, _sUnidadMedida;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fecha;

        public int iId_factura
        {
            get
            {
                return _iId_factura;
            }

            set
            {
                _iId_factura = value;
            }
        }

        public int iId_CeduJuridica
        {
            get
            {
                return _iId_CeduJuridica;
            }

            set
            {
                _iId_CeduJuridica = value;
            }
        }

        public int iTelefono
        {
            get
            {
                return _iTelefono;
            }

            set
            {
                _iTelefono = value;
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

        public int iId_OrdenServicio
        {
            get
            {
                return _iId_OrdenServicio;
            }

            set
            {
                _iId_OrdenServicio = value;
            }
        }

        public float fPrecioMaterialFactura
        {
            get
            {
                return _fPrecioMaterialFactura;
            }

            set
            {
                _fPrecioMaterialFactura = value;
            }
        }

        public float fTotalFactura
        {
            get
            {
                return _fTotalFactura;
            }

            set
            {
                _fTotalFactura = value;
            }
        }

        public float fImpuestosFactura
        {
            get
            {
                return _fImpuestosFactura;
            }

            set
            {
                _fImpuestosFactura = value;
            }
        }

        public float fDescuentoFactura
        {
            get
            {
                return _fDescuentoFactura;
            }

            set
            {
                _fDescuentoFactura = value;
            }
        }

        public float fTotalPagarFactura
        {
            get
            {
                return _fTotalPagarFactura;
            }

            set
            {
                _fTotalPagarFactura = value;
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

        public string sDireccionTaller
        {
            get
            {
                return _sDireccionTaller;
            }

            set
            {
                _sDireccionTaller = value;
            }
        }

        public string sNombreTaller
        {
            get
            {
                return _sNombreTaller;
            }

            set
            {
                _sNombreTaller = value;
            }
        }


        public string sNombreCliente
        {
            get
            {
                return _sNombreCliente;
            }

            set
            {
                _sNombreCliente = value;
            }
        }

        public string sId_MaterialDescripcion
        {
            get
            {
                return _sId_MaterialDescripcion;
            }

            set
            {
                _sId_MaterialDescripcion = value;
            }
        }

        public string sUnidadMedida
        {
            get
            {
                return _sUnidadMedida;
            }

            set
            {
                _sUnidadMedida = value;
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

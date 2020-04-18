using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_UnidadMedida_DAL
    {

        private int _iCod_Unidad, _iId_Empleado;
        private string _sDescripcion, _sMgsError;
        private float _fPrecio;
        private bool _bEstado;
        private DateTime _fecha;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;

        public int iCod_Unidad
        {
            get
            {
                return _iCod_Unidad;
            }

            set
            {
                _iCod_Unidad = value;
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

        public DateTime fecha
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

        public float fPrecio
        {
            get
            {
                return _fPrecio;
            }

            set
            {
                _fPrecio = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_MantenimientoMateriales_DAL
    {
        private int _iCod_MantenimientoMateriales, _iCod_Emple, _iId_Inventarios, _iId_UnidadMedida;
        private string _sMgsError, _sDescripcion, _sFamiliaMaterial, _sUbicacion, _sEstadoMaterial;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private float _fPrecio;
        private char _cBanOpc;
        private DateTime fecha;

        public int iCod_MantenimientoMateriales
        {
            get
            {
                return _iCod_MantenimientoMateriales;
            }

            set
            {
                _iCod_MantenimientoMateriales = value;
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

        public int iId_Inventarios
        {
            get
            {
                return _iId_Inventarios;
            }

            set
            {
                _iId_Inventarios = value;
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

        public string sFamiliaMaterial
        {
            get
            {
                return _sFamiliaMaterial;
            }

            set
            {
                _sFamiliaMaterial = value;
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

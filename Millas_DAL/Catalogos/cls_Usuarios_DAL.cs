using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Usuarios_DAL
    {
        private DataTable _dT_parametros;
        private string _sNombre, _sApellido1, _sApellido2, _sPuesto, _sCorreo, _sDireccion;
        private int _iID, _iEdad, _iTelefono;
        private string _sMgsError;
        private DataSet _dData;

        public DataTable DT_parametros
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

        public string sApellido1
        {
            get
            {
                return _sApellido1;
            }

            set
            {
                _sApellido1 = value;
            }
        }

        public string sApellido2
        {
            get
            {
                return _sApellido2;
            }

            set
            {
                _sApellido2 = value;
            }
        }

        public string sPuesto
        {
            get
            {
                return _sPuesto;
            }

            set
            {
                _sPuesto = value;
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
                return sDireccion;
            }

            set
            {
                sDireccion = value;
            }
        }

        public int iID
        {
            get
            {
                return iID;
            }

            set
            {
                iID = value;
            }
        }

        public int iEdad
        {
            get
            {
                return iEdad;
            }

            set
            {
                iEdad = value;
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

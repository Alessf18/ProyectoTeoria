using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_LineasDeTrabajo_DAL
    {
        private int _iId_LineasDeTrabajo, _iID_Servicios, _iId_Crea_Empleado;
        private string _sMgsError, _sDescripcion;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc, _cEstado;
        private DateTime _fecha;

        public int iId_LineasDeTrabajo
        {
            get
            {
                return _iId_LineasDeTrabajo;
            }

            set
            {
                _iId_LineasDeTrabajo = value;
            }
        }

        public int iID_Servicios
        {
            get
            {
                return _iID_Servicios;
            }

            set
            {
                _iID_Servicios = value;
            }
        }

        public int iId_Crea_Empleado
        {
            get
            {
                return _iId_Crea_Empleado;
            }

            set
            {
                _iId_Crea_Empleado = value;
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

        public char cEstado
        {
            get
            {
                return _cEstado;
            }

            set
            {
                _cEstado = value;
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
    }
}

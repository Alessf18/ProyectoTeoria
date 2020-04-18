using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_OrdenDeServicio_DAL
    {
        private int _iId_OrdenDeServicio, _iId_Cita, _iCantidad, _iId_Material, _iCod_Emple;
        private string _sMgsError, _sDescripcion, _sNumeroParte, _sEntrega;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fecha;

        public int iId_OrdenDeServicio
        {
            get
            {
                return _iId_OrdenDeServicio;
            }

            set
            {
                _iId_OrdenDeServicio = value;
            }
        }

        public int iId_Cita
        {
            get
            {
                return _iId_Cita;
            }

            set
            {
                _iId_Cita = value;
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

        public int iId_Material
        {
            get
            {
                return _iId_Material;
            }

            set
            {
                _iId_Material = value;
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

        public string sEntrega
        {
            get
            {
                return _sEntrega;
            }

            set
            {
                _sEntrega = value;
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

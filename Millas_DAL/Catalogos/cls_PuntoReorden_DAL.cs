using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_PuntoReorden_DAL
    {
        private int _iId_Reorden, _iCod_PuntoReordenMaterial, _iCantidadPedido, _iId_Inventarios , _iCod_Emple;
        private string _sMgsError, _sDescripcion;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fecha;

        public int iId_Reorden
        {
            get
            {
                return _iId_Reorden;
            }

            set
            {
                _iId_Reorden = value;
            }
        }

        public int iCod_PuntoReordenMaterial
        {
            get
            {
                return _iCod_PuntoReordenMaterial;
            }

            set
            {
                _iCod_PuntoReordenMaterial = value;
            }
        }

        public int iCantidadPedido
        {
            get
            {
                return _iCantidadPedido;
            }

            set
            {
                _iCantidadPedido = value;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_VehiPorClientes_DAL
    {
        private int _iCod_VehiPorClientes, _iCod_TipoVehiculos, _iCod_MarcasVehiculos, _iCod_ModelosVehiculos, _iAnio, _iCod_Combustible, _iId_Cliente;
        private string _sMgsError, _sPlaca, _sComentario;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;

        public int iCod_VehiPorClientes
        {
            get
            {
                return _iCod_VehiPorClientes;
            }

            set
            {
                _iCod_VehiPorClientes = value;
            }
        }

        public int iCod_TipoVehiculos
        {
            get
            {
                return _iCod_TipoVehiculos;
            }

            set
            {
                _iCod_TipoVehiculos = value;
            }
        }

        public int iCod_MarcasVehiculos
        {
            get
            {
                return _iCod_MarcasVehiculos;
            }

            set
            {
                _iCod_MarcasVehiculos = value;
            }
        }

        public int iCod_ModelosVehiculos
        {
            get
            {
                return _iCod_ModelosVehiculos;
            }

            set
            {
                _iCod_ModelosVehiculos = value;
            }
        }

        public int iAnio
        {
            get
            {
                return _iAnio;
            }

            set
            {
                _iAnio = value;
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

        public string sPlaca
        {
            get
            {
                return _sPlaca;
            }

            set
            {
                _sPlaca = value;
            }
        }

        public string sComentario
        {
            get
            {
                return _sComentario;
            }

            set
            {
                _sComentario = value;
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

        public int iCod_Combustible
        {
            get
            {
                return _iCod_Combustible;
            }

            set
            {
                _iCod_Combustible = value;
            }
        }

        public int iId_Cliente
        {
            get
            {
                return _iId_Cliente;
            }

            set
            {
                _iId_Cliente = value;
            }
        }
    }
}

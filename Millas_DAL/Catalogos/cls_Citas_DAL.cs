using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Millas_DAL.Catalogos
{
    public class cls_Citas_DAL
    {
        private int _id_Citas, _id_VehiculosPorClientes, _id_Cliente, _idEstadosCitas, _iCod_Emple;
        private string _sMgsError, _sDescripcion;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fecha, _fechaCita, _Hora;
        private bool _bPromocion;

        public int id_Citas
        {
            get
            {
                return _id_Citas;
            }

            set
            {
                _id_Citas = value;
            }
        }

        public int id_VehiculosPorClientes
        {
            get
            {
                return _id_VehiculosPorClientes;
            }

            set
            {
                _id_VehiculosPorClientes = value;
            }
        }

        public int idEstadosCitas
        {
            get
            {
                return _idEstadosCitas;
            }

            set
            {
                _idEstadosCitas = value;
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

        public DateTime FechaCita
        {
            get
            {
                return _fechaCita;
            }

            set
            {
                _fechaCita = value;
            }
        }

        public bool bPromocion
        {
            get
            {
                return _bPromocion;
            }

            set
            {
                _bPromocion = value;
            }
        }

        public int id_Cliente
        {
            get
            {
                return _id_Cliente;
            }

            set
            {
                _id_Cliente = value;
            }
        }

        public DateTime Hora
        {
            get
            {
                return _Hora;
            }

            set
            {
                _Hora = value;
            }
        }
    }
}

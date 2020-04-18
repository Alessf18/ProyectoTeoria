using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_ModelosVehi_DAL
    {
        private int _iCod_Model, iCod_Marca, iCod_Combustible, _iCod_EmpleCreador, iCod_empleActual, _iMotor;
        private string _sMgsError, _sDescripcion;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc, _cEstado;
        private DateTime fechaCreado, fechaActualiza;
        private float _fCoolant, _fGas, _fAceite;

        public int iCod_Model
        {
            get
            {
                return _iCod_Model;
            }

            set
            {
                _iCod_Model = value;
            }
        }

        public int ICod_Marca
        {
            get
            {
                return iCod_Marca;
            }

            set
            {
                iCod_Marca = value;
            }
        }

        public int ICod_Combustible
        {
            get
            {
                return iCod_Combustible;
            }

            set
            {
                iCod_Combustible = value;
            }
        }

        public int iCod_EmpleCreador
        {
            get
            {
                return _iCod_EmpleCreador;
            }

            set
            {
                _iCod_EmpleCreador = value;
            }
        }

        public int ICod_empleActual
        {
            get
            {
                return iCod_empleActual;
            }

            set
            {
                iCod_empleActual = value;
            }
        }

        public int iMotor
        {
            get
            {
                return _iMotor;
            }

            set
            {
                _iMotor = value;
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

        public DateTime FechaCreado
        {
            get
            {
                return fechaCreado;
            }

            set
            {
                fechaCreado = value;
            }
        }

        public DateTime FechaActualiza
        {
            get
            {
                return fechaActualiza;
            }

            set
            {
                fechaActualiza = value;
            }
        }

        public float fCoolant
        {
            get
            {
                return _fCoolant;
            }

            set
            {
                _fCoolant = value;
            }
        }

        public float fGas
        {
            get
            {
                return _fGas;
            }

            set
            {
                _fGas = value;
            }
        }

        public float fAceite
        {
            get
            {
                return _fAceite;
            }

            set
            {
                _fAceite = value;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Marcas_DAL
    {
        private int _iCod_Emple, _iCod_Marca, _iId_TiposVehi;
        private string _sDescripcion, _sMgsError;
        private DateTime fechaCreado;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private bool _bEstado;

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

        public int iCod_Marca
        {
            get
            {
                return _iCod_Marca;
            }

            set
            {
                _iCod_Marca = value;
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

        public int Id_TiposVehi
        {
            get
            {
                return _iId_TiposVehi;
            }

            set
            {
                _iId_TiposVehi = value;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_MantenimientoInventarios_DAL
    {
        private int _iCod_MantenimientoInventario, _iCod_Emple, _iId_Inventarios, _iId_UnidadMedida, _iCantidad;
        private string _sMgsError, _sDescripcion, _sNumeroParte, _sTipoAjuste; 
        private DataSet _dData;
        private DataTable _dT_parametros;
        private char _cBanOpc;
        private DateTime fecha;

        public int iCod_MantenimientoInventario
        {
            get
            {
                return _iCod_MantenimientoInventario;
            }

            set
            {
                _iCod_MantenimientoInventario = value;
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

        public string sTipoAjuste
        {
            get
            {
                return _sTipoAjuste;
            }

            set
            {
                _sTipoAjuste = value;
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

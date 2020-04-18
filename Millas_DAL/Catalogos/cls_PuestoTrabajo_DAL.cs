using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
   public class cls_PuestoTrabajo_DAL
    {
        private int _iCod_Id, _iCod_Rol;
        private string _sMgsError, _sNombre;
        private DataSet _dData;
        private DataTable _dT_parametros;
        private float _fSalario;

        public int iCod_Id
        {
            get
            {
                return _iCod_Id;
            }

            set
            {
                _iCod_Id = value;
            }
        }

        public int iCod_Rol
        {
            get
            {
                return _iCod_Rol;
            }

            set
            {
                _iCod_Rol = value;
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

        public float fSalario
        {
            get
            {
                return _fSalario;
            }

            set
            {
                _fSalario = value;
            }
        }
    }
}

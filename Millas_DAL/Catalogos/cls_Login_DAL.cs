using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Millas_DAL.Catalogos
{
    public class cls_Login_DAL
    {
        private string _sMsgError, _sContrasena,_sUsuario,_sCedUsuActual;
        private DataSet _dData;
        private int _iActualUserId, _iUsuario,_iPuesto;

        public string sMsgError
        {
            get
            {
                return _sMsgError;
            }

            set
            {
                _sMsgError = value;
            }
        }


        public string sContrasena
        {
            get
            {
                return _sContrasena;
            }

            set
            {
                _sContrasena = value;
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

        public int iActualUserId
        {
            get
            {
                return _iActualUserId;
            }

            set
            {
                _iActualUserId = value;
            }
        }

        public int iUsuario
        {
            get
            {
                return _iUsuario;
            }

            set
            {
                _iUsuario = value;
            }
        }

        public string sUsuario { get => _sUsuario; set => _sUsuario = value; }
        public int iPuesto { get => _iPuesto; set => _iPuesto = value; }
        public string sCedUsuActual { get => _sCedUsuActual; set => _sCedUsuActual = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Millas_DAL.Catalogos
{
    public class cls_ServciosPorCitas_DAL
    {
        private int _iIdCitas, _iIdServicios, _iIdEmp, _iIEmpAct,_iId;
        private DateTime _datFechaCr, _datFechaAct;
        private string _sMgsError;
        private DataSet _dData;
        private DataTable _dT_parametros;
        public int iIdCitas { get => _iIdCitas; set => _iIdCitas = value; }
        public int iIdServicios { get => _iIdServicios; set => _iIdServicios = value; }
        public int iIdEmp { get => _iIdEmp; set => _iIdEmp = value; }
        public int IIEmpAct { get => _iIEmpAct; set => _iIEmpAct = value; }
        public DateTime datFechaCr { get => _datFechaCr; set => _datFechaCr = value; }
        public DateTime datFechaAct { get => _datFechaAct; set => _datFechaAct = value; }
        public string sMgsError { get => _sMgsError; set => _sMgsError = value; }
        public DataSet dData { get => _dData; set => _dData = value; }
        public DataTable dT_parametros { get => _dT_parametros; set => _dT_parametros = value; }
        public int iId { get => _iId; set => _iId = value; }
    }
}

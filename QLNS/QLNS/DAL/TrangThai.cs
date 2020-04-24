using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class TrangThai
    {
        private long _MaTT;
        private string _TenTT;
        public TrangThai()
        {
            _MaTT = 0;
            _TenTT = "";
        }
        public TrangThai(long mc, string ten)
        {
            _MaTT = mc;
            _TenTT = ten;
        }
        public long MaTT { get => _MaTT; set => _MaTT = value; }
        public string TenTT { get => _TenTT; set => _TenTT = value; }
    }
}

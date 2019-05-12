using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ChucVU
    {
        private long _MaCV;
        private string _TenCV;
        public ChucVU()
        {
            _MaCV = 0;
            _TenCV = "";
        }
        public ChucVU(long mc, string ten)
        {
            _MaCV = mc;
            _TenCV = ten;
        }
        public long MaCV { get => _MaCV; set => _MaCV = value; }
        public string TenCV { get => _TenCV; set => _TenCV = value; }
    }
}

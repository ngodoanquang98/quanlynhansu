using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class PhongBan
    {
        private long _MaPB;
        private string _TenPB;
        private long _sl;
        public PhongBan()
        {
            _MaPB = 0;
            _TenPB = "";
            _sl = 0;
        }
        public PhongBan(long ma, string ten,long sl)
        {
            _MaPB = ma;
            _TenPB = ten;
            _sl = sl;
        }
        public PhongBan(DataRow r)
        {
            long.TryParse(r["MaPB"].ToString(), out _MaPB);
            _TenPB = r["TenPB"].ToString();
            long.TryParse(r["SoNV"].ToString(), out _sl);
        }
        public long MaPB { get => _MaPB; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }
        public long SoNV { get => _sl;  }
    }
}

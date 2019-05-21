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
        public PhongBan()
        {
            _MaPB = 0;
            _TenPB = "";
        }
        public PhongBan(long ma, string ten)
        {
            _MaPB = ma;
            _TenPB = ten;
        }
        public PhongBan(DataRow r)
        {
            long.TryParse(r["MaPB"].ToString(), out _MaPB);
            _TenPB = r["TenPB"].ToString();
        }
        public long MaPB { get => _MaPB; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }
    }
}

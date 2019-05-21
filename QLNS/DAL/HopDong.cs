using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class HopDong
    {

        private long _MaHD;
        private long _MaLHD;
        private long _MaNV;
        public HopDong()
        {
            _MaHD = 0;
            _MaLHD = 0;
            _MaNV = 0;
        }
        public HopDong(long ma, long ca, long nv)
        {
            _MaHD = ma;
            _MaLHD = ca;
            _MaNV = nv;
        }
        public HopDong(DataRow r)
        {
            long.TryParse(r["MaNV"].ToString(), out _MaNV);
            long.TryParse(r["MaHD"].ToString(), out _MaHD);
            long.TryParse(r["MaLHD"].ToString(), out _MaLHD);

        }
        public long MaHD { get => _MaHD; }
        public long MaLHD { get => _MaLHD; set => _MaLHD = value; }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
    }
}

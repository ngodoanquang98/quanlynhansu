using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class HopDong
    {
        private long _MaHD = 0;
        private long _MaNV = 0;
        private long _MaLHD = 0;
        private DateTime _NgayBatDau;
        public HopDong()
        {
            
        }
        public HopDong(long a, long b, long c, DateTime Ngay)
        {
            _MaHD = a;
            _MaNV = b;
            _MaLHD = c;
            _NgayBatDau = Ngay;
        }

        public long MaHD { get => _MaHD; set => _MaHD = value; }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
        public long MaLHD { get => _MaLHD; set => _MaLHD = value; }
        public DateTime NgayBatDau { get => _NgayBatDau; set => _NgayBatDau = value; }
    }
}

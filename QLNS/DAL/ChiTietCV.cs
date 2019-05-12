using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ChiTietCV
    {
        private long _MaCV;
        private long _MaNV;
        private DateTime _NgayBD;
        private long _MaPB;
        public ChiTietCV()
        {
            _MaCV = 0;
            _MaNV = 0;
            _NgayBD = DateTime.Now;
            _MaPB = 0;
        }
        public ChiTietCV(long cv, long nv, DateTime bd, long pb)
        {
            _MaPB = pb;
            _MaNV = nv;
            _MaCV = cv;
            _NgayBD = bd;
        }
        public long MaCV { get => _MaCV; set => _MaCV = value; }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
        public long MaPB { get => _MaPB; set => _MaPB = value; }
        public DateTime NgayBD { get => _NgayBD; set => _NgayBD = value; }
    }
}

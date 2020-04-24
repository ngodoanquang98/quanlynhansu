using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ChiTietTT
    {
        private long _MaTT;
        private long _MaNV;
        private DateTime _NgayBD;
        private string _GhiChu;
        public ChiTietTT()
        {
            _MaTT = 0;
            _MaNV = 0;
            _NgayBD = DateTime.Now;
            _GhiChu = "";
        }
        public ChiTietTT(long tt, long nv, DateTime bd, string gc)
        {
            _MaTT = tt;
            _MaNV = nv;
            _NgayBD = bd;
            _GhiChu = gc;
        }
        public long MaTT { get => _MaTT; set => _MaTT = value; }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public DateTime NgayBD { get => _NgayBD; set => _NgayBD = value; }
    }

}

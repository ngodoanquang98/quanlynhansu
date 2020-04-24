using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class LuongCoBan
    {
        private double _MaLCB;
        private double _Luong;
        public LuongCoBan()
        {
            _MaLCB = 0;
            _Luong = 0;
        }
        public LuongCoBan(double ma, double luong)
        {
            _MaLCB = ma;
            _Luong = luong;
        }
        public double MaLCB { get => _MaLCB; }
        public double Luong { get => _Luong; set => _Luong = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class NhatKy
    {
        private double _MaNK;
        private DateTime _Ngay;
        private double _MaND;
        public NhatKy()
        {
            _MaNK = 0;
            _MaND = 0;
            _Ngay = DateTime.Now;
        }
        public NhatKy(double ma, double nd, DateTime ngay)
        {
            _MaNK = ma;
            _MaND = nd;
            _Ngay = ngay;
        }
        public double MaNK { get => _MaNK; }
        public double MaND { get => _MaND; set => _MaND = value; }
    }
}

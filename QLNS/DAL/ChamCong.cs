using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ChamCong
    {
        private double _MaChamCong;
        private DateTime _Ngay;
        private double _MaCa;
        private double _MaNV;
        public ChamCong()
        {
            _MaChamCong = 0;
            _MaCa = 0;
            _Ngay = DateTime.Now;
            _MaNV = 0;
        }
        public ChamCong(double ma, DateTime ngay, double ca, double nv)
        {
            _MaChamCong = ma;
            _Ngay = ngay;
            _MaCa = ca;
            _MaNV = nv;
        }
        public double MaChamCong { get => _MaChamCong; }
        public DateTime Ngay { get => _Ngay; set => _Ngay = value; }
        public double MaCa { get => _MaCa; set => _MaCa = value; }
        public double MaNV { get => _MaNV; set => _MaNV = value; }
    }
}

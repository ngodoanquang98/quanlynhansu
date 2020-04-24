using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class PhongBan
    {
        private double _MaPB;
        private string _TenPB;
        private double _MaTP;
        private DateTime _NgayNhanChuc;
        private int _TongNV;
        public PhongBan()
        {
            _MaPB = 0;
            _TenPB = "";
            _NgayNhanChuc = DateTime.Now;
            _TongNV = 0;
        }
        public PhongBan(double ma, string ten, double matp, DateTime ngay, int tong)
        {
            _MaPB = ma;
            _TenPB = ten;
            _NgayNhanChuc = ngay;
            _TongNV = tong;
        }
        public double MaPB { get => _MaPB; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }
        public double MaTP { get => _MaTP; set => _MaTP = value; }
        public DateTime NgayNhanChuc { get => _NgayNhanChuc; set => _NgayNhanChuc = value; }
        public int TongNV { get => _TongNV; set => _TongNV = value; }
    }
}

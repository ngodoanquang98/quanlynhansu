using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ChiTietLuong
    {
        private double _MaLCB;
        private double _MaNV;
        private int _TongSoNgay;
        private int _TongSoDem;
        private decimal _Luong;
        private decimal _TienBaoHiem;
        public ChiTietLuong()
        {
            _MaLCB = 0;
            _MaNV = 0;
            _TongSoDem = 0;
            _TongSoNgay = 0;
            _Luong = 0;
            _TienBaoHiem = 0;
        }
        public ChiTietLuong(double ma, double manv, int ngay, int dem, decimal l, decimal bh)
        {
            _MaLCB = ma;
            _MaNV = manv;
            _TongSoDem = dem;
            _TongSoNgay = ngay;
            _Luong = l;
            _TienBaoHiem = bh;
        }
        public double MaLCB { get => _MaLCB; set => _MaLCB = value; }
        public double MaNV { get => _MaNV; set => _MaNV = value; }
        public int TongSoNgay { get => _TongSoNgay; }
        public int TongSoDem { get => _TongSoDem; }
        public decimal Luong { get => _Luong; }
        public decimal TienBaoHiem { get => _TienBaoHiem; set => _TienBaoHiem = value; }
    }
}

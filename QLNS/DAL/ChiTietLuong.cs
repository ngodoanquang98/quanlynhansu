using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ChiTietLuong
    {
        private long _MaNV;
        private int _TongNgay;
        private int _TongDem;
        private decimal _Luong;
        private decimal _TienBaoHiem;
        public ChiTietLuong()
        {
            _MaNV = 0;
            _TongDem = 0;
            _TongNgay = 0;
            _Luong = 500000;
            _TienBaoHiem = 0;
        }
        public ChiTietLuong(long manv, int ngay, int dem, decimal l, decimal bh)
        {
            _MaNV = manv;
            _TongDem = dem;
            _TongNgay = ngay;
            _Luong = l;
            _TienBaoHiem = bh;
        }
        public ChiTietLuong(DataRow r)
        {
            long.TryParse(r["MaNV"].ToString(), out _MaNV);
            decimal.TryParse(r["Luong"].ToString(), out _Luong);
            int.TryParse(r["TongDem"].ToString(), out _TongDem);
            int.TryParse(r["TongNgay"].ToString(), out _TongNgay);
            decimal.TryParse(r["TienBaoHiem"].ToString(), out _TienBaoHiem);

        }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
        public int TongNgay { get => _TongNgay; }
        public int TongDem { get => _TongDem; }
        public decimal Luong { get => _Luong; }
        public decimal TienBaoHiem { get => _TienBaoHiem; set => _TienBaoHiem = value; }
    }
}
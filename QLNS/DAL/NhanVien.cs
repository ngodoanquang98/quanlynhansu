using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class NhanVien
    {
        private long _MaNV;
        private string _HoTen;
        private DateTime _NgaySinh;
        private string _QueQuan;
        private string _email;
        private long _MaPB;
        private string _SDT;
        private string _CMT;
        private long _SoHD;
        private DateTime _NgayBatDau;
        public NhanVien()
        {
            _MaNV = 0;
            _HoTen = "";
            _NgaySinh = DateTime.Now;
            _QueQuan = "";
            _email = "";
            _MaPB = 0;
            _SDT = "";
            _CMT = "";
            _SoHD = 0;
            _NgayBatDau = DateTime.Now;
        }
        public NhanVien(long manv, string ten, long mapb,  string que, DateTime ngay, string email, string sdt, string cmt, long so, DateTime date)
        {
            _MaNV = manv;
            _HoTen = ten;
            _NgaySinh = ngay;
            _QueQuan = que;
            _email = email;
            _MaPB = mapb;
            _SDT = sdt;
            _CMT = cmt;
            _SoHD = so;
            _NgayBatDau = date;
        }


        public NhanVien(DataRow r)
        {
            long.TryParse(r["MaNV"].ToString(), out _MaNV);
            _HoTen = r["HoTen"].ToString();
            _QueQuan = r["QueQuan"].ToString();
            DateTime.TryParse(r["NgaySinh"].ToString(), out _NgaySinh);
            _email = r["email"].ToString();
            long.TryParse(r["MaPB"].ToString(), out _MaPB);
            _SDT = r["SDT"].ToString();
            _CMT = r["CMT"].ToString();
            long.TryParse(r["SoHD"].ToString(), out _SoHD);
            DateTime.TryParse(r["NgayBatDau"].ToString(), out _NgayBatDau);
        }
        public long MaNV { get => _MaNV; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string QueQuan { get => _QueQuan; set => _QueQuan = value; }
        public string email { get => _email; set => _email = value; }
        public long MaPB { get => _MaPB; set => _MaPB = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string CMT { get => _CMT; set => _CMT = value; }

        public long SoHD { get => _SoHD; set => _SoHD = value; }
        public DateTime NgayBatDau { get => _NgayBatDau; set => _NgayBatDau = value; }
      
    }
}

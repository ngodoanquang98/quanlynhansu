using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ThanNhan
    {
        private long _MaTN;
        private long _MaNV;
        private string _HoTen;
        private DateTime _NgaySinh;
        private string _SDT;
        public ThanNhan()
        {
            _MaTN = 0;
            _MaNV = 0;
            _HoTen = "";
            _NgaySinh = DateTime.Now;
            _SDT = "";
        }
        public ThanNhan(long ma, long manv, string ten, DateTime ns, string sdt)
        {
            _MaTN = ma;
            _MaNV = manv;
            _HoTen = ten;
            _NgaySinh = ns;
            _SDT = sdt;
        }

        public ThanNhan(DataRow r)
        {
            long.TryParse(r["MaTN"].ToString(), out _MaTN);
            long.TryParse(r["MaNV"].ToString(), out _MaNV);
            DateTime.TryParse(r["NgaySinh"].ToString(), out _NgaySinh);
            _HoTen = r["HoTen"].ToString();
            _SDT = r["SDT"].ToString();
        }
        public long MaTN { get => _MaTN; }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}

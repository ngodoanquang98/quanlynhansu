﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class PhongBan
    {
        private long _MaPB;
        private string _TenPB;
        private long _MaTP;
        private DateTime _NgayNhanChuc;
        private int _TongNV;
        public PhongBan()
        {
            _MaPB = 0;
            _TenPB = "";
            _NgayNhanChuc = DateTime.Now;
            _TongNV = 0;
        }
        public PhongBan(long ma, string ten)
        {
            _MaPB = ma;
            _TenPB = ten;
        }
        public PhongBan(DataRow r)
        {
            long.TryParse(r["MaPB"].ToString(), out _MaPB);
            _TenPB = r["TenPB"].ToString();
        }
        public long MaPB { get => _MaPB; }
        public string TenPB { get => _TenPB; set => _TenPB = value; }
        public long MaTP { get => _MaTP; set => _MaTP = value; }
        public DateTime NgayNhanChuc { get => _NgayNhanChuc; set => _NgayNhanChuc = value; }
        public int TongNV { get => _TongNV; set => _TongNV = value; }
    }
}

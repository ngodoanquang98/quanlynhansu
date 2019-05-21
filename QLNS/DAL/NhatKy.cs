using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class NhatKy
    {
        private long _MaNK;
        private DateTime _Ngay;
        private long _MaND;
        public NhatKy()
        {
            _MaNK = 0;
            _MaND = 0;
            _Ngay = DateTime.Now;
        }
        public NhatKy(long ma, long nd, DateTime ngay)
        {
            _MaNK = ma;
            _MaND = nd;
            _Ngay = ngay;
        }

        public NhatKy(DataRow r)
        {
            DateTime.TryParse(r["Ngay"].ToString(), out _Ngay);
            long.TryParse(r["MaND"].ToString(), out _MaND);
            long.TryParse(r["MaNK"].ToString(), out _MaNK);
        }
        public long MaNK { get => _MaNK; }
        public long MaND { get => _MaND; set => _MaND = value; }
        public DateTime Ngay { get => _Ngay; set => _Ngay = value; }
    }
}

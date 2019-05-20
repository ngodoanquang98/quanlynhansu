using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class ChamCong
    {
        private long _MaChamCong;
        private DateTime _Ngay;
        private int _MaCa;
        private long _MaNV;
        public ChamCong()
        {
            _MaChamCong = 0;
            _MaCa = 0;
            _Ngay = DateTime.Now;
            _MaNV = 0;
        }
        public ChamCong(long ma, DateTime ngay, int ca, long nv)
        {
            _MaChamCong = ma;
            _Ngay = ngay;
            _MaCa = ca;
            _MaNV = nv;
        }
        public ChamCong(DataRow r)
        {
            DateTime.TryParse(r["Ngay"].ToString(), out _Ngay);
            _MaCa = Convert.ToInt16(r["MaCa"]);
            long.TryParse(r["MaNV"].ToString(), out _MaNV);
            long.TryParse(r["MaChamCong"].ToString(), out _MaChamCong);

        }
        public long MaChamCong { get => _MaChamCong; }
        public DateTime Ngay { get => _Ngay; set => _Ngay = value; }
        public int MaCa { get => _MaCa; set => _MaCa = value; }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
    }
}

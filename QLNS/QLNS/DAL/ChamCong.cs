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
            long.TryParse(r["MaChamCong"].ToString(), out _MaChamCong);
            DateTime.TryParse(r["Ngay"].ToString(), out _Ngay);
            int.TryParse(r["MaCa"].ToString(), out _MaCa);
            long.TryParse(r["MaCa"].ToString(), out _MaNV);
        }
        public long MaChamCong { get => _MaChamCong; }
        public DateTime Ngay { get => _Ngay; set => _Ngay = value; }
        public int MaCa { get => _MaCa; set => _MaCa = value; }
        public long MaNV { get => _MaNV; set => _MaNV = value; }
    }
}

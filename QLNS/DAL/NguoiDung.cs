using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class NguoiDung
    {
        private double _MaND;
        private string _MatKhau;
        public NguoiDung()
        {
            _MaND = 0;
            _MatKhau = "";
        }
        public NguoiDung(double nd, string mk)
        {
            _MaND = nd;
            _MatKhau = mk;
        }
        public double MaND { get => _MaND; set => _MaND = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
    }
}

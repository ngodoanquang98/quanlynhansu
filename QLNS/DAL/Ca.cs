using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class Ca
    {
        private double _MaCa;
        private string _TenCa;
        public Ca()
        {
            _MaCa = 0;
            _TenCa = "";
        }
        public Ca(double ma, string ten)
        {
            _MaCa = ma;
            _TenCa = ten;
        }
        public double MaCa { get => _MaCa; }
        public string TenCa { get => _TenCa; set => _TenCa = value; }
    }
}

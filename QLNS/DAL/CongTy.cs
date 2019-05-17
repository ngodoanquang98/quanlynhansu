using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class CongTy
    {
        private string _TenCTy = "";
        private string _ChuTich = "";
        private string _HotLine = "";
        private string _DiaChi = "";
        public CongTy() { }
        public CongTy(string ten, string dc, string ct, string hot)
        {
            _TenCTy = ten;
            _ChuTich = ct;
            _HotLine = hot;
            _DiaChi = dc;
        }
        public string TenCty { get => _TenCTy; set => _TenCTy = value; }
        public string ChuTich { get => _ChuTich; set => _ChuTich = value; }
        public string HotLine { get => _HotLine; set => _HotLine = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
    }
}

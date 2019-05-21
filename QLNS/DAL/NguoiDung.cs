using QLNS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAL
{
    class NguoiDung
    {
        private static NguoiDung instance;
        private long _MaND;
        private string _MatKhau;
        public NguoiDung()
        {
            _MaND = 0;
            _MatKhau = "";
        }
        public NguoiDung(long nd, string mk)
        {
            _MaND = nd;
            _MatKhau = mk;
        }

        internal static NguoiDung Instance
        {
            get { if (instance == null) instance = new NguoiDung(); return instance; }
            private set { instance = value; }
        }

        public List<NguoiDung> LayDL()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NguoiDung");
            foreach (DataRow item in data.Rows)
            {
                NguoiDung nv = new NguoiDung(item);
                list.Add(nv);
            }
            return list;
        }

        public NguoiDung(DataRow r)
        {
            MaND = Convert.ToInt32(r["MaND"].ToString());
            _MatKhau = r["MatKhau"].ToString();
        }
        public long MaND { get => _MaND; set => _MaND = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
    }
}
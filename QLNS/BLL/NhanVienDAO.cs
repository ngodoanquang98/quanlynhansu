using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data;
using QLNS.DAL;
using QLNS.BLL;

namespace QLNS.BLL
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;
        SqlConnection conn = new SqlConnection();
        public NhanVienDAO()
        {

            string connString = @"Data Source=DESKTOP-34CKI58\HOAI;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        public List<NhanVien> LayDL()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhanVien");
            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }
        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public bool Insert(NhanVien nv, HopDong hd, ChiTietTT tt)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemNV @HoTen , @QueQuan , @NgaySinh , @email , @MaPB , @SDT , @CMT , @NgayBD , @MaLCB , @MaCV", new object[] { nv.HoTen, nv.QueQuan, nv.NgaySinh, nv.email, nv.MaPB, nv.SDT, nv.CMT, nv.NgayBatDau, nv.MaLCB, nv.MaCV });
            if (result > 0) return false;
            long a =Convert.ToInt32(DataProvider.Instance.ExecuteQuery("select top 1 MaNV from NhanVien orderby MaNV DESC").ToString());
            result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemHD @MaNV , @MaLHD", new object[] { a, hd.MaLHD });
            if (result > 0) return false;
            if (!UpdateTT(tt)) return false;
            return true;
        }

        public bool Update (NhanVien nv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec SuaNV @HoTen , @MaPB , @NgaySinh , @QueQuan , @email , @SDT , @CMT , @NgayBatDau , @MaNV , @MaLCB , @MaCV", new object[]{ nv.HoTen, nv.MaPB, nv.NgaySinh,
                nv.QueQuan, nv.email, nv.SDT, nv.CMT, nv.NgayBatDau, nv.MaNV,nv.MaLCB ,  nv.MaCV });
            return result > 0 ;
        }


        public bool UpdateTT(ChiTietTT ct)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemTT @MaNV , @MaTT  , @NgayBD", new object[] { ct.MaNV, ct.MaTT, ct.NgayBD });
            return result > 0;
        }

        public List<NhanVien> SearchKH(string str)
        {
            List<NhanVien> KHList = new List<NhanVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC TimNV @str",new object[] { str});
            foreach (DataRow item in data.Rows)
            {
                NhanVien KhachHang = new NhanVien(item);
                KHList.Add(KhachHang);
            }
            return KHList;
        }
    }
}

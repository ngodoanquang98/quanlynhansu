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
        public bool Insert(NhanVien nv)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemNV @HoTen , @QueQuan , @NgaySinh , @email , @MaPB , @SDT , @CMT , @NgayBD ", new object[] { nv.HoTen, nv.QueQuan, nv.NgaySinh, nv.email, nv.MaPB, nv.SDT, nv.CMT, nv.NgayBatDau });

            return result > 0;

        }
        public bool Update (NhanVien nv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec SuaNV @HoTen , @MaPB , @NgaySinh , @QueQuan , @email , @SDT , @CMT , @NgayBatDau , @MaNV ", new object[]{ nv.HoTen, nv.MaPB, nv.NgaySinh,
                nv.QueQuan, nv.email, nv.SDT, nv.CMT, nv.NgayBatDau, nv.MaNV });
           
            //result = DataProvider.Instance.ExecuteNonQuery("insert into ChiTietCV values ({0},{1},{2},{3}",new object[] { ct.MaCV, ct.MaNV, ct.MaPB, ct.NgayBD });
            //if (result <= 0) return false;
            return result > 0 ;
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

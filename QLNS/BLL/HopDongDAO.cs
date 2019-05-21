using QLNS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BLL
{
    class HopDongDAO
    {
        private static HopDongDAO instance;
        SqlConnection conn = new SqlConnection();
        public HopDongDAO()
        {

            string connString = @"Data Source=DESKTOP-34CKI58\HOAI;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        internal static HopDongDAO Instance
        {
            get { if (instance == null) instance = new HopDongDAO(); return instance; }
            private set { instance = value; }
        }
        public List<ChiTietLuong> TimKiemNgay(DateTime a)
        {
            ChiTietLuong nv = new ChiTietLuong();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC TimKiemLuongThang @ngay", new object[] { a });
            List<ChiTietLuong> list = new List<ChiTietLuong>();
            foreach (DataRow d in data.Rows)
            {
                ChiTietLuong nk = new ChiTietLuong(d);
                list.Add(nk);
            }
            return list;
        }

        //    public bool Insert(HopDong cc)
        //    {
        //        int result;

        //        HopDong nv = new HopDong();
        //            result = DataProvider.Instance.ExecuteNonQuery("EXEC Them ", new object[] { cc.TenCty, cc.DiaChi, cc.ChuTich, cc.HotLine });

        //        return result > 0;
        //    }
    }
}

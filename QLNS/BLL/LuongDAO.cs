using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DAL;

namespace QLNS.BLL
{
    class LuongDAO
    {
        private static LuongDAO instance;
        SqlConnection conn = new SqlConnection();
        public LuongDAO()
        {

            string connString = @"Data Source=QUANG\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        public bool TaoDL()
        {
            List<ChiTietLuong> list = new List<ChiTietLuong>();
            int r = DataProvider.Instance.ExecuteNonQuery("EXEC LayLuong");
            return r > 0;
        }
        internal static LuongDAO Instance
        {
            get { if (instance == null) instance = new LuongDAO(); return instance; }
            private set { instance = value; }
        }
        public List<ChiTietLuong> TimKiemMa(long a)
        {
            ChiTietLuong nv = new ChiTietLuong();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC TimKiemLuongMa @ma", new object[] { a });
            List<ChiTietLuong> list = new List<ChiTietLuong>();
            foreach (DataRow d in data.Rows)
            {
                ChiTietLuong nk = new ChiTietLuong(d);
                list.Add(nk);
            }
            return list;
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
    }
}

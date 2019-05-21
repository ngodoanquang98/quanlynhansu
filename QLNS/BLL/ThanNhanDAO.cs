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
    class ThanNhanDAO
    {
        private static ThanNhanDAO instance;
        SqlConnection conn = new SqlConnection();
        public ThanNhanDAO()
        {

            string connString = @"Data Source=DESKTOP-34CKI58\HOAI;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        internal static ThanNhanDAO Instance
        {
            get { if (instance == null) instance = new ThanNhanDAO(); return instance; }
            private set { instance = value; }
        }

        public List<ThanNhan> LayDS()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from thannhan");
            List<ThanNhan> list = new List<ThanNhan>();
            foreach (DataRow d in data.Rows)
            {
                ThanNhan nk = new ThanNhan(d);
                list.Add(nk);
            }
            return list;
        }

        public List<ThanNhan> TimTN(long a)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC TimTN @MaNV", new object[] { a});
            List<ThanNhan> list = new List<ThanNhan>();
            foreach (DataRow d in data.Rows)
            {
                ThanNhan nk = new ThanNhan(d);
                list.Add(nk);
            }
            return list;
        }
        public static bool Insert(ThanNhan cc)
        {
            int result;

            ThanNhan nv = new ThanNhan();
            result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemTN @MaNV , @HoTen , @NgaySinh , @SDT", new object[] { cc.MaNV, cc.HoTen, cc.NgaySinh, cc.SDT });

            return result > 0;
        }
        public static bool Update(ThanNhan cc)
        {
            int result;

            ThanNhan nv = new ThanNhan();
            result = DataProvider.Instance.ExecuteNonQuery("EXEC SuaTN @MaNV , @HoTen , @NgaySinh , @SDT , @MaTN", new object[] { cc.MaNV, cc.HoTen, cc.NgaySinh, cc.SDT,cc.MaTN });

            return result > 0;
        }
    }
}

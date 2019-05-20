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
    class ChamCongDAO
    {
        private static ChamCongDAO instance;
        SqlConnection conn = new SqlConnection();
        public ChamCongDAO()
        {

            string connString = @"Data Source=DESKTOP-34CKI58\HOAI;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        public List<ChamCong> LayDL()
        {
            List<ChamCong> list = new List<ChamCong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ChamCong");
            foreach (DataRow item in data.Rows)
            {
                ChamCong nv = new ChamCong(item);
                list.Add(nv);
            }
            return list;
        }
        internal static ChamCongDAO Instance
        {
            get { if (instance == null) instance = new ChamCongDAO(); return instance; }
            private set { instance = value; }
        }
        public bool Insert(ChamCong cc)
        {
            bool a;
            bool.TryParse(cc.MaCa.ToString(), out a);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemChamCong @Ngay ,  @MaNV , @MaCa ", new object[] { cc.Ngay, cc.MaNV , a });

            return result > 0;

        }

        public List<ChamCong> LayDL(DateTime d)
        {
            List<ChamCong> list = new List<ChamCong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC DSChamCong @Ngay",new object[] { d});
            foreach (DataRow item in data.Rows)
            {
                ChamCong nv = new ChamCong(item);
                list.Add(nv);
            }
            return list;
        }
    }
}

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
    class NhatKyDAO
    {
        private static NhatKyDAO instance;
        SqlConnection conn = new SqlConnection();
        public NhatKyDAO()
        {

            string connString = @"Data Source=QUANG\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        public List<NhatKy> LayDL()
        {
            List<NhatKy> list = new List<NhatKy>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhatKy");
            foreach (DataRow item in data.Rows)
            {
                NhatKy nv = new NhatKy(item);
                list.Add(nv);
            }
            return list;
        }
        internal static NhatKyDAO Instance
        {
            get { if (instance == null) instance = new NhatKyDAO(); return instance; }
            private set { instance = value; }
        }
        public bool Insert(long c)
        {
            int result;
            NhatKy nv = new NhatKy();
            result = DataProvider.Instance.ExecuteNonQuery("exec ThemNK @Ma ", new object[] { c });
            return result > 0;
        }
        public List<NhatKy> TimKiemMa(long a)
        {
            NhatKy nv = new NhatKy();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC TimNKMa @ma",new object[] { a});
            List<NhatKy> list = new List<NhatKy>();
            foreach(DataRow d in data.Rows){
                NhatKy nk = new NhatKy(d);
                list.Add(nk);
            }
            return list;
        }
        public List<NhatKy> TimKiemNgay(DateTime a)
        {
            NhatKy nv = new NhatKy();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC TimNKNgay @ngay", new object[] { a });
            List<NhatKy> list = new List<NhatKy>();
            foreach (DataRow d in data.Rows)
            {
                NhatKy nk = new NhatKy(d);
                list.Add(nk);
            }
            return list;
        }
    }
}

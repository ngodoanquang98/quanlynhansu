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
    class PhongBanDAO
    {
        private static PhongBanDAO instance;
        SqlConnection conn = new SqlConnection();
        public PhongBanDAO()
        {

            string connString = @"Data Source=QUANG\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        internal static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            private set { instance = value; }
        }

        public List<PhongBan> LayDS()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select* from PhongBan");
            List<PhongBan> list = new List<PhongBan>();
            foreach (DataRow d in data.Rows)
            {
                PhongBan nk = new PhongBan(d);
                list.Add(nk);
            }
            return list;
        }

        public bool Insert(string TenPB)
        {
            int result;

            PhongBan nv = new PhongBan();
            result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemPB @TenPB", new object[] { TenPB });

            return result > 0;
        }
        public bool Update(PhongBan cc)
        {
            int result;

            PhongBan nv = new PhongBan();
            result = DataProvider.Instance.ExecuteNonQuery("EXEC SuaPB @TenPB , @MaPB", new object[] { cc.TenPB, cc.MaPB});

            return result > 0;
        }
    }
}

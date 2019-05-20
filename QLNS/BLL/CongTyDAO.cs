﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DAL;
using System.Data.SqlClient;
using System.Data;

namespace QLNS.BLL
{
    class CongTyDAO
    {
        private static CongTyDAO instance;
        SqlConnection conn = new SqlConnection();
        public CongTyDAO()
        {

            string connString = @"Data Source=DESKTOP-34CKI58\HOAI;Initial Catalog=QLNS;Integrated Security=True";

            conn.ConnectionString = connString;
            conn.Open();
        }
        public CongTy LayDL()
        {
            CongTy nv = new CongTy();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from CongTy");
            foreach (DataRow item in data.Rows)
            {
                nv.TenCty = item["TenCTy"].ToString();
                nv.DiaChi = item["DiaChi"].ToString();
                nv.ChuTich = item["ChuTich"].ToString();
                nv.HotLine = item["HotLine"].ToString();
            }
            return nv;
        }
        internal static CongTyDAO Instance
        {
            get { if (instance == null) instance = new CongTyDAO(); return instance; }
            private set { instance = value; }
        }
        public bool Insert(CongTy cc)
        {
            int result;
            
                CongTy nv = new CongTy();
                DataTable data = DataProvider.Instance.ExecuteQuery("select * from CongTy");
            if(data.Rows.Count <= 0)
                result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemCTy @TenCTy ,  @DiaChi , @ChuTich, @HotLine ", new object[] { cc.TenCty, cc.DiaChi, cc.ChuTich, cc.HotLine });
            else result = DataProvider.Instance.ExecuteNonQuery("EXEC ThemCTy @TenCTy ,  @DiaChi , @ChuTich, @HotLine ", new object[] { cc.TenCty, cc.DiaChi, cc.ChuTich, cc.HotLine });
            return result > 0;
        }
    
    }
}

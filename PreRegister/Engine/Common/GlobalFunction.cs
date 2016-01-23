using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Engine.Common
{
    public class GlobalFunction
    {
        public static string GetCfSysconfig(string ConfigName) {
            string ret = "";
            try {
                string sql = "select config_value ";
                sql += " from cf_sysconfig ";
                sql += " where config_name ='" + ConfigName + "'";

                DataTable dt = Linq.Common.Utilities.SqlDB.ExecuteTable(sql);
                if (dt.Rows.Count > 0) {
                    ret = dt.Rows[0]["config_value"].ToString();
                }
                dt.Dispose();
            }
            catch (Exception ex) {
                ret = "";
            }

            return ret;
        }
    }
}

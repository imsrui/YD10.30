using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlHelper<T> where T : class, new()
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        public static int ExecuteNonQuery(string sql, T model)
        {
            using (IDbConnection con = new SqlConnection(constr))
            {

                return con.Execute(sql, model);
            }

        }
        public static IList<T> Query(string sql, T model)
        {
            using (IDbConnection con = new SqlConnection(constr))
            {
                return con.Query<T>(sql, model).ToList();
            }
        }
    }
}

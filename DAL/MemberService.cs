using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
  public  class MemberService
    {
        public DataTable GetAllMembers()
        {
            StringBuilder sbsql = new StringBuilder();
            sbsql.Append("Select  ");
            sbsql.Append("* ");
            sbsql.Append("From tb_Member  ");
            sbsql.Append("Where  tb_Member.DeleteFlag='0'");
            DataSet ds = new DataSet();             //创建DataSet对象
            SqlConnection con = null;               //创建数据库连接
            try
            {
                string ConnectionString = "Data Source=(local);DataBase=StudentClubMis;Trusted_Connection=SSPI"; //windows身份验证 
                // Data Source=(local);DataBase=StudentClubMis;User ID=(sql 用户名);pwd=(sql 密码);     sql server 身份验证
                con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(sbsql.ToString(), con);     //创建命令对象
                SqlDataAdapter da = new SqlDataAdapter();           //创建DataAdapter对象
                da.SelectCommand = cmd;                             //指定命令对象从数据存储区检索行
                da.Fill(ds, "Members");                             //填充ds对象即 DataSet 对象
                if (ds.Tables["Members"].Rows.Count > 0)            //如果DataSet存储区数据行数（Rows）大于0行
                {
                    return ds.Tables["Members"];                    //返回数据类型    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return null;
        }

    }
}

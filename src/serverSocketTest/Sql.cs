using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConnectControl
{
    public class Sql                                                                                        //一个SQL控制类
    {
        public String dbname = null;                                                                        //数据库名
        public String dbtable = null;                                                                       //数据将存入的表名
        public String dbsa = null;                                                                          //数据库账户名（mysql默认为root，sqlserver默认为sa）
        public String dbpassword = null;                                                                    //数据库密码

        public System.Windows.Forms.TextBox tB_sql_result = null;                                           //sql消息显示控件

        public MySqlConnection sqlcon = null;                                                               //连接数据库所开启的连接

        //构造函数，传入参数依次为数据库名、存储表名、数据库账户名、数据库密码、sql消息显示控件
        public Sql(String dbname, String dbtable, String dbsa, String dbpassword, System.Windows.Forms.TextBox tB_sql_result) 
        {
            this.dbname = dbname;
            this.dbtable = dbtable;
            this.dbsa = dbsa;
            this.dbpassword = dbpassword;

            this.tB_sql_result = tB_sql_result;

            //配置一个数据库连接串，包含Data Source、port、Database、User Id、Password、CharSet
            String sqlconnectinformation = String.Format("Data Source=localhost;port=3306;Database={0};User Id={1};Password={2};CharSet=utf8", dbname, dbsa, dbpassword);
            sqlcon = new MySqlConnection(sqlconnectinformation);                                            //建立一个与数据库的连接
            sqlcon.Open();                                                                                  //开启此连接
        }

        public void sqlinsert(String message, String dbtable, String clientinformation)                     //向数据库增加信息函数
        {
            //配置一个SQL命令，{1}：序号，设置为当前表长，{2}：数据发送方的ip，{3}：当前时间，{4}：接收到的数据
            String sqlTMP = String.Format("insert into {0} values ('{1}','{2}','{3}','{4}')", dbtable, tablelength(dbtable), clientinformation, DateTime.Now.ToLocalTime().ToString(), message);
            MySqlCommand cmdTmp = new MySqlCommand(sqlTMP, sqlcon);                                         //建立一个命令
            cmdTmp.ExecuteNonQuery();                                                                       //执行此命令并返回受影响行数
        }

        private void sqldelete()                                                                            //向数据库删除信息函数（未启用）
        {
            //"delete from {0} where {1}={2}",table, row, container
        }

        private void sqlupdata()                                                                            //向数据库更新信息函数（未启用）
        {
            //"update {0} set {1}={2} where {3}= {4}",table, row, container, row, container
        }

        public void sqlsearch(String dbtable)                                                               //向数据库查询信息函数（用来测试）
        {
            String sqlTMP = String.Format("select * from {0}", dbtable);                                    //配置一个SQL命令
            MySqlCommand cmdTmp = new MySqlCommand(sqlTMP, sqlcon);                                         //建立一个命令
            MySqlDataReader data = cmdTmp.ExecuteReader();                                                  //执行此命令并返回查询到的数据至一个数据缓冲区
            try
            {
                while (data.Read())
                {
                    if (data.HasRows)
                    {
                        tB_sql_result.AppendText("客户端IP:" + data.GetString(1) + "|\n接收时间:" + data.GetString(2) + "|\n接收内容:" + data.GetString(3) + "\n");
                    }
                }//将数据全部显示在sql消息控件中
            }
            catch (Exception)
            {
                tB_sql_result.AppendText("查询失败！\n");
            }
            finally
            {
                data.Close();                                                                               //关闭数据缓冲区
            }
        }

        private int tablelength(String dbtable)                                                             //查询当前表长函数
        {
            int length = -1;
            try 
            {
                
                String sqlTMP = String.Format("select count(*) from {0}", dbtable);                         //配置一个SQL命令（会返回表行数）
                MySqlCommand cmdTmp = new MySqlCommand(sqlTMP, sqlcon);                                     //建立一个命令
                length = Convert.ToInt32(cmdTmp.ExecuteScalar());                                           //执行命令并返回第一个元素值（即表行数）
 
            }catch(Exception)
            {
                tB_sql_result.AppendText("返回表行个数异常……\n"+length+"\n");
            }
            return length;
        }


        public void sqlclose()                                                                              //关闭与数据库的连接
        {
            sqlcon.Close();
        }
    }
}


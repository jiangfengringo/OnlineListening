using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ConnectControl
{
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//不检查线程间非法操作
        }


        //调试环境的相关配置
        public String dbname = "graduatedata";
        public String dbtable = "iptimevalue";
        public String dbsa = "root";
        public String dbpassword = "12345679";
        public IPAddress ip = IPAddress.Parse("127.0.0.1");
        public int port = 8008;
        public String returnmessage = "this is ringohu's program";

        //两个公共对象，用于类间调用，其中From_home会调用Tcp和Sql，Tcp会调用Sql
        public Tcp tcptmp = null;
        public Sql sqltmp = null;

        private void btn_home_db_test_Click(object sender, EventArgs e)//点击“测试连接”则会新建一个Sql
        {
            try 
            {
                sqltmp = new Sql(dbname, dbtable, dbsa, dbpassword, tB_sql_result);
                lbl_home_2.Text = "开启";
                btn_home_db_test.Enabled = false;
                btn_home_db_close.Enabled = true;
            }
            catch (Exception) 
            {
                lbl_home_2.Text = "开启失败";
            }
            
        }

        private void btn_home_db_close_Click(object sender, EventArgs e)//点击“关闭连接”会关闭与数据库的连接
        {
            try 
            {
                sqltmp.sqlclose();
                lbl_home_2.Text = "关闭";
                btn_home_db_test.Enabled = true;
                btn_home_db_close.Enabled = false;
            }
            catch(Exception)
            {
                lbl_home_2.Text = "关闭失败";
            }
        }

        private void btn_home_sc_open_Click(object sender, EventArgs e)//点击“开启侦听”会开始接收客户端的连接
        {
            try 
            {
                tcptmp = new Tcp(ip, port, returnmessage, tB_tcp_receive, sqltmp);
                lbl_home_4.Text = "开启";
                btn_home_sc_open.Enabled = false;
                btn_home_sc_close.Enabled = true;
            }
            catch(Exception)
            {
                lbl_home_4.Text = "开启失败";
            }

        }

        private void btn_home_sc_close_Click(object sender, EventArgs e)//点击“关闭侦听”则会关闭对TCP的连接
        {
            try 
            {
                tcptmp.closeserver();
                btn_home_sc_open.Enabled = true;
                btn_home_sc_close.Enabled = false;
                lbl_home_4.Text = "关闭";
            }
            catch(Exception)
            {
                lbl_home_4.Text = "关闭失败";
            }

        }

        private void btn_tcp_check_Click(object sender, EventArgs e)
        {
            if (returnmessage != null)
                tB_tcp_send.Text = returnmessage;
            else
                tB_tcp_send.Text = "错误：未设置回传数据";
        }

        private void btn_tcp_select_Click(object sender, EventArgs e)
        {
            if (tB_tcp_send != null)
            {
                returnmessage = tB_tcp_send.Text;
                tB_tcp_send.Text = null;
            }
            else 
            {
                tB_tcp_send.Text = "错误：回传数据不能为空";
            }
            
        }

        private void btn_ifmt_clearall_Click(object sender, EventArgs e)
        {
            dbsa = null;
            dbpassword = null;
            ip = null;
            port = 0;
            returnmessage = null;
            tB_ifmt_db_sa.Text = null;
            tB_ifmt_db_password.Text = null;
            tB_ifmt_sc_ipaddress.Text = null;
            tB_ifmt_sc_port.Text = null;
            btn_ifmt_clearall.Enabled = false;
        }

        private void btn_ifmt_selectall_Click(object sender, EventArgs e)
        {
            btn_ifmt_clearall.Enabled = true;
            if (tB_ifmt_db_sa.Text != null)
            {
                dbsa = tB_ifmt_db_sa.Text;
                tB_ifmt_db_sa.Text = "******";
            }
            if (tB_ifmt_db_password.Text != null)
            {
                dbpassword = tB_ifmt_db_password.Text;
                tB_ifmt_db_password.Text = "******";
            }
            if (tB_ifmt_sc_ipaddress.Text != null)
            {
                ip = IPAddress.Parse(tB_ifmt_sc_ipaddress.Text);
                tB_ifmt_sc_ipaddress.Text = "******";
            }
            if (tB_ifmt_sc_port.Text != null)
            {
                port = Convert.ToInt32(tB_ifmt_sc_port.Text);
                tB_ifmt_sc_port.Text = "******";
            }
        }

        private void btn_sql_quary_Click(object sender, EventArgs e)
        {
            try 
            {
                sqltmp.sqlsearch(dbtable);
                tB_sql_dbname.Text = sqltmp.dbname;
                tB_sql_table.Text = sqltmp.dbtable;
            }
            catch(Exception)
            {
                tB_sql_result.AppendText("连接数据库操作错误……\n");
            }
        }

        private void btn_sql_select_Click(object sender, EventArgs e)
        {
            if (tB_sql_dbname.Text != null && tB_sql_table.Text != null)
            {
                dbname = tB_sql_dbname.Text;
                dbtable = tB_sql_table.Text;
                tB_sql_dbname.Text = null;
                tB_sql_table.Text = null;
            }
            else 
            {
                tB_sql_result.AppendText("错误：数据库名和表名不能为空\n");
            }

        }


    }
}

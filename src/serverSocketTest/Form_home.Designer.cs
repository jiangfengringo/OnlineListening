namespace ConnectControl
{
    partial class Form_home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_home));
            this.tC_main = new System.Windows.Forms.TabControl();
            this.tp_home = new System.Windows.Forms.TabPage();
            this.lbl_home_4 = new System.Windows.Forms.Label();
            this.btn_home_sc_close = new System.Windows.Forms.Button();
            this.btn_home_sc_open = new System.Windows.Forms.Button();
            this.btn_home_db_close = new System.Windows.Forms.Button();
            this.lbl_home_3 = new System.Windows.Forms.Label();
            this.lbl_home_2 = new System.Windows.Forms.Label();
            this.btn_home_db_test = new System.Windows.Forms.Button();
            this.lbl_home_1 = new System.Windows.Forms.Label();
            this.tP_tcp = new System.Windows.Forms.TabPage();
            this.btn_tcp_select = new System.Windows.Forms.Button();
            this.btn_tcp_check = new System.Windows.Forms.Button();
            this.tB_tcp_send = new System.Windows.Forms.TextBox();
            this.lbl_tcp_2 = new System.Windows.Forms.Label();
            this.tB_tcp_receive = new System.Windows.Forms.TextBox();
            this.lbl_tcp_1 = new System.Windows.Forms.Label();
            this.tP_mysql = new System.Windows.Forms.TabPage();
            this.tB_sql_result = new System.Windows.Forms.TextBox();
            this.lbl_sql_3 = new System.Windows.Forms.Label();
            this.btn_sql_select = new System.Windows.Forms.Button();
            this.tB_sql_table = new System.Windows.Forms.TextBox();
            this.lbl_sql_2 = new System.Windows.Forms.Label();
            this.btn_sql_quary = new System.Windows.Forms.Button();
            this.tB_sql_dbname = new System.Windows.Forms.TextBox();
            this.lbl_sql_1 = new System.Windows.Forms.Label();
            this.tP_information = new System.Windows.Forms.TabPage();
            this.btn_ifmt_selectall = new System.Windows.Forms.Button();
            this.btn_ifmt_clearall = new System.Windows.Forms.Button();
            this.tB_ifmt_sc_port = new System.Windows.Forms.TextBox();
            this.lbl_ifmt_4 = new System.Windows.Forms.Label();
            this.tB_ifmt_sc_ipaddress = new System.Windows.Forms.TextBox();
            this.lbl_ifmt_3 = new System.Windows.Forms.Label();
            this.tB_ifmt_db_password = new System.Windows.Forms.TextBox();
            this.lbl_ifmt_2 = new System.Windows.Forms.Label();
            this.tB_ifmt_db_sa = new System.Windows.Forms.TextBox();
            this.lbl_ifmt_1 = new System.Windows.Forms.Label();
            this.tC_main.SuspendLayout();
            this.tp_home.SuspendLayout();
            this.tP_tcp.SuspendLayout();
            this.tP_mysql.SuspendLayout();
            this.tP_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // tC_main
            // 
            this.tC_main.Controls.Add(this.tp_home);
            this.tC_main.Controls.Add(this.tP_tcp);
            this.tC_main.Controls.Add(this.tP_mysql);
            this.tC_main.Controls.Add(this.tP_information);
            this.tC_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tC_main.Location = new System.Drawing.Point(0, 0);
            this.tC_main.Name = "tC_main";
            this.tC_main.SelectedIndex = 0;
            this.tC_main.Size = new System.Drawing.Size(292, 273);
            this.tC_main.TabIndex = 0;
            // 
            // tp_home
            // 
            this.tp_home.Controls.Add(this.lbl_home_4);
            this.tp_home.Controls.Add(this.btn_home_sc_close);
            this.tp_home.Controls.Add(this.btn_home_sc_open);
            this.tp_home.Controls.Add(this.btn_home_db_close);
            this.tp_home.Controls.Add(this.lbl_home_3);
            this.tp_home.Controls.Add(this.lbl_home_2);
            this.tp_home.Controls.Add(this.btn_home_db_test);
            this.tp_home.Controls.Add(this.lbl_home_1);
            this.tp_home.Location = new System.Drawing.Point(4, 22);
            this.tp_home.Name = "tp_home";
            this.tp_home.Padding = new System.Windows.Forms.Padding(3);
            this.tp_home.Size = new System.Drawing.Size(284, 247);
            this.tp_home.TabIndex = 0;
            this.tp_home.Text = "主页";
            this.tp_home.UseVisualStyleBackColor = true;
            // 
            // lbl_home_4
            // 
            this.lbl_home_4.AutoSize = true;
            this.lbl_home_4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_home_4.Location = new System.Drawing.Point(186, 133);
            this.lbl_home_4.Name = "lbl_home_4";
            this.lbl_home_4.Size = new System.Drawing.Size(58, 24);
            this.lbl_home_4.TabIndex = 13;
            this.lbl_home_4.Text = "未知";
            // 
            // btn_home_sc_close
            // 
            this.btn_home_sc_close.Enabled = false;
            this.btn_home_sc_close.Location = new System.Drawing.Point(152, 203);
            this.btn_home_sc_close.Name = "btn_home_sc_close";
            this.btn_home_sc_close.Size = new System.Drawing.Size(123, 23);
            this.btn_home_sc_close.TabIndex = 12;
            this.btn_home_sc_close.Text = "关闭侦听";
            this.btn_home_sc_close.UseVisualStyleBackColor = true;
            this.btn_home_sc_close.Click += new System.EventHandler(this.btn_home_sc_close_Click);
            // 
            // btn_home_sc_open
            // 
            this.btn_home_sc_open.Location = new System.Drawing.Point(13, 203);
            this.btn_home_sc_open.Name = "btn_home_sc_open";
            this.btn_home_sc_open.Size = new System.Drawing.Size(123, 23);
            this.btn_home_sc_open.TabIndex = 11;
            this.btn_home_sc_open.Text = "开启侦听";
            this.btn_home_sc_open.UseVisualStyleBackColor = true;
            this.btn_home_sc_open.Click += new System.EventHandler(this.btn_home_sc_open_Click);
            // 
            // btn_home_db_close
            // 
            this.btn_home_db_close.Enabled = false;
            this.btn_home_db_close.Location = new System.Drawing.Point(152, 73);
            this.btn_home_db_close.Name = "btn_home_db_close";
            this.btn_home_db_close.Size = new System.Drawing.Size(123, 23);
            this.btn_home_db_close.TabIndex = 10;
            this.btn_home_db_close.Text = "关闭连接";
            this.btn_home_db_close.UseVisualStyleBackColor = true;
            this.btn_home_db_close.Click += new System.EventHandler(this.btn_home_db_close_Click);
            // 
            // lbl_home_3
            // 
            this.lbl_home_3.AutoSize = true;
            this.lbl_home_3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_home_3.Location = new System.Drawing.Point(9, 133);
            this.lbl_home_3.Name = "lbl_home_3";
            this.lbl_home_3.Size = new System.Drawing.Size(166, 24);
            this.lbl_home_3.TabIndex = 9;
            this.lbl_home_3.Text = "通讯侦听状态:";
            // 
            // lbl_home_2
            // 
            this.lbl_home_2.AutoSize = true;
            this.lbl_home_2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_home_2.Location = new System.Drawing.Point(186, 7);
            this.lbl_home_2.Name = "lbl_home_2";
            this.lbl_home_2.Size = new System.Drawing.Size(58, 24);
            this.lbl_home_2.TabIndex = 8;
            this.lbl_home_2.Text = "未知";
            // 
            // btn_home_db_test
            // 
            this.btn_home_db_test.Location = new System.Drawing.Point(13, 73);
            this.btn_home_db_test.Name = "btn_home_db_test";
            this.btn_home_db_test.Size = new System.Drawing.Size(123, 23);
            this.btn_home_db_test.TabIndex = 2;
            this.btn_home_db_test.Text = "测试连接";
            this.btn_home_db_test.UseVisualStyleBackColor = true;
            this.btn_home_db_test.Click += new System.EventHandler(this.btn_home_db_test_Click);
            // 
            // lbl_home_1
            // 
            this.lbl_home_1.AutoSize = true;
            this.lbl_home_1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_home_1.Location = new System.Drawing.Point(9, 7);
            this.lbl_home_1.Name = "lbl_home_1";
            this.lbl_home_1.Size = new System.Drawing.Size(142, 24);
            this.lbl_home_1.TabIndex = 0;
            this.lbl_home_1.Text = "数据库状态:";
            // 
            // tP_tcp
            // 
            this.tP_tcp.Controls.Add(this.btn_tcp_select);
            this.tP_tcp.Controls.Add(this.btn_tcp_check);
            this.tP_tcp.Controls.Add(this.tB_tcp_send);
            this.tP_tcp.Controls.Add(this.lbl_tcp_2);
            this.tP_tcp.Controls.Add(this.tB_tcp_receive);
            this.tP_tcp.Controls.Add(this.lbl_tcp_1);
            this.tP_tcp.Location = new System.Drawing.Point(4, 22);
            this.tP_tcp.Name = "tP_tcp";
            this.tP_tcp.Padding = new System.Windows.Forms.Padding(3);
            this.tP_tcp.Size = new System.Drawing.Size(284, 247);
            this.tP_tcp.TabIndex = 1;
            this.tP_tcp.Text = "TCP控制操作";
            this.tP_tcp.UseVisualStyleBackColor = true;
            // 
            // btn_tcp_select
            // 
            this.btn_tcp_select.Location = new System.Drawing.Point(151, 216);
            this.btn_tcp_select.Name = "btn_tcp_select";
            this.btn_tcp_select.Size = new System.Drawing.Size(125, 23);
            this.btn_tcp_select.TabIndex = 5;
            this.btn_tcp_select.Text = "设置回传数据";
            this.btn_tcp_select.UseVisualStyleBackColor = true;
            this.btn_tcp_select.Click += new System.EventHandler(this.btn_tcp_select_Click);
            // 
            // btn_tcp_check
            // 
            this.btn_tcp_check.Location = new System.Drawing.Point(11, 216);
            this.btn_tcp_check.Name = "btn_tcp_check";
            this.btn_tcp_check.Size = new System.Drawing.Size(125, 23);
            this.btn_tcp_check.TabIndex = 4;
            this.btn_tcp_check.Text = "查看回传数据";
            this.btn_tcp_check.UseVisualStyleBackColor = true;
            this.btn_tcp_check.Click += new System.EventHandler(this.btn_tcp_check_Click);
            // 
            // tB_tcp_send
            // 
            this.tB_tcp_send.Location = new System.Drawing.Point(11, 189);
            this.tB_tcp_send.Name = "tB_tcp_send";
            this.tB_tcp_send.Size = new System.Drawing.Size(265, 21);
            this.tB_tcp_send.TabIndex = 3;
            // 
            // lbl_tcp_2
            // 
            this.lbl_tcp_2.AutoSize = true;
            this.lbl_tcp_2.Location = new System.Drawing.Point(9, 174);
            this.lbl_tcp_2.Name = "lbl_tcp_2";
            this.lbl_tcp_2.Size = new System.Drawing.Size(83, 12);
            this.lbl_tcp_2.TabIndex = 2;
            this.lbl_tcp_2.Text = "自动回传数据:";
            // 
            // tB_tcp_receive
            // 
            this.tB_tcp_receive.Location = new System.Drawing.Point(11, 23);
            this.tB_tcp_receive.Multiline = true;
            this.tB_tcp_receive.Name = "tB_tcp_receive";
            this.tB_tcp_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_tcp_receive.Size = new System.Drawing.Size(265, 148);
            this.tB_tcp_receive.TabIndex = 1;
            // 
            // lbl_tcp_1
            // 
            this.lbl_tcp_1.AutoSize = true;
            this.lbl_tcp_1.Location = new System.Drawing.Point(9, 7);
            this.lbl_tcp_1.Name = "lbl_tcp_1";
            this.lbl_tcp_1.Size = new System.Drawing.Size(95, 12);
            this.lbl_tcp_1.TabIndex = 0;
            this.lbl_tcp_1.Text = "已接受到的数据:";
            // 
            // tP_mysql
            // 
            this.tP_mysql.Controls.Add(this.tB_sql_result);
            this.tP_mysql.Controls.Add(this.lbl_sql_3);
            this.tP_mysql.Controls.Add(this.btn_sql_select);
            this.tP_mysql.Controls.Add(this.tB_sql_table);
            this.tP_mysql.Controls.Add(this.lbl_sql_2);
            this.tP_mysql.Controls.Add(this.btn_sql_quary);
            this.tP_mysql.Controls.Add(this.tB_sql_dbname);
            this.tP_mysql.Controls.Add(this.lbl_sql_1);
            this.tP_mysql.Location = new System.Drawing.Point(4, 22);
            this.tP_mysql.Name = "tP_mysql";
            this.tP_mysql.Padding = new System.Windows.Forms.Padding(3);
            this.tP_mysql.Size = new System.Drawing.Size(284, 247);
            this.tP_mysql.TabIndex = 2;
            this.tP_mysql.Text = "MYSQL控制操作";
            this.tP_mysql.UseVisualStyleBackColor = true;
            // 
            // tB_sql_result
            // 
            this.tB_sql_result.Location = new System.Drawing.Point(11, 102);
            this.tB_sql_result.Multiline = true;
            this.tB_sql_result.Name = "tB_sql_result";
            this.tB_sql_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_sql_result.Size = new System.Drawing.Size(265, 139);
            this.tB_sql_result.TabIndex = 7;
            // 
            // lbl_sql_3
            // 
            this.lbl_sql_3.AutoSize = true;
            this.lbl_sql_3.Location = new System.Drawing.Point(9, 86);
            this.lbl_sql_3.Name = "lbl_sql_3";
            this.lbl_sql_3.Size = new System.Drawing.Size(59, 12);
            this.lbl_sql_3.TabIndex = 6;
            this.lbl_sql_3.Text = "返回结果:";
            // 
            // btn_sql_select
            // 
            this.btn_sql_select.Location = new System.Drawing.Point(201, 60);
            this.btn_sql_select.Name = "btn_sql_select";
            this.btn_sql_select.Size = new System.Drawing.Size(75, 23);
            this.btn_sql_select.TabIndex = 5;
            this.btn_sql_select.Text = "设置路径";
            this.btn_sql_select.UseVisualStyleBackColor = true;
            this.btn_sql_select.Click += new System.EventHandler(this.btn_sql_select_Click);
            // 
            // tB_sql_table
            // 
            this.tB_sql_table.Location = new System.Drawing.Point(11, 62);
            this.tB_sql_table.Name = "tB_sql_table";
            this.tB_sql_table.Size = new System.Drawing.Size(184, 21);
            this.tB_sql_table.TabIndex = 4;
            // 
            // lbl_sql_2
            // 
            this.lbl_sql_2.AutoSize = true;
            this.lbl_sql_2.Location = new System.Drawing.Point(9, 47);
            this.lbl_sql_2.Name = "lbl_sql_2";
            this.lbl_sql_2.Size = new System.Drawing.Size(35, 12);
            this.lbl_sql_2.TabIndex = 3;
            this.lbl_sql_2.Text = "表名:";
            // 
            // btn_sql_quary
            // 
            this.btn_sql_quary.Location = new System.Drawing.Point(201, 20);
            this.btn_sql_quary.Name = "btn_sql_quary";
            this.btn_sql_quary.Size = new System.Drawing.Size(75, 23);
            this.btn_sql_quary.TabIndex = 2;
            this.btn_sql_quary.Text = "测试连接";
            this.btn_sql_quary.UseVisualStyleBackColor = true;
            this.btn_sql_quary.Click += new System.EventHandler(this.btn_sql_quary_Click);
            // 
            // tB_sql_dbname
            // 
            this.tB_sql_dbname.Location = new System.Drawing.Point(11, 23);
            this.tB_sql_dbname.Name = "tB_sql_dbname";
            this.tB_sql_dbname.Size = new System.Drawing.Size(184, 21);
            this.tB_sql_dbname.TabIndex = 1;
            // 
            // lbl_sql_1
            // 
            this.lbl_sql_1.AutoSize = true;
            this.lbl_sql_1.Location = new System.Drawing.Point(9, 7);
            this.lbl_sql_1.Name = "lbl_sql_1";
            this.lbl_sql_1.Size = new System.Drawing.Size(47, 12);
            this.lbl_sql_1.TabIndex = 0;
            this.lbl_sql_1.Text = "数据库:";
            // 
            // tP_information
            // 
            this.tP_information.Controls.Add(this.btn_ifmt_selectall);
            this.tP_information.Controls.Add(this.btn_ifmt_clearall);
            this.tP_information.Controls.Add(this.tB_ifmt_sc_port);
            this.tP_information.Controls.Add(this.lbl_ifmt_4);
            this.tP_information.Controls.Add(this.tB_ifmt_sc_ipaddress);
            this.tP_information.Controls.Add(this.lbl_ifmt_3);
            this.tP_information.Controls.Add(this.tB_ifmt_db_password);
            this.tP_information.Controls.Add(this.lbl_ifmt_2);
            this.tP_information.Controls.Add(this.tB_ifmt_db_sa);
            this.tP_information.Controls.Add(this.lbl_ifmt_1);
            this.tP_information.Location = new System.Drawing.Point(4, 22);
            this.tP_information.Name = "tP_information";
            this.tP_information.Padding = new System.Windows.Forms.Padding(3);
            this.tP_information.Size = new System.Drawing.Size(284, 247);
            this.tP_information.TabIndex = 3;
            this.tP_information.Text = "信息设置";
            this.tP_information.UseVisualStyleBackColor = true;
            // 
            // btn_ifmt_selectall
            // 
            this.btn_ifmt_selectall.Location = new System.Drawing.Point(11, 213);
            this.btn_ifmt_selectall.Name = "btn_ifmt_selectall";
            this.btn_ifmt_selectall.Size = new System.Drawing.Size(265, 23);
            this.btn_ifmt_selectall.TabIndex = 9;
            this.btn_ifmt_selectall.Text = "录入所有信息";
            this.btn_ifmt_selectall.UseVisualStyleBackColor = true;
            this.btn_ifmt_selectall.Click += new System.EventHandler(this.btn_ifmt_selectall_Click);
            // 
            // btn_ifmt_clearall
            // 
            this.btn_ifmt_clearall.Enabled = false;
            this.btn_ifmt_clearall.Location = new System.Drawing.Point(11, 183);
            this.btn_ifmt_clearall.Name = "btn_ifmt_clearall";
            this.btn_ifmt_clearall.Size = new System.Drawing.Size(265, 23);
            this.btn_ifmt_clearall.TabIndex = 8;
            this.btn_ifmt_clearall.Text = "擦除所有信息";
            this.btn_ifmt_clearall.UseVisualStyleBackColor = true;
            this.btn_ifmt_clearall.Click += new System.EventHandler(this.btn_ifmt_clearall_Click);
            // 
            // tB_ifmt_sc_port
            // 
            this.tB_ifmt_sc_port.Location = new System.Drawing.Point(11, 155);
            this.tB_ifmt_sc_port.Name = "tB_ifmt_sc_port";
            this.tB_ifmt_sc_port.Size = new System.Drawing.Size(265, 21);
            this.tB_ifmt_sc_port.TabIndex = 7;
            // 
            // lbl_ifmt_4
            // 
            this.lbl_ifmt_4.AutoSize = true;
            this.lbl_ifmt_4.Location = new System.Drawing.Point(11, 139);
            this.lbl_ifmt_4.Name = "lbl_ifmt_4";
            this.lbl_ifmt_4.Size = new System.Drawing.Size(83, 12);
            this.lbl_ifmt_4.TabIndex = 6;
            this.lbl_ifmt_4.Text = "TCP侦听端口：";
            // 
            // tB_ifmt_sc_ipaddress
            // 
            this.tB_ifmt_sc_ipaddress.Location = new System.Drawing.Point(11, 111);
            this.tB_ifmt_sc_ipaddress.Name = "tB_ifmt_sc_ipaddress";
            this.tB_ifmt_sc_ipaddress.Size = new System.Drawing.Size(265, 21);
            this.tB_ifmt_sc_ipaddress.TabIndex = 5;
            // 
            // lbl_ifmt_3
            // 
            this.lbl_ifmt_3.AutoSize = true;
            this.lbl_ifmt_3.Location = new System.Drawing.Point(11, 95);
            this.lbl_ifmt_3.Name = "lbl_ifmt_3";
            this.lbl_ifmt_3.Size = new System.Drawing.Size(77, 12);
            this.lbl_ifmt_3.TabIndex = 4;
            this.lbl_ifmt_3.Text = "TCP侦听地址:";
            // 
            // tB_ifmt_db_password
            // 
            this.tB_ifmt_db_password.Location = new System.Drawing.Point(11, 67);
            this.tB_ifmt_db_password.Name = "tB_ifmt_db_password";
            this.tB_ifmt_db_password.Size = new System.Drawing.Size(265, 21);
            this.tB_ifmt_db_password.TabIndex = 3;
            // 
            // lbl_ifmt_2
            // 
            this.lbl_ifmt_2.AutoSize = true;
            this.lbl_ifmt_2.Location = new System.Drawing.Point(11, 51);
            this.lbl_ifmt_2.Name = "lbl_ifmt_2";
            this.lbl_ifmt_2.Size = new System.Drawing.Size(71, 12);
            this.lbl_ifmt_2.TabIndex = 2;
            this.lbl_ifmt_2.Text = "数据库密码:";
            // 
            // tB_ifmt_db_sa
            // 
            this.tB_ifmt_db_sa.Location = new System.Drawing.Point(11, 23);
            this.tB_ifmt_db_sa.Name = "tB_ifmt_db_sa";
            this.tB_ifmt_db_sa.Size = new System.Drawing.Size(265, 21);
            this.tB_ifmt_db_sa.TabIndex = 1;
            // 
            // lbl_ifmt_1
            // 
            this.lbl_ifmt_1.AutoSize = true;
            this.lbl_ifmt_1.Location = new System.Drawing.Point(9, 7);
            this.lbl_ifmt_1.Name = "lbl_ifmt_1";
            this.lbl_ifmt_1.Size = new System.Drawing.Size(71, 12);
            this.lbl_ifmt_1.TabIndex = 0;
            this.lbl_ifmt_1.Text = "数据库账号:";
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tC_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯控制器byRingoHu";
            this.tC_main.ResumeLayout(false);
            this.tp_home.ResumeLayout(false);
            this.tp_home.PerformLayout();
            this.tP_tcp.ResumeLayout(false);
            this.tP_tcp.PerformLayout();
            this.tP_mysql.ResumeLayout(false);
            this.tP_mysql.PerformLayout();
            this.tP_information.ResumeLayout(false);
            this.tP_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tC_main;
        private System.Windows.Forms.TabPage tp_home;
        private System.Windows.Forms.TabPage tP_tcp;
        private System.Windows.Forms.TabPage tP_mysql;
        private System.Windows.Forms.TabPage tP_information;
        private System.Windows.Forms.Label lbl_home_4;
        private System.Windows.Forms.Button btn_home_sc_close;
        private System.Windows.Forms.Button btn_home_sc_open;
        private System.Windows.Forms.Button btn_home_db_close;
        private System.Windows.Forms.Label lbl_home_3;
        private System.Windows.Forms.Label lbl_home_2;
        private System.Windows.Forms.Button btn_home_db_test;
        private System.Windows.Forms.Label lbl_home_1;
        private System.Windows.Forms.Button btn_tcp_select;
        private System.Windows.Forms.Button btn_tcp_check;
        private System.Windows.Forms.TextBox tB_tcp_send;
        private System.Windows.Forms.Label lbl_tcp_2;
        public System.Windows.Forms.TextBox tB_tcp_receive;
        private System.Windows.Forms.Label lbl_tcp_1;
        public System.Windows.Forms.TextBox tB_sql_result;
        private System.Windows.Forms.Label lbl_sql_3;
        private System.Windows.Forms.Button btn_sql_select;
        private System.Windows.Forms.TextBox tB_sql_table;
        private System.Windows.Forms.Label lbl_sql_2;
        private System.Windows.Forms.Button btn_sql_quary;
        private System.Windows.Forms.TextBox tB_sql_dbname;
        private System.Windows.Forms.Label lbl_sql_1;
        private System.Windows.Forms.Button btn_ifmt_selectall;
        private System.Windows.Forms.Button btn_ifmt_clearall;
        private System.Windows.Forms.TextBox tB_ifmt_sc_port;
        private System.Windows.Forms.Label lbl_ifmt_4;
        private System.Windows.Forms.TextBox tB_ifmt_sc_ipaddress;
        private System.Windows.Forms.Label lbl_ifmt_3;
        private System.Windows.Forms.TextBox tB_ifmt_db_password;
        private System.Windows.Forms.Label lbl_ifmt_2;
        private System.Windows.Forms.TextBox tB_ifmt_db_sa;
        private System.Windows.Forms.Label lbl_ifmt_1;



    }
}


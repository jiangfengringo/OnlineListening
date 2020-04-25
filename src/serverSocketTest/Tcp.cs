using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ConnectControl
{
    public class Tcp                                                                                        //一个TCP通讯类
    {
        public IPAddress ip = null;                                                                         //侦听地址
        public int port = 0;                                                                                //侦听端口
        public String returnmessage = null;                                                                 //自动应答消息
        public System.Windows.Forms.TextBox tB_tcp_receive = null;                                          //tcp消息显示控件
        Socket server = null;                                                                               //一个服务器Socket
        public Boolean connectflag = true;                                                                  //控制连接线程关闭标志
        public Sql sqltmp = null;                                                                           //一个Sql实例

        //构造函数，传入参数依次为侦听地址、侦听端口、自动应答消息、消息显示控件、数据库控制实例
        public Tcp(IPAddress ip, int port, String returnmessage, System.Windows.Forms.TextBox tB_tcp_receive, Sql sqltmp) 
        {
            this.ip = ip;
            this.port = port;
            this.returnmessage = returnmessage;
            this.tB_tcp_receive = tB_tcp_receive;
            this.sqltmp = sqltmp;

            IPEndPoint pointTMP = new IPEndPoint(this.ip, this.port);                                       //建立网络端点
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);           //实例化服务器Socket
            server.Bind(pointTMP);                                                                          //将服务器Socket绑定网络端点
            server.Listen(10);                                                                              //设置服务器Socket最大侦听队列长度

            tB_tcp_receive.AppendText("系统配置完成……\n");

            Thread connnectthread = new Thread(clientconnect);                                              //实例化一个执行无参clientconnect方法的线程
            connnectthread.Start();                                                                         //开启线程

            tB_tcp_receive.AppendText("连接线程已开启……\n");

        }

        private void clientconnect()                                                                        //连接线程
        {
            try 
            {
                while (connectflag)
                {
                    tB_tcp_receive.AppendText("等待客户端连接……\n");

                    Socket client = server.Accept();                                                        //等待客户端Socket连接并将新建一个与之对话的Socket赋值给client
                    
                    tB_tcp_receive.AppendText(String.Format("客户端{0}已连接\n",client.RemoteEndPoint));

                    Thread receivethread = new Thread(receivemessage);                                      //实例化一个执行有参receivemessage方法的线程
                    receivethread.Start(client);                                                            //传入参数client并开启线程

                    tB_tcp_receive.AppendText("接收线程已开启……\n");

                    client.Send(Encoding.UTF8.GetBytes(returnmessage));                                     //像连接上的客户端发送自动应答消息
                }
                
            }
            catch (Exception)
            {
                tB_tcp_receive.AppendText("ERROR:连接线程错误！\n");
            }

        }

        private void receivemessage(Object o)                                                               //接收线程
        {
            Socket clientTMP = (Socket)o;                                                                   //将传入的对象转换为Socket并赋值给clientTMP
            Boolean receiveflag = true;                                                                     //控制接收线程关闭标志
            
            while (receiveflag)
            {
                try 
                {
                    byte[] data = new byte[4096];                                                           //建立一个字节数组作为接收字符缓冲区
                    int length = clientTMP.Receive(data);                                                   //接收客户端发送的数据将其载入缓冲区并返回其字节长度
                    if (length == 0)
                    {
                        receiveflag = false;
                    }                                                                                       //当缓冲区无数据时，标志接收线程停止
                    else 
                    {
                        String receiveTMP = Encoding.UTF8.GetString(data, 0, length);                       //将缓冲区数据全部转化为TUF8编码的字符串（将此部分处理后存入数据库）
                        sqltmp.sqlinsert(receiveTMP, sqltmp.dbtable, clientTMP.RemoteEndPoint.ToString());  //将接收到的数据存入数据库

                        tB_tcp_receive.AppendText(String.Format("客户端{0}发送消息：{1} \n",clientTMP.RemoteEndPoint,receiveTMP));
                    }

                }
                catch(Exception)
                {
                    tB_tcp_receive.AppendText(String.Format("客户端{0}断开连接……\n", clientTMP.RemoteEndPoint));

                    clientTMP.Shutdown(SocketShutdown.Both);                                                //终止两端数据传输
                    clientTMP.Close();                                                                      //关闭与客户端连接的Socket
                    receiveflag = false;                                                                    //标志接收线程停止
                    break;
                }
            }
        }

        public void closeserver()                                                                           //关闭侦听
        {
            connectflag = false;
            server.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 配置IP地址
{
    public partial class Main : Form
    {
        NetworkInterface[] adapters = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //执行一次网卡查询
            ExecuteInCmd("ipconfig");
            //初始化适配器列表
            adapters = NetworkInterface.GetAllNetworkInterfaces();
            InitializeAdapterList();
        }

        public void InitializeAdapterList()
        {
            //获取适配器列表
            适配器列表.DataSource = adapters.Select(n => n.Name).ToList();
        }

        

        private void B_execute_Click(object sender, EventArgs e)
        {

        }

        private void 按钮_测试_Click(object sender, EventArgs e)
        {

        }

        public string GetLocalIP()
        {
            List<string> strIPs = new List<string>();
            adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {

                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    var mac = adapter.GetPhysicalAddress();
                    Console.WriteLine(mac);
                    IPInterfaceProperties ip = adapter.GetIPProperties();
                    UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
                    foreach (UnicastIPAddressInformation ipadd in ipCollection)
                    {
                        //InterNetwork      IPV4地址      
                        //InterNetworkV6    IPV6地址 
                        if (ipadd.Address.AddressFamily == AddressFamily.InterNetwork)
                        {   //判断是否为ipv4
                            Console.WriteLine(ipadd.Address.ToString());
                            strIPs.Add(ipadd.Address.ToString());
                        }
                    }
                }
            }
            return string.Join(";", strIPs);
        }

        /// <summary>
        /// 切换适配器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 适配器列表_SelectedIndexChanged(object sender, EventArgs e)
        {
            //更新当前IP地址显示
            ShowNowIp();
            //加载适配器配置

        }

        /// <summary>
        /// 显示当前IP地址
        /// </summary>
        private void ShowNowIp()
        {
            IP_Now.Text = "当前IP地址：";
        }

        private void SetThisAdapterClass(int index_in)
        {
            NowNet nowNet = new NowNet();
            nowNet.type = null;
            nowNet.index = index_in;
            nowNet.name = null;
            nowNet.ip_mode = null;
            nowNet.ip = null;
            nowNet.zwym = null;
            nowNet.mrwg = null;
        }

        /// <summary>
        /// 执行cmd命令
        /// </summary>
        /// <param name="cmdline"></param>
        private void ExecuteInCmd(string cmdline)
        {
            if (cmdline != null)
            {
                using (var process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    process.StandardInput.AutoFlush = true;
                    process.StandardInput.WriteLine(cmdline + "&exit");

                    //获取cmd窗口的输出信息  
                    result.Text = process.StandardOutput.ReadToEnd();

                    process.WaitForExit();
                    process.Close();
                }
            }
        }

        class NowNet
        {
            /// <summary>
            /// 连接方式：以太网；无线网络
            /// </summary>
            public string type { get; set; }
            /// <summary>
            /// 序号
            /// </summary>
            public int index { get; set; }
            /// <summary>
            /// 适配器名称
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// ip获取模式
            /// </summary>
            public string ip_mode { get; set; }
            /// <summary>
            /// IP地址
            /// </summary>
            public string ip { get; set; }
            /// <summary>
            /// 子网掩码
            /// </summary>
            public string zwym { get; set; }
            /// <summary>
            /// 默认网关
            /// </summary>
            public string mrwg { get; set; }
        }

        private void IP_Now_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace 配置IP地址
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.B_execute = new System.Windows.Forms.Button();
            this.In_IP = new System.Windows.Forms.TextBox();
            this.文本_IP地址 = new System.Windows.Forms.Label();
            this.AutoIP = new System.Windows.Forms.RadioButton();
            this.操作模式 = new System.Windows.Forms.GroupBox();
            this.SetIP = new System.Windows.Forms.RadioButton();
            this.IP配置 = new System.Windows.Forms.GroupBox();
            this.In_默认网关 = new System.Windows.Forms.TextBox();
            this.文本_默认网关 = new System.Windows.Forms.Label();
            this.In_子网掩码 = new System.Windows.Forms.TextBox();
            this.文本_子网掩码 = new System.Windows.Forms.Label();
            this.按钮_测试 = new System.Windows.Forms.Button();
            this.IP_Now = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.文本_执行结果 = new System.Windows.Forms.Label();
            this.文本_适配器 = new System.Windows.Forms.Label();
            this.适配器列表 = new System.Windows.Forms.ComboBox();
            this.操作模式.SuspendLayout();
            this.IP配置.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_execute
            // 
            this.B_execute.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_execute.Location = new System.Drawing.Point(28, 393);
            this.B_execute.Name = "B_execute";
            this.B_execute.Size = new System.Drawing.Size(151, 35);
            this.B_execute.TabIndex = 0;
            this.B_execute.Text = "确认更改";
            this.B_execute.UseVisualStyleBackColor = true;
            this.B_execute.Click += new System.EventHandler(this.B_execute_Click);
            // 
            // In_IP
            // 
            this.In_IP.Location = new System.Drawing.Point(133, 18);
            this.In_IP.Name = "In_IP";
            this.In_IP.Size = new System.Drawing.Size(180, 21);
            this.In_IP.TabIndex = 1;
            // 
            // 文本_IP地址
            // 
            this.文本_IP地址.AutoSize = true;
            this.文本_IP地址.Location = new System.Drawing.Point(20, 24);
            this.文本_IP地址.Name = "文本_IP地址";
            this.文本_IP地址.Size = new System.Drawing.Size(41, 12);
            this.文本_IP地址.TabIndex = 2;
            this.文本_IP地址.Text = "IP地址";
            // 
            // AutoIP
            // 
            this.AutoIP.AutoSize = true;
            this.AutoIP.Location = new System.Drawing.Point(11, 29);
            this.AutoIP.Name = "AutoIP";
            this.AutoIP.Size = new System.Drawing.Size(107, 16);
            this.AutoIP.TabIndex = 3;
            this.AutoIP.TabStop = true;
            this.AutoIP.Text = "自动获得IP地址";
            this.AutoIP.UseVisualStyleBackColor = true;
            // 
            // 操作模式
            // 
            this.操作模式.Controls.Add(this.SetIP);
            this.操作模式.Controls.Add(this.AutoIP);
            this.操作模式.Location = new System.Drawing.Point(28, 121);
            this.操作模式.Name = "操作模式";
            this.操作模式.Size = new System.Drawing.Size(355, 104);
            this.操作模式.TabIndex = 4;
            this.操作模式.TabStop = false;
            this.操作模式.Text = "操作模式";
            // 
            // SetIP
            // 
            this.SetIP.AutoSize = true;
            this.SetIP.Location = new System.Drawing.Point(11, 61);
            this.SetIP.Name = "SetIP";
            this.SetIP.Size = new System.Drawing.Size(119, 16);
            this.SetIP.TabIndex = 3;
            this.SetIP.TabStop = true;
            this.SetIP.Text = "使用下面的IP地址";
            this.SetIP.UseVisualStyleBackColor = true;
            // 
            // IP配置
            // 
            this.IP配置.Controls.Add(this.In_默认网关);
            this.IP配置.Controls.Add(this.文本_默认网关);
            this.IP配置.Controls.Add(this.In_子网掩码);
            this.IP配置.Controls.Add(this.文本_子网掩码);
            this.IP配置.Controls.Add(this.In_IP);
            this.IP配置.Controls.Add(this.文本_IP地址);
            this.IP配置.Location = new System.Drawing.Point(28, 240);
            this.IP配置.Name = "IP配置";
            this.IP配置.Size = new System.Drawing.Size(355, 110);
            this.IP配置.TabIndex = 5;
            this.IP配置.TabStop = false;
            this.IP配置.Text = "IP";
            // 
            // In_默认网关
            // 
            this.In_默认网关.Location = new System.Drawing.Point(133, 72);
            this.In_默认网关.Name = "In_默认网关";
            this.In_默认网关.Size = new System.Drawing.Size(180, 21);
            this.In_默认网关.TabIndex = 1;
            // 
            // 文本_默认网关
            // 
            this.文本_默认网关.AutoSize = true;
            this.文本_默认网关.Location = new System.Drawing.Point(20, 78);
            this.文本_默认网关.Name = "文本_默认网关";
            this.文本_默认网关.Size = new System.Drawing.Size(53, 12);
            this.文本_默认网关.TabIndex = 2;
            this.文本_默认网关.Text = "默认网关";
            // 
            // In_子网掩码
            // 
            this.In_子网掩码.Location = new System.Drawing.Point(133, 45);
            this.In_子网掩码.Name = "In_子网掩码";
            this.In_子网掩码.Size = new System.Drawing.Size(180, 21);
            this.In_子网掩码.TabIndex = 1;
            // 
            // 文本_子网掩码
            // 
            this.文本_子网掩码.AutoSize = true;
            this.文本_子网掩码.Location = new System.Drawing.Point(20, 51);
            this.文本_子网掩码.Name = "文本_子网掩码";
            this.文本_子网掩码.Size = new System.Drawing.Size(53, 12);
            this.文本_子网掩码.TabIndex = 2;
            this.文本_子网掩码.Text = "子网掩码";
            // 
            // 按钮_测试
            // 
            this.按钮_测试.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.按钮_测试.Location = new System.Drawing.Point(221, 393);
            this.按钮_测试.Name = "按钮_测试";
            this.按钮_测试.Size = new System.Drawing.Size(151, 35);
            this.按钮_测试.TabIndex = 0;
            this.按钮_测试.Text = "运行测试";
            this.按钮_测试.UseVisualStyleBackColor = true;
            this.按钮_测试.Click += new System.EventHandler(this.按钮_测试_Click);
            // 
            // IP_Now
            // 
            this.IP_Now.AutoSize = true;
            this.IP_Now.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IP_Now.Location = new System.Drawing.Point(36, 78);
            this.IP_Now.Name = "IP_Now";
            this.IP_Now.Size = new System.Drawing.Size(68, 14);
            this.IP_Now.TabIndex = 6;
            this.IP_Now.Text = "当前IP：";
            this.IP_Now.Click += new System.EventHandler(this.IP_Now_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(417, 51);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(421, 376);
            this.result.TabIndex = 7;
            // 
            // 文本_执行结果
            // 
            this.文本_执行结果.AutoSize = true;
            this.文本_执行结果.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文本_执行结果.Location = new System.Drawing.Point(415, 26);
            this.文本_执行结果.Name = "文本_执行结果";
            this.文本_执行结果.Size = new System.Drawing.Size(57, 12);
            this.文本_执行结果.TabIndex = 8;
            this.文本_执行结果.Text = "运行结果";
            // 
            // 文本_适配器
            // 
            this.文本_适配器.AutoSize = true;
            this.文本_适配器.Location = new System.Drawing.Point(37, 26);
            this.文本_适配器.Name = "文本_适配器";
            this.文本_适配器.Size = new System.Drawing.Size(41, 12);
            this.文本_适配器.TabIndex = 10;
            this.文本_适配器.Text = "适配器";
            // 
            // 适配器列表
            // 
            this.适配器列表.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.适配器列表.FormattingEnabled = true;
            this.适配器列表.Location = new System.Drawing.Point(86, 21);
            this.适配器列表.Name = "适配器列表";
            this.适配器列表.Size = new System.Drawing.Size(240, 20);
            this.适配器列表.TabIndex = 11;
            this.适配器列表.SelectedIndexChanged += new System.EventHandler(this.适配器列表_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 466);
            this.Controls.Add(this.适配器列表);
            this.Controls.Add(this.文本_适配器);
            this.Controls.Add(this.文本_执行结果);
            this.Controls.Add(this.result);
            this.Controls.Add(this.IP_Now);
            this.Controls.Add(this.IP配置);
            this.Controls.Add(this.操作模式);
            this.Controls.Add(this.按钮_测试);
            this.Controls.Add(this.B_execute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "IP&DNS配置";
            this.Load += new System.EventHandler(this.Main_Load);
            this.操作模式.ResumeLayout(false);
            this.操作模式.PerformLayout();
            this.IP配置.ResumeLayout(false);
            this.IP配置.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_execute;
        private System.Windows.Forms.TextBox In_IP;
        private System.Windows.Forms.Label 文本_IP地址;
        private System.Windows.Forms.RadioButton AutoIP;
        private System.Windows.Forms.GroupBox 操作模式;
        private System.Windows.Forms.RadioButton SetIP;
        private System.Windows.Forms.GroupBox IP配置;
        private System.Windows.Forms.TextBox In_默认网关;
        private System.Windows.Forms.Label 文本_默认网关;
        private System.Windows.Forms.TextBox In_子网掩码;
        private System.Windows.Forms.Label 文本_子网掩码;
        private System.Windows.Forms.Button 按钮_测试;
        private System.Windows.Forms.Label IP_Now;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label 文本_执行结果;
        private System.Windows.Forms.Label 文本_适配器;
        private System.Windows.Forms.ComboBox 适配器列表;
    }
}


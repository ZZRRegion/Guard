namespace GuardCount
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.picHead = new System.Windows.Forms.PictureBox();
            this.btnPort = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txtCountSetting = new System.Windows.Forms.TextBox();
            this.btnCountSetting = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboAlarm = new System.Windows.Forms.ComboBox();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.txtYou7 = new System.Windows.Forms.TextBox();
            this.txtYou6 = new System.Windows.Forms.TextBox();
            this.txtYou8 = new System.Windows.Forms.TextBox();
            this.txtYou5 = new System.Windows.Forms.TextBox();
            this.txtYou4 = new System.Windows.Forms.TextBox();
            this.txtYou3 = new System.Windows.Forms.TextBox();
            this.txtYou2 = new System.Windows.Forms.TextBox();
            this.txtYou1 = new System.Windows.Forms.TextBox();
            this.txtYou0 = new System.Windows.Forms.TextBox();
            this.lblYou8 = new System.Windows.Forms.Label();
            this.lblYou7 = new System.Windows.Forms.Label();
            this.lblYou6 = new System.Windows.Forms.Label();
            this.lblYou5 = new System.Windows.Forms.Label();
            this.lblYou4 = new System.Windows.Forms.Label();
            this.lblYou3 = new System.Windows.Forms.Label();
            this.lblYou2 = new System.Windows.Forms.Label();
            this.lblYou1 = new System.Windows.Forms.Label();
            this.lblYou0 = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblErrorContent = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.pnlCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.pnlCompany);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1052, 255);
            this.pnl.TabIndex = 0;
            // 
            // pnlCompany
            // 
            this.pnlCompany.Controls.Add(this.lblCompany);
            this.pnlCompany.Controls.Add(this.picHead);
            this.pnlCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(1052, 99);
            this.pnlCompany.TabIndex = 0;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompany.Location = new System.Drawing.Point(383, 8);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(354, 80);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "威祥科技";
            // 
            // picHead
            // 
            this.picHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHead.BackgroundImage")));
            this.picHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHead.Location = new System.Drawing.Point(251, 3);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(130, 90);
            this.picHead.TabIndex = 0;
            this.picHead.TabStop = false;
            // 
            // btnPort
            // 
            this.btnPort.Location = new System.Drawing.Point(782, 19);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(76, 21);
            this.btnPort.TabIndex = 1;
            this.btnPort.Text = "配置";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(870, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 21);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.txtCountSetting);
            this.pnlCenter.Controls.Add(this.btnCountSetting);
            this.pnlCenter.Controls.Add(this.btnReset);
            this.pnlCenter.Controls.Add(this.cboAlarm);
            this.pnlCenter.Controls.Add(this.lblAlarm);
            this.pnlCenter.Controls.Add(this.txtYou7);
            this.pnlCenter.Controls.Add(this.txtYou6);
            this.pnlCenter.Controls.Add(this.txtYou8);
            this.pnlCenter.Controls.Add(this.txtYou5);
            this.pnlCenter.Controls.Add(this.txtYou4);
            this.pnlCenter.Controls.Add(this.txtYou3);
            this.pnlCenter.Controls.Add(this.txtYou2);
            this.pnlCenter.Controls.Add(this.txtYou1);
            this.pnlCenter.Controls.Add(this.txtYou0);
            this.pnlCenter.Controls.Add(this.lblYou8);
            this.pnlCenter.Controls.Add(this.lblYou7);
            this.pnlCenter.Controls.Add(this.lblYou6);
            this.pnlCenter.Controls.Add(this.lblYou5);
            this.pnlCenter.Controls.Add(this.lblYou4);
            this.pnlCenter.Controls.Add(this.lblYou3);
            this.pnlCenter.Controls.Add(this.lblYou2);
            this.pnlCenter.Controls.Add(this.lblYou1);
            this.pnlCenter.Controls.Add(this.lblYou0);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 255);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1052, 158);
            this.pnlCenter.TabIndex = 1;
            // 
            // txtCountSetting
            // 
            this.txtCountSetting.Location = new System.Drawing.Point(345, 128);
            this.txtCountSetting.Name = "txtCountSetting";
            this.txtCountSetting.ReadOnly = true;
            this.txtCountSetting.Size = new System.Drawing.Size(76, 21);
            this.txtCountSetting.TabIndex = 25;
            this.txtCountSetting.Text = "5";
            // 
            // btnCountSetting
            // 
            this.btnCountSetting.Location = new System.Drawing.Point(227, 127);
            this.btnCountSetting.Name = "btnCountSetting";
            this.btnCountSetting.Size = new System.Drawing.Size(102, 23);
            this.btnCountSetting.TabIndex = 24;
            this.btnCountSetting.Text = "连续数量设置";
            this.btnCountSetting.UseVisualStyleBackColor = true;
            this.btnCountSetting.Click += new System.EventHandler(this.btnCountSetting_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(104, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "产量清零";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cboAlarm
            // 
            this.cboAlarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlarm.FormattingEnabled = true;
            this.cboAlarm.Location = new System.Drawing.Point(14, 128);
            this.cboAlarm.Name = "cboAlarm";
            this.cboAlarm.Size = new System.Drawing.Size(76, 20);
            this.cboAlarm.TabIndex = 22;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(12, 104);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(89, 12);
            this.lblAlarm.TabIndex = 21;
            this.lblAlarm.Text = "报警输出选择：";
            // 
            // txtYou7
            // 
            this.txtYou7.Location = new System.Drawing.Point(840, 56);
            this.txtYou7.Name = "txtYou7";
            this.txtYou7.ReadOnly = true;
            this.txtYou7.Size = new System.Drawing.Size(76, 21);
            this.txtYou7.TabIndex = 20;
            // 
            // txtYou6
            // 
            this.txtYou6.Location = new System.Drawing.Point(722, 56);
            this.txtYou6.Name = "txtYou6";
            this.txtYou6.ReadOnly = true;
            this.txtYou6.Size = new System.Drawing.Size(76, 21);
            this.txtYou6.TabIndex = 19;
            // 
            // txtYou8
            // 
            this.txtYou8.Location = new System.Drawing.Point(958, 56);
            this.txtYou8.Name = "txtYou8";
            this.txtYou8.ReadOnly = true;
            this.txtYou8.Size = new System.Drawing.Size(76, 21);
            this.txtYou8.TabIndex = 18;
            // 
            // txtYou5
            // 
            this.txtYou5.Location = new System.Drawing.Point(604, 56);
            this.txtYou5.Name = "txtYou5";
            this.txtYou5.ReadOnly = true;
            this.txtYou5.Size = new System.Drawing.Size(76, 21);
            this.txtYou5.TabIndex = 17;
            // 
            // txtYou4
            // 
            this.txtYou4.Location = new System.Drawing.Point(486, 56);
            this.txtYou4.Name = "txtYou4";
            this.txtYou4.ReadOnly = true;
            this.txtYou4.Size = new System.Drawing.Size(76, 21);
            this.txtYou4.TabIndex = 16;
            // 
            // txtYou3
            // 
            this.txtYou3.Location = new System.Drawing.Point(368, 56);
            this.txtYou3.Name = "txtYou3";
            this.txtYou3.ReadOnly = true;
            this.txtYou3.Size = new System.Drawing.Size(76, 21);
            this.txtYou3.TabIndex = 15;
            // 
            // txtYou2
            // 
            this.txtYou2.Location = new System.Drawing.Point(250, 56);
            this.txtYou2.Name = "txtYou2";
            this.txtYou2.ReadOnly = true;
            this.txtYou2.Size = new System.Drawing.Size(76, 21);
            this.txtYou2.TabIndex = 14;
            // 
            // txtYou1
            // 
            this.txtYou1.Location = new System.Drawing.Point(132, 56);
            this.txtYou1.Name = "txtYou1";
            this.txtYou1.ReadOnly = true;
            this.txtYou1.Size = new System.Drawing.Size(76, 21);
            this.txtYou1.TabIndex = 13;
            // 
            // txtYou0
            // 
            this.txtYou0.Location = new System.Drawing.Point(14, 56);
            this.txtYou0.Name = "txtYou0";
            this.txtYou0.ReadOnly = true;
            this.txtYou0.Size = new System.Drawing.Size(76, 21);
            this.txtYou0.TabIndex = 12;
            // 
            // lblYou8
            // 
            this.lblYou8.AutoSize = true;
            this.lblYou8.Location = new System.Drawing.Point(958, 35);
            this.lblYou8.Name = "lblYou8";
            this.lblYou8.Size = new System.Drawing.Size(41, 12);
            this.lblYou8.TabIndex = 11;
            this.lblYou8.Text = "次品：";
            // 
            // lblYou7
            // 
            this.lblYou7.AutoSize = true;
            this.lblYou7.Location = new System.Drawing.Point(840, 35);
            this.lblYou7.Name = "lblYou7";
            this.lblYou7.Size = new System.Drawing.Size(41, 12);
            this.lblYou7.TabIndex = 10;
            this.lblYou7.Text = "合格：";
            // 
            // lblYou6
            // 
            this.lblYou6.AutoSize = true;
            this.lblYou6.Location = new System.Drawing.Point(722, 35);
            this.lblYou6.Name = "lblYou6";
            this.lblYou6.Size = new System.Drawing.Size(41, 12);
            this.lblYou6.TabIndex = 9;
            this.lblYou6.Text = "一级：";
            // 
            // lblYou5
            // 
            this.lblYou5.AutoSize = true;
            this.lblYou5.Location = new System.Drawing.Point(604, 35);
            this.lblYou5.Name = "lblYou5";
            this.lblYou5.Size = new System.Drawing.Size(47, 12);
            this.lblYou5.TabIndex = 8;
            this.lblYou5.Text = "优等5：";
            // 
            // lblYou4
            // 
            this.lblYou4.AutoSize = true;
            this.lblYou4.Location = new System.Drawing.Point(486, 35);
            this.lblYou4.Name = "lblYou4";
            this.lblYou4.Size = new System.Drawing.Size(47, 12);
            this.lblYou4.TabIndex = 7;
            this.lblYou4.Text = "优等4：";
            // 
            // lblYou3
            // 
            this.lblYou3.AutoSize = true;
            this.lblYou3.Location = new System.Drawing.Point(368, 35);
            this.lblYou3.Name = "lblYou3";
            this.lblYou3.Size = new System.Drawing.Size(47, 12);
            this.lblYou3.TabIndex = 6;
            this.lblYou3.Text = "优等3：";
            // 
            // lblYou2
            // 
            this.lblYou2.AutoSize = true;
            this.lblYou2.Location = new System.Drawing.Point(250, 35);
            this.lblYou2.Name = "lblYou2";
            this.lblYou2.Size = new System.Drawing.Size(47, 12);
            this.lblYou2.TabIndex = 5;
            this.lblYou2.Text = "优等2：";
            // 
            // lblYou1
            // 
            this.lblYou1.AutoSize = true;
            this.lblYou1.Location = new System.Drawing.Point(132, 35);
            this.lblYou1.Name = "lblYou1";
            this.lblYou1.Size = new System.Drawing.Size(47, 12);
            this.lblYou1.TabIndex = 4;
            this.lblYou1.Text = "优等1：";
            // 
            // lblYou0
            // 
            this.lblYou0.AutoSize = true;
            this.lblYou0.Location = new System.Drawing.Point(14, 35);
            this.lblYou0.Name = "lblYou0";
            this.lblYou0.Size = new System.Drawing.Size(47, 12);
            this.lblYou0.TabIndex = 3;
            this.lblYou0.Text = "优等0：";
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.btnStop);
            this.pnlBot.Controls.Add(this.lblErrorContent);
            this.pnlBot.Controls.Add(this.lblError);
            this.pnlBot.Controls.Add(this.btnStart);
            this.pnlBot.Controls.Add(this.btnPort);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 413);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(1052, 125);
            this.pnlBot.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(958, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblErrorContent
            // 
            this.lblErrorContent.AutoSize = true;
            this.lblErrorContent.Location = new System.Drawing.Point(92, 19);
            this.lblErrorContent.Name = "lblErrorContent";
            this.lblErrorContent.Size = new System.Drawing.Size(11, 12);
            this.lblErrorContent.TabIndex = 1;
            this.lblErrorContent.Text = "x";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(14, 19);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(65, 12);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "出错信息：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 538);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "守望";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnl.ResumeLayout(false);
            this.pnlCompany.ResumeLayout(false);
            this.pnlCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlBot.ResumeLayout(false);
            this.pnlBot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Label lblYou8;
        private System.Windows.Forms.Label lblYou7;
        private System.Windows.Forms.Label lblYou6;
        private System.Windows.Forms.Label lblYou5;
        private System.Windows.Forms.Label lblYou4;
        private System.Windows.Forms.Label lblYou3;
        private System.Windows.Forms.Label lblYou2;
        private System.Windows.Forms.Label lblYou1;
        private System.Windows.Forms.Label lblYou0;
        private System.Windows.Forms.Label lblErrorContent;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.TextBox txtCountSetting;
        private System.Windows.Forms.Button btnCountSetting;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboAlarm;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.TextBox txtYou7;
        private System.Windows.Forms.TextBox txtYou6;
        private System.Windows.Forms.TextBox txtYou8;
        private System.Windows.Forms.TextBox txtYou5;
        private System.Windows.Forms.TextBox txtYou4;
        private System.Windows.Forms.TextBox txtYou3;
        private System.Windows.Forms.TextBox txtYou2;
        private System.Windows.Forms.TextBox txtYou1;
        private System.Windows.Forms.TextBox txtYou0;
        private System.Windows.Forms.Button btnStop;
    }
}


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.picHead = new System.Windows.Forms.PictureBox();
            this.btnPort = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.cboAlarm = new System.Windows.Forms.ComboBox();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblErrorContent = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.pnlSetZero = new System.Windows.Forms.Panel();
            this.pnlProduction = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContinuityCount = new System.Windows.Forms.Label();
            this.txtContinuityCount = new System.Windows.Forms.TextBox();
            this.btnContinuitySetting = new System.Windows.Forms.Button();
            this.lblSetZero = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRegisterState = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.pnlCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.pnlSetZero.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.pnlCompany);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(806, 255);
            this.pnl.TabIndex = 0;
            // 
            // pnlCompany
            // 
            this.pnlCompany.Controls.Add(this.lblCompany);
            this.pnlCompany.Controls.Add(this.picHead);
            this.pnlCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(806, 99);
            this.pnlCompany.TabIndex = 0;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompany.Location = new System.Drawing.Point(297, 8);
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
            this.picHead.Location = new System.Drawing.Point(162, 3);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(130, 90);
            this.picHead.TabIndex = 0;
            this.picHead.TabStop = false;
            // 
            // btnPort
            // 
            this.btnPort.Location = new System.Drawing.Point(493, 166);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(76, 21);
            this.btnPort.TabIndex = 1;
            this.btnPort.Text = "配置";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(581, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 21);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.btnStop);
            this.pnlCenter.Controls.Add(this.panel1);
            this.pnlCenter.Controls.Add(this.pnlProduction);
            this.pnlCenter.Controls.Add(this.pnlSetZero);
            this.pnlCenter.Controls.Add(this.btnStart);
            this.pnlCenter.Controls.Add(this.btnPort);
            this.pnlCenter.Controls.Add(this.lblDisplay);
            this.pnlCenter.Controls.Add(this.cboAlarm);
            this.pnlCenter.Controls.Add(this.lblAlarm);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 255);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(806, 222);
            this.pnlCenter.TabIndex = 1;
            // 
            // cboAlarm
            // 
            this.cboAlarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlarm.FormattingEnabled = true;
            this.cboAlarm.Location = new System.Drawing.Point(5, 163);
            this.cboAlarm.Name = "cboAlarm";
            this.cboAlarm.Size = new System.Drawing.Size(89, 20);
            this.cboAlarm.TabIndex = 22;
            this.cboAlarm.SelectedIndexChanged += new System.EventHandler(this.cboAlarm_SelectedIndexChanged);
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(5, 139);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(89, 12);
            this.lblAlarm.TabIndex = 21;
            this.lblAlarm.Text = "报警输出选择：";
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.btnRegister);
            this.pnlBot.Controls.Add(this.lblRegisterState);
            this.pnlBot.Controls.Add(this.lblTime);
            this.pnlBot.Controls.Add(this.lblErrorContent);
            this.pnlBot.Controls.Add(this.lblError);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 477);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(806, 125);
            this.pnlBot.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(669, 166);
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
            this.lblError.Text = "通信故障：";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(5, 13);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(89, 12);
            this.lblDisplay.TabIndex = 26;
            this.lblDisplay.Text = "等级产量显示：";
            // 
            // pnlSetZero
            // 
            this.pnlSetZero.Controls.Add(this.lblSetZero);
            this.pnlSetZero.Location = new System.Drawing.Point(302, 139);
            this.pnlSetZero.Name = "pnlSetZero";
            this.pnlSetZero.Size = new System.Drawing.Size(156, 74);
            this.pnlSetZero.TabIndex = 4;
            // 
            // pnlProduction
            // 
            this.pnlProduction.Location = new System.Drawing.Point(3, 36);
            this.pnlProduction.Name = "pnlProduction";
            this.pnlProduction.Size = new System.Drawing.Size(800, 100);
            this.pnlProduction.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnContinuitySetting);
            this.panel1.Controls.Add(this.txtContinuityCount);
            this.panel1.Controls.Add(this.lblContinuityCount);
            this.panel1.Location = new System.Drawing.Point(102, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 48);
            this.panel1.TabIndex = 28;
            // 
            // lblContinuityCount
            // 
            this.lblContinuityCount.AutoSize = true;
            this.lblContinuityCount.Location = new System.Drawing.Point(2, 2);
            this.lblContinuityCount.Name = "lblContinuityCount";
            this.lblContinuityCount.Size = new System.Drawing.Size(89, 12);
            this.lblContinuityCount.TabIndex = 0;
            this.lblContinuityCount.Text = "连续报警数量：";
            // 
            // txtContinuityCount
            // 
            this.txtContinuityCount.Location = new System.Drawing.Point(2, 22);
            this.txtContinuityCount.Name = "txtContinuityCount";
            this.txtContinuityCount.ReadOnly = true;
            this.txtContinuityCount.Size = new System.Drawing.Size(100, 21);
            this.txtContinuityCount.TabIndex = 1;
            // 
            // btnContinuitySetting
            // 
            this.btnContinuitySetting.Location = new System.Drawing.Point(107, 21);
            this.btnContinuitySetting.Name = "btnContinuitySetting";
            this.btnContinuitySetting.Size = new System.Drawing.Size(75, 23);
            this.btnContinuitySetting.TabIndex = 2;
            this.btnContinuitySetting.Text = "设置";
            this.btnContinuitySetting.UseVisualStyleBackColor = true;
            this.btnContinuitySetting.Click += new System.EventHandler(this.btnContinuitySetting_Click);
            // 
            // lblSetZero
            // 
            this.lblSetZero.AutoSize = true;
            this.lblSetZero.Location = new System.Drawing.Point(2, 5);
            this.lblSetZero.Name = "lblSetZero";
            this.lblSetZero.Size = new System.Drawing.Size(113, 12);
            this.lblSetZero.TabIndex = 0;
            this.lblSetZero.Text = "产量清零设置：点动";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(580, 93);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "时间";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRegisterState
            // 
            this.lblRegisterState.AutoSize = true;
            this.lblRegisterState.Location = new System.Drawing.Point(26, 96);
            this.lblRegisterState.Name = "lblRegisterState";
            this.lblRegisterState.Size = new System.Drawing.Size(41, 12);
            this.lblRegisterState.TabIndex = 3;
            this.lblRegisterState.Text = "未注册";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(26, 59);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 602);
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
            this.pnlSetZero.ResumeLayout(false);
            this.pnlSetZero.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Label lblErrorContent;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.PictureBox picHead;
        private System.Windows.Forms.ComboBox cboAlarm;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Panel pnlSetZero;
        private System.Windows.Forms.Panel pnlProduction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContinuitySetting;
        private System.Windows.Forms.TextBox txtContinuityCount;
        private System.Windows.Forms.Label lblContinuityCount;
        private System.Windows.Forms.Label lblSetZero;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRegisterState;
        private System.Windows.Forms.Button btnRegister;
    }
}


namespace GuardCount
{
    partial class FrmSerialPortConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblDevNum = new System.Windows.Forms.Label();
            this.nudDevNum = new System.Windows.Forms.NumericUpDown();
            this.lblBad = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.lblPar = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDevNum)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(15, 38);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 20);
            this.cboPort.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(15, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(59, 12);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "COM端口：";
            // 
            // lblDevNum
            // 
            this.lblDevNum.AutoSize = true;
            this.lblDevNum.Location = new System.Drawing.Point(168, 20);
            this.lblDevNum.Name = "lblDevNum";
            this.lblDevNum.Size = new System.Drawing.Size(65, 12);
            this.lblDevNum.TabIndex = 2;
            this.lblDevNum.Text = "设备站号：";
            // 
            // nudDevNum
            // 
            this.nudDevNum.Location = new System.Drawing.Point(168, 38);
            this.nudDevNum.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudDevNum.Name = "nudDevNum";
            this.nudDevNum.Size = new System.Drawing.Size(121, 21);
            this.nudDevNum.TabIndex = 3;
            this.nudDevNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = true;
            this.lblBad.Location = new System.Drawing.Point(321, 20);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(53, 12);
            this.lblBad.TabIndex = 4;
            this.lblBad.Text = "波特率：";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cboBaudRate.Location = new System.Drawing.Point(321, 38);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cboBaudRate.TabIndex = 5;
            // 
            // cboDataBits
            // 
            this.cboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(168, 92);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(121, 20);
            this.cboDataBits.TabIndex = 6;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(168, 72);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(53, 12);
            this.lblDataBits.TabIndex = 7;
            this.lblDataBits.Text = "数据位：";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(321, 72);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(53, 12);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "停止位：";
            // 
            // cboStopBits
            // 
            this.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboStopBits.Location = new System.Drawing.Point(321, 92);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(121, 20);
            this.cboStopBits.TabIndex = 9;
            // 
            // cboParity
            // 
            this.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cboParity.Location = new System.Drawing.Point(15, 92);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(121, 20);
            this.cboParity.TabIndex = 10;
            // 
            // lblPar
            // 
            this.lblPar.AutoSize = true;
            this.lblPar.Location = new System.Drawing.Point(15, 72);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(65, 12);
            this.lblPar.TabIndex = 11;
            this.lblPar.Text = "奇偶校验：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(293, 129);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(375, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSerialPortConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 157);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPar);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.lblStopBits);
            this.Controls.Add(this.lblDataBits);
            this.Controls.Add(this.cboDataBits);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.nudDevNum);
            this.Controls.Add(this.lblDevNum);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cboPort);
            this.Name = "FrmSerialPortConfig";
            this.Text = "串口配置";
            this.Load += new System.EventHandler(this.FrmSerialPortConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDevNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblDevNum;
        private System.Windows.Forms.NumericUpDown nudDevNum;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
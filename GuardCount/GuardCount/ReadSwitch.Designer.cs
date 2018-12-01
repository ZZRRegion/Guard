namespace GuardCount
{
    partial class ReadSwitch
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMemo = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwitch.Location = new System.Drawing.Point(0, 0);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(102, 42);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblMemo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(102, 30);
            this.pnlTop.TabIndex = 1;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(3, 3);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(41, 12);
            this.lblMemo.TabIndex = 0;
            this.lblMemo.Text = "提示：";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.btnSwitch);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 30);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(102, 42);
            this.pnlCenter.TabIndex = 2;
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.txtCount);
            this.pnlBot.Controls.Add(this.lblCount);
            this.pnlBot.Controls.Add(this.cboSelect);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 72);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(102, 54);
            this.pnlBot.TabIndex = 3;
            // 
            // cboSelect
            // 
            this.cboSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Location = new System.Drawing.Point(0, 0);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(102, 28);
            this.cboSelect.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(5, 35);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 12);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "次数：";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(51, 31);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(47, 21);
            this.txtCount.TabIndex = 2;
            // 
            // ReadSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.pnlTop);
            this.Name = "ReadSwitch";
            this.Size = new System.Drawing.Size(102, 126);
            this.Load += new System.EventHandler(this.ReadSwitch_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlBot.ResumeLayout(false);
            this.pnlBot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
    }
}

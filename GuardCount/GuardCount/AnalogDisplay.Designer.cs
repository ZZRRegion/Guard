namespace GuardCount
{
    partial class AnalogDisplay
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMemo = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lblPian = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblMemo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(81, 24);
            this.pnlTop.TabIndex = 0;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(5, 5);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(29, 12);
            this.lblMemo.TabIndex = 0;
            this.lblMemo.Text = "提示";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.lblPian);
            this.pnlCenter.Controls.Add(this.txtCount);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 24);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(81, 32);
            this.pnlCenter.TabIndex = 1;
            // 
            // lblPian
            // 
            this.lblPian.AutoSize = true;
            this.lblPian.Location = new System.Drawing.Point(66, 11);
            this.lblPian.Name = "lblPian";
            this.lblPian.Size = new System.Drawing.Size(17, 12);
            this.lblPian.TabIndex = 1;
            this.lblPian.Text = "片";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(4, 7);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(62, 21);
            this.txtCount.TabIndex = 0;
            this.txtCount.Text = "0";
            // 
            // AnalogDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Name = "AnalogDisplay";
            this.Size = new System.Drawing.Size(81, 56);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblPian;
        private System.Windows.Forms.TextBox txtCount;
    }
}

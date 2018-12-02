namespace GuardCount
{
    partial class ButtonSwitch
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
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Green;
            this.btnSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwitch.Location = new System.Drawing.Point(0, 0);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(78, 43);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            this.btnSwitch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSwitch_MouseDown);
            this.btnSwitch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSwitch_MouseUp);
            // 
            // ButtonSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSwitch);
            this.Name = "ButtonSwitch";
            this.Size = new System.Drawing.Size(78, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
    }
}

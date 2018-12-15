namespace GuardCountRegister
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
            this.lblMachineCode = new System.Windows.Forms.Label();
            this.txtMachineCode = new System.Windows.Forms.TextBox();
            this.lblRegisterCode = new System.Windows.Forms.Label();
            this.txtRegisterCode = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMachineCode
            // 
            this.lblMachineCode.AutoSize = true;
            this.lblMachineCode.Location = new System.Drawing.Point(34, 43);
            this.lblMachineCode.Name = "lblMachineCode";
            this.lblMachineCode.Size = new System.Drawing.Size(53, 12);
            this.lblMachineCode.TabIndex = 0;
            this.lblMachineCode.Text = "机器码：";
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Location = new System.Drawing.Point(93, 39);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Size = new System.Drawing.Size(419, 21);
            this.txtMachineCode.TabIndex = 1;
            // 
            // lblRegisterCode
            // 
            this.lblRegisterCode.AutoSize = true;
            this.lblRegisterCode.Location = new System.Drawing.Point(34, 98);
            this.lblRegisterCode.Name = "lblRegisterCode";
            this.lblRegisterCode.Size = new System.Drawing.Size(53, 12);
            this.lblRegisterCode.TabIndex = 2;
            this.lblRegisterCode.Text = "注册码：";
            // 
            // txtRegisterCode
            // 
            this.txtRegisterCode.Location = new System.Drawing.Point(93, 94);
            this.txtRegisterCode.Name = "txtRegisterCode";
            this.txtRegisterCode.ReadOnly = true;
            this.txtRegisterCode.Size = new System.Drawing.Size(419, 21);
            this.txtRegisterCode.TabIndex = 3;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(93, 132);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(419, 23);
            this.btnMake.TabIndex = 4;
            this.btnMake.Text = "生成";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(518, 93);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "复制到剪贴板";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 166);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.txtRegisterCode);
            this.Controls.Add(this.lblRegisterCode);
            this.Controls.Add(this.txtMachineCode);
            this.Controls.Add(this.lblMachineCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册工具";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachineCode;
        private System.Windows.Forms.TextBox txtMachineCode;
        private System.Windows.Forms.Label lblRegisterCode;
        private System.Windows.Forms.TextBox txtRegisterCode;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnCopy;
    }
}


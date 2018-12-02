namespace GuardCount
{
    partial class FrmRegister
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
            this.lblMachineCode = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMachineCode = new System.Windows.Forms.TextBox();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMachineCode
            // 
            this.lblMachineCode.AutoSize = true;
            this.lblMachineCode.Location = new System.Drawing.Point(35, 42);
            this.lblMachineCode.Name = "lblMachineCode";
            this.lblMachineCode.Size = new System.Drawing.Size(53, 12);
            this.lblMachineCode.TabIndex = 0;
            this.lblMachineCode.Text = "机器码：";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(35, 102);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(53, 12);
            this.lblRegister.TabIndex = 1;
            this.lblRegister.Text = "注册码：";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(85, 136);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Location = new System.Drawing.Point(85, 38);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.ReadOnly = true;
            this.txtMachineCode.Size = new System.Drawing.Size(293, 21);
            this.txtMachineCode.TabIndex = 3;
            // 
            // txtRegister
            // 
            this.txtRegister.Location = new System.Drawing.Point(85, 98);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(293, 21);
            this.txtRegister.TabIndex = 4;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 167);
            this.Controls.Add(this.txtRegister);
            this.Controls.Add(this.txtMachineCode);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblMachineCode);
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachineCode;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtMachineCode;
        private System.Windows.Forms.TextBox txtRegister;
    }
}
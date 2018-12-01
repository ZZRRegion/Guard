﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GuardCount
{
    public partial class ReadSwitch : UserControl
    {
        private RunCollect Run;
        public Variable CurrentVariable { get; private set; }
        public ReadSwitch(Variable variable, RunCollect run)
        {
            InitializeComponent();
            this.LoadEvaluates();
            this.btnSwitch.BackgroundImageLayout = ImageLayout.Stretch;
            this.CurrentVariable = variable;
            this.lblMemo.Text = variable.Text;
            this.Run = run;
        }
        private void LoadEvaluates()
        {
            List<EvaluateModel> lst = EvaluateModel.GetEvaluates();
            lst.ForEach(item => {
                this.cboSelect.Items.Add(item);
            });
            if (this.cboSelect.Items.Count > 0)
                this.cboSelect.SelectedIndex = 0;
        }
        private void ReadSwitch_Load(object sender, EventArgs e)
        {
            this.SetValue(this.CurrentVariable.BoolValue);
        }
        public void SetValue(bool value)
        {
            Action action = () => {
                if (value)
                {
                    this.btnSwitch.BackgroundImage = new Bitmap(@"Images\on.png");
                }
                else
                {
                    this.btnSwitch.BackgroundImage = new Bitmap(@"Images\off.png");
                }
                this.txtCount.Text = this.CurrentVariable.ChangedCount.ToString();
            };
            this.Invoke(action);
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.btnSwitch.Enabled = false;
            if (this.CurrentVariable.AddressType == 0)
            {
                lock (this.Run.LockObj)
                {
                    this.CurrentVariable.BoolValue = !this.CurrentVariable.BoolValue;
                    this.SetValue(this.CurrentVariable.BoolValue);
                    if (this.Run.WriteBOOLValue.ContainsKey(this.CurrentVariable.Id))
                    {
                        this.Run.WriteBOOLValue[this.CurrentVariable.Id] = this.CurrentVariable.BoolValue;
                    }
                    else
                    {
                        this.Run.WriteBOOLValue.Add(this.CurrentVariable.Id, this.CurrentVariable.BoolValue);
                    }
                }
            }
            this.btnSwitch.Enabled = true;
        }
    }
}

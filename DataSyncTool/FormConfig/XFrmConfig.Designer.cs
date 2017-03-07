namespace DataSyncTool.FormConfig
{
    partial class XFrmConfig
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xsbSave = new DevExpress.XtraEditors.SimpleButton();
            this.xsbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.xlueSendLogTrigger = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xmemoReceiveEmail = new DevExpress.XtraEditors.MemoEdit();
            this.xteSendPassword = new DevExpress.XtraEditors.TextEdit();
            this.xteSendUser = new DevExpress.XtraEditors.TextEdit();
            this.xteSendServer = new DevExpress.XtraEditors.TextEdit();
            this.xteSendEmail = new DevExpress.XtraEditors.TextEdit();
            this.xteBeginTime = new DevExpress.XtraEditors.TimeEdit();
            this.xseDayInterval = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xlueSendLogTrigger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmemoReceiveEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteBeginTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xseDayInterval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xsbSave);
            this.layoutControl1.Controls.Add(this.xsbCancel);
            this.layoutControl1.Controls.Add(this.xlueSendLogTrigger);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.xmemoReceiveEmail);
            this.layoutControl1.Controls.Add(this.xteSendPassword);
            this.layoutControl1.Controls.Add(this.xteSendUser);
            this.layoutControl1.Controls.Add(this.xteSendServer);
            this.layoutControl1.Controls.Add(this.xteSendEmail);
            this.layoutControl1.Controls.Add(this.xteBeginTime);
            this.layoutControl1.Controls.Add(this.xseDayInterval);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(632, 451);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xsbSave
            // 
            this.xsbSave.Location = new System.Drawing.Point(441, 417);
            this.xsbSave.Name = "xsbSave";
            this.xsbSave.Size = new System.Drawing.Size(87, 22);
            this.xsbSave.StyleController = this.layoutControl1;
            this.xsbSave.TabIndex = 11;
            this.xsbSave.Text = "保存";
            this.xsbSave.Click += new System.EventHandler(this.xsbSave_Click);
            // 
            // xsbCancel
            // 
            this.xsbCancel.Location = new System.Drawing.Point(532, 417);
            this.xsbCancel.Name = "xsbCancel";
            this.xsbCancel.Size = new System.Drawing.Size(88, 22);
            this.xsbCancel.StyleController = this.layoutControl1;
            this.xsbCancel.TabIndex = 10;
            this.xsbCancel.Text = "取消";
            this.xsbCancel.Click += new System.EventHandler(this.xsbCancel_Click);
            // 
            // xlueSendLogTrigger
            // 
            this.xlueSendLogTrigger.Location = new System.Drawing.Point(111, 158);
            this.xlueSendLogTrigger.Name = "xlueSendLogTrigger";
            this.xlueSendLogTrigger.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xlueSendLogTrigger.Size = new System.Drawing.Size(497, 20);
            this.xlueSendLogTrigger.StyleController = this.layoutControl1;
            this.xlueSendLogTrigger.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(476, 387);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 14);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "多个邮箱之间用分号分隔";
            // 
            // xmemoReceiveEmail
            // 
            this.xmemoReceiveEmail.Location = new System.Drawing.Point(111, 182);
            this.xmemoReceiveEmail.Name = "xmemoReceiveEmail";
            this.xmemoReceiveEmail.Size = new System.Drawing.Size(497, 201);
            this.xmemoReceiveEmail.StyleController = this.layoutControl1;
            this.xmemoReceiveEmail.TabIndex = 1;
            // 
            // xteSendPassword
            // 
            this.xteSendPassword.Location = new System.Drawing.Point(405, 134);
            this.xteSendPassword.Name = "xteSendPassword";
            this.xteSendPassword.Size = new System.Drawing.Size(203, 20);
            this.xteSendPassword.StyleController = this.layoutControl1;
            this.xteSendPassword.TabIndex = 8;
            // 
            // xteSendUser
            // 
            this.xteSendUser.Location = new System.Drawing.Point(111, 134);
            this.xteSendUser.Name = "xteSendUser";
            this.xteSendUser.Size = new System.Drawing.Size(203, 20);
            this.xteSendUser.StyleController = this.layoutControl1;
            this.xteSendUser.TabIndex = 7;
            // 
            // xteSendServer
            // 
            this.xteSendServer.Location = new System.Drawing.Point(405, 110);
            this.xteSendServer.Name = "xteSendServer";
            this.xteSendServer.Size = new System.Drawing.Size(203, 20);
            this.xteSendServer.StyleController = this.layoutControl1;
            this.xteSendServer.TabIndex = 6;
            // 
            // xteSendEmail
            // 
            this.xteSendEmail.Location = new System.Drawing.Point(111, 110);
            this.xteSendEmail.Name = "xteSendEmail";
            this.xteSendEmail.Size = new System.Drawing.Size(203, 20);
            this.xteSendEmail.StyleController = this.layoutControl1;
            this.xteSendEmail.TabIndex = 1;
            // 
            // xteBeginTime
            // 
            this.xteBeginTime.EditValue = new System.DateTime(2017, 3, 3, 0, 0, 0, 0);
            this.xteBeginTime.Location = new System.Drawing.Point(405, 43);
            this.xteBeginTime.Name = "xteBeginTime";
            this.xteBeginTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xteBeginTime.Properties.Mask.EditMask = "HH:mm";
            this.xteBeginTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.xteBeginTime.Size = new System.Drawing.Size(203, 20);
            this.xteBeginTime.StyleController = this.layoutControl1;
            this.xteBeginTime.TabIndex = 5;
            // 
            // xseDayInterval
            // 
            this.xseDayInterval.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xseDayInterval.Location = new System.Drawing.Point(111, 43);
            this.xseDayInterval.Name = "xseDayInterval";
            this.xseDayInterval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xseDayInterval.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xseDayInterval.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xseDayInterval.Size = new System.Drawing.Size(203, 20);
            this.xseDayInterval.StyleController = this.layoutControl1;
            this.xseDayInterval.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem10,
            this.emptySpaceItem3,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(632, 451);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(612, 67);
            this.layoutControlGroup2.Text = "回写周期配置";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xseDayInterval;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(294, 24);
            this.layoutControlItem1.Text = "回写间隔天数：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.xteBeginTime;
            this.layoutControlItem3.Location = new System.Drawing.Point(294, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(294, 24);
            this.layoutControlItem3.Text = "回写开始时间：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem2,
            this.layoutControlItem9});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 67);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(612, 338);
            this.layoutControlGroup3.Text = "发送日志配置";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.xteSendUser;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(294, 24);
            this.layoutControlItem5.Text = "用户名：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xteSendEmail;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(294, 24);
            this.layoutControlItem2.Text = "发送邮箱：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.xteSendServer;
            this.layoutControlItem4.Location = new System.Drawing.Point(294, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(294, 24);
            this.layoutControlItem4.Text = "发送服务器：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.xteSendPassword;
            this.layoutControlItem6.Location = new System.Drawing.Point(294, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(294, 24);
            this.layoutControlItem6.Text = "密码：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.xmemoReceiveEmail;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(588, 205);
            this.layoutControlItem7.Text = "收件邮箱：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.labelControl1;
            this.layoutControlItem8.Location = new System.Drawing.Point(452, 277);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(136, 18);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 277);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(452, 18);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.xlueSendLogTrigger;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(588, 24);
            this.layoutControlItem9.Text = "发送级别：";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(84, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.xsbCancel;
            this.layoutControlItem10.Location = new System.Drawing.Point(520, 405);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(92, 26);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(92, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 405);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(429, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.xsbSave;
            this.layoutControlItem11.Location = new System.Drawing.Point(429, 405);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(91, 26);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(91, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(91, 26);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // XFrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 451);
            this.Controls.Add(this.layoutControl1);
            this.Name = "XFrmConfig";
            this.Text = "回写配置";
            this.Load += new System.EventHandler(this.XFrmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xlueSendLogTrigger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmemoReceiveEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteSendEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteBeginTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xseDayInterval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SpinEdit xseDayInterval;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TimeEdit xteBeginTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit xteSendPassword;
        private DevExpress.XtraEditors.TextEdit xteSendUser;
        private DevExpress.XtraEditors.TextEdit xteSendServer;
        private DevExpress.XtraEditors.TextEdit xteSendEmail;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.MemoEdit xmemoReceiveEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.LookUpEdit xlueSendLogTrigger;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton xsbSave;
        private DevExpress.XtraEditors.SimpleButton xsbCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
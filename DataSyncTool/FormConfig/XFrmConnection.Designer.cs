namespace DataSyncTool.FormConfig
{
    partial class XFrmConnection
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
            this.xsbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.xsbTestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.xsbSave = new DevExpress.XtraEditors.SimpleButton();
            this.xteIPSPAddress = new DevExpress.XtraEditors.TextEdit();
            this.xteIPSPUser = new DevExpress.XtraEditors.TextEdit();
            this.xteIPSPPassword = new DevExpress.XtraEditors.TextEdit();
            this.xteIPSPDatabase = new DevExpress.XtraEditors.TextEdit();
            this.xtePCPassword = new DevExpress.XtraEditors.TextEdit();
            this.xtePCUser = new DevExpress.XtraEditors.TextEdit();
            this.xtePCAddress = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtePCPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtePCUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtePCAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xsbCancel);
            this.layoutControl1.Controls.Add(this.xsbTestConnection);
            this.layoutControl1.Controls.Add(this.xsbSave);
            this.layoutControl1.Controls.Add(this.xteIPSPAddress);
            this.layoutControl1.Controls.Add(this.xteIPSPUser);
            this.layoutControl1.Controls.Add(this.xteIPSPPassword);
            this.layoutControl1.Controls.Add(this.xteIPSPDatabase);
            this.layoutControl1.Controls.Add(this.xtePCPassword);
            this.layoutControl1.Controls.Add(this.xtePCUser);
            this.layoutControl1.Controls.Add(this.xtePCAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(439, 253);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xsbCancel
            // 
            this.xsbCancel.Location = new System.Drawing.Point(350, 218);
            this.xsbCancel.Name = "xsbCancel";
            this.xsbCancel.Size = new System.Drawing.Size(77, 22);
            this.xsbCancel.StyleController = this.layoutControl1;
            this.xsbCancel.TabIndex = 12;
            this.xsbCancel.Text = "取消";
            this.xsbCancel.Click += new System.EventHandler(this.xsbCancel_Click);
            // 
            // xsbTestConnection
            // 
            this.xsbTestConnection.Location = new System.Drawing.Point(12, 218);
            this.xsbTestConnection.Name = "xsbTestConnection";
            this.xsbTestConnection.Size = new System.Drawing.Size(77, 22);
            this.xsbTestConnection.StyleController = this.layoutControl1;
            this.xsbTestConnection.TabIndex = 11;
            this.xsbTestConnection.Text = "测试连接";
            this.xsbTestConnection.Click += new System.EventHandler(this.xsbTestConnection_Click);
            // 
            // xsbSave
            // 
            this.xsbSave.Location = new System.Drawing.Point(269, 218);
            this.xsbSave.Name = "xsbSave";
            this.xsbSave.Size = new System.Drawing.Size(77, 22);
            this.xsbSave.StyleController = this.layoutControl1;
            this.xsbSave.TabIndex = 1;
            this.xsbSave.Text = "保存";
            this.xsbSave.Click += new System.EventHandler(this.xsbSave_Click);
            // 
            // xteIPSPAddress
            // 
            this.xteIPSPAddress.Location = new System.Drawing.Point(99, 134);
            this.xteIPSPAddress.Name = "xteIPSPAddress";
            this.xteIPSPAddress.Size = new System.Drawing.Size(316, 20);
            this.xteIPSPAddress.StyleController = this.layoutControl1;
            this.xteIPSPAddress.TabIndex = 10;
            // 
            // xteIPSPUser
            // 
            this.xteIPSPUser.Location = new System.Drawing.Point(99, 158);
            this.xteIPSPUser.Name = "xteIPSPUser";
            this.xteIPSPUser.Size = new System.Drawing.Size(119, 20);
            this.xteIPSPUser.StyleController = this.layoutControl1;
            this.xteIPSPUser.TabIndex = 9;
            // 
            // xteIPSPPassword
            // 
            this.xteIPSPPassword.Location = new System.Drawing.Point(297, 158);
            this.xteIPSPPassword.Name = "xteIPSPPassword";
            this.xteIPSPPassword.Size = new System.Drawing.Size(118, 20);
            this.xteIPSPPassword.StyleController = this.layoutControl1;
            this.xteIPSPPassword.TabIndex = 8;
            // 
            // xteIPSPDatabase
            // 
            this.xteIPSPDatabase.Location = new System.Drawing.Point(99, 182);
            this.xteIPSPDatabase.Name = "xteIPSPDatabase";
            this.xteIPSPDatabase.Size = new System.Drawing.Size(316, 20);
            this.xteIPSPDatabase.StyleController = this.layoutControl1;
            this.xteIPSPDatabase.TabIndex = 7;
            // 
            // xtePCPassword
            // 
            this.xtePCPassword.Location = new System.Drawing.Point(297, 67);
            this.xtePCPassword.Name = "xtePCPassword";
            this.xtePCPassword.Size = new System.Drawing.Size(118, 20);
            this.xtePCPassword.StyleController = this.layoutControl1;
            this.xtePCPassword.TabIndex = 5;
            // 
            // xtePCUser
            // 
            this.xtePCUser.Location = new System.Drawing.Point(99, 67);
            this.xtePCUser.Name = "xtePCUser";
            this.xtePCUser.Size = new System.Drawing.Size(119, 20);
            this.xtePCUser.StyleController = this.layoutControl1;
            this.xtePCUser.TabIndex = 4;
            // 
            // xtePCAddress
            // 
            this.xtePCAddress.Location = new System.Drawing.Point(99, 43);
            this.xtePCAddress.Name = "xtePCAddress";
            this.xtePCAddress.Size = new System.Drawing.Size(316, 20);
            this.xtePCAddress.StyleController = this.layoutControl1;
            this.xtePCAddress.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(439, 253);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(419, 91);
            this.layoutControlGroup2.Text = "PatentCase 数据连接";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xtePCUser;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(198, 24);
            this.layoutControlItem2.Text = "用户名：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtePCAddress;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem1.Text = "数据库地址：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.xtePCPassword;
            this.layoutControlItem3.Location = new System.Drawing.Point(198, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(197, 24);
            this.layoutControlItem3.Text = "密码：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem7});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 91);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(419, 115);
            this.layoutControlGroup3.Text = "IPSpacePlus 数据连接";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.xteIPSPAddress;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem5.Text = "数据库地址：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.xteIPSPUser;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(198, 24);
            this.layoutControlItem6.Text = "用户名：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.xteIPSPDatabase;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem8.Text = "数据库名称：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.xteIPSPPassword;
            this.layoutControlItem7.Location = new System.Drawing.Point(198, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(197, 24);
            this.layoutControlItem7.Text = "密码：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.xsbSave;
            this.layoutControlItem9.Location = new System.Drawing.Point(257, 206);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(81, 27);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.xsbTestConnection;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 206);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(81, 27);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.xsbCancel;
            this.layoutControlItem11.Location = new System.Drawing.Point(338, 206);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(81, 27);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(81, 206);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(176, 27);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // XFrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 253);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XFrmConnection";
            this.Text = "连接配置";
            this.Load += new System.EventHandler(this.XFrmConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xteIPSPDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtePCPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtePCUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtePCAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit xtePCPassword;
        private DevExpress.XtraEditors.TextEdit xtePCUser;
        private DevExpress.XtraEditors.TextEdit xtePCAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit xteIPSPAddress;
        private DevExpress.XtraEditors.TextEdit xteIPSPUser;
        private DevExpress.XtraEditors.TextEdit xteIPSPPassword;
        private DevExpress.XtraEditors.TextEdit xteIPSPDatabase;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton xsbCancel;
        private DevExpress.XtraEditors.SimpleButton xsbTestConnection;
        private DevExpress.XtraEditors.SimpleButton xsbSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
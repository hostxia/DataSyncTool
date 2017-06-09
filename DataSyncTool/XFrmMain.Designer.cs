namespace DataSyncTool
{
    partial class XFrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmMain));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xgridResult = new DevExpress.XtraGrid.GridControl();
            this.xgvResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riicbInfoType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.icInfoType = new DevExpress.Utils.ImageCollection(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xdeNextBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.xbbiConnectionConfig = new DevExpress.XtraBars.BarButtonItem();
            this.xbiCommonConfig = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xdeFinishDate = new DevExpress.XtraEditors.DateEdit();
            this.xdeBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.xsbSync = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xgridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riicbInfoType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icInfoType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeNextBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeNextBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeFinishDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeFinishDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xgridResult);
            this.layoutControl1.Controls.Add(this.xdeNextBeginDate);
            this.layoutControl1.Controls.Add(this.xdeFinishDate);
            this.layoutControl1.Controls.Add(this.xdeBeginDate);
            this.layoutControl1.Controls.Add(this.xsbSync);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(950, 612);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xgridResult
            // 
            this.xgridResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.xgridResult.Location = new System.Drawing.Point(24, 69);
            this.xgridResult.MainView = this.xgvResult;
            this.xgridResult.Name = "xgridResult";
            this.xgridResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riicbInfoType});
            this.xgridResult.Size = new System.Drawing.Size(902, 519);
            this.xgridResult.TabIndex = 5;
            this.xgridResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xgvResult});
            // 
            // xgvResult
            // 
            this.xgvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn8});
            this.xgvResult.GridControl = this.xgridResult;
            this.xgvResult.Name = "xgvResult";
            this.xgvResult.OptionsBehavior.Editable = false;
            this.xgvResult.OptionsSelection.MultiSelect = true;
            this.xgvResult.OptionsView.ColumnAutoWidth = false;
            this.xgvResult.OptionsView.ShowAutoFilterRow = true;
            this.xgvResult.OptionsView.ShowFooter = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "时间";
            this.gridColumn5.DisplayFormat.FormatString = "yyyy/MM/dd hh:mm:ss";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "CreateTime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CreateTime", "{0}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 137;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "类型";
            this.gridColumn1.ColumnEdit = this.riicbInfoType;
            this.gridColumn1.FieldName = "InfoTypeString";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 60;
            // 
            // riicbInfoType
            // 
            this.riicbInfoType.AutoHeight = false;
            this.riicbInfoType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riicbInfoType.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.riicbInfoType.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("错误", "Error", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("警告", "Warning", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("信息", "Info", 2)});
            this.riicbInfoType.Name = "riicbInfoType";
            this.riicbInfoType.SmallImages = this.icInfoType;
            // 
            // icInfoType
            // 
            this.icInfoType.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icInfoType.ImageStream")));
            this.icInfoType.InsertGalleryImage("error_16x16.png", "images/status/error_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/status/error_16x16.png"), 0);
            this.icInfoType.Images.SetKeyName(0, "error_16x16.png");
            this.icInfoType.InsertGalleryImage("warning_16x16.png", "images/status/warning_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/status/warning_16x16.png"), 1);
            this.icInfoType.Images.SetKeyName(1, "warning_16x16.png");
            this.icInfoType.InsertGalleryImage("equalto_16x16.png", "images/conditional%20formatting/equalto_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/equalto_16x16.png"), 2);
            this.icInfoType.Images.SetKeyName(2, "equalto_16x16.png");
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "源数据表";
            this.gridColumn2.FieldName = "Source";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 133;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "目标数据表";
            this.gridColumn3.FieldName = "Target";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 229;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "消息";
            this.gridColumn4.FieldName = "Content";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 316;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "相关信息";
            this.gridColumn8.FieldName = "Note";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 241;
            // 
            // xdeNextBeginDate
            // 
            this.xdeNextBeginDate.EditValue = new System.DateTime(2017, 2, 9, 9, 41, 36, 0);
            this.xdeNextBeginDate.Location = new System.Drawing.Point(587, 12);
            this.xdeNextBeginDate.MenuManager = this.barManager1;
            this.xdeNextBeginDate.Name = "xdeNextBeginDate";
            this.xdeNextBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xdeNextBeginDate.Properties.DisplayFormat.FormatString = "G";
            this.xdeNextBeginDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xdeNextBeginDate.Properties.EditFormat.FormatString = "G";
            this.xdeNextBeginDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xdeNextBeginDate.Properties.Mask.EditMask = "G";
            this.xdeNextBeginDate.Properties.ReadOnly = true;
            this.xdeNextBeginDate.Size = new System.Drawing.Size(117, 20);
            this.xdeNextBeginDate.StyleController = this.layoutControl1;
            this.xdeNextBeginDate.TabIndex = 8;
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.CloseButtonAffectAllTabs = false;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.xbbiConnectionConfig,
            this.xbiCommonConfig});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.xbbiConnectionConfig),
            new DevExpress.XtraBars.LinkPersistInfo(this.xbiCommonConfig)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // xbbiConnectionConfig
            // 
            this.xbbiConnectionConfig.Caption = "连接配置";
            this.xbbiConnectionConfig.Id = 0;
            this.xbbiConnectionConfig.Name = "xbbiConnectionConfig";
            this.xbbiConnectionConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.xbbiConnectionConfig_ItemClick);
            // 
            // xbiCommonConfig
            // 
            this.xbiCommonConfig.Caption = "全局配置";
            this.xbiCommonConfig.Id = 1;
            this.xbiCommonConfig.Name = "xbiCommonConfig";
            this.xbiCommonConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.xbiCommonConfig_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(950, 21);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 633);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(950, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 21);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 612);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(950, 21);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 612);
            // 
            // xdeFinishDate
            // 
            this.xdeFinishDate.EditValue = new System.DateTime(2017, 2, 9, 9, 41, 36, 0);
            this.xdeFinishDate.Location = new System.Drawing.Point(355, 12);
            this.xdeFinishDate.MenuManager = this.barManager1;
            this.xdeFinishDate.Name = "xdeFinishDate";
            this.xdeFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xdeFinishDate.Properties.DisplayFormat.FormatString = "G";
            this.xdeFinishDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xdeFinishDate.Properties.EditFormat.FormatString = "G";
            this.xdeFinishDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xdeFinishDate.Properties.Mask.EditMask = "G";
            this.xdeFinishDate.Properties.ReadOnly = true;
            this.xdeFinishDate.Size = new System.Drawing.Size(117, 20);
            this.xdeFinishDate.StyleController = this.layoutControl1;
            this.xdeFinishDate.TabIndex = 7;
            // 
            // xdeBeginDate
            // 
            this.xdeBeginDate.EditValue = new System.DateTime(2017, 2, 9, 9, 41, 36, 0);
            this.xdeBeginDate.Location = new System.Drawing.Point(123, 12);
            this.xdeBeginDate.MenuManager = this.barManager1;
            this.xdeBeginDate.Name = "xdeBeginDate";
            this.xdeBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xdeBeginDate.Properties.DisplayFormat.FormatString = "G";
            this.xdeBeginDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xdeBeginDate.Properties.EditFormat.FormatString = "G";
            this.xdeBeginDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.xdeBeginDate.Properties.Mask.EditMask = "G";
            this.xdeBeginDate.Properties.ReadOnly = true;
            this.xdeBeginDate.Size = new System.Drawing.Size(117, 20);
            this.xdeBeginDate.StyleController = this.layoutControl1;
            this.xdeBeginDate.TabIndex = 6;
            // 
            // xsbSync
            // 
            this.xsbSync.Location = new System.Drawing.Point(708, 12);
            this.xsbSync.Name = "xsbSync";
            this.xsbSync.Size = new System.Drawing.Size(230, 22);
            this.xsbSync.StyleController = this.layoutControl1;
            this.xsbSync.TabIndex = 5;
            this.xsbSync.Text = "立即回写";
            this.xsbSync.Click += new System.EventHandler(this.xsbSync_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(950, 612);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(930, 566);
            this.layoutControlGroup2.Text = "同步信息";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xgridResult;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(906, 523);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.xdeBeginDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(232, 26);
            this.layoutControlItem4.Text = "上次开始同步时间：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.xdeNextBeginDate;
            this.layoutControlItem6.Location = new System.Drawing.Point(464, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(232, 26);
            this.layoutControlItem6.Text = "下次同步开始时间：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(108, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.xdeFinishDate;
            this.layoutControlItem5.Location = new System.Drawing.Point(232, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(232, 26);
            this.layoutControlItem5.Text = "上次同步结束时间：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xsbSync;
            this.layoutControlItem2.Location = new System.Drawing.Point(696, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(234, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "数据回写工具";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // XFrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 633);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmMain";
            this.Text = "数据回写工具";
            this.Load += new System.EventHandler(this.XFrmMain_Load);
            this.SizeChanged += new System.EventHandler(this.XFrmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xgridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riicbInfoType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icInfoType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeNextBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeNextBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeFinishDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeFinishDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdeBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem xbbiConnectionConfig;
        private DevExpress.XtraBars.BarButtonItem xbiCommonConfig;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton xsbSync;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit xdeBeginDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit xdeFinishDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DateEdit xdeNextBeginDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl xgridResult;
        private DevExpress.XtraGrid.Views.Grid.GridView xgvResult;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox riicbInfoType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.ImageCollection icInfoType;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}


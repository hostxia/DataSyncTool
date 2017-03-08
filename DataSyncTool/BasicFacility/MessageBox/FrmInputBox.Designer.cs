namespace BasicFacility.MessageBox
{
    partial class FrmInputBox
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tbText = new DevExpress.XtraEditors.TextEdit();
            this.lbText = new System.Windows.Forms.Label();
            this.radioGroupPower = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.tbText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupPower.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Appearance.Font = new System.Drawing.Font("NSimSun", 9F);
            this.btOK.Appearance.Options.UseFont = true;
            this.btOK.Location = new System.Drawing.Point(239, 66);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "确定(&O)";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Appearance.Font = new System.Drawing.Font("NSimSun", 9F);
            this.btCancel.Appearance.Options.UseFont = true;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(320, 66);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消(&C)";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(12, 34);
            this.tbText.Name = "tbText";
            this.tbText.Properties.MaxLength = 100;
            this.tbText.Size = new System.Drawing.Size(383, 21);
            this.tbText.TabIndex = 1;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(12, 9);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(65, 12);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "请输入文字";
            // 
            // radioGroupPower
            // 
            this.radioGroupPower.Location = new System.Drawing.Point(12, 65);
            this.radioGroupPower.Name = "radioGroupPower";
            this.radioGroupPower.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupPower.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupPower.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupPower.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}), "公开"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            1,
                            0,
                            0,
                            0}), "只有我")});
            this.radioGroupPower.Properties.LookAndFeel.SkinName = "PatentStar";
            this.radioGroupPower.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radioGroupPower.Size = new System.Drawing.Size(143, 28);
            this.radioGroupPower.TabIndex = 4;
            this.radioGroupPower.Visible = false;
            // 
            // FrmInputBox
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(407, 101);
            this.ControlBox = false;
            this.Controls.Add(this.radioGroupPower);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Space输入框";
            ((System.ComponentModel.ISupportInitialize)(this.tbText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupPower.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        public DevExpress.XtraEditors.TextEdit tbText;
        public System.Windows.Forms.Label lbText;
        public DevExpress.XtraEditors.RadioGroup radioGroupPower;
    }
}
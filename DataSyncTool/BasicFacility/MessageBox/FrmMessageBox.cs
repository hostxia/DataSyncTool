using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using DevExpress.XtraEditors;
namespace BasicFacility.MessageBox
{
	class FrmMessageBox : XtraForm
	{
		#region [API声明]
		[DllImport("user32.dll", EntryPoint="SetWindowRgn")]
		public static extern int SetWindowRgn (
			IntPtr hWnd,
			int hRgn,
			int bRedraw
			);
		
		[DllImport("gdi32.dll", EntryPoint="CreateRoundRectRgn")]
		public static extern int CreateRoundRectRgn (
			int X1,
			int Y1,
			int X2,
			int Y2,
			int X3,
			int Y3
			);
		#endregion

		#region [字段]
		private Point mouse_offset;//鼠标位移
		#endregion

		#region [窗体控件]

        private System.Windows.Forms.Panel panelPics;
		private System.Windows.Forms.PictureBox picQuestion;
		private System.Windows.Forms.PictureBox picError;
		private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox picRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRetry;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private PictureBox picNote;
        private Label lbNote;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region [构造函数]
		public FrmMessageBox()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBox));
            this.panelPics = new System.Windows.Forms.Panel();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picError = new System.Windows.Forms.PictureBox();
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRetry = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.picNote = new System.Windows.Forms.PictureBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.panelPics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPics
            // 
            resources.ApplyResources(this.panelPics, "panelPics");
            this.panelPics.Controls.Add(this.picRight);
            this.panelPics.Controls.Add(this.picError);
            this.panelPics.Controls.Add(this.picQuestion);
            this.panelPics.Controls.Add(this.picInfo);
            this.panelPics.Name = "panelPics";
            // 
            // picRight
            // 
            resources.ApplyResources(this.picRight, "picRight");
            this.picRight.Image = global::BasicFacility.Properties.ResourceImage.Info;
            this.picRight.Name = "picRight";
            this.picRight.TabStop = false;
            // 
            // picError
            // 
            resources.ApplyResources(this.picError, "picError");
            this.picError.Image = global::BasicFacility.Properties.ResourceImage.Error;
            this.picError.Name = "picError";
            this.picError.TabStop = false;
            // 
            // picQuestion
            // 
            resources.ApplyResources(this.picQuestion, "picQuestion");
            this.picQuestion.Image = global::BasicFacility.Properties.ResourceImage.Question;
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.TabStop = false;
            // 
            // picInfo
            // 
            resources.ApplyResources(this.picInfo, "picInfo");
            this.picInfo.Image = global::BasicFacility.Properties.ResourceImage.Info;
            this.picInfo.Name = "picInfo";
            this.picInfo.TabStop = false;
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnRetry);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnNo);
            this.panelControl1.Controls.Add(this.btnYes);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Controls.Add(this.picNote);
            this.panelControl1.Controls.Add(this.lbNote);
            this.panelControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl1.Name = "panelControl1";
            // 
            // btnRetry
            // 
            resources.ApplyResources(this.btnRetry, "btnRetry");
            this.btnRetry.Appearance.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.Appearance.Options.UseFont = true;
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Appearance.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNo
            // 
            resources.ApplyResources(this.btnNo, "btnNo");
            this.btnNo.Appearance.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.Name = "btnNo";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            resources.ApplyResources(this.btnYes, "btnYes");
            this.btnYes.Appearance.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.Name = "btnYes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Appearance.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // picNote
            // 
            resources.ApplyResources(this.picNote, "picNote");
            this.picNote.Image = global::BasicFacility.Properties.ResourceImage.Info;
            this.picNote.Name = "picNote";
            this.picNote.TabStop = false;
            // 
            // lbNote
            // 
            resources.ApplyResources(this.lbNote, "lbNote");
            this.lbNote.Name = "lbNote";
            // 
            // FrmMessageBox
            // 
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.panelPics);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmMessageBox_Load);
            this.panelPics.ResumeLayout(false);
            this.panelPics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNote)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region [方法]
		public int SetWindowToRoundRect(IntPtr WHandle,			
			int X1,
			int Y1,
			int X2,
			int Y2,
			int X3,
			int Y3)
		{
			int tmprgn = CreateRoundRectRgn(X1,Y1,X2,Y2,X3,Y3);
			return SetWindowRgn(WHandle,tmprgn,1);
		}

        ///#################################################################################
        /// <summary>
        /// 专利\提案提示
        /// </summary>
        /// <param name="Message"></param>
        ///#################################################################################
        public void ShowMessageBox(int temp,string Text)
        {
            this.lbNote.Visible = true;
            this.lbNote.Text = Text;
            this.lbNote.Left = this.picNote .Right +5;
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.picNote.Visible = true ;
            this.picNote.Image = this.picQuestion.Image;

            this.btnYes.Text = Properties.Resource.MessageBox_Text_Skip_All;
            this.btnYes.Visible = true;

            this.btnNo.Text = Properties.Resource.MessageBox_Text_Override;
            this.btnNo.Visible = true;

            this.btnOK.Text = Properties.Resource.MessageBox_Text_Skip;
            this.btnOK.Visible = true;
            //this.btnOK.Left = (this.Width - btnOK.Width) / 2;

            this.btnCancel.Text = Properties.Resource.MessageBox_Text_Override_All;
            this.btnCancel.Visible = true;

            this.btnRetry.Text = Properties.Resource.MessageBox_Text_Import_Addtional;
            this.btnRetry.Visible = true;
            
        }
        /// <summary>
        /// 专利\提案提示
        /// </summary>
        /// <param name="Text"></param>
        public void ShowMessageBox(int temp, int tmp, int itemp, string Text)
        {
            this.lbNote.Visible = true;
            this.lbNote.Text = Text;
            this.lbNote.Left = this.picNote.Right + 5;
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.picNote.Visible = true;
            this.picNote.Image = this.picQuestion.Image;

            this.btnYes.Text = Properties.Resource.MessageBox_Text_Skip_All;
            this.btnYes.Visible = true;

            this.btnNo.Text = Properties.Resource.MessageBox_Text_Skip;
            this.btnNo.Visible = true;


            this.btnOK.Visible = false;

            this.btnCancel.Text = Properties.Resource.MessageBox_Text_Override;
            this.btnCancel.Visible = true;

            this.btnRetry.Text = Properties.Resource.MessageBox_Text_Override_All;
            this.btnRetry.Visible = true;
        }

        ///#################################################################################
        /// <summary>
        /// 专利年费导入产生重复提示
        /// </summary>
        /// <param name="Message"></param>
        ///#################################################################################
        public void ShowMessageBox(int temp,int tmp, string Text)
        {
            this.lbNote.Visible = true;
            this.lbNote.Text = Text;
            this.lbNote.Left = this.picNote.Right + 5;
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.picNote.Visible = true;
            this.picNote.Image = this.picQuestion.Image;

            this.btnYes.Text = Properties.Resource.MessageBox_Text_Skip_All;
            this.btnYes.Visible = true;

            this.btnNo.Text = Properties.Resource.MessageBox_Text_Skip;
            this.btnNo.Visible = true;


            this.btnOK.Visible = false;
            //this.btnOK.Left = (this.Width - btnOK.Width) / 2;

            this.btnCancel.Text = Properties.Resource.MessageBox_Text_Delete;
            this.btnCancel.Visible = true;

            this.btnRetry.Text = Properties.Resource.MessageBox_Text_Delete_All;
            this.btnRetry.Visible = true;

        }
        ///#################################################################################
		/// <summary>
		/// 文字、确认按钮
		/// </summary>
		/// <param name="Message"></param>
        ///#################################################################################
		public void ShowMessageBox(string Text)
		{
			this.lbNote.Text = Text;
			this.lbNote.Left = (this.Width - this.lbNote.Width)/2;
			this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.picNote.Visible = false;
			this.btnYes.Visible = false;
			this.btnNo.Visible = false;
			this.btnCancel.Visible = false;
            this.btnOK.Visible = true;
			this.btnOK.Left = (this.Width - btnOK.Width)/2;
		}
        ///#################################################################################
		/// <summary>
		/// 文字、标题、确认按钮
		/// </summary>
		/// <param name="Message"></param>
        ///#################################################################################
		public void ShowMessageBox(string Text,string Caption)
		{
            //this.lbTitle.Text = Caption;
            this.Text = Caption;
			this.lbNote.Text = Text;
			this.lbNote.Left = (this.Width - this.lbNote.Width)/2;
			this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.picNote.Visible = false;
			this.btnYes.Visible = false;
			this.btnNo.Visible = false;
			this.btnCancel.Visible = false;
            this.btnOK.Visible = true;
			this.btnOK.Left = (this.Width - btnOK.Width)/2;
		}
        ///#################################################################################
        /// <summary>
		/// 文字、标题、各种按钮
		/// </summary>
		/// <param name="Message"></param>
        ///#################################################################################
		public void ShowMessageBox(string Text,string Caption, MessageBoxButtons buttons)
		{
            //this.lbTitle.Text = Caption;
            this.Text = Caption;
			this.lbNote.Text = Text;
			this.lbNote.Left = this.picNote.Left + picNote.Width + 10;
			this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			switch(buttons)
			{
				case MessageBoxButtons.YesNo:
				{
					this.picNote.Image = this.picQuestion.Image;
					this.picNote.Visible = true;
					this.btnYes.Visible = true;
					this.btnNo.Visible = true;
					this.btnCancel.Visible = false;
					this.btnOK.Visible = false;
					this.btnYes.Left = this.Width / 2 - btnYes.Width - 20;
					this.btnNo.Left = this.Width / 2 + 20;
					break;
				}
				case MessageBoxButtons.YesNoCancel:
				{
					this.picNote.Image = this.picQuestion.Image;
					this.picNote.Visible = true;
					this.btnYes.Visible = true;
					this.btnNo.Visible = true;
					this.btnCancel.Visible = true;
					this.btnOK.Visible = false;
					this.btnNo.Left = this.Width / 2 - btnNo.Width / 2;
					this.btnYes.Left = this.btnNo.Left - btnYes.Width - 20;
					this.btnCancel.Left = this.btnNo.Right + 20;
					break;
				}
			}
		}
        ///#################################################################################
        /// <summary>
        /// 文字、各种按钮、图形
        /// </summary>
        /// <param name="Message"></param>
        ///#################################################################################
        public void ShowMessageBox(string Text, MessageBoxButtons buttons, MessageBoxIconEnum icon)
        {
            //this.lbTitle.Text = "BizPatent Star";
            this.Text = "IP Space";
            this.lbNote.Text = Text;
            this.lbNote.Left = this.picNote.Left + picNote.Width + 10;
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picNote.Visible = true;
            switch (icon)
            {
                case MessageBoxIconEnum.Error:
                    {
                        this.picNote.Image = this.picError.Image;
                        break;
                    }
                case MessageBoxIconEnum.Question:
                    {
                        this.picNote.Image = this.picQuestion.Image;
                        break;
                    }
                case MessageBoxIconEnum.Right:
                    {
                        this.picNote.Image = this.picRight.Image;
                        break;
                    }
                case MessageBoxIconEnum.Warning:
                    {
                        this.picNote.Image = this.picInfo.Image;
                        break;
                    }
            }
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    {
                        this.btnYes.Visible = false;
                        this.btnNo.Visible = false;
                        this.btnCancel.Visible = false;
                        this.btnOK.Visible = true;
                        this.btnOK.Left = (this.Width - btnOK.Width) / 2;
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        this.btnYes.Visible = true;
                        this.btnNo.Visible = true;
                        this.btnCancel.Visible = false;
                        this.btnOK.Visible = false;
                        this.btnYes.Left = this.Width / 2 - btnYes.Width - 20;
                        this.btnNo.Left = this.Width / 2 + 20;
                        break;
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        this.btnYes.Visible = true;
                        this.btnNo.Visible = true;
                        this.btnCancel.Visible = true;
                        this.btnOK.Visible = false;
                        this.btnNo.Left = this.Width / 2 - btnNo.Width / 2;
                        this.btnYes.Left = this.btnNo.Left - btnYes.Width - 20;
                        this.btnCancel.Left = this.btnNo.Right + 20;
                        break;
                    }
                case MessageBoxButtons.OKCancel:
                    {
                        this.btnYes.Visible = false;
                        this.btnNo.Visible = false;
                        this.btnCancel.Visible = true;
                        this.btnOK.Visible = true;
                        this.btnOK.Left = this.Width / 2 - btnOK.Width - 20;
                        this.btnCancel.Left = this.Width / 2 + 20;
                        break;
                    }
                case MessageBoxButtons.RetryCancel:
                    {
                        this.btnRetry.Visible = true;
                        this.btnYes.Visible = false;
                        this.btnNo.Visible = false;
                        this.btnCancel.Visible = true;
                        this.btnOK.Visible = false;
                        this.btnRetry.Left = this.Width / 2 - btnRetry.Width - 20;
                        this.btnCancel.Left = this.Width / 2 + 20;
                        break;
                    }
            }
        }
        ///#################################################################################
        /// <summary>
        /// 文字、各种按钮、图形
        /// </summary>
        /// <param name="Message"></param>
        public void ShowMessageBox(string Text, MessageBoxButtons buttons, PTMessageBoxIcon icon)
        {
            //this.lbTitle.Text = "";
            this.Text = "IP Space";
            this.lbNote.Text = Text;
            this.lbNote.Left = this.picNote.Left + picNote.Width + 10;
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picNote.Visible = true;
            switch (icon)
            {
                case PTMessageBoxIcon.Error:
                    {
                        this.picNote.Image = this.picError.Image;
                        break;
                    }
                case PTMessageBoxIcon.Question:
                    {
                        this.picNote.Image = this.picQuestion.Image;
                        break;
                    }
                case PTMessageBoxIcon.Right:
                    {
                        this.picNote.Image = this.picRight.Image;
                        break;
                    }
                case PTMessageBoxIcon.Warning:
                    {
                        this.picNote.Image = this.picInfo.Image;
                        break;
                    }
            }
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    {
                        this.btnYes.Visible = false;
                        this.btnNo.Visible = false;
                        this.btnCancel.Visible = false;
                        this.btnOK.Visible = true;
                        this.btnOK.Left = (this.Width - btnOK.Width) / 2;
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        this.btnYes.Visible = true;
                        this.btnNo.Visible = true;
                        this.btnCancel.Visible = false;
                        this.btnOK.Visible = false;
                        this.btnYes.Left = this.Width / 2 - btnYes.Width - 20;
                        this.btnNo.Left = this.Width / 2 + 20;
                        break;
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        this.btnYes.Visible = true;
                        this.btnNo.Visible = true;
                        this.btnCancel.Visible = true;
                        this.btnOK.Visible = false;
                        this.btnNo.Left = this.Width / 2 - btnNo.Width / 2;
                        this.btnYes.Left = this.btnNo.Left - btnYes.Width - 20;
                        this.btnCancel.Left = this.btnNo.Right + 20;
                        break;
                    }
                case MessageBoxButtons.OKCancel:
                    {
                        this.btnYes.Visible = false;
                        this.btnNo.Visible = false;
                        this.btnCancel.Visible = true;
                        this.btnOK.Visible = true;
                        this.btnOK.Left = this.Width / 2 - btnOK.Width - 20;
                        this.btnCancel.Left = this.Width / 2 + 20;
                        break;
                    }
                case MessageBoxButtons.RetryCancel:
                    {
                        this.btnRetry.Visible = true;
                        this.btnYes.Visible = false;
                        this.btnNo.Visible = false;
                        this.btnCancel.Visible = true;
                        this.btnOK.Visible = false;
                        this.btnRetry.Left = this.Width / 2 - btnRetry.Width - 20;
                        this.btnCancel.Left = this.Width / 2 + 20;
                        break;
                    }
            }
        }
		#endregion

		#region [事件]
        ///#################################################################################
		/// <summary>
		/// 载入的时候切割本体为圆角
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        ///#################################################################################
		private void FrmMessageBox_Load(object sender, System.EventArgs e)
		{
			//int tmp = this.SetWindowToRoundRect(this.Handle,0,0,this.Width+1,this.Height+1,25,25);
		}
        ///#################################################################################
		/// <summary>
		/// 确定按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        ///#################################################################################
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
        ///#################################################################################
		/// <summary>
		/// 否定按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        ///#################################################################################
		private void btnNo_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}
        ///#################################################################################
		/// <summary>
		/// 是 按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        ///#################################################################################
		private void btnYes_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
			this.Close();			
		}
        ///#################################################################################
		/// <summary>
		/// 拖动
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        ///#################################################################################
		private void lbTitle_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			mouse_offset = new Point(e.X, e.Y);
		}
        ///#################################################################################
		/// <summary>
		/// 取消按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        ///#################################################################################
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
        ///#################################################################################
        /// <summary>
        /// 重试按钮
        /// Coder: Alex Sun (2007-10-08)
        /// </summary>
        ///#################################################################################
        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
		#endregion

	}
}

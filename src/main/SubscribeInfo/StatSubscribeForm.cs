using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using NetFocus.MagzineSubscribe.Business;


namespace NetFocus.MagzineSubscribe.UI
{
	public class StatSubscribeForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.Label label1;

		private System.ComponentModel.Container components = null;

		public StatSubscribeForm()
		{

			InitializeComponent();

		}

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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(StatSubscribeForm));
			this.lblName = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(16, 32);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(144, 24);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "请输入要统计金额的月份";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(280, 24);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(48, 23);
			this.btnSubmit.TabIndex = 10;
			this.btnSubmit.Text = "确 定";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(168, 24);
			this.txtDate.Name = "txtDate";
			this.txtDate.TabIndex = 0;
			this.txtDate.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "如:2005-8";
			// 
			// StatSubscribeForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(346, 95);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDate);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "StatSubscribeForm";
			this.Text = "统计某月金额";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			DateTime inputDate;
			if(this.txtDate.Text.Trim().Length == 0)
			{
				MessageBox.Show("请输入月份!");
				return;
			}
			try
			{
				inputDate = Convert.ToDateTime(this.txtDate.Text.Trim() + "-1");
				DataTable tbl = SubscribeInfoManager.RetrieveInfoByDateOnly(inputDate);
				MainForm.Form.StatResultTable = tbl;
				MainForm.Form.CurrentInputDate = inputDate;
				
				this.DialogResult = DialogResult.OK;

				this.Close();

			}
			catch (Exception e1)
			{
				if(e1.InnerException != null)
				{
					MessageBox.Show(e1.InnerException.Message);
				}
				else
				{
					MessageBox.Show("无效的日期格式!");
				}
			}


		}

	}
}

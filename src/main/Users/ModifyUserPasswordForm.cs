using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Reflection;
using System.Threading;
using System.Resources;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;

using NetFocus.MagzineSubscribe.Business;
using NetFocus.MagzineSubscribe.Data;
using Crownwood.Magic.Menus;


namespace NetFocus.MagzineSubscribe.UI
{

	public class ModifyUserPasswordForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.TextBox txtOldPassword;
		private System.Windows.Forms.Label lblConfirm;
		private System.Windows.Forms.Label lblNewPassword;
		private System.Windows.Forms.Label lblOldPassword;

		private System.ComponentModel.Container components = null;

		public ModifyUserPasswordForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ModifyUserPasswordForm));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.txtOldPassword = new System.Windows.Forms.TextBox();
			this.lblConfirm = new System.Windows.Forms.Label();
			this.lblNewPassword = new System.Windows.Forms.Label();
			this.lblOldPassword = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(176, 160);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(48, 23);
			this.btnCancel.TabIndex = 23;
			this.btnCancel.Text = "取 消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(72, 160);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(48, 23);
			this.btnSubmit.TabIndex = 22;
			this.btnSubmit.Text = "确 定";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtConfirm
			// 
			this.txtConfirm.Location = new System.Drawing.Point(112, 112);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.PasswordChar = '*';
			this.txtConfirm.Size = new System.Drawing.Size(144, 21);
			this.txtConfirm.TabIndex = 21;
			this.txtConfirm.Text = "";
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(112, 64);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.Size = new System.Drawing.Size(144, 21);
			this.txtNewPassword.TabIndex = 18;
			this.txtNewPassword.Text = "";
			// 
			// txtOldPassword
			// 
			this.txtOldPassword.Location = new System.Drawing.Point(112, 24);
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.PasswordChar = '*';
			this.txtOldPassword.Size = new System.Drawing.Size(144, 21);
			this.txtOldPassword.TabIndex = 17;
			this.txtOldPassword.Text = "";
			// 
			// lblConfirm
			// 
			this.lblConfirm.Location = new System.Drawing.Point(40, 120);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.Size = new System.Drawing.Size(64, 23);
			this.lblConfirm.TabIndex = 20;
			this.lblConfirm.Text = "密码确认";
			// 
			// lblNewPassword
			// 
			this.lblNewPassword.Location = new System.Drawing.Point(40, 72);
			this.lblNewPassword.Name = "lblNewPassword";
			this.lblNewPassword.Size = new System.Drawing.Size(48, 24);
			this.lblNewPassword.TabIndex = 14;
			this.lblNewPassword.Text = "密码";
			// 
			// lblOldPassword
			// 
			this.lblOldPassword.Location = new System.Drawing.Point(40, 32);
			this.lblOldPassword.Name = "lblOldPassword";
			this.lblOldPassword.Size = new System.Drawing.Size(48, 24);
			this.lblOldPassword.TabIndex = 13;
			this.lblOldPassword.Text = "旧密码";
			// 
			// ModifyUserPasswordForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 205);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.txtOldPassword);
			this.Controls.Add(this.lblConfirm);
			this.Controls.Add(this.lblNewPassword);
			this.Controls.Add(this.lblOldPassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ModifyUserPasswordForm";
			this.Text = "ModifyUserPasswordForm";
			this.Load += new System.EventHandler(this.ModifyUserPasswordForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			if(this.txtOldPassword.Text != MainForm.Form.CurrentManager.Password)
			{
				MessageBox.Show("旧密码错误!");
				return;
			}
			if(this.txtNewPassword.Text != this.txtConfirm.Text)
			{
				MessageBox.Show("新密码不一致!");
				return;
			}

			ManagerManager.UpdateManagerPassword(MainForm.Form.CurrentManager.Id,this.txtConfirm.Text);

			this.DialogResult = DialogResult.OK;

			this.Close();

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void ModifyUserPasswordForm_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}

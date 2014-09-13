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

	public class LoginForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtId;

		private System.ComponentModel.Container components = null;

		public LoginForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LoginForm));
			this.lblName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lblName.Location = new System.Drawing.Point(32, 32);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(56, 23);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "用户名";
			// 
			// lblPassword
			// 
			this.lblPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lblPassword.Location = new System.Drawing.Point(32, 80);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 23);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "密  码";
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtId.Location = new System.Drawing.Point(112, 24);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(128, 26);
			this.txtId.TabIndex = 2;
			this.txtId.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtPassword.Location = new System.Drawing.Point(112, 72);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(128, 26);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Text = "";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
			this.btnLogin.Location = new System.Drawing.Point(64, 128);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(56, 24);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "确 定";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
			this.btnCancel.Location = new System.Drawing.Point(160, 128);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(56, 24);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "取 消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(282, 183);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.Text = "用户登陆";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			string id = this.txtId.Text.Trim();
			string password = this.txtPassword.Text.Trim();
			if(id.Length == 0)
			{
				MessageBox.Show("用户名不能为空!");
				return;
			}
			if(password.Length == 0)
			{
				MessageBox.Show("密码不能为空!");
				return;
			}
			try
			{
				if(ManagerManager.ValidateManager(id,password) > 0)
				{
					DataTable tbl = ManagerManager.GetManager(id);
					//创建一个当前的用户
					MainForm.Form.CurrentManager = new Manager();
					MainForm.Form.CurrentManager.Id = id;
					MainForm.Form.CurrentManager.Name = tbl.Rows[0]["name"].ToString();
					MainForm.Form.CurrentManager.Password = tbl.Rows[0]["password"].ToString();
					MainForm.Form.CurrentManager.Property = Int32.Parse(tbl.Rows[0]["property"].ToString());

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show("用户名或密码错误!");
				}
			}
			catch(Exception e1)
			{
				MessageBox.Show(e1.InnerException.Message);
			}

		}

		
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}

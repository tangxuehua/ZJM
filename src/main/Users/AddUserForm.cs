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
	public class AddUserForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblProperty;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.ComboBox cmbProperty;
		private System.Windows.Forms.Label lblConfirm;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;

		private System.ComponentModel.Container components = null;

		public AddUserForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddUserForm));
			this.lblId = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblProperty = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cmbProperty = new System.Windows.Forms.ComboBox();
			this.lblConfirm = new System.Windows.Forms.Label();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.Location = new System.Drawing.Point(40, 32);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(48, 24);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "登陆名";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(40, 78);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(48, 24);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "姓名";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(40, 124);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(48, 24);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "密码";
			// 
			// lblProperty
			// 
			this.lblProperty.Location = new System.Drawing.Point(40, 215);
			this.lblProperty.Name = "lblProperty";
			this.lblProperty.Size = new System.Drawing.Size(48, 24);
			this.lblProperty.TabIndex = 3;
			this.lblProperty.Text = "等级";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(112, 24);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(144, 21);
			this.txtId.TabIndex = 4;
			this.txtId.Text = "";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(112, 70);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(144, 21);
			this.txtName.TabIndex = 5;
			this.txtName.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(112, 116);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(144, 21);
			this.txtPassword.TabIndex = 6;
			this.txtPassword.Text = "";
			// 
			// cmbProperty
			// 
			this.cmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProperty.Location = new System.Drawing.Point(112, 208);
			this.cmbProperty.Name = "cmbProperty";
			this.cmbProperty.Size = new System.Drawing.Size(144, 20);
			this.cmbProperty.TabIndex = 7;
			this.cmbProperty.SelectedIndexChanged += new System.EventHandler(this.cmbProperty_SelectedIndexChanged);
			// 
			// lblConfirm
			// 
			this.lblConfirm.Location = new System.Drawing.Point(40, 170);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.Size = new System.Drawing.Size(64, 23);
			this.lblConfirm.TabIndex = 8;
			this.lblConfirm.Text = "密码确认";
			// 
			// txtConfirm
			// 
			this.txtConfirm.Location = new System.Drawing.Point(112, 162);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.PasswordChar = '*';
			this.txtConfirm.Size = new System.Drawing.Size(144, 21);
			this.txtConfirm.TabIndex = 9;
			this.txtConfirm.Text = "";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(72, 256);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(48, 23);
			this.btnSubmit.TabIndex = 10;
			this.btnSubmit.Text = "确 定";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(176, 256);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(48, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "取 消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// AddUserForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(304, 309);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblConfirm);
			this.Controls.Add(this.cmbProperty);
			this.Controls.Add(this.lblProperty);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblId);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AddUserForm";
			this.Text = "添加用户";
			this.Load += new System.EventHandler(this.AddUserForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			string id = this.txtId.Text;
			string name = this.txtName.Text;
			string password = this.txtPassword.Text;
			string passwordConfirm = this.txtConfirm.Text;
			int property = this.cmbProperty.SelectedIndex;

			if(id == "" || name == "")
			{
				MessageBox.Show("登陆名或密码不能为空!");
				return;
			}
			if(password != passwordConfirm)
			{
				MessageBox.Show("密码不一致!");
				return;
			}
			if(MainForm.Form.CurrentManager.Property == 1 && property == 1)
			{
				MessageBox.Show("您无此权限!");
				return;
			}
			if(property < 0)
			{
				MessageBox.Show("请选择正确的用户权限!");
				return;
			}
			int i = ManagerManager.CreateManager(id,name,password,property);
			if(i == -1)
			{
				MessageBox.Show("该用户已经存在,请选择不同的登陆名!");
				return;
			}

			this.DialogResult = DialogResult.OK;

			this.Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void AddUserForm_Load(object sender, System.EventArgs e)
		{
			this.cmbProperty.Items.Add("一般用户");
			this.cmbProperty.Items.Add("管理员");
			this.cmbProperty.SelectedIndex = 0;
		}

		private void cmbProperty_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}

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
	public class UpdateUserPropertyForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblProperty;
		private System.Windows.Forms.ComboBox cmbProperty;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cmbName;

		private System.ComponentModel.Container components = null;

		public UpdateUserPropertyForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UpdateUserPropertyForm));
			this.lblName = new System.Windows.Forms.Label();
			this.lblProperty = new System.Windows.Forms.Label();
			this.cmbProperty = new System.Windows.Forms.ComboBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cmbName = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(56, 32);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(32, 24);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "姓名";
			// 
			// lblProperty
			// 
			this.lblProperty.Location = new System.Drawing.Point(56, 88);
			this.lblProperty.Name = "lblProperty";
			this.lblProperty.Size = new System.Drawing.Size(32, 24);
			this.lblProperty.TabIndex = 3;
			this.lblProperty.Text = "等级";
			// 
			// cmbProperty
			// 
			this.cmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProperty.Location = new System.Drawing.Point(104, 80);
			this.cmbProperty.Name = "cmbProperty";
			this.cmbProperty.Size = new System.Drawing.Size(112, 20);
			this.cmbProperty.TabIndex = 7;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(64, 128);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(48, 23);
			this.btnSubmit.TabIndex = 10;
			this.btnSubmit.Text = "确 定";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(152, 128);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(48, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "取 消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cmbName
			// 
			this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName.Location = new System.Drawing.Point(104, 24);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(112, 20);
			this.cmbName.TabIndex = 12;
			// 
			// UpdateUserPropertyForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(272, 173);
			this.Controls.Add(this.cmbName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.cmbProperty);
			this.Controls.Add(this.lblProperty);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "UpdateUserPropertyForm";
			this.Text = "修改用户权限";
			this.Load += new System.EventHandler(this.AddUserForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			if(this.cmbProperty.SelectedIndex < 0)
			{
				MessageBox.Show("请选择正确的用户权限!");
				return;
			}
			
			if(MessageBox.Show("确认是否要修改此用户的权限?","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				ManagerManager.UpdateManagerProperty(this.cmbName.SelectedValue.ToString(),this.cmbProperty.SelectedIndex);

				this.DialogResult = DialogResult.OK;

				this.Close();
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;

			this.Close();
		}

		private void AddUserForm_Load(object sender, System.EventArgs e)
		{
			DataTable tbl = ManagerManager.RetrieveAllManagers();
			DataView view = tbl.DefaultView;

			view.RowFilter = "property <> 2";

			this.cmbProperty.Items.Add("一般用户");
			this.cmbProperty.Items.Add("管理员");
			this.cmbProperty.SelectedIndex = 0;

			this.cmbName.DataSource = view;
			this.cmbName.DisplayMember = "name";
			this.cmbName.ValueMember = "ID";

			this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);


		}

		private void cmbName_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DataTable tbl = ManagerManager.GetManager(this.cmbName.SelectedValue.ToString());
			this.cmbProperty.SelectedIndex = Int32.Parse(tbl.Rows[0]["property"].ToString());
		}
	}
}

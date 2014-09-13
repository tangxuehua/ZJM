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
	public class DeleteUserForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.ComboBox cmbName;

		private System.ComponentModel.Container components = null;

		public DeleteUserForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DeleteUserForm));
			this.lblName = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.cmbName = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(24, 37);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(56, 24);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "选择用户";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(224, 32);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(48, 23);
			this.btnSubmit.TabIndex = 10;
			this.btnSubmit.Text = "删 除";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// cmbName
			// 
			this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbName.Location = new System.Drawing.Point(88, 32);
			this.cmbName.Name = "cmbName";
			this.cmbName.Size = new System.Drawing.Size(112, 20);
			this.cmbName.TabIndex = 12;
			// 
			// DeleteUserForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(304, 85);
			this.Controls.Add(this.cmbName);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DeleteUserForm";
			this.Text = "删除用户";
			this.Load += new System.EventHandler(this.AddUserForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("确认是否删除?","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				ManagerManager.DeleteManager(this.cmbName.SelectedValue.ToString());

				this.DialogResult = DialogResult.OK;

				this.Close();
			}

		}

		private void AddUserForm_Load(object sender, System.EventArgs e)
		{
			DataTable tbl = ManagerManager.RetrieveAllManagers();
			DataView view = tbl.DefaultView;

			if(MainForm.Form.CurrentManager.Property == 1)
			{
				view.RowFilter = "property = 0";
			}
			if(MainForm.Form.CurrentManager.Property == 2)
			{
				view.RowFilter = "property <> 2";
			}

			this.cmbName.DataSource = view;
			this.cmbName.DisplayMember = "name";
			this.cmbName.ValueMember = "ID";
		}
	}
}

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

	public class DeleteRegionForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;

		private System.ComponentModel.Container components = null;

		public DeleteRegionForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DeleteRegionForm));
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "删除";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "选择地区";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(87, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(113, 20);
			this.comboBox1.TabIndex = 4;
			// 
			// DeleteRegionForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(288, 87);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DeleteRegionForm";
			this.Text = "删除地区";
			this.Load += new System.EventHandler(this.DeleteRegionForm_Load);
			this.ResumeLayout(false);

		}
		#endregion


		private void BindToComboBox()
		{
			DataTable tblRegions = SubscribeInfoManager.RetrieveRegions();
			this.comboBox1.DataSource = tblRegions;
			this.comboBox1.DisplayMember = "name";
			this.comboBox1.ValueMember = "Id";

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DataRowView row = this.comboBox1.SelectedItem as DataRowView;

			if(row != null)
			{
				if(row["name"].ToString().Trim().Length == 0)
				{
					MessageBox.Show("请选择一个地区进行删除!");
					return;
				}
			}
			else
			{
				MessageBox.Show("请选择一个地区进行删除!");
				return;
			}
			if(MessageBox.Show("确认是否删除?","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SubscribeInfoManager.DeleteRegion(Int32.Parse(this.comboBox1.SelectedValue.ToString().Trim()));
			
				BindToComboBox();

				MessageBox.Show("删除成功!");
			}
		}

		private void DeleteRegionForm_Load(object sender, System.EventArgs e)
		{
			BindToComboBox();
		}
	}
}

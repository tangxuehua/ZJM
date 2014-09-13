using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NetFocus.MagzineSubscribe.UI
{

	public class TempForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label1;
		private DataSet currentDataSet;

		private System.ComponentModel.Container components = null;

		public DataSet CurrentDataSet
		{
			get
			{
				return currentDataSet;
			}
			set
			{
				currentDataSet = value;
			}
		}

		public TempForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}
		public TempForm(string label1Caption)
		{

			InitializeComponent();
			
			this.label1.Text = label1Caption;

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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TempForm));
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 40);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.RowHeaderWidth = 30;
			this.dataGrid1.Size = new System.Drawing.Size(724, 317);
			this.dataGrid1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(724, 40);
			this.label1.TabIndex = 1;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TempForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(724, 357);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TempForm";
			this.Text = "数据信息";
			this.Load += new System.EventHandler(this.TempForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		void BindToDataGrid()
		{
			if(currentDataSet != null)
			{

				currentDataSet.Tables[0].TableName = "resultTable";
				this.dataGrid1.DataSource = null;

				this.dataGrid1.SetDataBinding(currentDataSet,"resultTable");
				
				DataGridTableStyle ts = new DataGridTableStyle();
				ts.MappingName = this.dataGrid1.DataMember;
				if(this.dataGrid1.TableStyles.Count > 0 )
				{
					this.dataGrid1.TableStyles.Clear();	
				}
				this.dataGrid1.TableStyles.Add(ts);
				this.dataGrid1.TableStyles[0].AllowSorting = false;
				this.dataGrid1.TableStyles[0].GridColumnStyles["行号"].Width = 45;
				this.dataGrid1.TableStyles[0].GridColumnStyles["姓名"].Width = 60;
				this.dataGrid1.TableStyles[0].GridColumnStyles["公司"].Width = 200;
				this.dataGrid1.TableStyles[0].GridColumnStyles["职位"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["地址"].Width = 250;
				this.dataGrid1.TableStyles[0].GridColumnStyles["邮编"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["电话"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["手机"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["起始日期"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["结束日期"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["付款日期"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["份数"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["期数"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["金额"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["落款"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["来源"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["支付方式"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["发票号"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["客户类别"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["业务员"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["奖金提取"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["县级地区"].Width = 0;
				this.dataGrid1.TableStyles[0].GridColumnStyles["订阅形式"].Width = 0;
				if(this.label1.Text == "以下" + currentDataSet.Tables[0].Rows.Count + "条记录在Excel表中有重复,请核对后再导入")
				{
					this.dataGrid1.TableStyles[0].GridColumnStyles["地区"].Width = 74;
					this.dataGrid1.TableStyles[0].GridColumnStyles["重复次数"].Width = 60;
				}
				else if(this.label1.Text == "以下" + currentDataSet.Tables[0].Rows.Count + "条记录在数据库中已存在,请核对后再导入")
				{
					this.dataGrid1.TableStyles[0].GridColumnStyles["地区"].Width = 133;
					this.dataGrid1.TableStyles[0].GridColumnStyles["重复次数"].Width = 0;
				}
			}
		}

		void CreateSplitter()
		{
			this.SuspendLayout();
			
			System.Windows.Forms.Splitter splitter = new Splitter();
			splitter.Dock = DockStyle.Top;
			splitter.BackColor = SystemColors.ControlDark;
			splitter.Enabled = false;
			splitter.Height = 1;

			this.Controls.Add(splitter);

			this.ResumeLayout();

			splitter.BringToFront();
			this.dataGrid1.BringToFront();

		}


		private void TempForm_Load(object sender, System.EventArgs e)
		{
			
			CreateSplitter();

			BindToDataGrid();
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using NetFocus.MagzineSubscribe.Business;


namespace NetFocus.MagzineSubscribe.UI
{

	public class ShowStatResultForm : System.Windows.Forms.Form
	{
		#region 一些变量

		DateTime startDate;
		DateTime endDate;
		DateTime giveDate;
		int number;
		int monthCount;
		int totalMoney;
		int averageMoney;
		int monthMoney;
		string name;
		string post;
		string company;
		string region;
		string source;
		string invoice;
		string telephone;
		string mobilephone;

		string fileName;

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private DataTable tbl = null;
		private DateTime inputDate;
		private int totalRealMoney;
		private int totalShouldMoney;

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnExport1;
		private System.Windows.Forms.Button btnExport2;
		private System.Windows.Forms.Panel pnlHavePaid;
		private System.Windows.Forms.Panel pnlUnPaid;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;

		private DataTable tempTable = new DataTable();
		private DataTable tempTable1 = new DataTable();

		#endregion
		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ShowStatResultForm));
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExport1 = new System.Windows.Forms.Button();
			this.btnExport2 = new System.Windows.Forms.Button();
			this.pnlHavePaid = new System.Windows.Forms.Panel();
			this.pnlUnPaid = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.pnlHavePaid.SuspendLayout();
			this.pnlUnPaid.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(818, 39);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGrid1
			// 
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 303);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(818, 296);
			this.dataGrid1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(743, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "已付款的公司名单";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGrid2
			// 
			this.dataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid2.CaptionFont = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
			this.dataGrid2.CaptionVisible = false;
			this.dataGrid2.DataMember = "";
			this.dataGrid2.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGrid2.FlatMode = true;
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(0, 63);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(818, 216);
			this.dataGrid2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(743, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "未付款的公司名单";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnExport1
			// 
			this.btnExport1.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnExport1.Location = new System.Drawing.Point(743, 0);
			this.btnExport1.Name = "btnExport1";
			this.btnExport1.Size = new System.Drawing.Size(75, 24);
			this.btnExport1.TabIndex = 6;
			this.btnExport1.Text = "导 出";
			this.btnExport1.Click += new System.EventHandler(this.btnExport1_Click);
			// 
			// btnExport2
			// 
			this.btnExport2.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnExport2.Location = new System.Drawing.Point(743, 0);
			this.btnExport2.Name = "btnExport2";
			this.btnExport2.Size = new System.Drawing.Size(75, 24);
			this.btnExport2.TabIndex = 7;
			this.btnExport2.Text = "导 出";
			this.btnExport2.Click += new System.EventHandler(this.btnExport2_Click);
			// 
			// pnlHavePaid
			// 
			this.pnlHavePaid.Controls.Add(this.label2);
			this.pnlHavePaid.Controls.Add(this.btnExport1);
			this.pnlHavePaid.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHavePaid.Location = new System.Drawing.Point(0, 39);
			this.pnlHavePaid.Name = "pnlHavePaid";
			this.pnlHavePaid.Size = new System.Drawing.Size(818, 24);
			this.pnlHavePaid.TabIndex = 8;
			// 
			// pnlUnPaid
			// 
			this.pnlUnPaid.Controls.Add(this.label3);
			this.pnlUnPaid.Controls.Add(this.btnExport2);
			this.pnlUnPaid.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlUnPaid.Location = new System.Drawing.Point(0, 279);
			this.pnlUnPaid.Name = "pnlUnPaid";
			this.pnlUnPaid.Size = new System.Drawing.Size(818, 24);
			this.pnlUnPaid.TabIndex = 9;
			// 
			// ShowStatResultForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(818, 599);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.pnlUnPaid);
			this.Controls.Add(this.dataGrid2);
			this.Controls.Add(this.pnlHavePaid);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ShowStatResultForm";
			this.Text = "统计结果";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ShowStatResultForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.pnlHavePaid.ResumeLayout(false);
			this.pnlUnPaid.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
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



		public ShowStatResultForm(DataTable tbl,DateTime inputDate)
		{

			InitializeComponent();

			this.tbl = tbl;
			this.inputDate = inputDate;
		}

		
		void AddRowToTable(DataTable tbl,DataRow row,int moneyOfThisMonth)
		{
			DataRow newRow = tbl.NewRow();
			for(int i=0;i<tbl.Columns.Count-1;i++)
			{
				if(tbl.Columns[i].ColumnName == "起始日期" || tbl.Columns[i].ColumnName == "结束日期" || tbl.Columns[i].ColumnName == "付款日期")
				{
					if(row[i] != DBNull.Value)
					{
						newRow[i] = DateTime.Parse(row[i].ToString()).Year.ToString() + "-" + DateTime.Parse(row[i].ToString()).Month.ToString() + "-1";
					}
				}
				else
				{
					newRow[i] = row[i];
				}
			}
			newRow[tbl.Columns.Count-1] = moneyOfThisMonth;  //最后一个字段用来存放本月收取

			tbl.Rows.Add(newRow);

		}

		DataTable CreateTable(DataTable sourceTable)
		{
			DataTable tbl = new DataTable();

			foreach(DataColumn col in sourceTable.Columns)
			{
				tbl.Columns.Add(col.ColumnName);
			}

			return tbl;
		}

		void InitData()
		{
			if(tbl == null)
			{
				this.label1.Text = "没有统计结果!";
				return;
			}
			//创建两张表,分别存放已付款公司和未付款公司
			//提示:这里的tbl中的数据的特点是只满足起始日期和结束日期包括当前日期的值,而对于期数,金额都没有作过判断
			tempTable = CreateTable(tbl);//存放未付款的记录
			tempTable1 = CreateTable(tbl);//存放已付款的记录

			if(tbl.Rows.Count <= 0)
			{
				this.label1.Text = "没有统计结果!";
				return;
			}

			foreach(DataRow row in tbl.Rows)
			{
				//如果金额或者期数其中有一个为空,则认为是免费送的
				if(row["金额"] == DBNull.Value || row["期数"] == DBNull.Value)
				{
					AddRowToTable(tempTable,row,0);
					continue;
				}
				//如果金额或者期数都不为空,但付款日期为空
				if(row["付款日期"] == DBNull.Value)
				{
					AddRowToTable(tempTable,row,0);
					totalShouldMoney = totalShouldMoney + Int32.Parse(row["平均金额"].ToString());
					continue;
				}

				//下面是金额,期数,付款日期都不为空的情况																	 
				DateTime giveDate = DateTime.Parse(row["付款日期"].ToString());
				//1.表明到本月为止,该单位还未付款
				if((giveDate.Year == inputDate.Year && giveDate.Month > inputDate.Month) || giveDate.Year > inputDate.Year)  //如果到本月为止还未付款
				{
					AddRowToTable(tempTable,row,0);
					totalShouldMoney = totalShouldMoney + Int32.Parse(row["平均金额"].ToString());
					continue;
				}
				//2.表明正好在本月付款
				if(giveDate.Year == inputDate.Year && giveDate.Month == inputDate.Month) 
				{
					int n = 0; //用于存放前面几个月包括本月应该被累加起来,并算到这个月的收入
					DateTime startDate = DateTime.Parse(row["起始日期"].ToString());
					while((startDate.Year == giveDate.Year && startDate.Month <= giveDate.Month) || startDate.Year < giveDate.Year)
					{
						n = n + 1;
						startDate = startDate.AddMonths(1);
					}
					int money = n * Int32.Parse(row["平均金额"].ToString());
					totalRealMoney = totalRealMoney + money;
					totalShouldMoney = totalShouldMoney + money;
					AddRowToTable(tempTable1,row,money);
					continue;
				}
				//3.表明在本月之前就已经付款
				totalRealMoney = totalRealMoney + Int32.Parse(row["平均金额"].ToString());
				totalShouldMoney = totalShouldMoney + Int32.Parse(row["平均金额"].ToString());

				AddRowToTable(tempTable1,row,Int32.Parse(row["平均金额"].ToString()));
					

			}
			this.label1.Text = "本月实际收入金额为: " + totalRealMoney.ToString() + " 元" + "      应该收入金额为: " + totalShouldMoney.ToString() + " 元" + "     查询月份为: " + inputDate.Year.ToString() + "年" + inputDate.Month.ToString() + "月";
		}

		private void ShowStatResultForm_Load(object sender, System.EventArgs e)
		{
			InitData();
			DataSet ds = new DataSet();
			ds.Tables.Add(tempTable);
			ds.Tables.Add(tempTable1);
			ds.Tables[0].TableName = "tempTable";
			ds.Tables[1].TableName = "tempTable1";

			this.dataGrid1.DataSource = null;

			this.dataGrid1.SetDataBinding(ds,"tempTable");
				
			DataGridTableStyle ts = new DataGridTableStyle();
			ts.MappingName = this.dataGrid1.DataMember;
			if(this.dataGrid1.TableStyles.Count > 0 )
			{
				this.dataGrid1.TableStyles.Clear();	
			}
				
			this.dataGrid1.TableStyles.Add(ts);
			this.dataGrid1.TableStyles[0].RowHeaderWidth = 45;
			this.dataGrid1.TableStyles[0].AllowSorting = false;
			this.dataGrid1.TableStyles[0].GridColumnStyles["姓名"].Width = 60;
			this.dataGrid1.TableStyles[0].GridColumnStyles["平均金额"].Width = 0;
			this.dataGrid1.TableStyles[0].GridColumnStyles["公司"].Width = 186;



			this.dataGrid2.DataSource = null;

			this.dataGrid2.SetDataBinding(ds,"tempTable1");
				
			DataGridTableStyle ts1 = new DataGridTableStyle();
			ts1.MappingName = this.dataGrid2.DataMember;
			if(this.dataGrid2.TableStyles.Count > 0 )
			{
				this.dataGrid2.TableStyles.Clear();	
			}
					
			this.dataGrid2.TableStyles.Add(ts1);
			this.dataGrid2.TableStyles[0].RowHeaderWidth = 45;
			this.dataGrid2.TableStyles[0].AllowSorting = false;
			this.dataGrid2.TableStyles[0].GridColumnStyles["姓名"].Width = 60;
			this.dataGrid2.TableStyles[0].GridColumnStyles["平均金额"].Width = 0;
			this.dataGrid2.TableStyles[0].GridColumnStyles["公司"].Width = 186;

			this.label2.Text = this.label2.Text + "(共" + tempTable1.Rows.Count.ToString() + "条记录)";
			this.label3.Text = this.label3.Text + "(共" + tempTable.Rows.Count.ToString() + "条记录)";


		}

		void AssignValues(DataRow row)
		{
			name = row["姓名"].ToString().Trim();
			post = row["职位"].ToString().Trim();
			company = row["公司"].ToString().Trim();
			region = row["地区"].ToString().Trim();
			source = row["来源"].ToString().Trim();
			invoice = row["发票号"].ToString().Trim();
			telephone = row["电话"].ToString().Trim();
			mobilephone = row["手机"].ToString().Trim();

			if(row["起始日期"] != DBNull.Value)
			{
				startDate = DateTime.Parse(row["起始日期"].ToString());
			}
			else
			{
				startDate = DateTime.Parse("1900-1-1");
			}
			if(row["结束日期"] != DBNull.Value)
			{
				endDate = DateTime.Parse(row["结束日期"].ToString());
			}
			else
			{
				endDate = DateTime.Parse("1900-1-1");
			}
			if(row["付款日期"] != DBNull.Value)
			{
				giveDate = DateTime.Parse(row["付款日期"].ToString());
			}
			else
			{
				giveDate = DateTime.Parse("1900-1-1");
			}
			if(row["份数"] != DBNull.Value)
			{
				number = Int32.Parse(row["份数"].ToString());
			}
			else
			{
				number = -1;
			}
			if(row["期数"] != DBNull.Value)
			{
				monthCount = Int32.Parse(row["期数"].ToString());
			}
			else
			{
				monthCount = -1;
			}
			if(row["金额"] != DBNull.Value)
			{
				totalMoney = Int32.Parse(row["金额"].ToString());
			}
			else
			{
				totalMoney = -1;
			}
			if(row["平均金额"] != DBNull.Value)
			{
				averageMoney = Int32.Parse(row["平均金额"].ToString());
			}
			else
			{
				averageMoney = -1;
			}
			if(row["本月收取"] != DBNull.Value)
			{
				monthMoney = Int32.Parse(row["本月收取"].ToString());
			}
			else
			{
				monthMoney = -1;
			}
		}
		void ExportData(DataTable tbl)
		{
			this.openFileDialog1.Filter = "Excel数据文件|*.xls";
			this.openFileDialog1.RestoreDirectory = true;
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//先获取一个要导出的Excel文件名
				fileName = this.openFileDialog1.FileName;
				string path = Path.GetDirectoryName(fileName);
				if(!path.EndsWith(@"\"))
				{
					path = path + @"\";
				}
				string name1 = Path.GetFileName(fileName);

				//清空保存统计信息的表中的记录
				SubscribeInfoManager.ClearStatInfoTable();
				//将记录插入到StatInfoTable中
				foreach(DataRow row in tbl.Rows)
				{
					AssignValues(row);
					SubscribeInfoManager.InsertIntoStatInfoTable(name,post,company,region,source,invoice,telephone,mobilephone,number,monthCount,totalMoney,averageMoney,monthMoney,startDate,endDate,giveDate);
				}
				//将StatInfoTable表中的记录导出到Excel文件中
				SubscribeInfoManager.OutputDataToExcel(path,name1,"StatInfoTable");

				foreach(Process process in Process.GetProcessesByName("EXCEL"))
				{
					process.Kill();
				}

				MessageBox.Show("数据已成功保存到 " + fileName);
			}
		}
		private void btnExport1_Click(object sender, System.EventArgs e)//导出已付款的记录
		{
			ExportData(tempTable1);

		}

		private void btnExport2_Click(object sender, System.EventArgs e)//导出未付款的记录
		{
			ExportData(tempTable);

		}

	}
}

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
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.OleDb;

using NetFocus.MagzineSubscribe.Business;
using NetFocus.MagzineSubscribe.Data;
using Crownwood.Magic.Menus;


namespace NetFocus.MagzineSubscribe.UI
{

	public class MainForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.Container components = null;
		private DataGrid dataGrid1;
		private ToolBar bar = null;
		private static MainForm mainForm = null;
		private System.Data.DataSet currentDataSet = null;
		private DataTable statResultTable = null;
		private DateTime currentInputDate;
		private Manager currentManager = null;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Crownwood.Magic.Menus.MenuControl topMenu = null;

		public static MainForm Form
		{
			get
			{
				return mainForm;
			}
			set
			{
				mainForm = value;
			}
		}
		
		public System.Data.DataSet CurrentDataSet
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

		public DataTable StatResultTable
		{
			get
			{
				return statResultTable;
			}
			set
			{
				statResultTable = value;
			}
		}
		public DateTime CurrentInputDate
		{
			get
			{
				return currentInputDate;
			}
			set
			{
				currentInputDate = value;
			}
		}
		public Manager CurrentManager
		{
			get
			{
				return currentManager;
			}
			set
			{
				currentManager = value;
			}
		}
		public DataGrid ShowResultDataGrid
		{
			get
			{
				return dataGrid1;
			}
			set
			{
				dataGrid1 = value;
			}
		}

		
		private MainForm()
		{

			InitializeComponent();

		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		
		#region Windows 窗体设计器生成的代码
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.BackColor = System.Drawing.Color.White;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10F);
			this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.dataGrid1.Location = new System.Drawing.Point(0, 0);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeaderWidth = 100;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.Size = new System.Drawing.Size(704, 453);
			this.dataGrid1.TabIndex = 2;
			this.dataGrid1.DataSourceChanged += new System.EventHandler(this.dataGrid1_DataSourceChanged);
			this.dataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseUp);
			this.dataGrid1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGrid1_Paint);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(704, 453);
			this.Controls.Add(this.dataGrid1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "杂志订阅管理系统";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			mainForm = new MainForm();
			ConfigurationSettings.GetConfig("MyConfig");//读取自定义配置节,在这个过程中会初始化所有的托管容器对象

			LoginForm loginForm = new LoginForm();
			loginForm.StartPosition = FormStartPosition.CenterScreen;
			if(loginForm.ShowDialog() == DialogResult.OK)
			{
				Application.Run(mainForm);//启动主窗体
			}
		}


		#region MenuCommands

		void AddUser(object sender,EventArgs e)
		{
			AddUserForm userForm = new AddUserForm();
			userForm.StartPosition = FormStartPosition.CenterParent;
			if(userForm.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("添加用户成功!");
			}
		}
		void DeleteUser(object sender,EventArgs e)
		{
			DeleteUserForm userForm = new DeleteUserForm();
			userForm.StartPosition = FormStartPosition.CenterParent;
			if(userForm.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("删除用户成功!");
			}
		}
		void ModifyUserPassword(object sender,EventArgs e)
		{
			ModifyUserPasswordForm userForm = new ModifyUserPasswordForm();
			userForm.StartPosition = FormStartPosition.CenterParent;
			if(userForm.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("密码修改成功!");
			}
		}
		void ModifyUserName(object sender,EventArgs e)
		{
			UpdateUserNameForm userForm = new UpdateUserNameForm();
			userForm.StartPosition = FormStartPosition.CenterParent;
			if(userForm.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("姓名修改成功!");
			}
		}
		void ModifyUserProperty(object sender,EventArgs e)
		{
			UpdateUserPropertyForm userForm = new UpdateUserPropertyForm();
			userForm.StartPosition = FormStartPosition.CenterParent;
			if(userForm.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("权限修改成功!");
			}
		}
		void UserExit(object sender,EventArgs e)
		{
			this.Close();
		}

		
		void AddEmployee(object sender,EventArgs e)
		{
			AddEmployeeForm employeeForm = new AddEmployeeForm();
			employeeForm.StartPosition = FormStartPosition.CenterParent;
			employeeForm.ShowDialog();

		}
		void DeleteEmployee(object sender,EventArgs e)
		{
			DeleteEmployeeForm employeeForm = new DeleteEmployeeForm();
			employeeForm.StartPosition = FormStartPosition.CenterParent;
			employeeForm.ShowDialog();
		}
		void ModifyEmployee(object sender,EventArgs e)
		{
			UpdateEmployeeForm employeeForm = new UpdateEmployeeForm();
			employeeForm.StartPosition = FormStartPosition.CenterParent;
			employeeForm.ShowDialog();
		}

		
		void AddSubscribe(object sender,EventArgs e)
		{
			AddForm addForm = new AddForm();
			addForm.StartPosition = FormStartPosition.CenterParent;
			if(addForm.ShowDialog() == DialogResult.OK)
			{
				RebindToDataGrid();
			}
		}
		void DeleteSubscribe(object sender,EventArgs e)
		{
			if(DeleteSelectedRows() == true)
			{
				RebindToDataGrid();
			}
		}

		void ModifySubscribe(object sender,EventArgs e)
		{
			UpdateForm updateForm = new UpdateForm();
			updateForm.StartPosition = FormStartPosition.CenterParent;
			if(updateForm.ShowDialog() == DialogResult.OK)
			{
				RebindToDataGrid();
			}
		}
		void BatchModifySubscribe(object sender,EventArgs e)
		{
			if(TestSelectedRows() == false)
			{
				MessageBox.Show("您没有选中任何行！");
				return;
			}

			BatchUpdateForm batchUpdateForm = new BatchUpdateForm();
			batchUpdateForm.StartPosition = FormStartPosition.CenterParent;
			if(batchUpdateForm.ShowDialog() == DialogResult.OK)
			{
				RebindToDataGrid();
			}
			
		}
		void OtherSearch(object sender,EventArgs e)
		{
			OtherSearchForm searchForm = new OtherSearchForm();
			searchForm.StartPosition = FormStartPosition.CenterParent;
			if(searchForm.ShowDialog() == DialogResult.OK)
			{
				RebindToDataGrid();
			}
		}
		void SearchSubscribe(object sender,EventArgs e)
		{
			SearchForm searchForm = new SearchForm();
			searchForm.StartPosition = FormStartPosition.CenterParent;
			if(searchForm.ShowDialog() == DialogResult.OK)
			{
				RebindToDataGrid();
			}
		}
		void InputSubscribe(object sender,EventArgs e)
		{
			//if(MessageBox.Show("导入前请先保存并关闭所有打开的Excel文档!","警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1) == DialogResult.OK)
			//{
				if(ImportExcelData() == true)
				{
					RebindToDataGrid();
				}
			//}
		}
		void OutputSubscribe(object sender,EventArgs e)
		{
			ExportDataToExcel();
		}

		void StatSubscribe(object sender,EventArgs e)
		{
			StatSubscribeForm statSubscribeForm = new StatSubscribeForm();
			statSubscribeForm.StartPosition = FormStartPosition.CenterParent;
			if(statSubscribeForm.ShowDialog() == DialogResult.OK)
			{
				ShowStatResultForm form = new ShowStatResultForm(this.statResultTable,this.currentInputDate);
				form.StartPosition = FormStartPosition.CenterParent;
				form.ShowDialog();
			}
		}


		void AddRegion(object sender,EventArgs e)
		{
			AddRegionForm regionForm = new AddRegionForm();
			regionForm.StartPosition = FormStartPosition.CenterParent;
			regionForm.ShowDialog();
		}
		void DeleteRegion(object sender,EventArgs e)
		{
			DeleteRegionForm regionForm = new DeleteRegionForm();
			regionForm.StartPosition = FormStartPosition.CenterParent;
			regionForm.ShowDialog();
		}


		#endregion

		DataSet GetData(string fileName)    //将Excel文件中的数据存放在一个DataSet中
		{
			string file=openFileDialog1.FileName;
			string cmdText;
			string conStr=@" Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + file + ";Extended Properties=Excel 8.0" ; 
			string tableName = "";
			DataSet ds = null;
			OleDbConnection objConn = new OleDbConnection(conStr);
			
			try
			{
				if(objConn.State == ConnectionState.Open)
				{
					objConn.Close();
				}

				objConn.Open();
				
				DataTable schemaTable = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,null);
				tableName = schemaTable.Rows[0][2].ToString().Trim(); 
				
				if(tableName.EndsWith("$"))
				{
					cmdText="select * from [" + tableName + "]";
				}
				else
				{
					cmdText="select * from [" + tableName + "$]";
				}

				OleDbDataAdapter a = new OleDbDataAdapter(cmdText,conStr);
				
				ds = new DataSet();

				a.Fill(ds);//先将数据放在一个DataSet中

			}
			catch(Exception e)
			{
				throw new Exception(e.Message);
			}
			finally
			{
				objConn.Close();
				objConn.Dispose();
			}

			DataTable tbl = ds.Tables[0];

			if(tbl.Columns.Count != 23)
			{
				throw new Exception("Excel中存在空表格,或者格式不正确,请检查!");
			}
				
			//创建一个新的DataSet,其中的一张表中包含一个自动递增列
			DataSet returnDs = new DataSet();//新建一个记录集
			DataTable returnTable = new DataTable();//新建一张表
			returnDs.Tables.Add(returnTable);//将该表添加到DatSet中

			DataColumn col1 = returnTable.Columns.Add("行号");//先新建一个自动递增列,用于显示Excel表中的行号
			col1.AutoIncrement = true;
			col1.AutoIncrementSeed = 2;//这里因为Excel表中第一行是标题行,而且行号是从1开始的
			col1.AutoIncrementStep = 1;

			foreach(DataColumn col in tbl.Columns)//为该表添加所有Excel表中的列
			{
				returnTable.Columns.Add(col.ColumnName);
			}

			foreach(DataRow row in tbl.Rows) //将Excel表中的所有的行添加到该表中
			{
				DataRow newRow = returnTable.NewRow();
				for(int i=1;i<returnTable.Columns.Count;i++)
				{
					newRow[i] = row[i-1];
				}
				returnTable.Rows.Add(newRow);

			}

			foreach(Process process in Process.GetProcessesByName("EXCEL"))
			{
				process.Kill();
			}

			return returnDs;

		}
		
		DataTable CreateTable(DataTable sourceTable)
		{
			DataTable tbl = new DataTable();

			foreach(DataColumn col in sourceTable.Columns)
			{
				tbl.Columns.Add(col.ColumnName);
			}
			tbl.Columns.Add("重复次数");  //新增一列,用于显示重复次数
			tbl.PrimaryKey = new DataColumn[]{tbl.Columns["姓名"],tbl.Columns["公司"]};  //设置主键,用于排序
			return tbl;
		}
		void AddRowToTable(DataTable tbl,DataRow row)
		{
			if(!tbl.Rows.Contains(new object[]{row["姓名"].ToString(),row["公司"].ToString()}))  //如果表中不包括当前行
			{
				DataRow newRow = tbl.NewRow();
				for(int i=0;i<tbl.Columns.Count - 1;i++)
				{
					newRow[i] = row[i];
				}
				newRow["重复次数"] = 1;
				tbl.Rows.Add(newRow);
			}
			else  //否则重复次数 + 1
			{
				DataRow row1 = tbl.Rows.Find(new object[]{row["姓名"].ToString(),row["公司"].ToString()});
				row1["重复次数"] = Int32.Parse(row1["重复次数"].ToString()) + 1;  
			}
		}
		
		void CheckTableFormat(DataTable table)
		{
			string[] fieldsArray = new string[]{
									"起始日期","结束日期","付款日期","份数","期数","金额","姓名","县级地区",
									"地区","公司","订阅形式","职位","地址","邮编","手机","电话","落款","来源",
									"支付方式","发票号","客户类别","业务员","奖金提取"};
			foreach(string fieldString in fieldsArray)
			{
				if(table.Columns[fieldString] == null)
				{
					throw new Exception("Excel表中字段 \"" + fieldString + "\" 的名称不正确,请检查该字段名是否有多余的空格或者名称是否正确!");
				}
			}

		}
		DataTable CheckDataReduplicateInExcel(DataTable sourceTable)   //检查在Excel表中是否有重复的记录,如果有,则用DataSet来返回
		{
			DataTable tbl = CreateTable(sourceTable);

			DataRow[] sourceRows = sourceTable.Select("","姓名");  //先按姓名排序
			int i;
			for(i = 0;i<sourceRows.Length -1;i++)  //从第一条记录到最后第二条记录进行迭代
			{
				string name1 = sourceRows[i]["姓名"].ToString().Trim();
				string company1 = sourceRows[i]["公司"].ToString().Trim();
				string name2 = sourceRows[i+1]["姓名"].ToString().Trim();
				string company2 = sourceRows[i+1]["公司"].ToString().Trim();

				if(name1 == "")
				{
					sourceRows[i]["姓名"] = "  ";
				}
				if(company1 == "")
				{
					sourceRows[i]["公司"] = "  ";
				}
				if( name1 == name2 && company1 == company2)
				{
					AddRowToTable(tbl,sourceRows[i]);//这里,有可能将从倒数第二条记录之前的所有记录都添加到tbl中
				}
			}

			return tbl;

		}
		DataTable CheckDataReduplicateWithDatabase(DataTable sourceTable)   //检查在Excel表中是否有于数据库重复的记录,如果有,则用DataTable来返回
		{
			DataTable tbl = CreateTable(sourceTable);
			
			foreach(DataRow row in sourceTable.Rows)
			{
				int count = SubscribeInfoManager.CheckSubscribeExist(row["姓名"].ToString().Trim(),row["公司"].ToString().Trim());
				if(count >=1)  //说明当前记录在数据库主表中已经存在
				{
					if(row["姓名"].ToString().Trim() == "")
					{
						row["姓名"] = "  ";
					}
					if(row["公司"].ToString().Trim() == "")
					{
						row["公司"] = "  ";
					}
					AddRowToTable(tbl,row);
				}
			}
			return tbl;
		}
		
		void ImportDataToDatabase(DataTable sourceTable)
		{

			SubscribeInfoManager.ClearTempInfo();

			foreach(DataRow row in sourceTable.Rows)
			{

				DateTime startDate = DateTime.Parse("1900-1-1");
				DateTime endDate = DateTime.Parse("1900-1-1");
				DateTime giveDate = DateTime.Parse("1900-1-1");

				int number = -1;
				int monthCount = -1;
				int totalMoney = -1;
				string name;
				string localAddress;
				string company;
				string subscription;
				string post;
				string region;
				string address;
				string postcode;
				string mobilePhone;
				string telephone;
				string inscribe;
				string source;
				string payment;
				string invoice;
				string client;
				string operator1;
				string bonus;

				if(row["起始日期"] != DBNull.Value)
				{
					startDate = DateTime.Parse(row["起始日期"].ToString().Trim());//注意:这里一定能够转换,因为如果格式不正确则它的值必定为DBNull.Value
				}
				if(row["结束日期"] != DBNull.Value)
				{
					endDate = DateTime.Parse(row["结束日期"].ToString().Trim());//同上
				}
				if(row["付款日期"] != DBNull.Value)
				{
					giveDate = DateTime.Parse(row["付款日期"].ToString().Trim());//同上
				}
				if(row["份数"] != DBNull.Value)
				{
					number = Int32.Parse(row["份数"].ToString());//同上
				}
				if(row["期数"] != DBNull.Value)
				{
					monthCount = Int32.Parse(row["期数"].ToString());//同上
				}
				if(row["金额"] != DBNull.Value)
				{
					totalMoney = Int32.Parse(row["金额"].ToString());//同上
				}
				
				name = row["姓名"].ToString().Trim() == String.Empty ? "  " : row["姓名"].ToString().Trim();
				localAddress = row["县级地区"].ToString().Trim() == String.Empty ? "  " : row["县级地区"].ToString().Trim();
				region = row["地区"].ToString().Trim() == String.Empty ? "  " : row["地区"].ToString().Trim();
				company = row["公司"].ToString().Trim() == String.Empty ? "  " : row["公司"].ToString().Trim();
				subscription = row["订阅形式"].ToString().Trim() == String.Empty ? "  " : row["订阅形式"].ToString().Trim();
				post = row["职位"].ToString().Trim() == String.Empty ? "  " : row["职位"].ToString().Trim();
				address = row["地址"].ToString().Trim() == String.Empty ? "  " : row["地址"].ToString().Trim();
				postcode = row["邮编"].ToString().Trim() == String.Empty ? "  " : row["邮编"].ToString().Trim();
				mobilePhone = row["手机"].ToString().Trim() == String.Empty ? "  " : row["手机"].ToString().Trim();
				telephone = row["电话"].ToString().Trim() == String.Empty ? "  " : row["电话"].ToString().Trim();
				inscribe = row["落款"].ToString().Trim() == String.Empty ? "  " : row["落款"].ToString().Trim();
				source = row["来源"].ToString().Trim() == String.Empty ? "  " : row["来源"].ToString().Trim();
				payment = row["支付方式"].ToString().Trim() == String.Empty ? "  " : row["支付方式"].ToString().Trim();
				invoice = row["发票号"].ToString().Trim() == String.Empty ? "  " : row["发票号"].ToString().Trim();
				client = row["客户类别"].ToString().Trim() == String.Empty ? "  " : row["客户类别"].ToString().Trim();
				operator1 = row["业务员"].ToString().Trim() == String.Empty ? "  " : row["业务员"].ToString().Trim();
				bonus = row["奖金提取"].ToString().Trim() == String.Empty ? "  " : row["奖金提取"].ToString().Trim();
				
				SubscribeInfoManager.CreateSubscribeInfo(name,post,company,address,region,postcode,telephone,mobilePhone,startDate,endDate,giveDate,number,monthCount,totalMoney,inscribe,source,payment,invoice,client,operator1,bonus,localAddress,subscription);
			}
		}
		

		bool ImportExcelData()
		{
			openFileDialog1.Filter = "Excel数据文件|*.xls";
			openFileDialog1.RestoreDirectory = true;
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				DataSet ds = null;
				DataTable tempTable = null;
				try
				{
					ds = GetData(openFileDialog1.FileName);
					
					CheckTableFormat(ds.Tables[0]);
				}
				catch(Exception e)
				{
					MessageBox.Show(e.Message);
					return false;
				}
				//到这里为止,说明Excel表中字段的结构已经正确
				
				//1.检查Excel中是否有重复的记录
				tempTable = CheckDataReduplicateInExcel(ds.Tables[0]);

				if(tempTable.Rows.Count > 0)
				{
					DataSet tempDs = new DataSet();
					tempDs.Tables.Add(tempTable);
					//跳出一个窗体,显示Excel表格中重复的记录
					TempForm tempForm = new TempForm("以下" + tempDs.Tables[0].Rows.Count + "条记录在Excel表中有重复,请核对后再导入");
					tempForm.CurrentDataSet = tempDs;
					tempForm.StartPosition = FormStartPosition.CenterParent;
					tempForm.ShowDialog();

					return false;
				}
				//2.检查Excel中是否有和数据库重复的记录
				tempTable = CheckDataReduplicateWithDatabase(ds.Tables[0]);

				if(tempTable.Rows.Count > 0)
				{
					DataSet tempDs = new DataSet();
					tempDs.Tables.Add(tempTable);
					//跳出一个窗体,显示与数据库中记录重复的记录
					TempForm tempForm = new TempForm("以下" + tempDs.Tables[0].Rows.Count + "条记录在数据库中已存在,请核对后再导入");
					tempForm.CurrentDataSet = tempDs;
					tempForm.StartPosition = FormStartPosition.CenterParent;
					tempForm.ShowDialog();

					return false;
				}

				//到这里可以安全的将数据导入到数据库
				ImportDataToDatabase(ds.Tables[0]);
				
				this.currentDataSet = SubscribeInfoManager.RetriveDataFromTempInfo();
							
				return true;
				
			}
			return false;
		}
		
		void ExportDataToExcel()
		{
			string fileName;
			this.openFileDialog1.Filter = "Excel数据文件|*.xls";
			this.openFileDialog1.RestoreDirectory = true;
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				fileName = this.openFileDialog1.FileName;
				string path = Path.GetDirectoryName(fileName);
				if(!path.EndsWith(@"\"))
				{
					path = path + @"\";
				}
				string name = Path.GetFileName(fileName);

				SubscribeInfoManager.OutputDataToExcel(path,name,"TempInfo");

				foreach(Process process in Process.GetProcessesByName("EXCEL"))
				{
					process.Kill();
				}

				MessageBox.Show("数据已成功保存到 " + fileName);
			}
		}

		void CreateMainMenu()
		{
			this.SuspendLayout();
			topMenu = new MenuControl();
			//添加用户菜单
			Crownwood.Magic.Menus.MenuCommand itemUserManage = new MenuCommand("用户管理");
			Crownwood.Magic.Menus.MenuCommand itemAddUser = new MenuCommand("添加新用户",new EventHandler(AddUser));
			Crownwood.Magic.Menus.MenuCommand itemModifyUserNameAndProperty = new MenuCommand("更新用户权限",new EventHandler(ModifyUserProperty));
			Crownwood.Magic.Menus.MenuCommand itemModifyUserName = new MenuCommand("用户更改姓名",new EventHandler(ModifyUserName));
			Crownwood.Magic.Menus.MenuCommand itemModifyUserPassword = new MenuCommand("用户更改密码",new EventHandler(ModifyUserPassword));
			Crownwood.Magic.Menus.MenuCommand itemDeleteUser = new MenuCommand("删除用户",new EventHandler(DeleteUser));
			Crownwood.Magic.Menus.MenuCommand itemUserExit = new MenuCommand("用户退出",new EventHandler(UserExit));

			itemUserManage.MenuCommands.AddRange(new MenuCommand[]{itemAddUser,itemModifyUserNameAndProperty,itemModifyUserName,itemModifyUserPassword,itemDeleteUser,itemUserExit});
			//添加业务员管理菜单
			Crownwood.Magic.Menus.MenuCommand itemEmployeeManage = new MenuCommand("业务员管理");
			Crownwood.Magic.Menus.MenuCommand itemAddEmployee = new MenuCommand("添加业务员",new EventHandler(AddEmployee));
			Crownwood.Magic.Menus.MenuCommand itemModifyEmployee = new MenuCommand("更新业务员",new EventHandler(ModifyEmployee));
			Crownwood.Magic.Menus.MenuCommand itemDeleteEmployee = new MenuCommand("删除业务员",new EventHandler(DeleteEmployee));

			itemEmployeeManage.MenuCommands.AddRange(new MenuCommand[]{itemAddEmployee,itemModifyEmployee,itemDeleteEmployee});

			//添加订阅系统菜单
			Crownwood.Magic.Menus.MenuCommand itemSubscribeManage = new MenuCommand("订阅管理");
			Crownwood.Magic.Menus.MenuCommand itemAddSubscribe = new MenuCommand("添加订阅",new EventHandler(AddSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemBatchModifySubscribe = new MenuCommand("批量修改",new EventHandler(BatchModifySubscribe));

			Crownwood.Magic.Menus.MenuCommand itemModifySubscribe = new MenuCommand("修改订阅",new EventHandler(ModifySubscribe));
			Crownwood.Magic.Menus.MenuCommand itemDeleteSubscribe = new MenuCommand("删除订阅",new EventHandler(DeleteSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemSearchSubscribe = new MenuCommand("查询订阅",new EventHandler(SearchSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemOtherSearch = new MenuCommand("其它查询",new EventHandler(OtherSearch));
			Crownwood.Magic.Menus.MenuCommand itemInputSubscribe = new MenuCommand("数据导入",new EventHandler(InputSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemOutputSubscribe = new MenuCommand("数据导出",new EventHandler(OutputSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemStatSubscribe = new MenuCommand("统计金额",new EventHandler(StatSubscribe));

			itemSubscribeManage.MenuCommands.AddRange(new MenuCommand[]{itemAddSubscribe,itemModifySubscribe,itemBatchModifySubscribe,itemDeleteSubscribe,itemSearchSubscribe,itemOtherSearch,itemInputSubscribe,itemOutputSubscribe,itemStatSubscribe});
			
			//添加其他菜单
			Crownwood.Magic.Menus.MenuCommand itemOtherInfoManage = new MenuCommand("其它管理");
			Crownwood.Magic.Menus.MenuCommand itemAddRegion = new MenuCommand("添加地区",new EventHandler(AddRegion));
			Crownwood.Magic.Menus.MenuCommand itemDeleteRegion = new MenuCommand("删除地区",new EventHandler(DeleteRegion));

			itemOtherInfoManage.MenuCommands.AddRange(new MenuCommand[]{itemAddRegion,itemDeleteRegion});

			
			topMenu.MenuCommands.AddRange(new MenuCommand[]{itemUserManage,itemEmployeeManage,itemSubscribeManage,itemOtherInfoManage});
			topMenu.Dock = DockStyle.Top;
			
			this.Controls.Add(topMenu);
			this.ResumeLayout();
			this.Menu = null;
			topMenu.Style = Crownwood.Magic.Common.VisualStyle.IDE;
			topMenu.MdiContainer = this;

		}

		void CreateToolbar()
		{
			bar = new ToolBar();
			ImageList imgList = new ImageList();
			ResourceManager iconsManager    = null;
			iconsManager = new ResourceManager("main.BitmapResources",Assembly.GetEntryAssembly());

			imgList.Images.Add((Bitmap)iconsManager.GetObject("AddButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("SearchButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("ModifyButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("InputButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("OutputButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("DeleteButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("ClearButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("SelectAllButton"));
			imgList.Images.Add((Bitmap)iconsManager.GetObject("StatButton"));
			
			bar.AutoSize  = true;
			bar.ButtonClick += new ToolBarButtonClickEventHandler(ToolBarButtonClick);
			
			bar.Appearance = ToolBarAppearance.Flat;
			bar.TextAlign = ToolBarTextAlign.Right;
			//添加订阅按钮
			ToolBarButton btnAddSubscribe = new ToolBarButton();
			btnAddSubscribe.ImageIndex = 0;
			btnAddSubscribe.ToolTipText = "添加订阅信息";
			btnAddSubscribe.Text = "添加";
			//删除订阅按钮
			ToolBarButton btnDeleteSubscribe = new ToolBarButton();
			btnDeleteSubscribe.ImageIndex = 5;
			btnDeleteSubscribe.ToolTipText = "删除当前的订阅信息";
			btnDeleteSubscribe.Text = "删除";
			//查询订阅按钮
			ToolBarButton btnSearchSubscribe = new ToolBarButton();
			btnSearchSubscribe.ImageIndex = 1;
			btnSearchSubscribe.ToolTipText = "按条件查询订阅信息";
			btnSearchSubscribe.Text = "查询";
			//修改订阅按钮
			ToolBarButton btnModifySubscribe = new ToolBarButton();
			btnModifySubscribe.ImageIndex = 2;
			btnModifySubscribe.ToolTipText = "修改当前的订阅信息";
			btnModifySubscribe.Text = "修改";
			//数据导入按钮
			ToolBarButton btnInputSubscribe = new ToolBarButton();
			btnInputSubscribe.ImageIndex = 3;
			btnInputSubscribe.ToolTipText = "从Excel文件中导入订阅信息";
			btnInputSubscribe.Text = "导入";
			//数据导出按钮
			ToolBarButton btnOutputSubscribe = new ToolBarButton();
			btnOutputSubscribe.ImageIndex = 4;
			btnOutputSubscribe.ToolTipText = "将订阅信息导出到Excel文件";
			btnOutputSubscribe.Text = "导出";

			//隐藏按钮
			ToolBarButton btnClearSubscribe = new ToolBarButton();
			btnClearSubscribe.ImageIndex = 6;
			btnClearSubscribe.ToolTipText = "隐藏当前显示的记录";
			btnClearSubscribe.Text = "隐藏";

			//全选按钮
			ToolBarButton btnSelectAllSubscribe = new ToolBarButton();
			btnSelectAllSubscribe.ImageIndex = 7;
			btnSelectAllSubscribe.ToolTipText = "选中所有的订阅信息";
			btnSelectAllSubscribe.Text = "全选";

			//统计按钮
			ToolBarButton btnStatSubscribe = new ToolBarButton();
			btnStatSubscribe.ImageIndex = 8;
			btnStatSubscribe.ToolTipText = "统计符合条件的订阅信息的金额总数及详细情况";
			btnStatSubscribe.Text = "统计";

			bar.Buttons.AddRange(new ToolBarButton[]{btnAddSubscribe,btnDeleteSubscribe,btnSelectAllSubscribe,btnSearchSubscribe,btnModifySubscribe,btnInputSubscribe,btnOutputSubscribe,btnStatSubscribe,btnClearSubscribe});
			bar.ImageList = imgList;

			this.SuspendLayout();
			this.Controls.Add(bar);
			bar.BringToFront();
			this.ResumeLayout();
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

		void SetButtonEnabled()
		{
			if(currentManager.Property == 0)  //如果是一般用户
			{
				this.topMenu.MenuCommands["用户管理"].MenuCommands["添加新用户"].Enabled = false;
				this.topMenu.MenuCommands["用户管理"].MenuCommands["更新用户权限"].Enabled = false;
				this.topMenu.MenuCommands["用户管理"].MenuCommands["用户更改密码"].Enabled = true;
				this.topMenu.MenuCommands["用户管理"].MenuCommands["删除用户"].Enabled = false;


				this.topMenu.MenuCommands["业务员管理"].Enabled = false;
				this.topMenu.MenuCommands["其它管理"].Enabled = false;
				this.topMenu.MenuCommands["订阅管理"].MenuCommands["添加订阅"].Enabled = false;
				this.topMenu.MenuCommands["订阅管理"].MenuCommands["修改订阅"].Enabled = false;
				this.topMenu.MenuCommands["订阅管理"].MenuCommands["批量修改"].Enabled = false;
				this.topMenu.MenuCommands["订阅管理"].MenuCommands["删除订阅"].Enabled = false;
				this.topMenu.MenuCommands["订阅管理"].MenuCommands["数据导入"].Enabled = false;
				this.topMenu.MenuCommands["订阅管理"].MenuCommands["数据导出"].Enabled = false;

				this.bar.Buttons[1].Enabled = false;
				this.bar.Buttons[2].Enabled = false;
				this.bar.Buttons[4].Enabled = false;
				this.bar.Buttons[6].Enabled = false;
				if(this.currentDataSet == null)
				{
					this.bar.Buttons[8].Enabled = false;

				}
				else if(this.currentDataSet.Tables[0].Rows.Count == 0)
				{
					this.bar.Buttons[8].Enabled = false;

				}
				else
				{
					this.bar.Buttons[8].Enabled = true;
				}
				this.bar.Buttons[5].Enabled = false;
				this.bar.Buttons[0].Enabled = false;
				this.bar.Buttons[3].Enabled = true;
			}
			else
			{
				if(this.currentDataSet == null)
				{
					this.bar.Buttons[1].Enabled = false;
					this.bar.Buttons[2].Enabled = false;
					this.bar.Buttons[4].Enabled = false;
					this.bar.Buttons[6].Enabled = false;
					this.bar.Buttons[8].Enabled = false;
					this.bar.Buttons[5].Enabled = true;
					this.bar.Buttons[0].Enabled = true;
					this.bar.Buttons[3].Enabled = true;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["修改订阅"].Enabled = false;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["批量修改"].Enabled = false;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["删除订阅"].Enabled = false;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["数据导出"].Enabled = false;
				}
				else if(this.currentDataSet.Tables[0].Rows.Count == 0)
				{
					this.bar.Buttons[1].Enabled = false;
					this.bar.Buttons[2].Enabled = false;
					this.bar.Buttons[4].Enabled = false;
					this.bar.Buttons[6].Enabled = false;
					this.bar.Buttons[8].Enabled = false;
					this.bar.Buttons[5].Enabled = true;
					this.bar.Buttons[0].Enabled = true;
					this.bar.Buttons[3].Enabled = true;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["修改订阅"].Enabled = false;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["批量修改"].Enabled = false;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["删除订阅"].Enabled = false;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["数据导出"].Enabled = false;
				}
				else
				{
					this.bar.Buttons[2].Enabled = true;
					this.bar.Buttons[4].Enabled = true;
					this.bar.Buttons[5].Enabled = true;
					this.bar.Buttons[1].Enabled = true;
					this.bar.Buttons[3].Enabled = true;
					this.bar.Buttons[0].Enabled = true;
					this.bar.Buttons[6].Enabled = true;
					this.bar.Buttons[7].Enabled = true;
					this.bar.Buttons[8].Enabled = true;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["修改订阅"].Enabled = true;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["批量修改"].Enabled = true;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["删除订阅"].Enabled = true;
					this.topMenu.MenuCommands["订阅管理"].MenuCommands["数据导出"].Enabled = true;
				}
				if(this.currentManager.Property == 1)
				{
					this.topMenu.MenuCommands["用户管理"].MenuCommands["更新用户权限"].Enabled = false;
				}
			}

		}
		

		void RebindToDataGrid()
		{
			if(currentDataSet != null)
			{
				if(currentDataSet.Tables[0] != null)
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
					this.dataGrid1.TableStyles[0].RowHeaderWidth = 45;
					this.dataGrid1.TableStyles[0].AllowSorting = false;
					this.dataGrid1.TableStyles[0].GridColumnStyles["姓名"].Width = 60;
					this.dataGrid1.TableStyles[0].GridColumnStyles["公司"].Width = 170;
					this.dataGrid1.TableStyles[0].GridColumnStyles["地址"].Width = 200;

				}
			}
		}

		bool TestSelectedRows()
		{
			int i1;
			for(i1 = 0;i1<this.currentDataSet.Tables[0].Rows.Count;i1++)
			{
				if(this.dataGrid1.IsSelected(i1) == true)
				{
					break;
				}
			}
			if(i1 == this.currentDataSet.Tables[0].Rows.Count)
			{
				return false;
			}
			return true;
		}
		bool DeleteSelectedRows()
		{
			if(TestSelectedRows() == false)
			{
				MessageBox.Show("请选中一行进行删除！");
				return false;
			}
			if(MessageBox.Show("删除后不能恢复,是否删除？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				for(int i = 0;i<this.currentDataSet.Tables[0].Rows.Count;i++)  //通过循环删除所有被选中的行
				{
					if(this.dataGrid1.IsSelected(i) == true)
					{
						string name = this.currentDataSet.Tables[0].Rows[i]["姓名"].ToString();
						string company = this.currentDataSet.Tables[0].Rows[i]["公司"].ToString();
						SubscribeInfoManager.DeleteSubscribeInfo(name,company);
					}
				}
				
				this.currentDataSet = SubscribeInfoManager.RetriveDataFromTempInfo();

				return true;
			}
			else
			{
				return false;
			}
		}

		void ToolBarButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch (e.Button.Text) 
			{
				case "添加":
					AddForm addForm = new AddForm();
					addForm.StartPosition = FormStartPosition.CenterParent;
					if(addForm.ShowDialog() == DialogResult.OK)
					{
						RebindToDataGrid();
					}
					break;
				case "删除":
					if(DeleteSelectedRows() == true)
					{
						RebindToDataGrid();
					}
					break;
				case "修改":
					UpdateForm updateForm = new UpdateForm();
					updateForm.StartPosition = FormStartPosition.CenterParent;
					if(updateForm.ShowDialog() == DialogResult.OK)
					{
						RebindToDataGrid();
					}
					break;
				case "查询":
					SearchForm searchForm = new SearchForm();
					searchForm.StartPosition = FormStartPosition.CenterParent;
					if(searchForm.ShowDialog() == DialogResult.OK)
					{
						RebindToDataGrid();
					}
					break;
				case "导入":
					//if(MessageBox.Show("导入前请先保存并关闭所有打开的Excel文档!","警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1) == DialogResult.OK)
					//{
						if(ImportExcelData() == true)
						{
							RebindToDataGrid();
						}
					//}
					break;
				case "导出":
					ExportDataToExcel();
					break;
				case "隐藏":
					this.currentDataSet = null;
					this.dataGrid1.DataSource = null;
					break;
				case "全选":
					for(int i=0;i<this.currentDataSet.Tables[0].Rows.Count;i++)
					{
						this.dataGrid1.Select(i);
					}
					break;
				case "统计":
					StatSubscribeForm statSubscribeForm = new StatSubscribeForm();
					statSubscribeForm.StartPosition = FormStartPosition.CenterParent;
					if(statSubscribeForm.ShowDialog() == DialogResult.OK)
					{
						ShowStatResultForm form = new ShowStatResultForm(this.statResultTable,this.currentInputDate);
						form.StartPosition = FormStartPosition.CenterParent;
						form.ShowDialog();
					}
					break;
			}
		}

		
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			CreateMainMenu();//创建菜单栏

			CreateToolbar();//创建工具栏

			CreateSplitter();//创建一个分割条
			
			SetButtonEnabled();//设置工具栏上按钮的活动状态

			SubscribeInfoManager.ClearTempInfo();  //清楚临时表中的数据
			
			this.Text = this.Text + "     当前用户:  " + this.currentManager.Name;


		}

		private void dataGrid1_DataSourceChanged(object sender, System.EventArgs e)
		{
			SetButtonEnabled();
		}

		
		private void dataGrid1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{

			int row =1;  
			int y = 0;
			if(this.currentDataSet != null)
			{
				int count =this.currentDataSet.Tables[0].Rows.Count; 

				while( row <= count)  
				{ 
					//get & draw the header text... 
 
					string text = string.Format(" {0}", row);

					y = this.dataGrid1.GetCellBounds(row - 1, 0).Y + 2;
 
					e.Graphics.DrawString(text,this.dataGrid1.Font, new SolidBrush(Color.Black),2,y); 

					row ++;  
				}
			}

		}


		void CreatePopUpMenu(object sender,MouseEventArgs e)
		{
			PopupMenu popup = new PopupMenu();
			DataGrid myGrid = (DataGrid) sender;
			popup.Style = Crownwood.Magic.Common.VisualStyle.IDE;

			Crownwood.Magic.Menus.MenuCommand itemAddSubscribe = new MenuCommand("添加订阅",new EventHandler(AddSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemModifySubscribe = new MenuCommand("修改订阅",new EventHandler(ModifySubscribe));
			Crownwood.Magic.Menus.MenuCommand itemDeleteSubscribe = new MenuCommand("删除订阅",new EventHandler(DeleteSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemSearchSubscribe = new MenuCommand("查询订阅",new EventHandler(SearchSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemInputSubscribe = new MenuCommand("数据导入",new EventHandler(InputSubscribe));
			Crownwood.Magic.Menus.MenuCommand itemOutputSubscribe = new MenuCommand("数据导出",new EventHandler(OutputSubscribe));

			popup.MenuCommands.AddRange(new MenuCommand[]{itemAddSubscribe,itemModifySubscribe,itemDeleteSubscribe,itemSearchSubscribe,itemInputSubscribe,itemOutputSubscribe});

			if(this.currentManager.Property == 0)
			{
				popup.MenuCommands["添加订阅"].Enabled = false;
				popup.MenuCommands["修改订阅"].Enabled = false;
				popup.MenuCommands["删除订阅"].Enabled = false;
				popup.MenuCommands["查询订阅"].Enabled = true;
				popup.MenuCommands["数据导入"].Enabled = false;
				popup.MenuCommands["数据导出"].Enabled = false;

			}
			
			popup.TrackPopup(myGrid.PointToScreen(new Point(e.X, e.Y)));


		}
		
		private void dataGrid1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			DataGrid myGrid = (DataGrid) sender;
			DataGrid.HitTestInfo hti = myGrid.HitTest(e.X,e.Y);
			if(e.Button == MouseButtons.Right)
			{
				if(hti.Type == DataGrid.HitTestType.RowHeader)
				{
					CreatePopUpMenu(sender,e);
				}
			}

		}


	}


}

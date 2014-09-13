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
	
	public class UpdateForm : System.Windows.Forms.Form
	{
		#region 一些变量

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSubmit;

		string startDate;
		string endDate;
		string giveDate;

		string number;
		string monthCount;
		string totalMoney;
		string oldName;
		string newName;
		string localAddress;
		string oldCompany;
		string newCompany;
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

		private System.Windows.Forms.Label lblHead;
		private System.Windows.Forms.TextBox txtMonthCount;
		private System.Windows.Forms.TextBox txtTotalMoney;
		private System.Windows.Forms.Label lblTotalMoney;
		private System.Windows.Forms.Label lblGiveDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbGiveYear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbGiveMonth;
		private System.Windows.Forms.Label lblMonthCount;
		private System.Windows.Forms.ComboBox cmbBonus;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPostCode;
		private System.Windows.Forms.TextBox txtPost;
		private System.Windows.Forms.TextBox txtMobilephone;
		private System.Windows.Forms.TextBox txtTelephone;
		private System.Windows.Forms.TextBox txtInscribe;
		private System.Windows.Forms.TextBox txtInvoice;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtCompany;
		private System.Windows.Forms.TextBox txtLocalAddress;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblPostCode;
		private System.Windows.Forms.Label lblPost;
		private System.Windows.Forms.Label lblMobilephone;
		private System.Windows.Forms.Label lblTelephone;
		private System.Windows.Forms.ComboBox cmbPayment;
		private System.Windows.Forms.Label lblPayment;
		private System.Windows.Forms.Label lblBonus;
		private System.Windows.Forms.ComboBox cmbOperator;
		private System.Windows.Forms.Label lblOperator;
		private System.Windows.Forms.Label lblInscribe;
		private System.Windows.Forms.Label lblInvoice;
		private System.Windows.Forms.ComboBox cmbClient;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.Label lblNumber1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblCompany;
		private System.Windows.Forms.Label lblRegion;
		private System.Windows.Forms.ComboBox cmbRegion;
		private System.Windows.Forms.Label lblLocalAddress;
		private System.Windows.Forms.Label lblStartDate;
		private System.Windows.Forms.Label lblStartYear;
		private System.Windows.Forms.ComboBox cmbStartYear;
		private System.Windows.Forms.Label lblStartMonth;
		private System.Windows.Forms.ComboBox cmbStartMonth;
		private System.Windows.Forms.Label lblEndDate;
		private System.Windows.Forms.ComboBox cmbEndMonth;
		private System.Windows.Forms.Label lblEndMonth;
		private System.Windows.Forms.ComboBox cmbEndYear;
		private System.Windows.Forms.Label lblEndYear;
		private System.Windows.Forms.Label lblSubscription;
		private System.Windows.Forms.ComboBox cmbSubscription;
		private System.Windows.Forms.Label lblNumber;

		#endregion
		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UpdateForm));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblHead = new System.Windows.Forms.Label();
			this.txtMonthCount = new System.Windows.Forms.TextBox();
			this.txtTotalMoney = new System.Windows.Forms.TextBox();
			this.lblTotalMoney = new System.Windows.Forms.Label();
			this.lblGiveDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbGiveYear = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbGiveMonth = new System.Windows.Forms.ComboBox();
			this.lblMonthCount = new System.Windows.Forms.Label();
			this.cmbBonus = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPostCode = new System.Windows.Forms.TextBox();
			this.txtPost = new System.Windows.Forms.TextBox();
			this.txtMobilephone = new System.Windows.Forms.TextBox();
			this.txtTelephone = new System.Windows.Forms.TextBox();
			this.txtInscribe = new System.Windows.Forms.TextBox();
			this.txtInvoice = new System.Windows.Forms.TextBox();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCompany = new System.Windows.Forms.TextBox();
			this.txtLocalAddress = new System.Windows.Forms.TextBox();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPostCode = new System.Windows.Forms.Label();
			this.lblPost = new System.Windows.Forms.Label();
			this.lblMobilephone = new System.Windows.Forms.Label();
			this.lblTelephone = new System.Windows.Forms.Label();
			this.cmbPayment = new System.Windows.Forms.ComboBox();
			this.lblPayment = new System.Windows.Forms.Label();
			this.lblBonus = new System.Windows.Forms.Label();
			this.cmbOperator = new System.Windows.Forms.ComboBox();
			this.lblOperator = new System.Windows.Forms.Label();
			this.lblInscribe = new System.Windows.Forms.Label();
			this.lblInvoice = new System.Windows.Forms.Label();
			this.cmbClient = new System.Windows.Forms.ComboBox();
			this.lblClient = new System.Windows.Forms.Label();
			this.lblSource = new System.Windows.Forms.Label();
			this.lblNumber1 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCompany = new System.Windows.Forms.Label();
			this.lblRegion = new System.Windows.Forms.Label();
			this.cmbRegion = new System.Windows.Forms.ComboBox();
			this.lblLocalAddress = new System.Windows.Forms.Label();
			this.lblStartDate = new System.Windows.Forms.Label();
			this.lblStartYear = new System.Windows.Forms.Label();
			this.cmbStartYear = new System.Windows.Forms.ComboBox();
			this.lblStartMonth = new System.Windows.Forms.Label();
			this.cmbStartMonth = new System.Windows.Forms.ComboBox();
			this.lblEndDate = new System.Windows.Forms.Label();
			this.cmbEndMonth = new System.Windows.Forms.ComboBox();
			this.lblEndMonth = new System.Windows.Forms.Label();
			this.cmbEndYear = new System.Windows.Forms.ComboBox();
			this.lblEndYear = new System.Windows.Forms.Label();
			this.lblSubscription = new System.Windows.Forms.Label();
			this.cmbSubscription = new System.Windows.Forms.ComboBox();
			this.lblNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(304, 496);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(64, 32);
			this.btnCancel.TabIndex = 60;
			this.btnCancel.Text = "取 消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(160, 496);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(64, 32);
			this.btnSubmit.TabIndex = 59;
			this.btnSubmit.Text = "确 定";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblHead
			// 
			this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblHead.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lblHead.Location = new System.Drawing.Point(0, 0);
			this.lblHead.Name = "lblHead";
			this.lblHead.Size = new System.Drawing.Size(536, 32);
			this.lblHead.TabIndex = 58;
			this.lblHead.Text = "修改订阅信息";
			this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMonthCount
			// 
			this.txtMonthCount.Location = new System.Drawing.Point(384, 208);
			this.txtMonthCount.Name = "txtMonthCount";
			this.txtMonthCount.Size = new System.Drawing.Size(64, 21);
			this.txtMonthCount.TabIndex = 207;
			this.txtMonthCount.Text = "";
			// 
			// txtTotalMoney
			// 
			this.txtTotalMoney.Location = new System.Drawing.Point(384, 248);
			this.txtTotalMoney.Name = "txtTotalMoney";
			this.txtTotalMoney.Size = new System.Drawing.Size(64, 21);
			this.txtTotalMoney.TabIndex = 206;
			this.txtTotalMoney.Text = "";
			// 
			// lblTotalMoney
			// 
			this.lblTotalMoney.Location = new System.Drawing.Point(336, 256);
			this.lblTotalMoney.Name = "lblTotalMoney";
			this.lblTotalMoney.Size = new System.Drawing.Size(32, 23);
			this.lblTotalMoney.TabIndex = 205;
			this.lblTotalMoney.Text = "金额";
			// 
			// lblGiveDate
			// 
			this.lblGiveDate.Location = new System.Drawing.Point(24, 256);
			this.lblGiveDate.Name = "lblGiveDate";
			this.lblGiveDate.Size = new System.Drawing.Size(56, 16);
			this.lblGiveDate.TabIndex = 200;
			this.lblGiveDate.Text = "付款日期";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(96, 256);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 16);
			this.label2.TabIndex = 201;
			this.label2.Text = "年";
			// 
			// cmbGiveYear
			// 
			this.cmbGiveYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGiveYear.Location = new System.Drawing.Point(120, 248);
			this.cmbGiveYear.Name = "cmbGiveYear";
			this.cmbGiveYear.Size = new System.Drawing.Size(72, 20);
			this.cmbGiveYear.TabIndex = 202;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(208, 256);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 203;
			this.label3.Text = "月";
			// 
			// cmbGiveMonth
			// 
			this.cmbGiveMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGiveMonth.Location = new System.Drawing.Point(232, 248);
			this.cmbGiveMonth.Name = "cmbGiveMonth";
			this.cmbGiveMonth.Size = new System.Drawing.Size(56, 20);
			this.cmbGiveMonth.TabIndex = 204;
			// 
			// lblMonthCount
			// 
			this.lblMonthCount.Location = new System.Drawing.Point(336, 216);
			this.lblMonthCount.Name = "lblMonthCount";
			this.lblMonthCount.Size = new System.Drawing.Size(32, 23);
			this.lblMonthCount.TabIndex = 199;
			this.lblMonthCount.Text = "期数";
			// 
			// cmbBonus
			// 
			this.cmbBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBonus.Location = new System.Drawing.Point(328, 440);
			this.cmbBonus.Name = "cmbBonus";
			this.cmbBonus.Size = new System.Drawing.Size(112, 20);
			this.cmbBonus.TabIndex = 198;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(72, 112);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(248, 21);
			this.txtAddress.TabIndex = 197;
			this.txtAddress.Text = "";
			// 
			// txtPostCode
			// 
			this.txtPostCode.Location = new System.Drawing.Point(232, 176);
			this.txtPostCode.Name = "txtPostCode";
			this.txtPostCode.TabIndex = 195;
			this.txtPostCode.Text = "";
			// 
			// txtPost
			// 
			this.txtPost.Location = new System.Drawing.Point(272, 56);
			this.txtPost.Name = "txtPost";
			this.txtPost.TabIndex = 193;
			this.txtPost.Text = "";
			// 
			// txtMobilephone
			// 
			this.txtMobilephone.Location = new System.Drawing.Point(392, 144);
			this.txtMobilephone.Name = "txtMobilephone";
			this.txtMobilephone.Size = new System.Drawing.Size(120, 21);
			this.txtMobilephone.TabIndex = 191;
			this.txtMobilephone.Text = "";
			// 
			// txtTelephone
			// 
			this.txtTelephone.Location = new System.Drawing.Point(232, 144);
			this.txtTelephone.Name = "txtTelephone";
			this.txtTelephone.TabIndex = 189;
			this.txtTelephone.Text = "";
			// 
			// txtInscribe
			// 
			this.txtInscribe.Location = new System.Drawing.Point(96, 416);
			this.txtInscribe.Name = "txtInscribe";
			this.txtInscribe.Size = new System.Drawing.Size(216, 21);
			this.txtInscribe.TabIndex = 182;
			this.txtInscribe.Text = "";
			// 
			// txtInvoice
			// 
			this.txtInvoice.Location = new System.Drawing.Point(96, 384);
			this.txtInvoice.Name = "txtInvoice";
			this.txtInvoice.TabIndex = 180;
			this.txtInvoice.Text = "";
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(256, 312);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(128, 21);
			this.txtSource.TabIndex = 176;
			this.txtSource.Text = "";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(72, 56);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(120, 21);
			this.txtName.TabIndex = 153;
			this.txtName.Text = "";
			// 
			// txtCompany
			// 
			this.txtCompany.Location = new System.Drawing.Point(72, 88);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.Size = new System.Drawing.Size(208, 21);
			this.txtCompany.TabIndex = 152;
			this.txtCompany.Text = "";
			// 
			// txtLocalAddress
			// 
			this.txtLocalAddress.Location = new System.Drawing.Point(72, 176);
			this.txtLocalAddress.Name = "txtLocalAddress";
			this.txtLocalAddress.Size = new System.Drawing.Size(88, 21);
			this.txtLocalAddress.TabIndex = 159;
			this.txtLocalAddress.Text = "";
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(96, 352);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(48, 21);
			this.txtNumber.TabIndex = 173;
			this.txtNumber.Text = "";
			// 
			// lblAddress
			// 
			this.lblAddress.Location = new System.Drawing.Point(24, 120);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(40, 16);
			this.lblAddress.TabIndex = 196;
			this.lblAddress.Text = "地址";
			// 
			// lblPostCode
			// 
			this.lblPostCode.Location = new System.Drawing.Point(184, 184);
			this.lblPostCode.Name = "lblPostCode";
			this.lblPostCode.Size = new System.Drawing.Size(40, 16);
			this.lblPostCode.TabIndex = 194;
			this.lblPostCode.Text = "邮编";
			// 
			// lblPost
			// 
			this.lblPost.Location = new System.Drawing.Point(224, 64);
			this.lblPost.Name = "lblPost";
			this.lblPost.Size = new System.Drawing.Size(32, 16);
			this.lblPost.TabIndex = 192;
			this.lblPost.Text = "职位";
			// 
			// lblMobilephone
			// 
			this.lblMobilephone.Location = new System.Drawing.Point(344, 152);
			this.lblMobilephone.Name = "lblMobilephone";
			this.lblMobilephone.Size = new System.Drawing.Size(40, 13);
			this.lblMobilephone.TabIndex = 190;
			this.lblMobilephone.Text = "手机";
			// 
			// lblTelephone
			// 
			this.lblTelephone.Location = new System.Drawing.Point(184, 152);
			this.lblTelephone.Name = "lblTelephone";
			this.lblTelephone.Size = new System.Drawing.Size(40, 13);
			this.lblTelephone.TabIndex = 188;
			this.lblTelephone.Text = "电话";
			// 
			// cmbPayment
			// 
			this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPayment.Location = new System.Drawing.Point(272, 352);
			this.cmbPayment.Name = "cmbPayment";
			this.cmbPayment.Size = new System.Drawing.Size(120, 20);
			this.cmbPayment.TabIndex = 187;
			// 
			// lblPayment
			// 
			this.lblPayment.Location = new System.Drawing.Point(208, 360);
			this.lblPayment.Name = "lblPayment";
			this.lblPayment.Size = new System.Drawing.Size(56, 16);
			this.lblPayment.TabIndex = 186;
			this.lblPayment.Text = "付款方式";
			// 
			// lblBonus
			// 
			this.lblBonus.Location = new System.Drawing.Point(256, 448);
			this.lblBonus.Name = "lblBonus";
			this.lblBonus.Size = new System.Drawing.Size(64, 16);
			this.lblBonus.TabIndex = 185;
			this.lblBonus.Text = "奖金提取";
			// 
			// cmbOperator
			// 
			this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOperator.Location = new System.Drawing.Point(96, 440);
			this.cmbOperator.Name = "cmbOperator";
			this.cmbOperator.Size = new System.Drawing.Size(112, 20);
			this.cmbOperator.TabIndex = 184;
			// 
			// lblOperator
			// 
			this.lblOperator.Location = new System.Drawing.Point(24, 448);
			this.lblOperator.Name = "lblOperator";
			this.lblOperator.Size = new System.Drawing.Size(48, 16);
			this.lblOperator.TabIndex = 183;
			this.lblOperator.Text = "业务员";
			// 
			// lblInscribe
			// 
			this.lblInscribe.Location = new System.Drawing.Point(24, 416);
			this.lblInscribe.Name = "lblInscribe";
			this.lblInscribe.Size = new System.Drawing.Size(56, 16);
			this.lblInscribe.TabIndex = 181;
			this.lblInscribe.Text = "落款";
			// 
			// lblInvoice
			// 
			this.lblInvoice.Location = new System.Drawing.Point(24, 392);
			this.lblInvoice.Name = "lblInvoice";
			this.lblInvoice.Size = new System.Drawing.Size(64, 16);
			this.lblInvoice.TabIndex = 179;
			this.lblInvoice.Text = "发票号";
			// 
			// cmbClient
			// 
			this.cmbClient.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClient.Location = new System.Drawing.Point(456, 312);
			this.cmbClient.Name = "cmbClient";
			this.cmbClient.Size = new System.Drawing.Size(56, 20);
			this.cmbClient.TabIndex = 178;
			// 
			// lblClient
			// 
			this.lblClient.Location = new System.Drawing.Point(392, 320);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new System.Drawing.Size(56, 16);
			this.lblClient.TabIndex = 177;
			this.lblClient.Text = "客户类别";
			// 
			// lblSource
			// 
			this.lblSource.Location = new System.Drawing.Point(216, 320);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(32, 16);
			this.lblSource.TabIndex = 175;
			this.lblSource.Text = "来源";
			// 
			// lblNumber1
			// 
			this.lblNumber1.Location = new System.Drawing.Point(152, 360);
			this.lblNumber1.Name = "lblNumber1";
			this.lblNumber1.Size = new System.Drawing.Size(16, 16);
			this.lblNumber1.TabIndex = 174;
			this.lblNumber1.Text = "份";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(24, 64);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(32, 16);
			this.lblName.TabIndex = 154;
			this.lblName.Text = "姓名";
			// 
			// lblCompany
			// 
			this.lblCompany.Location = new System.Drawing.Point(24, 96);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(32, 16);
			this.lblCompany.TabIndex = 157;
			this.lblCompany.Text = "公司";
			// 
			// lblRegion
			// 
			this.lblRegion.Location = new System.Drawing.Point(24, 152);
			this.lblRegion.Name = "lblRegion";
			this.lblRegion.Size = new System.Drawing.Size(32, 16);
			this.lblRegion.TabIndex = 155;
			this.lblRegion.Text = "地区";
			// 
			// cmbRegion
			// 
			this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRegion.Location = new System.Drawing.Point(72, 144);
			this.cmbRegion.Name = "cmbRegion";
			this.cmbRegion.Size = new System.Drawing.Size(88, 20);
			this.cmbRegion.TabIndex = 156;
			// 
			// lblLocalAddress
			// 
			this.lblLocalAddress.Location = new System.Drawing.Point(24, 184);
			this.lblLocalAddress.Name = "lblLocalAddress";
			this.lblLocalAddress.Size = new System.Drawing.Size(32, 16);
			this.lblLocalAddress.TabIndex = 158;
			this.lblLocalAddress.Text = "县区";
			// 
			// lblStartDate
			// 
			this.lblStartDate.Location = new System.Drawing.Point(24, 216);
			this.lblStartDate.Name = "lblStartDate";
			this.lblStartDate.Size = new System.Drawing.Size(56, 16);
			this.lblStartDate.TabIndex = 160;
			this.lblStartDate.Text = "起始日期";
			// 
			// lblStartYear
			// 
			this.lblStartYear.Location = new System.Drawing.Point(96, 216);
			this.lblStartYear.Name = "lblStartYear";
			this.lblStartYear.Size = new System.Drawing.Size(16, 16);
			this.lblStartYear.TabIndex = 161;
			this.lblStartYear.Text = "年";
			// 
			// cmbStartYear
			// 
			this.cmbStartYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStartYear.Location = new System.Drawing.Point(120, 208);
			this.cmbStartYear.Name = "cmbStartYear";
			this.cmbStartYear.Size = new System.Drawing.Size(72, 20);
			this.cmbStartYear.TabIndex = 162;
			// 
			// lblStartMonth
			// 
			this.lblStartMonth.Location = new System.Drawing.Point(208, 216);
			this.lblStartMonth.Name = "lblStartMonth";
			this.lblStartMonth.Size = new System.Drawing.Size(16, 16);
			this.lblStartMonth.TabIndex = 163;
			this.lblStartMonth.Text = "月";
			// 
			// cmbStartMonth
			// 
			this.cmbStartMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStartMonth.Location = new System.Drawing.Point(232, 208);
			this.cmbStartMonth.Name = "cmbStartMonth";
			this.cmbStartMonth.Size = new System.Drawing.Size(56, 20);
			this.cmbStartMonth.TabIndex = 164;
			// 
			// lblEndDate
			// 
			this.lblEndDate.Location = new System.Drawing.Point(24, 288);
			this.lblEndDate.Name = "lblEndDate";
			this.lblEndDate.Size = new System.Drawing.Size(56, 16);
			this.lblEndDate.TabIndex = 165;
			this.lblEndDate.Text = "终止日期";
			// 
			// cmbEndMonth
			// 
			this.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEndMonth.Location = new System.Drawing.Point(232, 280);
			this.cmbEndMonth.Name = "cmbEndMonth";
			this.cmbEndMonth.Size = new System.Drawing.Size(56, 20);
			this.cmbEndMonth.TabIndex = 169;
			// 
			// lblEndMonth
			// 
			this.lblEndMonth.Location = new System.Drawing.Point(208, 288);
			this.lblEndMonth.Name = "lblEndMonth";
			this.lblEndMonth.Size = new System.Drawing.Size(16, 16);
			this.lblEndMonth.TabIndex = 168;
			this.lblEndMonth.Text = "月";
			// 
			// cmbEndYear
			// 
			this.cmbEndYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEndYear.Location = new System.Drawing.Point(120, 280);
			this.cmbEndYear.Name = "cmbEndYear";
			this.cmbEndYear.Size = new System.Drawing.Size(72, 20);
			this.cmbEndYear.TabIndex = 167;
			// 
			// lblEndYear
			// 
			this.lblEndYear.Location = new System.Drawing.Point(96, 288);
			this.lblEndYear.Name = "lblEndYear";
			this.lblEndYear.Size = new System.Drawing.Size(16, 16);
			this.lblEndYear.TabIndex = 166;
			this.lblEndYear.Text = "年";
			// 
			// lblSubscription
			// 
			this.lblSubscription.Location = new System.Drawing.Point(24, 320);
			this.lblSubscription.Name = "lblSubscription";
			this.lblSubscription.Size = new System.Drawing.Size(56, 16);
			this.lblSubscription.TabIndex = 170;
			this.lblSubscription.Text = "订阅形式";
			// 
			// cmbSubscription
			// 
			this.cmbSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSubscription.Location = new System.Drawing.Point(96, 312);
			this.cmbSubscription.Name = "cmbSubscription";
			this.cmbSubscription.Size = new System.Drawing.Size(96, 20);
			this.cmbSubscription.TabIndex = 171;
			// 
			// lblNumber
			// 
			this.lblNumber.Location = new System.Drawing.Point(24, 360);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(56, 16);
			this.lblNumber.TabIndex = 172;
			this.lblNumber.Text = "份数等于";
			// 
			// UpdateForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(536, 549);
			this.Controls.Add(this.txtMonthCount);
			this.Controls.Add(this.txtTotalMoney);
			this.Controls.Add(this.lblTotalMoney);
			this.Controls.Add(this.lblGiveDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbGiveYear);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbGiveMonth);
			this.Controls.Add(this.lblMonthCount);
			this.Controls.Add(this.cmbBonus);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPostCode);
			this.Controls.Add(this.txtPost);
			this.Controls.Add(this.txtMobilephone);
			this.Controls.Add(this.txtTelephone);
			this.Controls.Add(this.txtInscribe);
			this.Controls.Add(this.txtInvoice);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtCompany);
			this.Controls.Add(this.txtLocalAddress);
			this.Controls.Add(this.txtNumber);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblPostCode);
			this.Controls.Add(this.lblPost);
			this.Controls.Add(this.lblMobilephone);
			this.Controls.Add(this.lblTelephone);
			this.Controls.Add(this.cmbPayment);
			this.Controls.Add(this.lblPayment);
			this.Controls.Add(this.lblBonus);
			this.Controls.Add(this.cmbOperator);
			this.Controls.Add(this.lblOperator);
			this.Controls.Add(this.lblInscribe);
			this.Controls.Add(this.lblInvoice);
			this.Controls.Add(this.cmbClient);
			this.Controls.Add(this.lblClient);
			this.Controls.Add(this.lblSource);
			this.Controls.Add(this.lblNumber1);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblCompany);
			this.Controls.Add(this.lblRegion);
			this.Controls.Add(this.cmbRegion);
			this.Controls.Add(this.lblLocalAddress);
			this.Controls.Add(this.lblStartDate);
			this.Controls.Add(this.lblStartYear);
			this.Controls.Add(this.cmbStartYear);
			this.Controls.Add(this.lblStartMonth);
			this.Controls.Add(this.cmbStartMonth);
			this.Controls.Add(this.lblEndDate);
			this.Controls.Add(this.cmbEndMonth);
			this.Controls.Add(this.lblEndMonth);
			this.Controls.Add(this.cmbEndYear);
			this.Controls.Add(this.lblEndYear);
			this.Controls.Add(this.lblSubscription);
			this.Controls.Add(this.cmbSubscription);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblHead);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "UpdateForm";
			this.Text = "修改订阅信息";
			this.Load += new System.EventHandler(this.UpdateForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private System.ComponentModel.Container components = null;
		public UpdateForm()
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


		void InitData()
		{
			DataTable table = MainForm.Form.CurrentDataSet.Tables[0];
			DataGrid grid = MainForm.Form.ShowResultDataGrid;
			//先读取所有的数据
			this.startDate = table.Rows[grid.CurrentRowIndex]["起始日期"] == DBNull.Value ? "" : table.Rows[grid.CurrentRowIndex]["起始日期"].ToString();
			this.endDate = table.Rows[grid.CurrentRowIndex]["结束日期"] == DBNull.Value ? "" : table.Rows[grid.CurrentRowIndex]["结束日期"].ToString();
			this.giveDate = table.Rows[grid.CurrentRowIndex]["付款日期"] == DBNull.Value ? "" : table.Rows[grid.CurrentRowIndex]["付款日期"].ToString();
			this.number = table.Rows[grid.CurrentRowIndex]["份数"] == DBNull.Value ? "" : table.Rows[grid.CurrentRowIndex]["份数"].ToString();
			this.monthCount = table.Rows[grid.CurrentRowIndex]["期数"] == DBNull.Value ? "" : table.Rows[grid.CurrentRowIndex]["期数"].ToString();
			this.totalMoney = table.Rows[grid.CurrentRowIndex]["金额"] == DBNull.Value ? "" : table.Rows[grid.CurrentRowIndex]["金额"].ToString();
			this.oldName = table.Rows[grid.CurrentRowIndex]["姓名"].ToString();
			this.localAddress = table.Rows[grid.CurrentRowIndex]["县级地区"].ToString();
			this.region = table.Rows[grid.CurrentRowIndex]["地区"].ToString();
			this.oldCompany = table.Rows[grid.CurrentRowIndex]["公司"].ToString();
			this.subscription = table.Rows[grid.CurrentRowIndex]["订阅形式"].ToString();
			this.post = table.Rows[grid.CurrentRowIndex]["职位"].ToString();
			this.address = table.Rows[grid.CurrentRowIndex]["地址"].ToString();
			this.postcode = table.Rows[grid.CurrentRowIndex]["邮编"].ToString();
			this.mobilePhone = table.Rows[grid.CurrentRowIndex]["手机"].ToString();
			this.telephone = table.Rows[grid.CurrentRowIndex]["电话"].ToString();
			this.inscribe = table.Rows[grid.CurrentRowIndex]["落款"].ToString();
			this.source = table.Rows[grid.CurrentRowIndex]["来源"].ToString();
			this.payment = table.Rows[grid.CurrentRowIndex]["支付方式"].ToString();
			this.invoice = table.Rows[grid.CurrentRowIndex]["发票号"].ToString();
			this.client = table.Rows[grid.CurrentRowIndex]["客户类别"].ToString();
			this.operator1 = table.Rows[grid.CurrentRowIndex]["业务员"].ToString();
			this.bonus = table.Rows[grid.CurrentRowIndex]["奖金提取"].ToString();
			//为窗体上的各个控件赋值
			DataTable tblRegions = SubscribeInfoManager.RetrieveRegions();
			DataTable tblEmployees = EmployeeManager.RetrieveAllEmployees();//得到所有的业务员
			
			this.txtName.Text = this.oldName;
			this.txtNumber.Text = this.number;
			this.txtMonthCount.Text = this.monthCount;
			this.txtTotalMoney.Text = this.totalMoney;
			this.txtLocalAddress.Text = this.localAddress;
			this.txtCompany.Text = this.oldCompany;
			this.txtAddress.Text = this.address;
			this.txtPost.Text = this.post;
			this.txtPostCode.Text = this.postcode;
			this.txtTelephone.Text = this.telephone;
			this.txtMobilephone.Text = this.mobilePhone;
			this.txtInscribe.Text = this.inscribe;
			this.txtInvoice.Text = this.invoice;
			this.txtSource.Text = this.source;

			//bind data to region comboBox
			this.cmbRegion.DataSource = tblRegions;
			this.cmbRegion.DisplayMember = "name";
			this.cmbRegion.ValueMember = "name";
			for(int i=0;i<this.cmbRegion.Items.Count;i++)
			{
				this.cmbRegion.SelectedIndex = i;

				if(this.cmbRegion.SelectedValue.ToString() == this.region)
				{
					break;
				}
			}
			//bind data to payment comboBox
			this.cmbPayment.Items.Add("  ");
			this.cmbPayment.Items.Add("现金支付");
			this.cmbPayment.Items.Add("银行转帐");
			this.cmbPayment.Items.Add("邮局汇款");
			this.cmbPayment.Items.Add("网上支付");
			this.cmbPayment.Items.Add("货到付款");
			if(this.payment.Trim() == "")
			{
				this.cmbPayment.SelectedIndex = 0;
			}
			else if(this.payment == "现金支付")
			{
				this.cmbPayment.SelectedIndex = 1;
			}
			else if(this.payment == "银行转帐")
			{
				this.cmbPayment.SelectedIndex = 2;
			}
			else if(this.payment == "邮局汇款")
			{
				this.cmbPayment.SelectedIndex = 3;
			}
			else if(this.payment == "网上支付")
			{
				this.cmbPayment.SelectedIndex = 4;
			}
			else
			{
				this.cmbPayment.SelectedIndex = 5;
			}
			//bind data to client comboBox
			this.cmbOperator.DataSource = tblEmployees;
			this.cmbOperator.DisplayMember = "name";
			this.cmbOperator.ValueMember = "name";
			for(int i= 0;i<this.cmbOperator.Items.Count;i++)
			{
				this.cmbOperator.SelectedIndex = i;

				if(this.cmbOperator.SelectedValue.ToString() == this.operator1)
				{
					break;
				}
			}
			//add items to bonus comboBox
			this.cmbBonus.Items.Add("  ");
			this.cmbBonus.Items.Add("已提");
			this.cmbBonus.Items.Add("未提");
			this.cmbBonus.SelectedIndex = 0;
			if(this.bonus.Trim() == "")
			{
				this.cmbBonus.SelectedIndex = 0;
			}
			else if(this.bonus == "已提")
			{
				this.cmbBonus.SelectedIndex = 1;
			}
			else
			{
				this.cmbBonus.SelectedIndex = 2;
			}
			//add items to subscription comboBox
			this.cmbSubscription.Items.Add("  ");
			this.cmbSubscription.Items.Add("订阅");
			this.cmbSubscription.Items.Add("赠阅");
			if(this.subscription.Trim() == "")
			{
				this.cmbSubscription.SelectedIndex = 0;
			}
			else if(this.subscription == "订阅")
			{
				this.cmbSubscription.SelectedIndex = 1;
			}
			else
			{
				this.cmbSubscription.SelectedIndex = 2;
			}
			//add items to clientCategory comboBox
			this.cmbClient.Items.Add("  ");
			this.cmbClient.Items.Add("A");
			this.cmbClient.Items.Add("B");
			this.cmbClient.Items.Add("C");
			if(this.client.Trim() == "")
			{
				this.cmbClient.SelectedIndex = 0;
			}
			else if(this.client == "A")
			{
				this.cmbClient.SelectedIndex = 1;
			}
			else if(this.client == "B")
			{
				this.cmbClient.SelectedIndex = 2;
			}
			else
			{
				this.cmbClient.SelectedIndex = 3;
			}
			//add years items
			this.cmbStartYear.Items.AddRange(new string[]{"","2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015"});
			this.cmbEndYear.Items.AddRange(new string[]{"","2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015"});
			this.cmbGiveYear.Items.AddRange(new string[]{"","2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015"});

			//add month items
			this.cmbStartMonth.Items.AddRange(new string[]{"","1","2","3","4","5","6","7","8","9","10","11","12"});
			this.cmbEndMonth.Items.AddRange(new string[]{"","1","2","3","4","5","6","7","8","9","10","11","12"});
			this.cmbGiveMonth.Items.AddRange(new string[]{"","1","2","3","4","5","6","7","8","9","10","11","12"});
			
			if(this.startDate != "")  //如果起始日期不为空
			{
				for(int i = 0;i<this.cmbStartYear.Items.Count;i++)
				{
					if(this.cmbStartYear.Items[i].ToString() == DateTime.Parse(startDate).Year.ToString())
					{
						this.cmbStartYear.SelectedIndex = i;
						break;
					}
				}
				for(int i = 0;i<this.cmbStartMonth.Items.Count;i++)
				{
					if(this.cmbStartMonth.Items[i].ToString() == DateTime.Parse(startDate).Month.ToString())
					{
						this.cmbStartMonth.SelectedIndex = i;
						break;
					}
				}
			}
			if(this.endDate != "")  //如果结束日期不为空
			{
				for(int i = 0;i<this.cmbEndYear.Items.Count;i++)
				{
					if(this.cmbEndYear.Items[i].ToString() == DateTime.Parse(endDate).Year.ToString())
					{
						this.cmbEndYear.SelectedIndex = i;
						break;
					}
				}
				for(int i = 0;i<this.cmbEndMonth.Items.Count;i++)
				{
					if(this.cmbEndMonth.Items[i].ToString() == DateTime.Parse(endDate).Month.ToString())
					{
						this.cmbEndMonth.SelectedIndex = i;
						break;
					}
				}
			}
			if(this.giveDate != "")  //如果付款日期不为空
			{
				for(int i = 0;i<this.cmbGiveYear.Items.Count;i++)
				{
					if(this.cmbGiveYear.Items[i].ToString() == DateTime.Parse(giveDate).Year.ToString())
					{
						this.cmbGiveYear.SelectedIndex = i;
						break;
					}
				}
				for(int i = 0;i<this.cmbGiveMonth.Items.Count;i++)
				{
					if(this.cmbGiveMonth.Items[i].ToString() == DateTime.Parse(giveDate).Month.ToString())
					{
						this.cmbGiveMonth.SelectedIndex = i;
						break;
					}
				}
			}

		}

		void AssignValueToData()
		{
			//注意:这里startDate,endDate,giveDate,number,monthCount,totalMoney这六个字段如果用户没有选择,则:
			//前面三个赋值为日期1900-1-1,后面三个赋值为-1,因为最终在存储过程执行时会判断这六个字段是否为这些值,
			//如果是,则会用null来替代,之所以要这样做,是因为不能直接在代码中将null值付给一个日期型或者整形的变量.

			if(this.cmbSubscription.SelectedIndex >= 0)
			{
				subscription = this.cmbSubscription.Items[this.cmbSubscription.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbSubscription.Items[this.cmbSubscription.SelectedIndex].ToString().Trim();
			}
			if(this.cmbBonus.SelectedIndex >= 0)
			{
				bonus = this.cmbBonus.Items[this.cmbBonus.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbBonus.Items[this.cmbBonus.SelectedIndex].ToString().Trim();
			}
			localAddress = this.txtLocalAddress.Text.Trim() == "" ? "  " : this.txtLocalAddress.Text.Trim();
			post = this.txtPost.Text.Trim() == "" ? "  " : this.txtPost.Text.Trim();
			address = this.txtAddress.Text.Trim() == "" ? "  " : this.txtAddress.Text.Trim();
			postcode = this.txtPostCode.Text.Trim() == "" ? "  " : this.txtPostCode.Text.Trim();
			telephone = this.txtTelephone.Text.Trim() == "" ? "  " : this.txtTelephone.Text.Trim();
			mobilePhone = this.txtMobilephone.Text.Trim() == "" ? "  " : this.txtMobilephone.Text.Trim();
			inscribe = this.txtInscribe.Text.Trim() == "" ? "  " : this.txtInscribe.Text.Trim();
			source = this.txtSource.Text.Trim() == "" ? "  " : this.txtSource.Text.Trim();
			invoice = this.txtInvoice.Text.Trim() == "" ? "  " : this.txtInvoice.Text.Trim();
			newName = this.txtName.Text.Trim() == "" ? "  " : this.txtName.Text.Trim();
			newCompany = this.txtCompany.Text.Trim() == "" ? "  " : this.txtCompany.Text.Trim();
			if(this.cmbClient.SelectedIndex >= 0)
			{
				client = this.cmbClient.Items[this.cmbClient.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbClient.Items[this.cmbClient.SelectedIndex].ToString().Trim();
			}
			
			//取得日期
			if(this.cmbStartYear.SelectedIndex > 0 && this.cmbStartMonth.SelectedIndex > 0)
			{
				if(this.cmbStartYear.Items[this.cmbStartYear.SelectedIndex].ToString().Length > 0)
				{
					if(this.cmbStartMonth.Items[this.cmbStartMonth.SelectedIndex].ToString().Length > 0)
					{
						try
						{
							startDate = this.cmbStartYear.Items[this.cmbStartYear.SelectedIndex].ToString().Trim() + "-" + this.cmbStartMonth.Items[this.cmbStartMonth.SelectedIndex].ToString().Trim() + "-1";
						}
						catch
						{
							throw new Exception("起始日期格式不正确!");
						}
					}
				}
			}
			else
			{
				this.startDate = "1900-1-1";
			}
			if(this.cmbEndYear.SelectedIndex > 0 && this.cmbEndMonth.SelectedIndex > 0)
			{
				if(this.cmbEndYear.Items[this.cmbEndYear.SelectedIndex].ToString().Length > 0)
				{
					if(this.cmbEndMonth.Items[this.cmbEndMonth.SelectedIndex].ToString().Length > 0)
					{
						try
						{
							endDate = this.cmbEndYear.Items[this.cmbEndYear.SelectedIndex].ToString().Trim() + "-" + this.cmbEndMonth.Items[this.cmbEndMonth.SelectedIndex].ToString().Trim() + "-1";
						}
						catch
						{
							throw new Exception("结束日期格式不正确!");
						}
					}
				}
			}
			else
			{
				this.endDate = "1900-1-1";
			}
			if(this.cmbGiveYear.SelectedIndex > 0 && this.cmbGiveMonth.SelectedIndex > 0)
			{
				if(this.cmbGiveYear.Items[this.cmbGiveYear.SelectedIndex].ToString().Length > 0)
				{
					if(this.cmbGiveMonth.Items[this.cmbGiveMonth.SelectedIndex].ToString().Length > 0)
					{
						try
						{
							giveDate = this.cmbGiveYear.Items[this.cmbGiveYear.SelectedIndex].ToString().Trim() + "-" + this.cmbGiveMonth.Items[this.cmbGiveMonth.SelectedIndex].ToString().Trim() + "-1";
						}
						catch
						{
							throw new Exception("结束日期格式不正确!");
						}
					}
				}
			}
			else
			{
				this.giveDate = "1900-1-1";
			}
			this.number = this.txtNumber.Text.Trim() == "" ? "-1" : this.txtNumber.Text.Trim();

			this.monthCount = this.txtMonthCount.Text.Trim() == "" ? "-1" : this.txtMonthCount.Text.Trim();

			this.totalMoney = this.txtTotalMoney.Text.Trim() == "" ? "-1" : this.txtTotalMoney.Text.Trim();

			if(this.cmbRegion.SelectedValue != null)
			{
				if(this.cmbRegion.SelectedValue.ToString().Trim() == "")
				{
					throw new Exception("地区不能为空!");

				}
				else
				{
					region = this.cmbRegion.SelectedValue.ToString().Trim();
				}
			}
			else
			{
				throw new Exception("地区不能为空!");
			}
			if(this.cmbPayment.SelectedIndex >= 0)
			{
				this.payment = this.cmbPayment.Items[this.cmbPayment.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbPayment.Items[this.cmbPayment.SelectedIndex].ToString().Trim();
			}
			if(this.cmbOperator.SelectedValue != null)
			{
				this.operator1 = this.cmbOperator.SelectedValue.ToString().Trim() == "" ? "  " : this.cmbOperator.SelectedValue.ToString().Trim();
			}

		}


		
		private void UpdateForm_Load(object sender, System.EventArgs e)
		{
			InitData();	
		
		}


		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			DateTime startDate1;
			DateTime endDate1;
			DateTime giveDate1;
			int number1;
			int monthCount1;
			int totalMoney1;

			try
			{
				AssignValueToData();
			}
			catch(Exception e2)
			{
				MessageBox.Show(e2.Message);
				return;
			}
			try
			{
				try
				{
					startDate1 = DateTime.Parse(startDate);
				}
				catch
				{
					throw new Exception("起始日期格式不正确!");
				}
				try
				{
					endDate1 = DateTime.Parse(endDate);
				}
				catch
				{
					throw new Exception("结束日期格式不正确!");
				}
				try
				{
					giveDate1 = DateTime.Parse(giveDate);
				}
				catch
				{
					throw new Exception("付款日期格式不正确!");
				}
				try
				{
					number1 = Int32.Parse(number);
				}
				catch
				{
					throw new Exception("份数格式不正确!");
				}
				try
				{
					monthCount1 = Int32.Parse(monthCount);
				}
				catch
				{
					throw new Exception("期数格式不正确!");
				}
				try
				{
					totalMoney1 = Int32.Parse(totalMoney);
				}
				catch
				{
					throw new Exception("金额格式不正确!");
				}
				int id = SubscribeInfoManager.UpdateSubscribeInfo(oldName,newName,post,oldCompany,newCompany,address,region,postcode,telephone,mobilePhone,DateTime.Parse(startDate),DateTime.Parse(endDate),DateTime.Parse(giveDate),Int32.Parse(number),Int32.Parse(monthCount),Int32.Parse(totalMoney),inscribe,source,payment,invoice,client,operator1,bonus,localAddress,subscription);
			
				if(id == 1)
				{
					MainForm.Form.CurrentDataSet = SubscribeInfoManager.RetriveDataFromTempInfo();					
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show("修改后的姓名和公司在数据库中已经存在，不能更新！");
				}
			}
			catch (Exception e1)
			{
				MessageBox.Show(e1.Message);
			}			

		}

		
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

	}
}

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

	public class AddForm : System.Windows.Forms.Form
	{
		#region  一些变量的定义

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
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSubmit;
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
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblHead;
		private System.Windows.Forms.Label lblNumber1;
		private System.Windows.Forms.ComboBox cmbBonus;
		private System.Windows.Forms.Label lblMonthCount;
		private System.Windows.Forms.Label lblGiveDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTotalMoney;
		private System.Windows.Forms.TextBox txtTotalMoney;
		private System.Windows.Forms.TextBox txtMonthCount;
		private System.Windows.Forms.ComboBox cmbGiveYear;
		private System.Windows.Forms.ComboBox cmbGiveMonth;
		private System.Windows.Forms.Label label1;

		DateTime startDate = DateTime.Parse("1900-1-1");
		DateTime endDate = DateTime.Parse("1900-1-1");
		DateTime giveDate = DateTime.Parse("1900-1-1");
		int number = -1;
		int monthCount = -1;
		int totalMoney = -1;
		string name;
		string localAddress = "未知";
		string company;
		string region;
		string subscription;
		string post;
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

		#endregion
		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddForm));
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblHead = new System.Windows.Forms.Label();
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
			this.cmbBonus = new System.Windows.Forms.ComboBox();
			this.lblMonthCount = new System.Windows.Forms.Label();
			this.lblGiveDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbGiveYear = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbGiveMonth = new System.Windows.Forms.ComboBox();
			this.lblTotalMoney = new System.Windows.Forms.Label();
			this.txtTotalMoney = new System.Windows.Forms.TextBox();
			this.txtMonthCount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(80, 116);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(248, 21);
			this.txtAddress.TabIndex = 140;
			this.txtAddress.Text = "";
			// 
			// txtPostCode
			// 
			this.txtPostCode.Location = new System.Drawing.Point(240, 179);
			this.txtPostCode.Name = "txtPostCode";
			this.txtPostCode.TabIndex = 138;
			this.txtPostCode.Text = "";
			// 
			// txtPost
			// 
			this.txtPost.Location = new System.Drawing.Point(280, 54);
			this.txtPost.Name = "txtPost";
			this.txtPost.TabIndex = 136;
			this.txtPost.Text = "";
			// 
			// txtMobilephone
			// 
			this.txtMobilephone.Location = new System.Drawing.Point(400, 147);
			this.txtMobilephone.Name = "txtMobilephone";
			this.txtMobilephone.Size = new System.Drawing.Size(120, 21);
			this.txtMobilephone.TabIndex = 134;
			this.txtMobilephone.Text = "";
			// 
			// txtTelephone
			// 
			this.txtTelephone.Location = new System.Drawing.Point(240, 147);
			this.txtTelephone.Name = "txtTelephone";
			this.txtTelephone.TabIndex = 132;
			this.txtTelephone.Text = "";
			// 
			// txtInscribe
			// 
			this.txtInscribe.Location = new System.Drawing.Point(104, 416);
			this.txtInscribe.Name = "txtInscribe";
			this.txtInscribe.Size = new System.Drawing.Size(216, 21);
			this.txtInscribe.TabIndex = 122;
			this.txtInscribe.Text = "";
			// 
			// txtInvoice
			// 
			this.txtInvoice.Location = new System.Drawing.Point(104, 384);
			this.txtInvoice.Name = "txtInvoice";
			this.txtInvoice.TabIndex = 120;
			this.txtInvoice.Text = "";
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(264, 312);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(128, 21);
			this.txtSource.TabIndex = 116;
			this.txtSource.Text = "";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(80, 54);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(120, 21);
			this.txtName.TabIndex = 90;
			this.txtName.Text = "";
			// 
			// txtCompany
			// 
			this.txtCompany.Location = new System.Drawing.Point(80, 86);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.Size = new System.Drawing.Size(208, 21);
			this.txtCompany.TabIndex = 89;
			this.txtCompany.Text = "";
			// 
			// txtLocalAddress
			// 
			this.txtLocalAddress.Location = new System.Drawing.Point(80, 179);
			this.txtLocalAddress.Name = "txtLocalAddress";
			this.txtLocalAddress.Size = new System.Drawing.Size(88, 21);
			this.txtLocalAddress.TabIndex = 96;
			this.txtLocalAddress.Text = "";
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(104, 352);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(48, 21);
			this.txtNumber.TabIndex = 110;
			this.txtNumber.Text = "";
			// 
			// lblAddress
			// 
			this.lblAddress.Location = new System.Drawing.Point(32, 123);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(40, 16);
			this.lblAddress.TabIndex = 139;
			this.lblAddress.Text = "地址";
			// 
			// lblPostCode
			// 
			this.lblPostCode.Location = new System.Drawing.Point(192, 187);
			this.lblPostCode.Name = "lblPostCode";
			this.lblPostCode.Size = new System.Drawing.Size(40, 16);
			this.lblPostCode.TabIndex = 137;
			this.lblPostCode.Text = "邮编";
			// 
			// lblPost
			// 
			this.lblPost.Location = new System.Drawing.Point(232, 62);
			this.lblPost.Name = "lblPost";
			this.lblPost.Size = new System.Drawing.Size(32, 16);
			this.lblPost.TabIndex = 135;
			this.lblPost.Text = "职位";
			// 
			// lblMobilephone
			// 
			this.lblMobilephone.Location = new System.Drawing.Point(352, 155);
			this.lblMobilephone.Name = "lblMobilephone";
			this.lblMobilephone.Size = new System.Drawing.Size(40, 13);
			this.lblMobilephone.TabIndex = 133;
			this.lblMobilephone.Text = "手机";
			// 
			// lblTelephone
			// 
			this.lblTelephone.Location = new System.Drawing.Point(192, 155);
			this.lblTelephone.Name = "lblTelephone";
			this.lblTelephone.Size = new System.Drawing.Size(40, 13);
			this.lblTelephone.TabIndex = 131;
			this.lblTelephone.Text = "电话";
			// 
			// cmbPayment
			// 
			this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPayment.Location = new System.Drawing.Point(280, 352);
			this.cmbPayment.Name = "cmbPayment";
			this.cmbPayment.Size = new System.Drawing.Size(120, 20);
			this.cmbPayment.TabIndex = 130;
			// 
			// lblPayment
			// 
			this.lblPayment.Location = new System.Drawing.Point(216, 360);
			this.lblPayment.Name = "lblPayment";
			this.lblPayment.Size = new System.Drawing.Size(56, 16);
			this.lblPayment.TabIndex = 129;
			this.lblPayment.Text = "付款方式";
			// 
			// lblBonus
			// 
			this.lblBonus.Location = new System.Drawing.Point(264, 448);
			this.lblBonus.Name = "lblBonus";
			this.lblBonus.Size = new System.Drawing.Size(64, 16);
			this.lblBonus.TabIndex = 125;
			this.lblBonus.Text = "奖金提取";
			// 
			// cmbOperator
			// 
			this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOperator.Location = new System.Drawing.Point(104, 440);
			this.cmbOperator.Name = "cmbOperator";
			this.cmbOperator.Size = new System.Drawing.Size(112, 20);
			this.cmbOperator.TabIndex = 124;
			// 
			// lblOperator
			// 
			this.lblOperator.Location = new System.Drawing.Point(32, 448);
			this.lblOperator.Name = "lblOperator";
			this.lblOperator.Size = new System.Drawing.Size(48, 16);
			this.lblOperator.TabIndex = 123;
			this.lblOperator.Text = "业务员";
			// 
			// lblInscribe
			// 
			this.lblInscribe.Location = new System.Drawing.Point(32, 416);
			this.lblInscribe.Name = "lblInscribe";
			this.lblInscribe.Size = new System.Drawing.Size(56, 16);
			this.lblInscribe.TabIndex = 121;
			this.lblInscribe.Text = "落款";
			// 
			// lblInvoice
			// 
			this.lblInvoice.Location = new System.Drawing.Point(32, 392);
			this.lblInvoice.Name = "lblInvoice";
			this.lblInvoice.Size = new System.Drawing.Size(64, 16);
			this.lblInvoice.TabIndex = 119;
			this.lblInvoice.Text = "发票号";
			// 
			// cmbClient
			// 
			this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClient.Location = new System.Drawing.Point(464, 312);
			this.cmbClient.Name = "cmbClient";
			this.cmbClient.Size = new System.Drawing.Size(56, 20);
			this.cmbClient.TabIndex = 118;
			// 
			// lblClient
			// 
			this.lblClient.Location = new System.Drawing.Point(400, 320);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new System.Drawing.Size(56, 16);
			this.lblClient.TabIndex = 117;
			this.lblClient.Text = "客户类别";
			// 
			// lblSource
			// 
			this.lblSource.Location = new System.Drawing.Point(224, 320);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(32, 16);
			this.lblSource.TabIndex = 115;
			this.lblSource.Text = "来源";
			// 
			// lblNumber1
			// 
			this.lblNumber1.Location = new System.Drawing.Point(160, 360);
			this.lblNumber1.Name = "lblNumber1";
			this.lblNumber1.Size = new System.Drawing.Size(16, 16);
			this.lblNumber1.TabIndex = 114;
			this.lblNumber1.Text = "份";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(304, 488);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(64, 32);
			this.btnCancel.TabIndex = 113;
			this.btnCancel.Text = "取 消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(160, 488);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(64, 32);
			this.btnSubmit.TabIndex = 112;
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
			this.lblHead.TabIndex = 111;
			this.lblHead.Text = "添加订阅信息";
			this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(32, 62);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(32, 16);
			this.lblName.TabIndex = 91;
			this.lblName.Text = "姓名";
			// 
			// lblCompany
			// 
			this.lblCompany.Location = new System.Drawing.Point(32, 94);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(32, 16);
			this.lblCompany.TabIndex = 94;
			this.lblCompany.Text = "公司";
			// 
			// lblRegion
			// 
			this.lblRegion.Location = new System.Drawing.Point(32, 155);
			this.lblRegion.Name = "lblRegion";
			this.lblRegion.Size = new System.Drawing.Size(32, 16);
			this.lblRegion.TabIndex = 92;
			this.lblRegion.Text = "地区";
			// 
			// cmbRegion
			// 
			this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRegion.Location = new System.Drawing.Point(80, 147);
			this.cmbRegion.Name = "cmbRegion";
			this.cmbRegion.Size = new System.Drawing.Size(88, 20);
			this.cmbRegion.TabIndex = 93;
			// 
			// lblLocalAddress
			// 
			this.lblLocalAddress.Location = new System.Drawing.Point(32, 187);
			this.lblLocalAddress.Name = "lblLocalAddress";
			this.lblLocalAddress.Size = new System.Drawing.Size(32, 16);
			this.lblLocalAddress.TabIndex = 95;
			this.lblLocalAddress.Text = "县区";
			// 
			// lblStartDate
			// 
			this.lblStartDate.Location = new System.Drawing.Point(32, 219);
			this.lblStartDate.Name = "lblStartDate";
			this.lblStartDate.Size = new System.Drawing.Size(56, 16);
			this.lblStartDate.TabIndex = 97;
			this.lblStartDate.Text = "起始日期";
			// 
			// lblStartYear
			// 
			this.lblStartYear.Location = new System.Drawing.Point(104, 219);
			this.lblStartYear.Name = "lblStartYear";
			this.lblStartYear.Size = new System.Drawing.Size(16, 16);
			this.lblStartYear.TabIndex = 98;
			this.lblStartYear.Text = "年";
			// 
			// cmbStartYear
			// 
			this.cmbStartYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStartYear.Location = new System.Drawing.Point(128, 211);
			this.cmbStartYear.Name = "cmbStartYear";
			this.cmbStartYear.Size = new System.Drawing.Size(72, 20);
			this.cmbStartYear.TabIndex = 99;
			// 
			// lblStartMonth
			// 
			this.lblStartMonth.Location = new System.Drawing.Point(216, 219);
			this.lblStartMonth.Name = "lblStartMonth";
			this.lblStartMonth.Size = new System.Drawing.Size(16, 16);
			this.lblStartMonth.TabIndex = 100;
			this.lblStartMonth.Text = "月";
			// 
			// cmbStartMonth
			// 
			this.cmbStartMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStartMonth.Location = new System.Drawing.Point(240, 211);
			this.cmbStartMonth.Name = "cmbStartMonth";
			this.cmbStartMonth.Size = new System.Drawing.Size(56, 20);
			this.cmbStartMonth.TabIndex = 101;
			// 
			// lblEndDate
			// 
			this.lblEndDate.Location = new System.Drawing.Point(32, 288);
			this.lblEndDate.Name = "lblEndDate";
			this.lblEndDate.Size = new System.Drawing.Size(56, 16);
			this.lblEndDate.TabIndex = 102;
			this.lblEndDate.Text = "终止日期";
			// 
			// cmbEndMonth
			// 
			this.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEndMonth.Location = new System.Drawing.Point(240, 280);
			this.cmbEndMonth.Name = "cmbEndMonth";
			this.cmbEndMonth.Size = new System.Drawing.Size(56, 20);
			this.cmbEndMonth.TabIndex = 106;
			// 
			// lblEndMonth
			// 
			this.lblEndMonth.Location = new System.Drawing.Point(216, 288);
			this.lblEndMonth.Name = "lblEndMonth";
			this.lblEndMonth.Size = new System.Drawing.Size(16, 16);
			this.lblEndMonth.TabIndex = 105;
			this.lblEndMonth.Text = "月";
			// 
			// cmbEndYear
			// 
			this.cmbEndYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEndYear.Location = new System.Drawing.Point(128, 280);
			this.cmbEndYear.Name = "cmbEndYear";
			this.cmbEndYear.Size = new System.Drawing.Size(72, 20);
			this.cmbEndYear.TabIndex = 104;
			// 
			// lblEndYear
			// 
			this.lblEndYear.Location = new System.Drawing.Point(104, 288);
			this.lblEndYear.Name = "lblEndYear";
			this.lblEndYear.Size = new System.Drawing.Size(16, 16);
			this.lblEndYear.TabIndex = 103;
			this.lblEndYear.Text = "年";
			// 
			// lblSubscription
			// 
			this.lblSubscription.Location = new System.Drawing.Point(32, 320);
			this.lblSubscription.Name = "lblSubscription";
			this.lblSubscription.Size = new System.Drawing.Size(56, 16);
			this.lblSubscription.TabIndex = 107;
			this.lblSubscription.Text = "订阅形式";
			// 
			// cmbSubscription
			// 
			this.cmbSubscription.Location = new System.Drawing.Point(104, 312);
			this.cmbSubscription.Name = "cmbSubscription";
			this.cmbSubscription.Size = new System.Drawing.Size(96, 20);
			this.cmbSubscription.TabIndex = 108;
			// 
			// lblNumber
			// 
			this.lblNumber.Location = new System.Drawing.Point(32, 360);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(56, 16);
			this.lblNumber.TabIndex = 109;
			this.lblNumber.Text = "份数等于";
			// 
			// cmbBonus
			// 
			this.cmbBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBonus.Location = new System.Drawing.Point(336, 440);
			this.cmbBonus.Name = "cmbBonus";
			this.cmbBonus.Size = new System.Drawing.Size(112, 20);
			this.cmbBonus.TabIndex = 141;
			// 
			// lblMonthCount
			// 
			this.lblMonthCount.Location = new System.Drawing.Point(344, 219);
			this.lblMonthCount.Name = "lblMonthCount";
			this.lblMonthCount.Size = new System.Drawing.Size(32, 23);
			this.lblMonthCount.TabIndex = 142;
			this.lblMonthCount.Text = "期数";
			// 
			// lblGiveDate
			// 
			this.lblGiveDate.Location = new System.Drawing.Point(32, 254);
			this.lblGiveDate.Name = "lblGiveDate";
			this.lblGiveDate.Size = new System.Drawing.Size(56, 16);
			this.lblGiveDate.TabIndex = 144;
			this.lblGiveDate.Text = "付款日期";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 254);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 16);
			this.label2.TabIndex = 145;
			this.label2.Text = "年";
			// 
			// cmbGiveYear
			// 
			this.cmbGiveYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGiveYear.Location = new System.Drawing.Point(128, 246);
			this.cmbGiveYear.Name = "cmbGiveYear";
			this.cmbGiveYear.Size = new System.Drawing.Size(72, 20);
			this.cmbGiveYear.TabIndex = 146;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(216, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 147;
			this.label3.Text = "月";
			// 
			// cmbGiveMonth
			// 
			this.cmbGiveMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGiveMonth.Location = new System.Drawing.Point(240, 246);
			this.cmbGiveMonth.Name = "cmbGiveMonth";
			this.cmbGiveMonth.Size = new System.Drawing.Size(56, 20);
			this.cmbGiveMonth.TabIndex = 148;
			// 
			// lblTotalMoney
			// 
			this.lblTotalMoney.Location = new System.Drawing.Point(344, 254);
			this.lblTotalMoney.Name = "lblTotalMoney";
			this.lblTotalMoney.Size = new System.Drawing.Size(32, 23);
			this.lblTotalMoney.TabIndex = 149;
			this.lblTotalMoney.Text = "金额";
			// 
			// txtTotalMoney
			// 
			this.txtTotalMoney.Location = new System.Drawing.Point(392, 246);
			this.txtTotalMoney.Name = "txtTotalMoney";
			this.txtTotalMoney.Size = new System.Drawing.Size(64, 21);
			this.txtTotalMoney.TabIndex = 150;
			this.txtTotalMoney.Text = "";
			// 
			// txtMonthCount
			// 
			this.txtMonthCount.Location = new System.Drawing.Point(392, 211);
			this.txtMonthCount.Name = "txtMonthCount";
			this.txtMonthCount.Size = new System.Drawing.Size(64, 21);
			this.txtMonthCount.TabIndex = 151;
			this.txtMonthCount.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(320, 288);
			this.label1.Name = "label1";
			this.label1.TabIndex = 152;
			this.label1.Text = "默认为起始日期";
			// 
			// AddForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(536, 535);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMonthCount);
			this.Controls.Add(this.txtTotalMoney);
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
			this.Controls.Add(this.lblTotalMoney);
			this.Controls.Add(this.lblGiveDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbGiveYear);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbGiveMonth);
			this.Controls.Add(this.lblMonthCount);
			this.Controls.Add(this.cmbBonus);
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
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblHead);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AddForm";
			this.Text = "添加订阅信息";
			this.Load += new System.EventHandler(this.AddForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private System.ComponentModel.Container components = null;

		public AddForm()
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
			DataTable tblRegions = SubscribeInfoManager.RetrieveRegions();//得到所有的地区
			DataTable tblEmployees = EmployeeManager.RetrieveAllEmployees();//得到所有的业务员

			this.txtNumber.Text = "1";

			//bind data to region comboBox
			this.cmbRegion.DataSource = tblRegions;
			this.cmbRegion.DisplayMember = "name";
			this.cmbRegion.ValueMember = "name";
		
			//bind data to payment comboBox
			this.cmbPayment.Items.Add("  ");
			this.cmbPayment.Items.Add("现金支付");
			this.cmbPayment.Items.Add("银行转帐");
			this.cmbPayment.Items.Add("邮局汇款");
			this.cmbPayment.Items.Add("网上支付");
			this.cmbPayment.Items.Add("货到付款");
			this.cmbPayment.SelectedIndex = 0;
		
			//bind data to client comboBox
			this.cmbOperator.DataSource = tblEmployees;
			this.cmbOperator.DisplayMember = "name";
			this.cmbOperator.ValueMember = "name";
			//add items to subscription comboBox
			this.cmbSubscription.Items.Add("  ");
			this.cmbSubscription.Items.Add("订阅");
			this.cmbSubscription.Items.Add("赠阅");
			this.cmbSubscription.SelectedIndex = 0;
			//add items to clientCategory comboBox
			this.cmbClient.Items.Add("  ");
			this.cmbClient.Items.Add("A");
			this.cmbClient.Items.Add("B");
			this.cmbClient.Items.Add("C");
			this.cmbClient.SelectedIndex = 0;
			//add items to bonus comboBox
			this.cmbBonus.Items.Add("  ");
			this.cmbBonus.Items.Add("已提");
			this.cmbBonus.Items.Add("未提");
			this.cmbBonus.SelectedIndex = 0;

			//add years items
			this.cmbStartYear.Items.AddRange(new string[]{"","2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015"});
			this.cmbEndYear.Items.AddRange(new string[]{"","2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015"});
			this.cmbGiveYear.Items.AddRange(new string[]{"","2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015"});

			//add month items
			this.cmbStartMonth.Items.AddRange(new string[]{"","1","2","3","4","5","6","7","8","9","10","11","12"});
			this.cmbEndMonth.Items.AddRange(new string[]{"","1","2","3","4","5","6","7","8","9","10","11","12"});
			this.cmbGiveMonth.Items.AddRange(new string[]{"","1","2","3","4","5","6","7","8","9","10","11","12"});

			this.cmbStartYear.SelectedIndex = 0;
			this.cmbEndYear.SelectedIndex = 0;
			this.cmbGiveYear.SelectedIndex = 0;
			this.cmbStartMonth.SelectedIndex = 0;
			this.cmbEndMonth.SelectedIndex = 0;
			this.cmbGiveMonth.SelectedIndex = 0;

		}

		void GetValues()
		{
			localAddress = this.txtLocalAddress.Text.Trim() == "" ? "  " : this.txtLocalAddress.Text.Trim();
			post = this.txtPost.Text.Trim() == "" ? "  " : this.txtPost.Text.Trim();
			address = this.txtAddress.Text.Trim() == "" ? "  " : this.txtAddress.Text.Trim();
			postcode = this.txtPostCode.Text.Trim() == "" ? "  " : this.txtPostCode.Text.Trim();
			telephone = this.txtTelephone.Text.Trim() == "" ? "  " : this.txtTelephone.Text.Trim();
			mobilePhone = this.txtMobilephone.Text.Trim() == "" ? "  " : this.txtMobilephone.Text.Trim();
			inscribe = this.txtInscribe.Text.Trim() == "" ? "  " : this.txtInscribe.Text.Trim();
			source = this.txtSource.Text.Trim() == "" ? "  " : this.txtSource.Text.Trim();
			invoice = this.txtInvoice.Text.Trim() == "" ? "  " : this.txtInvoice.Text.Trim();
			name = this.txtName.Text.Trim() == "" ? "  " : this.txtName.Text.Trim();
			company = this.txtCompany.Text.Trim() == "" ? "  " : this.txtCompany.Text.Trim();
			region = this.cmbRegion.SelectedValue.ToString();
			if(this.cmbClient.SelectedIndex >= 0)
			{
				client = this.cmbClient.Items[this.cmbClient.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbClient.Items[this.cmbClient.SelectedIndex].ToString().Trim();
			}

			if(this.cmbPayment.SelectedIndex >= 0)
			{
				this.payment = this.cmbPayment.Items[this.cmbPayment.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbPayment.Items[this.cmbPayment.SelectedIndex].ToString().Trim();
			}
			if(this.cmbSubscription.SelectedIndex >= 0)
			{
				subscription = this.cmbSubscription.Items[this.cmbSubscription.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbSubscription.Items[this.cmbSubscription.SelectedIndex].ToString().Trim();
			}
			if(this.cmbBonus.SelectedIndex >= 0)
			{
				bonus = this.cmbBonus.Items[this.cmbBonus.SelectedIndex].ToString().Trim() == "" ? "  " : this.cmbBonus.Items[this.cmbBonus.SelectedIndex].ToString().Trim();
			}
			if(this.cmbOperator.SelectedValue != null)
			{
				this.operator1 = this.cmbOperator.SelectedValue.ToString().Trim() == "" ? "  " : this.cmbOperator.SelectedValue.ToString().Trim();
			}
			
			//获取份数
			if(this.txtNumber.Text.Trim().Length > 0)
			{
				try
				{
					number = Convert.ToInt32(this.txtNumber.Text.Trim());
				}
				catch
				{
					throw new Exception("份数格式不正确!");
				}
			}
			//获取期数
			if(this.txtMonthCount.Text.Trim().Length > 0)
			{
				try
				{
					monthCount = Convert.ToInt32(this.txtMonthCount.Text.Trim());
				}
				catch
				{
					throw new Exception("期数格式不正确!");
				}
			}
			//获取金额
			if(this.txtTotalMoney.Text.Trim().Length > 0)
			{
				try
				{
					totalMoney = Convert.ToInt32(this.txtTotalMoney.Text.Trim());
				}
				catch
				{
					throw new Exception("金额格式不正确!");
				}
			}
			//如果指定了日期
			if(this.cmbStartYear.SelectedIndex > 0 && this.cmbStartMonth.SelectedIndex > 0)
			{
				if(this.cmbStartYear.Items[this.cmbStartYear.SelectedIndex].ToString().Length > 0)
				{
					if(this.cmbStartMonth.Items[this.cmbStartMonth.SelectedIndex].ToString().Length > 0)
					{
						startDate = DateTime.Parse(this.cmbStartYear.Items[this.cmbStartYear.SelectedIndex].ToString() + "-" + this.cmbStartMonth.Items[this.cmbStartMonth.SelectedIndex].ToString() + "-1");
					}
				}
			}
			if(this.cmbEndYear.SelectedIndex > 0 && this.cmbEndMonth.SelectedIndex > 0)
			{
				if(this.cmbEndYear.Items[this.cmbEndYear.SelectedIndex].ToString().Length > 0)
				{
					if(this.cmbEndMonth.Items[this.cmbEndMonth.SelectedIndex].ToString().Length > 0)
					{
						endDate = DateTime.Parse(this.cmbEndYear.Items[this.cmbEndYear.SelectedIndex].ToString() + "-" + this.cmbEndMonth.Items[this.cmbEndMonth.SelectedIndex].ToString() + "-1");
					}
				}
			}
			if(this.cmbGiveYear.SelectedIndex > 0 && this.cmbGiveMonth.SelectedIndex > 0)
			{
				if(this.cmbGiveYear.Items[this.cmbGiveYear.SelectedIndex].ToString().Length > 0)
				{
					if(this.cmbGiveMonth.Items[this.cmbGiveMonth.SelectedIndex].ToString().Length > 0)
					{
						giveDate = DateTime.Parse(this.cmbGiveYear.Items[this.cmbGiveYear.SelectedIndex].ToString() + "-" + this.cmbGiveMonth.Items[this.cmbGiveMonth.SelectedIndex].ToString() + "-1");
					}
				}
			}
			if(giveDate == DateTime.Parse("1900-1-1"))  //如果没有指定付款日期,则默认为起始日期
			{
				giveDate = startDate;
			}

		}


		private void AddForm_Load(object sender, System.EventArgs e)
		{
			InitData();
		}		

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		
		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.cmbRegion.SelectedValue != null)
				{
					if(this.cmbRegion.SelectedValue.ToString().Trim() == "")
					{
						MessageBox.Show("地区不能为空!");
						return;
					}
				}
				else
				{
					MessageBox.Show("地区不能为空!");
					return;
				}
				GetValues();
		
				int id = SubscribeInfoManager.CreateSubscribeInfo(name,post,company,address,region,postcode,telephone,
					mobilePhone,startDate,endDate,giveDate,number,monthCount,totalMoney,inscribe,source,payment,invoice,client,operator1,bonus,
					localAddress,subscription);
				if(id == 1)   //添加成功
				{
					MainForm.Form.CurrentDataSet = SubscribeInfoManager.RetriveDataFromTempInfo();					
					
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else  //添加失败
				{
					MessageBox.Show("已经存在该记录！");
				}
			}
			catch(Exception e1)
			{
				MessageBox.Show(e1.Message);
			}
		}


	}
}
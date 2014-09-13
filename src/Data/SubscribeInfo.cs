using System;
using NetFocus.MagzineSubscribe.CMPServices;

namespace NetFocus.MagzineSubscribe.Data 
{

	public class SubscribeInfo : PersistableObject
	{
		public SubscribeInfo()
		{
		}

		
		int id;
		DateTime startDate;
		DateTime endDate;
		DateTime giveDate;
		int compareDirection;
		int number;
		int monthCount;
		int totalMoney;
		int averageMoney;
		int monthMoney;
		string oldName;
		string newName;
		string localAddress;
		string oldCompany;
		string newCompany;
		string region;
		string subscription;
		string post;
		string address;
		string postcode;
		string  mobilePhone;
		string telephone;
		string inscribe;
		string source;
		string payment;
		string invoice;
		string client;
		string operator1;
		string bonus;

		string fileName;
		string path;
		string tableName;

		int searchDateType;

		public int SearchDateType
		{
			get
			{
				return searchDateType;
			}
			set
			{
				searchDateType = value;
			}
		}

		public string FileName
		{
			get
			{
				return fileName;
			}
			set
			{
				fileName = value;
			}
		}
		public string Path
		{
			get
			{
				return path;
			}
			set
			{
				path = value;
			}
		}
		public string TableName
		{
			get
			{
				return tableName;
			}
			set
			{
				tableName = value;
			}
		}
		
		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}

		public DateTime StartDate
		{
			get
			{
				return startDate;
			}
			set
			{
				startDate = value;
			}
		}
		public DateTime EndDate
		{
			get
			{
				return endDate;
			}
			set
			{
				endDate = value;
			}
		}
		public DateTime GiveDate
		{
			get
			{
				return giveDate;
			}
			set
			{
				giveDate = value;
			}
		}
		public int CompareDirection
		{
			get
			{
				return compareDirection;
			}
			set
			{
				compareDirection = value;
			}
		}
		public int Number
		{
			get
			{
				return number;
			}
			set
			{
				number = value;
			}
		}
		public int MonthCount
		{
			get
			{
				return monthCount;
			}
			set
			{
				monthCount = value;
			}
		}
		public int TotalMoney
		{
			get
			{
				return totalMoney;
			}
			set
			{
				totalMoney = value;
			}
		}
		public int AverageMoney
		{
			get
			{
				return averageMoney;
			}
			set
			{
				averageMoney = value;
			}
		}
		public int MonthMoney
		{
			get
			{
				return monthMoney;
			}
			set
			{
				monthMoney = value;
			}
		}
		public string OldName
		{
			get
			{
				return oldName;
			}
			set
			{
				oldName = value;
			}
		}
		public string NewName
		{
			get
			{
				return newName;
			}
			set
			{
				newName = value;
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set
			{
				region = value;
			}
		}
		public string LocalAddress
		{
			get
			{
				return localAddress;
			}
			set
			{
				localAddress = value;
			}
		}
		public string OldCompany
		{
			get
			{
				return oldCompany;
			}
			set
			{
				oldCompany = value;
			}
		}
		public string NewCompany
		{
			get
			{
				return newCompany;
			}
			set
			{
				newCompany = value;
			}
		}
		public string Subscription
		{
			get
			{
				return subscription;
			}
			set
			{
				subscription = value;
			}
		}
		public string Post
		{
			get
			{
				return post;
			}
			set
			{
				post = value;
			}
		}
		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				address = value;
			}
		}
		public string PostCode
		{
			get
			{
				return postcode;
			}
			set
			{
				postcode = value;
			}
		}
		public string MobilePhone
		{
			get
			{
				return mobilePhone;
			}
			set
			{
				mobilePhone = value;
			}
		}
		public string Telephone
		{
			get
			{
				return telephone;
			}
			set
			{
				telephone = value;
			}
		}
		public string Inscribe
		{
			get
			{
				return inscribe;
			}
			set
			{
				inscribe = value;
			}
		}
		public string Source
		{
			get
			{
				return source;
			}
			set
			{
				source = value;
			}
		}
		public string Payment
		{
			get
			{
				return payment;
			}
			set
			{
				payment = value;
			}
		}
		public string Invoice
		{
			get
			{
				return invoice;
			}
			set
			{
				invoice = value;
			}
		}
		public string Client
		{
			get
			{
				return client;
			}
			set
			{
				client = value;
			}
		}
		public string Operator
		{
			get
			{
				return operator1;
			}
			set
			{
				operator1 = value;
			}
		}
		public string Bonus
		{
			get
			{
				return bonus;
			}
			set
			{
				bonus = value;
			}
		}


	}
}

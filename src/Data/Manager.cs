using System;
using NetFocus.MagzineSubscribe.CMPServices;

namespace NetFocus.MagzineSubscribe.Data 
{

	public class Manager : PersistableObject
	{
		public Manager()
		{
		}

		string id;
		string name;
		string password;
		int property;
		int returnValue;

		public string Id
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

		public int Property
		{
			get
			{
				return property;
			}
			set
			{
				property = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
			}
		}
		
		public int ReturnValue
		{
			get
			{
				return returnValue;
			}
			set
			{
				returnValue = value;
			}
		}



	}
}

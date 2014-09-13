using System;
using NetFocus.MagzineSubscribe.CMPServices;

namespace NetFocus.MagzineSubscribe.Data 
{

	public class Region : PersistableObject
	{
		public Region()
		{

		}
		int id;
		string name;
		int returnValue;

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

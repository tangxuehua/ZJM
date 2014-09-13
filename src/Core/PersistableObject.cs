
using System;
using System.Data;
using System.Xml;
using System.Xml.Serialization; 
using System.Text;

namespace NetFocus.MagzineSubscribe.CMPServices
{
	public class PersistableObject  //此类定义了一个持久性对象，作为一个基类
	{
		protected DataSet internalData = new DataSet();
		
		public PersistableObject()
		{}

		
		public bool CanPersist()  //返回该对象是否能持久
		{
			return true;
		}

		
		public string ToXmlString()  //序列化该对象
		{
			try 
			{
				Type objType = this.GetType();
				StringBuilder sb = new StringBuilder();
				System.IO.StringWriter sw = new System.IO.StringWriter( sb );
				XmlSerializer xs = new XmlSerializer( objType );
				xs.Serialize( sw, this );
				return sw.GetStringBuilder().ToString();
			}
			catch 
			{
				return "Serialization Failure";
			}
		}
		
		public DataSet ResultSet
		{
			get 
			{
				return internalData;
			}
			set 
			{
				internalData = value;
			}
		}

	}
}

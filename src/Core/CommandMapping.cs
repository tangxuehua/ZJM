
using System;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;


namespace NetFocus.MagzineSubscribe.CMPServices
{

	public class CommandMapping  //这个类代表一个命令的映射
	{
		private string commandName;
		private ArrayList commandParameters;  //注意参数被定义成一个集合，因为参数可能有好几个。
		private string returnValueType;

		private void ConstructCommandMapping( string initCommandName, ArrayList initCommandParameters )
		{
			commandName = initCommandName;
			commandParameters = initCommandParameters;
		}

		public CommandMapping()
		{
			ArrayList newParams = new ArrayList();
			ConstructCommandMapping( "Not Set", newParams );
		}

		public CommandMapping( string initCommandName )
		{
			ArrayList newParams = new ArrayList();
			ConstructCommandMapping( initCommandName, newParams );
		}

		public CommandMapping( string initCommandName, ArrayList initCommandParameters )
		{
			ConstructCommandMapping( initCommandName, initCommandParameters );
		}

		
		public string CommandName
		{
			get 
			{
				return commandName;
			}
			set 
			{
				commandName = value;
			}
		}

		
		public ArrayList Parameters
		{
			get 
			{
				return commandParameters;
			}
			set 
			{
				commandParameters = value;
			}
		}
		
		
		public string ReturnValueType
		{
			get
			{
				return returnValueType;
			}
			set
			{
				returnValueType = value;
			}
		}

		
		public void AddParameter( CommandParameter newParameter )
		{
			commandParameters.Add( newParameter );
		}
	}
}

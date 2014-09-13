using System;
using System.Xml;
using System.Xml.Serialization; 
using System.Reflection;
using System.Collections;


namespace NetFocus.MagzineSubscribe.CMPServices
{
	public class ContainerMapping  //这个类代表一个容器的映射
	{
		private string containerMappingId;
		private Hashtable commandMappingList = new Hashtable();
		private string currentCommandName;


		//这个构造函数最重要，因为它以一个节点作为初始化参数，
		//而往往在初始化时都是从配置文件中读取ContainerMapping节点的。
		public ContainerMapping( XmlNode xmlNode )
		{
			containerMappingId = xmlNode.SelectSingleNode( "ContainerMappingId" ).InnerText;
			XmlNodeList commandMappingNodeList;

			commandMappingNodeList = xmlNode.SelectNodes("Command");
			foreach(XmlNode commandMappingNode in commandMappingNodeList)
			{
				string commandName = commandMappingNode.SelectSingleNode( "CommandName" ).InnerText;
				commandMappingList[commandName] = CreateCommandMappingFromNode(commandName, commandMappingNode );
				
			}
			
		}

		protected static CommandMapping CreateCommandMappingFromNode(string commandName, XmlNode cmdNode )
		{
			CommandMapping newCmdMap = new CommandMapping(commandName);

			newCmdMap.ReturnValueType = cmdNode.SelectSingleNode("ReturnValueType").InnerText;
			//创建这个命令映射对象的参数列表
			CommandParameter newParam;
			foreach (XmlNode cmdParamNode in cmdNode.SelectNodes("Parameter"))
			{
				newParam = new CommandParameter();
				newParam.ClassMember = cmdParamNode.SelectSingleNode("ClassMember").InnerText;
				newParam.DbTypeHint = cmdParamNode.SelectSingleNode("DbTypeHint").InnerText;
				newParam.ParameterName = cmdParamNode.SelectSingleNode("ParameterName").InnerText;
				newParam.Size = System.Convert.ToInt32( cmdParamNode.SelectSingleNode("Size").InnerText );
				newParam.ParamDirection = cmdParamNode.SelectSingleNode("ParamDirection").InnerText;
				newCmdMap.AddParameter( newParam );
			}

			return newCmdMap;
		}

		
		public string ContainerMappingId
		{
			get 
			{
				return containerMappingId;
			}
			set 
			{
				containerMappingId = value;
			}
		}


		public Hashtable CommandMappingList
		{
			get
			{
				return commandMappingList;
			}
			set
			{
				commandMappingList = value;
			}
		}
		public string CurrentCommandName
		{
			get
			{
				return currentCommandName;
			}
			set
			{
				currentCommandName = value;
			}
		}
	}
}

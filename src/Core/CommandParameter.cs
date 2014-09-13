
using System;
using System.Xml.Serialization;
using System.Data;
using System.Reflection;

namespace NetFocus.MagzineSubscribe.CMPServices
{
	public class CommandParameter  //这个类代表一个命令的参数
	{
		private string classMember;
		private string parameterName;
		private string dbTypeHint;
		private int size;
		private ParameterDirection parameterDirection;//参数的方向为枚举类型

		//任何构造方法都要直接或间接调用这个方法，这样可以最大化的共享代码。
		private void ConstructCommandParameter(string initClassMember,string initParameterName,string initDbTypeHint,string initParameterDirection,int initSize )
		{
			classMember = initClassMember;
			parameterName = initParameterName;
			dbTypeHint = initDbTypeHint;
			ParamDirection = initParameterDirection;
			size = initSize;
		}

		
		public CommandParameter()//一个构造方法，不带任何参数
		{
			ConstructCommandParameter( "Not Set", "Not Set", "Not Set", "ReturnValue", -1 );
		}

		public CommandParameter(string initClassMember,string initParameterName,string initDbTypeHint,string initParameterDirection,int initSize )//带参数的构造方法
		{
			ConstructCommandParameter( initClassMember,initParameterName,initDbTypeHint,initParameterDirection,initSize );
		}

		
		public string ClassMember
		{
			get 
			{
				return classMember;
			}
			set 
			{
				classMember = value;
			}
		}

		public string ParameterName
		{
			get 
			{
				return parameterName;
			}
			set 
			{
				parameterName = value;
			}
		}

		public string DbTypeHint
		{
			get 
			{
				return dbTypeHint;
			}
			set 
			{
				dbTypeHint = value;
			}
		}

		public int Size
		{
			get 
			{
				return size;
			}
			set 
			{
				size = value;
			}
		}
		public string ParamDirection
		{
			get 
			{
				return parameterDirection.ToString();
			}
			set 
			{
				if (value == "Input")
					parameterDirection = ParameterDirection.Input;
				else if (value == "InputOutput")
					parameterDirection = ParameterDirection.InputOutput;
				else if (value == "Output" )
					parameterDirection = ParameterDirection.Output;
				else
					parameterDirection = ParameterDirection.ReturnValue;
			}
		}

		
		//注意，下面这个是只读的属性，与上面这个不同。
		public ParameterDirection RealParameterDirection
		{
			get 
			{
				return parameterDirection;
			}
		}
	}
}


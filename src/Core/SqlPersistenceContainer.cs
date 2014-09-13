
using System;
using System.Xml;
using System.Xml.Serialization; 
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetFocus.MagzineSubscribe.CMPServices
{
	//定义了一个对应SQL Server的持久性容器类，继承标准的容器类
	public class SqlPersistenceContainer : StdPersistenceContainer  
	{
		public SqlPersistenceContainer() : base() { }

		public SqlPersistenceContainer( ContainerMapping initCurrentMap ) : base( initCurrentMap )
		{

		}

		
		public override void Execute( PersistableObject currentObject )
		{
			try 
			{
				CommandMapping cmdMap = (CommandMapping)ContainerMapping.CommandMappingList[ContainerMapping.CurrentCommandName];  
				SqlCommand currentCommand = BuildCommandFromMapping( cmdMap );//根据一个Command映射对象来创建一个SqlCommand对象
				AssignValuesToParameters( cmdMap, ref currentCommand, currentObject );
				currentCommand.Connection.Open();

				if (cmdMap.ReturnValueType == "DataSet")
				{
					AssignReturnValueToDataSet( cmdMap, currentCommand, ref currentObject );
					AssignOutputValuesToInstance( cmdMap, currentCommand, ref currentObject );
					currentCommand.Connection.Close();
				}
				else
				{
					currentCommand.ExecuteNonQuery();
					currentCommand.Connection.Close();
					AssignOutputValuesToInstance( cmdMap, currentCommand, ref currentObject );
				}
				currentCommand.Connection.Dispose();
				currentCommand.Dispose();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message,e);
			}
		}

	
		private void AssignReturnValueToDataSet( CommandMapping cmdMap,SqlCommand currentCmd,ref PersistableObject persistObject )
		{
			DataSet internalData = persistObject.ResultSet;
			SqlDataAdapter sqlDa = new SqlDataAdapter( currentCmd );
			sqlDa.Fill( internalData );
		}

		
		private void AssignOutputValuesToInstance( CommandMapping cmdMap,SqlCommand currentCmd,ref PersistableObject persistObject )
		{
			Type objType;
			PropertyInfo prop;

			objType = persistObject.GetType();
			SqlParameter curParam;
			foreach (CommandParameter cmdParameter in cmdMap.Parameters )
			{
				if ( (cmdParameter.RealParameterDirection == ParameterDirection.InputOutput ) ||
					(cmdParameter.RealParameterDirection == ParameterDirection.ReturnValue ) ||
					(cmdParameter.RealParameterDirection == ParameterDirection.Output ) )
				{
					curParam = currentCmd.Parameters[ cmdParameter.ParameterName ];
					prop = objType.GetProperty( cmdParameter.ClassMember );
					if (prop != null)
					{
						if ( curParam.Value != DBNull.Value )//如果传出参数的值不为空
						{
							prop.SetValue( persistObject, curParam.Value, null );//为当前属性设置值
						} 
					}
				}
			}

		}

		
		private void AssignValuesToParameters( CommandMapping cmdMap,ref SqlCommand currentCmd,PersistableObject persistObject )
		{
			Type objType;
			PropertyInfo prop;

			objType = persistObject.GetType();

			foreach (CommandParameter cmdParameter in cmdMap.Parameters )
			{
				if ( (cmdParameter.RealParameterDirection == ParameterDirection.Input ) ||
					(cmdParameter.RealParameterDirection == ParameterDirection.InputOutput ) )
				{
					prop = objType.GetProperty( cmdParameter.ClassMember );//得到objType类型中属性名为cmdParameter.ClassMember的一个属性对象
					currentCmd.Parameters[ cmdParameter.ParameterName ].Value = prop.GetValue( persistObject, null );//将persistObject对象中prop所表示的属性的值作为当前sql command对象所对应的参数的值

				}
			}
		}

		
		private SqlCommand BuildCommandFromMapping( CommandMapping cmdMap )
		{
			SqlConnection conn = new SqlConnection( SiteProfile.DefaultDataSource );
			
			SqlCommand sqlCommand = conn.CreateCommand();
			sqlCommand.CommandText = cmdMap.CommandName;
			sqlCommand.CommandType = CommandType.StoredProcedure;
			foreach ( CommandParameter cmdParameter in cmdMap.Parameters )
			{
				SqlParameter newParam = new SqlParameter();
				newParam.ParameterName = cmdParameter.ParameterName;
				newParam.Direction = cmdParameter.RealParameterDirection;
				newParam.SqlDbType = (SqlDbType)SiteProfile.DbTypeHints[cmdParameter.DbTypeHint];
				newParam.Size = cmdParameter.Size;

				sqlCommand.Parameters.Add( newParam );
			}

			return sqlCommand;
		}


	}
}

using System;
using System.Data;
using NetFocus.MagzineSubscribe.CMPServices;
using NetFocus.MagzineSubscribe.Data;


namespace NetFocus.MagzineSubscribe.Business
{

	public class EmployeeManager
	{
		public EmployeeManager()
		{

		}

		
		public static DataTable RetrieveAllEmployees()
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["EmployeeCatalog"];
			currentContainerMapping.CurrentCommandName = "GetEmployees";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Employee employee = new Employee();
			
			spc.Execute(employee);

			return employee.ResultSet.Tables[0];	
		}
		
		
		public static int CreateEmployee(string name)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["EmployeeCatalog"];
			currentContainerMapping.CurrentCommandName = "CreateEmployee";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Employee employee = new Employee();

			employee.Name = name;
			
			spc.Execute(employee);

			return employee.ReturnValue;	
		}
		
		
		public static int UpdateEmployee(int id,string name)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["EmployeeCatalog"];
			currentContainerMapping.CurrentCommandName = "UpdateEmployee";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Employee employee = new Employee();

			employee.Name = name;
			employee.Id = id;
			
			spc.Execute(employee);

			return employee.ReturnValue;	
		}
		
		
		public static void DeleteEmployee(int id)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["EmployeeCatalog"];
			currentContainerMapping.CurrentCommandName = "DeleteEmployee";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Employee employee = new Employee();

			employee.Id = id;
			
			spc.Execute(employee);
	
		}
	}
}

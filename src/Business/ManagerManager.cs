using System;
using System.Data;
using NetFocus.MagzineSubscribe.CMPServices;
using NetFocus.MagzineSubscribe.Data;

namespace NetFocus.MagzineSubscribe.Business
{

	public class ManagerManager
	{
		public ManagerManager()
		{

		}

		public static DataTable RetrieveAllManagers()
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "GetManagers";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();
			
			spc.Execute(manager);

			return manager.ResultSet.Tables[0];	
		}
		public static DataTable GetManager(string id)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "GetManager";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();

			manager.Id = id;
			
			spc.Execute(manager);

			return manager.ResultSet.Tables[0];	
		}
		public static int ValidateManager(string id,string password)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "ValidateManager";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();

			manager.Id = id;
			manager.Password = password;
			
			spc.Execute(manager);

			return manager.ReturnValue;	
		}
		public static int CreateManager(string id,string name,string password,int property)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "CreateManager";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();

			manager.Id = id;
			manager.Name = name;
			manager.Password = password;
			manager.Property = property;
			
			spc.Execute(manager);

			return manager.ReturnValue;	
		}
		public static void DeleteManager(string id)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "DeleteManager";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();

			manager.Id = id;
			
			spc.Execute(manager);

		}
		public static void UpdateManagerProperty(string id,int property)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "UpdateManagerProperty";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();

			manager.Id = id;
			manager.Property = property;
			
			spc.Execute(manager);
	
		}
		public static void UpdateManagerPassword(string id,string password)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "UpdateManagerPassword";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();

			manager.Id = id;
			manager.Password = password;
			
			spc.Execute(manager);


		}

		public static void UpdateManagerName(string id,string name)
		{
			ContainerMapping currentContainerMapping = CMPConfigurationHandler.ContainerMaps["ManagerCatalog"];
			currentContainerMapping.CurrentCommandName = "UpdateManagerName";
			
			SqlPersistenceContainer spc = new SqlPersistenceContainer(currentContainerMapping);
			Manager manager = new Manager();

			manager.Id = id;
			manager.Name = name;
			
			spc.Execute(manager);


		}



	}
}

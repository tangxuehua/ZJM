
using System;

namespace NetFocus.MagzineSubscribe.CMPServices
{
	public class StdPersistenceContainer  //定义了一个标准的持久性容器类，作为基类。
	{
		protected ContainerMapping currentMap;

		public StdPersistenceContainer()
		{ }

		
		public StdPersistenceContainer( ContainerMapping initCurrentMap )
		{
			currentMap = initCurrentMap;
		}

		
		public ContainerMapping ContainerMapping
		{
			get 
			{
				return currentMap;
			}
			set 
			{
				currentMap = value;
			}
		}

		public virtual void Execute( PersistableObject currentObject )
		{
		}

		
	}
}

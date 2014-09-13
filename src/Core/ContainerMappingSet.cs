using System;
using System.Xml;
using System.Xml.Serialization; 
using System.Reflection;
using System.Collections;

namespace NetFocus.MagzineSubscribe.CMPServices
{
	public class ContainerMappingSet
	{
		private Hashtable containerMappings;

		public ContainerMappingSet()
		{
			containerMappings = new Hashtable();
		}

		public ContainerMapping this [ string key ]
		{
			get 
			{
				if ( containerMappings.ContainsKey( key ) )
				{
					return (ContainerMapping) containerMappings[key];
				}
				else
					return null;
			}
			set 
			{
				if (containerMappings.ContainsKey( key ) )
				{
					containerMappings.Remove( key );
				}
				containerMappings.Add(key, value);
			}
		}

		public int Count
		{
			get 
			{
				return containerMappings.Count;
			}
		}
	}
}


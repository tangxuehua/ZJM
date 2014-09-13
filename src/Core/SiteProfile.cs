
using System;
using System.Collections;

namespace NetFocus.MagzineSubscribe.CMPServices
{
	public class SiteProfile
	{
		private static Hashtable dbTypeHints;
		private static string defaultDataSource;
		
		static SiteProfile()
		{
			dbTypeHints = new Hashtable();
		}

		public static Hashtable DbTypeHints
		{
			get 
			{
				return dbTypeHints;
			}
			set 
			{
				dbTypeHints = value;
			}
		}

		public static string DefaultDataSource
		{
			get 
			{
				return defaultDataSource;
			}
			set 
			{
				defaultDataSource = value;
			}
		}
	}
}

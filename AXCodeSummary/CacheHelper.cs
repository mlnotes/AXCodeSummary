using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading;
using System.Web.Caching;

namespace AXCodeSummary
{
	class CacheHelper
	{
		public static void Set(string key, string value)
		{
			Properties.Settings.Default[key] = value;
		}

		public static string Get(string key)
		{
			string value = Properties.Settings.Default[key] as string;
			return (value == null) ? "" : value;
		}

		public static void Save()
		{
			Properties.Settings.Default.Save();
		}
	}
}

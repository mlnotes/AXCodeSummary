using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAXParser.CodeParse.Util
{
	class Logger
	{
		public static Action<string> LogAction;

		public static void Log(string msg)
		{
			if (LogAction != null)
			{
				LogAction(msg);
			}
		}
	}
}

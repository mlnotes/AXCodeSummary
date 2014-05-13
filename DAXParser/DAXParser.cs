using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAXParser.CodeParse.IO;
using DAXParser.CodeParse;
using DAXParser.CodeParse.DirParse;
using DAXParser.CodeParse.Util;

namespace DAXParser
{
	public class DAXParser
	{
		public static void Parse(
			string[] layers,
			string[] modules,
			string output,
			string pattern,
			string[] ownerships,
			string[] countries,
			string[] regions,
			string[] tag_regions,
			Action<string> logAction)
		{
			Argument arg = Argument.Parse(layers, modules, output, pattern, 
				ownerships, countries, regions, tag_regions);

			Logger.LogAction = logAction;
		
			CSVDumper dumper = CSVDumper.GetInstance();
			dumper.TagRegion = arg.TagRegion;

			if (!string.IsNullOrEmpty(arg.Output))
			{
				dumper.Output = arg.Output;
			}

			foreach (string module in arg.Modules)
			{
				if (logAction != null)
				{
					Logger.Log("Parsing " + module + " ...");
				}

				ParseModule(arg.Dirs, module, arg.PrefixOwnership,
					arg.PostfixOwnership, arg.Country, arg.Region,
					arg.Pattern, dumper);
				
				if (logAction != null)
				{
					Logger.Log("Parse " + module + " Complete");
				}
			}
			dumper.Dispose();
		}


		private static void ParseModule(string[] dirs, String module,
								Dictionary<string, string> prefix,
								Dictionary<string, string> postfix,
								Dictionary<string, string> country,
								Dictionary<string, string> region,
								string pattern, CSVDumper dumper)
		{
			switch (module)
			{
				case ModuleDirs.Name.CLASS:
					List<ClassData> classes = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, ClassData.Parse, pattern);
					dumper.Dump(classes);
					break;
				case ModuleDirs.Name.TABLE:
					List<TableData> tables = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, TableData.Parse, pattern);
					dumper.Dump(tables);
					break;
				case ModuleDirs.Name.FORM:
					List<FormData> forms = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, FormData.Parse, pattern);
					dumper.Dump(forms);
					break;
				case ModuleDirs.Name.ENUM:
					List<EnumData> enums = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, EnumData.Parse, pattern);
					dumper.Dump(enums);
					break;
				case ModuleDirs.Name.MAP:
					List<MapData> maps = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, MapData.Parse, pattern);
					dumper.Dump(maps);
					break;
				case ModuleDirs.Name.QUERY:
					List<QueryData> queries = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, QueryData.Parse, pattern);
					dumper.Dump(queries);
					break;
				case ModuleDirs.Name.VIEW:
					List<ViewData> views = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, ViewData.Parse, pattern);
					dumper.Dump(views);
					break;
				case ModuleDirs.Name.SSRS:
					List<SSRSData> ssrs = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, SSRSData.Parse, pattern);
					dumper.Dump(ssrs);
					break;
				case ModuleDirs.Name.SERVICE:
					List<ServiceData> service = DirParser.Parse(dirs, ModuleDirs.GetModuleDir(module), prefix, postfix, country, region, ServiceData.Parse, pattern);
					dumper.Dump(service);
					break;
			}
		}
		
	}
}

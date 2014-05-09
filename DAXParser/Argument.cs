using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DAXParser
{
	class Argument
	{
		private string pattern = "*.xpo";
		private string output = "dax_parse_result.csv";
		private string[] dirs;
		private string[] modules;
		private Dictionary<string, string> prefixOwnership;
		private Dictionary<string, string> postfixOwnership;
		private Dictionary<string, string> region;
		private Dictionary<string, string> country;
		private Dictionary<string, string> tagRegion;

		public string Pattern { get { return pattern; } }

		public string Output { get { return output; } }

		public string[] Dirs { get { return dirs; } }

		public string[] Modules { get { return modules; } }

		public Dictionary<string, string> PrefixOwnership { get { return prefixOwnership; } }

		public Dictionary<string, string> PostfixOwnership { get { return postfixOwnership; } }

		public Dictionary<string, string> Region { get { return region; } }

		public Dictionary<string, string> Country { get { return country; } }

		public Dictionary<string, string> TagRegion { get { return tagRegion; } }

		private Argument()
		{
			dirs = new string[0];
			modules = new string[0];
			prefixOwnership = new Dictionary<string, string>();
			postfixOwnership = new Dictionary<string, string>();
			region = new Dictionary<string, string>();
			country = new Dictionary<string, string>();
			tagRegion = new Dictionary<string, string>();
		}

		public static Argument Parse(
			string[] layers,
			string[] modules,
			string output,
			string pattern,
			string[] ownerships,
			string[] countries,
			string[] regions,
			string[] tag_regions)
		{
			Argument argument = new Argument();

			argument.dirs = layers;

			// parse modules
			List<string> listModules = new List<string>();
			for (int i = 0; i < modules.Length; ++i)
			{
				if (ModuleDirs.IsValidModule(modules[i]))
				{
					listModules.Add(modules[i].ToUpper());
				}
			}
			argument.modules = listModules.ToArray();

			argument.output = output;
			argument.pattern = pattern;

			// parse ownership
			if (ownerships != null)
			{
				for (int i = 0; i < ownerships.Length; ++i)
				{
					ParseOwnership(argument.prefixOwnership, argument.postfixOwnership, ownerships[i]);
				}
			}

			// parse country
			if (countries != null)
			{
				for (int i = 0; i < countries.Length; ++i)
				{
					ParseCountry(argument.country, countries[i]);
				}
			}

			// parse region
			if (regions != null)
			{
				for (int i = 0; i < regions.Length; ++i)
				{
					ParseRegion(argument.region, regions[i]);
				}
			}

			// parse tag region
			if (tag_regions != null)
			{
				for (int i = 0; i < tag_regions.Length; ++i)
				{
					ParseTagRegion(argument.tagRegion, tag_regions[i]);
				}
			}

			return argument;
		}

		private static void ParseOwnership(Dictionary<string, string> prefix, Dictionary<string, string> postfix, string path)
		{
			if (!File.Exists(path))
			{
				return;
			}

			using (StreamReader reader = new StreamReader(path))
			{
				string line = reader.ReadLine();
				while (!reader.EndOfStream)
				{
					line = reader.ReadLine().Trim();
					string[] parts = line.Split('\t');
					if (parts.Length >= 2)
					{
						if (parts[1].StartsWith("*"))
						{
							postfix[parts[1].Substring(1).ToUpper()] = parts[0];
						}
						else
						{
							prefix[parts[1].ToUpper()] = parts[0];
						}
					}
				}
			}
		}

		private static void ParseCountry(Dictionary<string, string> country, string path)
		{
			if (!File.Exists(path))
			{
				return;
			}

			using (StreamReader reader = new StreamReader(path))
			{
				string line = reader.ReadLine();
				while (!reader.EndOfStream)
				{
					line = reader.ReadLine().Trim();
					string[] parts = line.Split('\t');
					if (parts.Length >= 2)
					{
						// currently only support postfix
						if (parts[1].StartsWith("*"))
						{
							country[parts[1].Substring(1).ToUpper()] = parts[0];
						}
					}
				}
			}
		}

		private static void ParseTagRegion(Dictionary<string, string> tagRegion, string path)
		{
			if (!File.Exists(path))
			{
				return;
			}

			using (StreamReader reader = new StreamReader(path))
			{
				string line = reader.ReadLine();
				while (!reader.EndOfStream)
				{
					line = reader.ReadLine().Trim();
					string[] parts = line.Split('\t');
					if (parts.Length >= 2)
					{
						// currently only support prefix
						tagRegion[parts[1].ToUpper()] = parts[0];
					}
				}
			}
		}

		private static void ParseRegion(Dictionary<string, string> region, string path)
		{
			if (!File.Exists(path))
			{
				return;
			}

			using (StreamReader reader = new StreamReader(path))
			{
				string line = reader.ReadLine();
				while (!reader.EndOfStream)
				{
					line = reader.ReadLine().Trim();
					string[] parts = line.Split('\t');
					if (parts.Length >= 2)
					{
						// match all
						region[parts[1].ToUpper()] = parts[0];
					}
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAXParser.CodeParse.IO;
using DAXParser.CodeParse.Config;

namespace DAXParser.CodeParse
{
	class ServiceData: BaseObjectData
	{
		public static ServiceData Parse(string path)
		{
			XPOReader reader;
			ServiceData data = new ServiceData();
			using (reader = new XPOReader(path))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine().TrimStart();
					if (line.StartsWith("#"))
					{
						data.lineCount++;
					}
					else if (line.StartsWith(KeyWords.SERVICE))
					{
						data.Name = line.Substring(KeyWords.SERVICE.Length).Trim().Substring(1);
					}
				}
			}

			data.lineCountOfFile = reader.LineCountOfFile;
			return data;
		}

		public override string Type
		{
			get { return "SERVICE"; }
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DAXParser.CodeParse.Config;
using DAXParser.CodeParse;
using DAXParser.CodeParse.Common;
using DAXParser.CodeParse.IO;

namespace DAXParser.CodeParse.Form.DataSource.Field
{
	class ReferenceFieldData: BaseObjectData
	{
		public override string Type
		{
			get { return "REFERENCEFIELD"; }
		}

		public static ReferenceFieldData Parse(string firstLine, XPOReader reader)
		{
			ReferenceFieldData data = new ReferenceFieldData();
			data.Name = firstLine.TrimStart().Substring(KeyWords.REFERENCEFIELD.Length).Trim();

			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine().TrimStart();
				if (line.StartsWith(KeyWords.METHODS))
				{
					List<MethodData> methods = ParseMethods(reader);
					foreach (MethodData m in methods)
					{
						data.AddMethod(m);
					}
				}
				else if (line.StartsWith(KeyWords.ENDREFERENCEFIELD))
				{
					break;
				}
			}

			return data;
		}
	}
}

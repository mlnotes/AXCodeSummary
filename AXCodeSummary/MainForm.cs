using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace AXCodeSummary
{
	public partial class MainForm : Form
	{
		private const string BASELAYER = "BaseLayer";
		private const string UPPERLAYERS = "UpperLayers";
		private const string PATTERN = "Pattern";
		private const string OUTPUT = "Output";
		private const string OWNERSHIP = "Ownership";
		private const string COUNTRY = "Country";
		private const string REGION = "Region";
		private const string TAGREGION = "TagRegion";
		private const string MODULES = "Modules";

		private const string MODULE_CLASS = "class";
		private const string MODULE_TABLE = "table";
		private const string MODULE_FORM = "form";
		private const string MODULE_SSRS = "ssrs";
		private const string MODULE_MAP = "map";
		private const string MODULE_VIEW = "view";
		private const string MODULE_QUERY = "query";
		private const string MODULE_ENUM = "enum";

		// parameters used to run background work
		private string[] ParmLayers;
		private string[] ParmModules;
		private string ParmOutput;
		private string ParmPattern;
		private string[] ParmOwnerships;
		private string[] ParmCountries;
		private string[] ParmRegions;
		private string[] ParmTagRegions;
		

		public MainForm()
		{
			InitializeComponent();
			InitWithCache();
			InitWorker();
		}

		private void InitWithCache()
		{
			textBaseLayer.Text = CacheHelper.Get(BASELAYER);
			textPattern.Text = CacheHelper.Get(PATTERN);
			textOutput.Text = CacheHelper.Get(OUTPUT);
			textOwnership.Text = CacheHelper.Get(OWNERSHIP);
			textCountry.Text = CacheHelper.Get(COUNTRY);
			textRegion.Text = CacheHelper.Get(REGION);
			textTagRegion.Text = CacheHelper.Get(TAGREGION);

			string strModules = CacheHelper.Get(MODULES);
			string[] modules = strModules.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < modules.Length; ++i)
			{
				switch (modules[i].ToLower())
				{
					case MODULE_CLASS:
						cbClass.Checked = true;
						break;
					case MODULE_TABLE:
						cbTable.Checked = true;
						break;
					case MODULE_FORM:
						cbForm.Checked = true;
						break;
					case MODULE_SSRS:
						cbSSRS.Checked = true;
						break;
					case MODULE_QUERY:
						cbQuery.Checked = true;
						break;
					case MODULE_MAP:
						cbMap.Checked = true;
						break;
					case MODULE_VIEW:
						cbView.Checked = true;
						break;
					case MODULE_ENUM:
						cbEnum.Checked = true;
						break;
					default:
						break;
				}
			}
		}

		private void InitWorker()
		{
			backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_DoWork);
			backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
		}

		void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			DAXParser.DAXParser.Parse(ParmLayers, ParmModules, ParmOutput, ParmPattern,
				ParmOwnerships, ParmCountries, ParmRegions, ParmTagRegions, log);
		}

		private string selectFile(string hintName)
		{
			openFileDialog.FileName = hintName;
			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				return openFileDialog.FileName;
			}
			else
			{
				return "";
			}
		}

		private string selectFolder()
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				return folderBrowserDialog.SelectedPath;
			}
			else
			{
				return "";
			}
		}

		private void btnBrowseOutput_Click(object sender, EventArgs e)
		{
			string filename = selectFile("dax_summary.csv");
			if(!string.IsNullOrEmpty(filename))
			{
				textOutput.Text = filename;
			}
		}

		private void btnBrowseOwnership_Click(object sender, EventArgs e)
		{
			string filename = selectFile("ownership.txt");
			if (!string.IsNullOrEmpty(filename))
			{
				textOwnership.Text = filename;
			}
		}

		private void btnBrowseCountry_Click(object sender, EventArgs e)
		{
			string filename = selectFile("country.txt");
			if (!string.IsNullOrEmpty(filename))
			{
				textCountry.Text = filename;
			}
		}

		private void btnBrowseRegion_Click(object sender, EventArgs e)
		{
			string filename = selectFile("region.txt");
			if (!string.IsNullOrEmpty(filename))
			{
				textRegion.Text = filename;
			}
		}

		private void btnBrowseTagRegion_Click(object sender, EventArgs e)
		{
			string filename = selectFile("tag_region.txt");
			if (!string.IsNullOrEmpty(filename))
			{
				textTagRegion.Text = filename;
			}
		}

		private List<string> getSelectedModules()
		{
			List<string> result = new List<string>();
			if (cbClass.Checked)
			{
				result.Add(MODULE_CLASS);
			}
			if (cbTable.Checked)
			{
				result.Add(MODULE_TABLE);
			}
			if (cbForm.Checked)
			{
				result.Add(MODULE_FORM);
			}
			if (cbSSRS.Checked)
			{
				result.Add(MODULE_SSRS);
			}
			if (cbView.Checked)
			{
				result.Add(MODULE_VIEW);
			}
			if (cbMap.Checked)
			{
				result.Add(MODULE_MAP);
			}
			if (cbQuery.Checked)
			{
				result.Add(MODULE_QUERY);
			}
			if (cbEnum.Checked)
			{
				result.Add(MODULE_ENUM);
			}
			return result;
		}

		private string join(List<string> parts, string glue=";")
		{
			if (parts == null)
			{
				return null;
			}
			
			StringBuilder result = new StringBuilder("");
			for (int i = 0; i < parts.Count-1; ++i)
			{
				result.Append(parts[i]).Append(glue);
			}
			if (parts.Count > 0)
			{
				result.Append(parts[parts.Count - 1]);
			}

			return result.ToString();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			// mandatory
			if (string.IsNullOrEmpty(textBaseLayer.Text))
			{
				MessageBox.Show("Base Layer must be set");
				return;
			}
			CacheHelper.Set(BASELAYER, textBaseLayer.Text);

			if (string.IsNullOrEmpty(textOutput.Text))
			{
				MessageBox.Show("Output must be set");
				return;
			}
			CacheHelper.Set(OUTPUT, textOutput.Text);

			List<string> modules = getSelectedModules();
			if (modules.Count == 0)
			{
				MessageBox.Show("At least one module should be selected");
				return;
			}
			CacheHelper.Set(MODULES, join(modules, ";"));

			// non mandatory
			CacheHelper.Set(PATTERN, textPattern.Text);
			CacheHelper.Set(OWNERSHIP, textOwnership.Text);
			CacheHelper.Set(COUNTRY, textCountry.Text);
			CacheHelper.Set(REGION, textRegion.Text);
			CacheHelper.Set(TAGREGION, textTagRegion.Text);
			CacheHelper.Save();

			ParmLayers = new string[] { textBaseLayer.Text };
			ParmPattern = textPattern.Text;
			ParmOutput = textOutput.Text;
			ParmModules = modules.ToArray();

			ParmOwnerships = null;
			if(!string.IsNullOrEmpty(textOwnership.Text))
			{
				ParmOwnerships = new string[] { textOwnership.Text };
			}

			ParmCountries = null;
			if(!string.IsNullOrEmpty(textCountry.Text))
			{
				ParmCountries = new string[] { textCountry.Text };
			}

			ParmRegions = null;
			if(!string.IsNullOrEmpty(textRegion.Text))
			{
				ParmRegions = new string[] { textRegion.Text };
			}

			ParmTagRegions = null;
			if(!string.IsNullOrEmpty(textTagRegion.Text))
			{
				ParmTagRegions = new string[] { textTagRegion.Text };
			}

			backgroundWorker.RunWorkerAsync();
		}

		void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			log("All Complete");
		}

		private void log(string msg)
		{
			textLog.Text += string.Format("[{0}]: {1} {2}", DateTime.Now, msg, Environment.NewLine);
		}

		private void textLog_TextChanged(object sender, EventArgs e)
		{
			textLog.SelectionStart = textLog.Text.Length;
			textLog.ScrollToCaret();
		}

		private void btnBaseLayer_Click(object sender, EventArgs e)
		{
			string path = selectFolder();
			if (!string.IsNullOrEmpty(path))
			{
				textBaseLayer.Text = path;
			}
		}

		private void btnAddLayer_Click(object sender, EventArgs e)
		{
			// TODO
			//Console.WriteLine("xxxx");
		}
	}
}

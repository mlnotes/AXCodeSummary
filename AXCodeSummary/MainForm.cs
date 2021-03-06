﻿using System;
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
		private const string MODULE_SERVICE = "service";

		// parameters used to run background work
		private string[] ParmLayers;
		private string[] ParmModules;
		private string ParmOutput;
		private string ParmPattern;
		private string[] ParmOwnerships;
		private string[] ParmCountries;
		private string[] ParmRegions;
		private string[] ParmTagRegions;

		private List<TextBox> textLayers = new List<TextBox>();
		private List<Button> btnLayers = new List<Button>();
		private List<Button> btnDels = new List<Button>();

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
					case MODULE_SERVICE:
						cbService.Checked = true;
						break;
					default:
						break;
				}
			}

			string strLayers = CacheHelper.Get(UPPERLAYERS);
			string[] layers = strLayers.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 1; i < layers.Length; ++i)
			{
				addLayer(layers[i]);
			}
		}

		private void InitWorker()
		{
			backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_DoWork);
			backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
			backgroundWorker.WorkerSupportsCancellation = true;
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
			if (cbService.Checked)
			{
				result.Add(MODULE_SERVICE);
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

		private void enableAll(bool enable = true)
		{
			groupLayers.Enabled = enable;
			btnRun.Enabled = enable;
			groupConfig.Enabled = enable;
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
			
			// upper layers
			List<string> layers = new List<string>();
			layers.Add(textBaseLayer.Text.Trim());
			for (int i = 0; i < textLayers.Count; ++i)
			{
				if (!string.IsNullOrEmpty(textLayers[i].Text))
				{
					layers.Add(textLayers[i].Text);
				}
			}
			CacheHelper.Set(UPPERLAYERS, join(layers, ";"));
			CacheHelper.Save();

			ParmLayers = layers.ToArray();
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

			enableAll(false);
		}

		void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			log("All Complete");
			enableAll(true);

			DialogResult result = MessageBox.Show(
				"Open the result file?", 
				"All Complete", 
				MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				System.Diagnostics.Process.Start(ParmOutput);
			}
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

		private void setCommonAttributes(Control baseControl, Control targetControl)
		{
			targetControl.Left = baseControl.Left;
			targetControl.Width = baseControl.Width;
			targetControl.Height = baseControl.Height;
			targetControl.Anchor = baseControl.Anchor;
		}

		private void addLayer(string layerPath = "")
		{
			// add text
			TextBox text = new TextBox();
			textLayers.Add(text);
			setCommonAttributes(textBaseLayer, text);
			text.Text = layerPath;
			text.Top = textBaseLayer.Top + (text.Height + 2) * textLayers.Count;
			groupLayers.Controls.Add(text);

			// add browser button
			Button btnLayer = new Button();
			btnLayers.Add(btnLayer);
			setCommonAttributes(btnBaseLayer, btnLayer);
			btnLayer.Text = btnBaseLayer.Text;
			btnLayer.Top = btnBaseLayer.Top + (btnLayer.Height + 2) * btnLayers.Count;
			btnLayer.Tag = btnLayers.Count - 1; // index of this button
			btnLayer.Click += new EventHandler(btnLayer_Click);
			groupLayers.Controls.Add(btnLayer);

			// add delete button
			Button btnDel = new Button();
			btnDels.Add(btnDel);
			setCommonAttributes(btnAddLayer, btnDel);
			
			btnDel.Text = "Delete";
			btnDel.Top = btnAddLayer.Top + (btnDel.Height + 2) * btnDels.Count;
			btnDel.Tag = btnDels.Count - 1; // index of this button
			btnDel.Click += new EventHandler(btnDel_Click);
			groupLayers.Controls.Add(btnDel);
		}

		private void btnAddLayer_Click(object sender, EventArgs e)
		{
			addLayer();
		}

		void btnLayer_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			int index = Convert.ToInt32(btn.Tag);
			string path = selectFolder();
			if (!string.IsNullOrEmpty(path))
			{
				textLayers[index].Text = path;
			}

		}

		void btnDel_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			int index = Convert.ToInt32(btn.Tag);
			int size = btnLayers.Count;

			groupLayers.Controls.Remove(btnLayers[index]);
			groupLayers.Controls.Remove(btnDels[index]);
			groupLayers.Controls.Remove(textLayers[index]);
			
			btnLayers.Remove(btnLayers[index]);
			btnDels.Remove(btnDels[index]);
			textLayers.Remove(textLayers[index]);

			for (int i = index; i < size-1; ++i)
			{
				btnLayers[i].Tag = i;
				btnDels[i].Tag = i;
				textLayers[i].Tag = i;

				btnLayers[i].Top = btnBaseLayer.Top + (btnBaseLayer.Height + 2) * (i+1);
				btnDels[i].Top = btnAddLayer.Top + (btnAddLayer.Height + 2) * (i + 1);
				textLayers[i].Top = textBaseLayer.Top + (textBaseLayer.Height + 2) * (i + 1);
			}
		}
	}
}

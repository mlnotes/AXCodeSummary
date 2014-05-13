namespace AXCodeSummary
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnRun = new System.Windows.Forms.Button();
			this.groupLayers = new System.Windows.Forms.GroupBox();
			this.btnAddLayer = new System.Windows.Forms.Button();
			this.btnBaseLayer = new System.Windows.Forms.Button();
			this.lblBaseLayer = new System.Windows.Forms.Label();
			this.textBaseLayer = new System.Windows.Forms.TextBox();
			this.groupLog = new System.Windows.Forms.GroupBox();
			this.textLog = new System.Windows.Forms.RichTextBox();
			this.groupConfig = new System.Windows.Forms.GroupBox();
			this.cbEnum = new System.Windows.Forms.CheckBox();
			this.cbView = new System.Windows.Forms.CheckBox();
			this.cbMap = new System.Windows.Forms.CheckBox();
			this.cbQuery = new System.Windows.Forms.CheckBox();
			this.cbSSRS = new System.Windows.Forms.CheckBox();
			this.cbForm = new System.Windows.Forms.CheckBox();
			this.cbTable = new System.Windows.Forms.CheckBox();
			this.cbClass = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnBrowseTagRegion = new System.Windows.Forms.Button();
			this.btnBrowseRegion = new System.Windows.Forms.Button();
			this.btnBrowseCountry = new System.Windows.Forms.Button();
			this.btnBrowseOwnership = new System.Windows.Forms.Button();
			this.btnBrowseOutput = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textTagRegion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textRegion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textCountry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textOwnership = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textPattern = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textOutput = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.cbService = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupLayers.SuspendLayout();
			this.groupLog.SuspendLayout();
			this.groupConfig.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.splitContainer1.Panel1.Controls.Add(this.btnRun);
			this.splitContainer1.Panel1.Controls.Add(this.groupLayers);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.splitContainer1.Panel2.Controls.Add(this.groupLog);
			this.splitContainer1.Panel2.Controls.Add(this.groupConfig);
			this.splitContainer1.Size = new System.Drawing.Size(622, 556);
			this.splitContainer1.SplitterDistance = 93;
			this.splitContainer1.TabIndex = 0;
			// 
			// btnRun
			// 
			this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRun.Location = new System.Drawing.Point(529, 12);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 65);
			this.btnRun.TabIndex = 8;
			this.btnRun.Text = "Run";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// groupLayers
			// 
			this.groupLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupLayers.Controls.Add(this.btnAddLayer);
			this.groupLayers.Controls.Add(this.btnBaseLayer);
			this.groupLayers.Controls.Add(this.lblBaseLayer);
			this.groupLayers.Controls.Add(this.textBaseLayer);
			this.groupLayers.Location = new System.Drawing.Point(12, 3);
			this.groupLayers.Name = "groupLayers";
			this.groupLayers.Size = new System.Drawing.Size(505, 82);
			this.groupLayers.TabIndex = 5;
			this.groupLayers.TabStop = false;
			this.groupLayers.Text = "Layers";
			// 
			// btnAddLayer
			// 
			this.btnAddLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddLayer.Location = new System.Drawing.Point(443, 23);
			this.btnAddLayer.Name = "btnAddLayer";
			this.btnAddLayer.Size = new System.Drawing.Size(49, 20);
			this.btnAddLayer.TabIndex = 16;
			this.btnAddLayer.Text = "Add";
			this.btnAddLayer.UseVisualStyleBackColor = true;
			this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
			// 
			// btnBaseLayer
			// 
			this.btnBaseLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBaseLayer.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnBaseLayer.Location = new System.Drawing.Point(377, 23);
			this.btnBaseLayer.Name = "btnBaseLayer";
			this.btnBaseLayer.Size = new System.Drawing.Size(60, 20);
			this.btnBaseLayer.TabIndex = 15;
			this.btnBaseLayer.Text = "Browse";
			this.btnBaseLayer.UseVisualStyleBackColor = false;
			this.btnBaseLayer.Click += new System.EventHandler(this.btnBaseLayer_Click);
			// 
			// lblBaseLayer
			// 
			this.lblBaseLayer.AutoSize = true;
			this.lblBaseLayer.Location = new System.Drawing.Point(9, 26);
			this.lblBaseLayer.Name = "lblBaseLayer";
			this.lblBaseLayer.Size = new System.Drawing.Size(60, 13);
			this.lblBaseLayer.TabIndex = 3;
			this.lblBaseLayer.Text = "Base Layer";
			// 
			// textBaseLayer
			// 
			this.textBaseLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBaseLayer.Location = new System.Drawing.Point(79, 23);
			this.textBaseLayer.Name = "textBaseLayer";
			this.textBaseLayer.Size = new System.Drawing.Size(292, 20);
			this.textBaseLayer.TabIndex = 2;
			// 
			// groupLog
			// 
			this.groupLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupLog.Controls.Add(this.textLog);
			this.groupLog.Location = new System.Drawing.Point(12, 215);
			this.groupLog.Name = "groupLog";
			this.groupLog.Size = new System.Drawing.Size(598, 232);
			this.groupLog.TabIndex = 7;
			this.groupLog.TabStop = false;
			this.groupLog.Text = "Log";
			// 
			// textLog
			// 
			this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textLog.Location = new System.Drawing.Point(6, 20);
			this.textLog.Name = "textLog";
			this.textLog.ReadOnly = true;
			this.textLog.Size = new System.Drawing.Size(586, 206);
			this.textLog.TabIndex = 0;
			this.textLog.Text = "";
			this.textLog.TextChanged += new System.EventHandler(this.textLog_TextChanged);
			// 
			// groupConfig
			// 
			this.groupConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupConfig.Controls.Add(this.cbService);
			this.groupConfig.Controls.Add(this.cbEnum);
			this.groupConfig.Controls.Add(this.cbView);
			this.groupConfig.Controls.Add(this.cbMap);
			this.groupConfig.Controls.Add(this.cbQuery);
			this.groupConfig.Controls.Add(this.cbSSRS);
			this.groupConfig.Controls.Add(this.cbForm);
			this.groupConfig.Controls.Add(this.cbTable);
			this.groupConfig.Controls.Add(this.cbClass);
			this.groupConfig.Controls.Add(this.label8);
			this.groupConfig.Controls.Add(this.btnBrowseTagRegion);
			this.groupConfig.Controls.Add(this.btnBrowseRegion);
			this.groupConfig.Controls.Add(this.btnBrowseCountry);
			this.groupConfig.Controls.Add(this.btnBrowseOwnership);
			this.groupConfig.Controls.Add(this.btnBrowseOutput);
			this.groupConfig.Controls.Add(this.label6);
			this.groupConfig.Controls.Add(this.textTagRegion);
			this.groupConfig.Controls.Add(this.label5);
			this.groupConfig.Controls.Add(this.textRegion);
			this.groupConfig.Controls.Add(this.label4);
			this.groupConfig.Controls.Add(this.textCountry);
			this.groupConfig.Controls.Add(this.label3);
			this.groupConfig.Controls.Add(this.textOwnership);
			this.groupConfig.Controls.Add(this.label2);
			this.groupConfig.Controls.Add(this.textPattern);
			this.groupConfig.Controls.Add(this.label1);
			this.groupConfig.Controls.Add(this.textOutput);
			this.groupConfig.Location = new System.Drawing.Point(12, 3);
			this.groupConfig.Name = "groupConfig";
			this.groupConfig.Size = new System.Drawing.Size(598, 206);
			this.groupConfig.TabIndex = 6;
			this.groupConfig.TabStop = false;
			this.groupConfig.Text = "Configuration";
			// 
			// cbEnum
			// 
			this.cbEnum.AutoSize = true;
			this.cbEnum.Location = new System.Drawing.Point(469, 24);
			this.cbEnum.Name = "cbEnum";
			this.cbEnum.Size = new System.Drawing.Size(53, 17);
			this.cbEnum.TabIndex = 28;
			this.cbEnum.Text = "Enum";
			this.cbEnum.UseVisualStyleBackColor = true;
			// 
			// cbView
			// 
			this.cbView.AutoSize = true;
			this.cbView.Location = new System.Drawing.Point(416, 24);
			this.cbView.Name = "cbView";
			this.cbView.Size = new System.Drawing.Size(49, 17);
			this.cbView.TabIndex = 27;
			this.cbView.Text = "View";
			this.cbView.UseVisualStyleBackColor = true;
			// 
			// cbMap
			// 
			this.cbMap.AutoSize = true;
			this.cbMap.Location = new System.Drawing.Point(365, 24);
			this.cbMap.Name = "cbMap";
			this.cbMap.Size = new System.Drawing.Size(47, 17);
			this.cbMap.TabIndex = 26;
			this.cbMap.Text = "Map";
			this.cbMap.UseVisualStyleBackColor = true;
			// 
			// cbQuery
			// 
			this.cbQuery.AutoSize = true;
			this.cbQuery.Location = new System.Drawing.Point(308, 24);
			this.cbQuery.Name = "cbQuery";
			this.cbQuery.Size = new System.Drawing.Size(54, 17);
			this.cbQuery.TabIndex = 25;
			this.cbQuery.Text = "Query";
			this.cbQuery.UseVisualStyleBackColor = true;
			// 
			// cbSSRS
			// 
			this.cbSSRS.AutoSize = true;
			this.cbSSRS.Location = new System.Drawing.Point(249, 24);
			this.cbSSRS.Name = "cbSSRS";
			this.cbSSRS.Size = new System.Drawing.Size(55, 17);
			this.cbSSRS.TabIndex = 24;
			this.cbSSRS.Text = "SSRS";
			this.cbSSRS.UseVisualStyleBackColor = true;
			// 
			// cbForm
			// 
			this.cbForm.AutoSize = true;
			this.cbForm.Location = new System.Drawing.Point(196, 24);
			this.cbForm.Name = "cbForm";
			this.cbForm.Size = new System.Drawing.Size(49, 17);
			this.cbForm.TabIndex = 23;
			this.cbForm.Text = "Form";
			this.cbForm.UseVisualStyleBackColor = true;
			// 
			// cbTable
			// 
			this.cbTable.AutoSize = true;
			this.cbTable.Location = new System.Drawing.Point(139, 24);
			this.cbTable.Name = "cbTable";
			this.cbTable.Size = new System.Drawing.Size(53, 17);
			this.cbTable.TabIndex = 22;
			this.cbTable.Text = "Table";
			this.cbTable.UseVisualStyleBackColor = true;
			// 
			// cbClass
			// 
			this.cbClass.AutoSize = true;
			this.cbClass.Location = new System.Drawing.Point(85, 24);
			this.cbClass.Name = "cbClass";
			this.cbClass.Size = new System.Drawing.Size(51, 17);
			this.cbClass.TabIndex = 21;
			this.cbClass.Text = "Class";
			this.cbClass.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(17, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Modules";
			// 
			// btnBrowseTagRegion
			// 
			this.btnBrowseTagRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseTagRegion.Location = new System.Drawing.Point(517, 174);
			this.btnBrowseTagRegion.Name = "btnBrowseTagRegion";
			this.btnBrowseTagRegion.Size = new System.Drawing.Size(75, 20);
			this.btnBrowseTagRegion.TabIndex = 19;
			this.btnBrowseTagRegion.Text = "Browse";
			this.btnBrowseTagRegion.UseVisualStyleBackColor = true;
			this.btnBrowseTagRegion.Click += new System.EventHandler(this.btnBrowseTagRegion_Click);
			// 
			// btnBrowseRegion
			// 
			this.btnBrowseRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseRegion.Location = new System.Drawing.Point(517, 148);
			this.btnBrowseRegion.Name = "btnBrowseRegion";
			this.btnBrowseRegion.Size = new System.Drawing.Size(75, 20);
			this.btnBrowseRegion.TabIndex = 18;
			this.btnBrowseRegion.Text = "Browse";
			this.btnBrowseRegion.UseVisualStyleBackColor = true;
			this.btnBrowseRegion.Click += new System.EventHandler(this.btnBrowseRegion_Click);
			// 
			// btnBrowseCountry
			// 
			this.btnBrowseCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseCountry.Location = new System.Drawing.Point(517, 122);
			this.btnBrowseCountry.Name = "btnBrowseCountry";
			this.btnBrowseCountry.Size = new System.Drawing.Size(75, 20);
			this.btnBrowseCountry.TabIndex = 17;
			this.btnBrowseCountry.Text = "Browse";
			this.btnBrowseCountry.UseVisualStyleBackColor = true;
			this.btnBrowseCountry.Click += new System.EventHandler(this.btnBrowseCountry_Click);
			// 
			// btnBrowseOwnership
			// 
			this.btnBrowseOwnership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOwnership.Location = new System.Drawing.Point(517, 96);
			this.btnBrowseOwnership.Name = "btnBrowseOwnership";
			this.btnBrowseOwnership.Size = new System.Drawing.Size(75, 20);
			this.btnBrowseOwnership.TabIndex = 16;
			this.btnBrowseOwnership.Text = "Browse";
			this.btnBrowseOwnership.UseVisualStyleBackColor = true;
			this.btnBrowseOwnership.Click += new System.EventHandler(this.btnBrowseOwnership_Click);
			// 
			// btnBrowseOutput
			// 
			this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOutput.Location = new System.Drawing.Point(517, 69);
			this.btnBrowseOutput.Name = "btnBrowseOutput";
			this.btnBrowseOutput.Size = new System.Drawing.Size(75, 20);
			this.btnBrowseOutput.TabIndex = 14;
			this.btnBrowseOutput.Text = "Browse";
			this.btnBrowseOutput.UseVisualStyleBackColor = true;
			this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 178);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Tag Region";
			// 
			// textTagRegion
			// 
			this.textTagRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textTagRegion.Location = new System.Drawing.Point(85, 175);
			this.textTagRegion.Name = "textTagRegion";
			this.textTagRegion.Size = new System.Drawing.Size(420, 20);
			this.textTagRegion.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Region";
			// 
			// textRegion
			// 
			this.textRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textRegion.Location = new System.Drawing.Point(85, 149);
			this.textRegion.Name = "textRegion";
			this.textRegion.Size = new System.Drawing.Size(420, 20);
			this.textRegion.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Country";
			// 
			// textCountry
			// 
			this.textCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textCountry.Location = new System.Drawing.Point(85, 124);
			this.textCountry.Name = "textCountry";
			this.textCountry.Size = new System.Drawing.Size(420, 20);
			this.textCountry.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ownership";
			// 
			// textOwnership
			// 
			this.textOwnership.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textOwnership.Location = new System.Drawing.Point(85, 97);
			this.textOwnership.Name = "textOwnership";
			this.textOwnership.Size = new System.Drawing.Size(420, 20);
			this.textOwnership.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Pattern";
			// 
			// textPattern
			// 
			this.textPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textPattern.Location = new System.Drawing.Point(85, 44);
			this.textPattern.Name = "textPattern";
			this.textPattern.Size = new System.Drawing.Size(420, 20);
			this.textPattern.TabIndex = 2;
			this.textPattern.Text = "*.xpo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Output";
			// 
			// textOutput
			// 
			this.textOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textOutput.Location = new System.Drawing.Point(85, 69);
			this.textOutput.Name = "textOutput";
			this.textOutput.Size = new System.Drawing.Size(420, 20);
			this.textOutput.TabIndex = 0;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// cbService
			// 
			this.cbService.AutoSize = true;
			this.cbService.Location = new System.Drawing.Point(521, 24);
			this.cbService.Name = "cbService";
			this.cbService.Size = new System.Drawing.Size(62, 17);
			this.cbService.TabIndex = 29;
			this.cbService.Text = "Service";
			this.cbService.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(622, 556);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(600, 39);
			this.Name = "MainForm";
			this.Text = "AX Code Summary";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupLayers.ResumeLayout(false);
			this.groupLayers.PerformLayout();
			this.groupLog.ResumeLayout(false);
			this.groupConfig.ResumeLayout(false);
			this.groupConfig.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.GroupBox groupLayers;
		private System.Windows.Forms.GroupBox groupLog;
		private System.Windows.Forms.GroupBox groupConfig;
		private System.Windows.Forms.Button btnBrowseTagRegion;
		private System.Windows.Forms.Button btnBrowseRegion;
		private System.Windows.Forms.Button btnBrowseCountry;
		private System.Windows.Forms.Button btnBrowseOwnership;
		private System.Windows.Forms.Button btnBrowseOutput;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textTagRegion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textRegion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textOwnership;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textPattern;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textOutput;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label lblBaseLayer;
		private System.Windows.Forms.TextBox textBaseLayer;
		private System.Windows.Forms.Button btnBaseLayer;
		private System.Windows.Forms.Button btnAddLayer;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox cbEnum;
		private System.Windows.Forms.CheckBox cbView;
		private System.Windows.Forms.CheckBox cbMap;
		private System.Windows.Forms.CheckBox cbQuery;
		private System.Windows.Forms.CheckBox cbSSRS;
		private System.Windows.Forms.CheckBox cbForm;
		private System.Windows.Forms.CheckBox cbTable;
		private System.Windows.Forms.CheckBox cbClass;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.RichTextBox textLog;
		private System.Windows.Forms.CheckBox cbService;


	}
}


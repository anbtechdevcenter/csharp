namespace AnBTech.RestAPI
{
	partial class FrmEmployeeMag
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
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtpkTo = new System.Windows.Forms.DateTimePicker();
			this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
			this.cboEmployeeName = new System.Windows.Forms.ComboBox();
			this.lblSearchDate = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.cboRank = new System.Windows.Forms.ComboBox();
			this.lblRank = new System.Windows.Forms.Label();
			this.txtTeamName = new System.Windows.Forms.TextBox();
			this.lblTeamName = new System.Windows.Forms.Label();
			this.btnNewEmployee = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chkContractEmployee = new System.Windows.Forms.CheckBox();
			this.chkPermanentEmployee = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboProjectName = new System.Windows.Forms.ComboBox();
			this.lblProjectName = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSearchResult = new System.Windows.Forms.TabPage();
			this.pnlSearchResult = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageSearchResult.SuspendLayout();
			this.pnlSearchResult.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1264, 682);
			this.splitContainer1.SplitterDistance = 39;
			this.splitContainer1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dtpkTo);
			this.panel1.Controls.Add(this.dtpkFrom);
			this.panel1.Controls.Add(this.cboEmployeeName);
			this.panel1.Controls.Add(this.lblSearchDate);
			this.panel1.Controls.Add(this.lblEmployeeName);
			this.panel1.Controls.Add(this.cboRank);
			this.panel1.Controls.Add(this.lblRank);
			this.panel1.Controls.Add(this.txtTeamName);
			this.panel1.Controls.Add(this.lblTeamName);
			this.panel1.Controls.Add(this.btnNewEmployee);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1264, 39);
			this.panel1.TabIndex = 0;
			// 
			// dtpkTo
			// 
			this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpkTo.Location = new System.Drawing.Point(965, 10);
			this.dtpkTo.Name = "dtpkTo";
			this.dtpkTo.Size = new System.Drawing.Size(100, 21);
			this.dtpkTo.TabIndex = 3;
			// 
			// dtpkFrom
			// 
			this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpkFrom.Location = new System.Drawing.Point(859, 10);
			this.dtpkFrom.Name = "dtpkFrom";
			this.dtpkFrom.Size = new System.Drawing.Size(100, 21);
			this.dtpkFrom.TabIndex = 3;
			// 
			// cboEmployeeName
			// 
			this.cboEmployeeName.FormattingEnabled = true;
			this.cboEmployeeName.Location = new System.Drawing.Point(682, 10);
			this.cboEmployeeName.Name = "cboEmployeeName";
			this.cboEmployeeName.Size = new System.Drawing.Size(90, 20);
			this.cboEmployeeName.TabIndex = 2;
			// 
			// lblSearchDate
			// 
			this.lblSearchDate.AutoSize = true;
			this.lblSearchDate.Location = new System.Drawing.Point(800, 13);
			this.lblSearchDate.Name = "lblSearchDate";
			this.lblSearchDate.Size = new System.Drawing.Size(53, 12);
			this.lblSearchDate.TabIndex = 1;
			this.lblSearchDate.Text = "검색기간";
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Location = new System.Drawing.Point(635, 13);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(41, 12);
			this.lblEmployeeName.TabIndex = 1;
			this.lblEmployeeName.Text = "사원명";
			// 
			// cboRank
			// 
			this.cboRank.FormattingEnabled = true;
			this.cboRank.Location = new System.Drawing.Point(539, 10);
			this.cboRank.Name = "cboRank";
			this.cboRank.Size = new System.Drawing.Size(81, 20);
			this.cboRank.TabIndex = 2;
			// 
			// lblRank
			// 
			this.lblRank.AutoSize = true;
			this.lblRank.Location = new System.Drawing.Point(468, 13);
			this.lblRank.Name = "lblRank";
			this.lblRank.Size = new System.Drawing.Size(29, 12);
			this.lblRank.TabIndex = 1;
			this.lblRank.Text = "직급";
			// 
			// txtTeamName
			// 
			this.txtTeamName.Location = new System.Drawing.Point(87, 10);
			this.txtTeamName.Name = "txtTeamName";
			this.txtTeamName.Size = new System.Drawing.Size(360, 21);
			this.txtTeamName.TabIndex = 2;
			// 
			// lblTeamName
			// 
			this.lblTeamName.AutoSize = true;
			this.lblTeamName.Location = new System.Drawing.Point(16, 13);
			this.lblTeamName.Name = "lblTeamName";
			this.lblTeamName.Size = new System.Drawing.Size(41, 12);
			this.lblTeamName.TabIndex = 1;
			this.lblTeamName.Text = "부서명";
			// 
			// btnNewEmployee
			// 
			this.btnNewEmployee.Location = new System.Drawing.Point(1177, 4);
			this.btnNewEmployee.Name = "btnNewEmployee";
			this.btnNewEmployee.Size = new System.Drawing.Size(75, 30);
			this.btnNewEmployee.TabIndex = 0;
			this.btnNewEmployee.Text = "New";
			this.btnNewEmployee.UseVisualStyleBackColor = true;
			this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(1096, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 30);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.panel2);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer2.Size = new System.Drawing.Size(1264, 639);
			this.splitContainer2.SplitterDistance = 37;
			this.splitContainer2.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.chkContractEmployee);
			this.panel2.Controls.Add(this.chkPermanentEmployee);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cboProjectName);
			this.panel2.Controls.Add(this.lblProjectName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1264, 37);
			this.panel2.TabIndex = 1;
			// 
			// chkContractEmployee
			// 
			this.chkContractEmployee.AutoSize = true;
			this.chkContractEmployee.Location = new System.Drawing.Point(605, 11);
			this.chkContractEmployee.Name = "chkContractEmployee";
			this.chkContractEmployee.Size = new System.Drawing.Size(60, 16);
			this.chkContractEmployee.TabIndex = 4;
			this.chkContractEmployee.Text = "계약직";
			this.chkContractEmployee.UseVisualStyleBackColor = true;
			// 
			// chkPermanentEmployee
			// 
			this.chkPermanentEmployee.AutoSize = true;
			this.chkPermanentEmployee.Location = new System.Drawing.Point(539, 11);
			this.chkPermanentEmployee.Name = "chkPermanentEmployee";
			this.chkPermanentEmployee.Size = new System.Drawing.Size(60, 16);
			this.chkPermanentEmployee.TabIndex = 4;
			this.chkPermanentEmployee.Text = "정규직";
			this.chkPermanentEmployee.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(468, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "사원분류";
			// 
			// cboProjectName
			// 
			this.cboProjectName.FormattingEnabled = true;
			this.cboProjectName.Location = new System.Drawing.Point(87, 9);
			this.cboProjectName.Name = "cboProjectName";
			this.cboProjectName.Size = new System.Drawing.Size(360, 20);
			this.cboProjectName.TabIndex = 2;
			// 
			// lblProjectName
			// 
			this.lblProjectName.AutoSize = true;
			this.lblProjectName.Location = new System.Drawing.Point(16, 12);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(65, 12);
			this.lblProjectName.TabIndex = 1;
			this.lblProjectName.Text = "프로젝트명";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageSearchResult);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1264, 598);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageSearchResult
			// 
			this.tabPageSearchResult.Controls.Add(this.pnlSearchResult);
			this.tabPageSearchResult.Location = new System.Drawing.Point(4, 22);
			this.tabPageSearchResult.Name = "tabPageSearchResult";
			this.tabPageSearchResult.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSearchResult.Size = new System.Drawing.Size(1256, 572);
			this.tabPageSearchResult.TabIndex = 0;
			this.tabPageSearchResult.Text = "Search Result";
			this.tabPageSearchResult.UseVisualStyleBackColor = true;
			// 
			// pnlSearchResult
			// 
			this.pnlSearchResult.Controls.Add(this.treeView1);
			this.pnlSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSearchResult.Location = new System.Drawing.Point(3, 3);
			this.pnlSearchResult.Name = "pnlSearchResult";
			this.pnlSearchResult.Size = new System.Drawing.Size(1250, 566);
			this.pnlSearchResult.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(1250, 566);
			this.treeView1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem,
            this.삭제ToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
			// 
			// 삭제ToolStripMenuItem
			// 
			this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
			this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.삭제ToolStripMenuItem.Text = "수정";
			// 
			// 삭제ToolStripMenuItem1
			// 
			this.삭제ToolStripMenuItem1.Name = "삭제ToolStripMenuItem1";
			this.삭제ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
			this.삭제ToolStripMenuItem1.Text = "삭제";
			// 
			// FrmEmployeeMag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 682);
			this.Controls.Add(this.splitContainer1);
			this.Name = "FrmEmployeeMag";
			this.Text = "A&B Employee Manager";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPageSearchResult.ResumeLayout(false);
			this.pnlSearchResult.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNewEmployee;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cboEmployeeName;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.ComboBox cboRank;
		private System.Windows.Forms.Label lblRank;
		private System.Windows.Forms.TextBox txtTeamName;
		private System.Windows.Forms.Label lblTeamName;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox chkContractEmployee;
		private System.Windows.Forms.CheckBox chkPermanentEmployee;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboProjectName;
		private System.Windows.Forms.Label lblProjectName;
		private System.Windows.Forms.DateTimePicker dtpkTo;
		private System.Windows.Forms.DateTimePicker dtpkFrom;
		private System.Windows.Forms.Label lblSearchDate;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSearchResult;
		private System.Windows.Forms.Panel pnlSearchResult;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem1;
	}
}
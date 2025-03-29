namespace Academy
{
	partial class Main
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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tpStudent = new System.Windows.Forms.TabPage();
			this.cbStudentsGroups = new System.Windows.Forms.ComboBox();
			this.cbDirectionsStudents = new System.Windows.Forms.ComboBox();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmRefreshTable = new System.Windows.Forms.ToolStripMenuItem();
			this.cmSeeAllDirctions = new System.Windows.Forms.ToolStripMenuItem();
			this.tbGroups = new System.Windows.Forms.TabPage();
			this.cbDirectionsGroups = new System.Windows.Forms.ComboBox();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.tpDirections = new System.Windows.Forms.TabPage();
			this.dgvDirections = new System.Windows.Forms.DataGridView();
			this.tpDisciplines = new System.Windows.Forms.TabPage();
			this.dgvDisciplines = new System.Windows.Forms.DataGridView();
			this.tbTeahcers = new System.Windows.Forms.TabPage();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.toolStripFilterCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tpStudent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.contextMenu.SuspendLayout();
			this.tbGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.tpDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
			this.tpDisciplines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
			this.tbTeahcers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripFilterCount});
			this.statusStrip.Location = new System.Drawing.Point(0, 419);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(624, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tpStudent);
			this.tabControl.Controls.Add(this.tbGroups);
			this.tabControl.Controls.Add(this.tpDirections);
			this.tabControl.Controls.Add(this.tpDisciplines);
			this.tabControl.Controls.Add(this.tbTeahcers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(624, 419);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
			// 
			// tpStudent
			// 
			this.tpStudent.BackColor = System.Drawing.Color.Teal;
			this.tpStudent.Controls.Add(this.cbStudentsGroups);
			this.tpStudent.Controls.Add(this.cbDirectionsStudents);
			this.tpStudent.Controls.Add(this.dgvStudents);
			this.tpStudent.Location = new System.Drawing.Point(4, 22);
			this.tpStudent.Name = "tpStudent";
			this.tpStudent.Padding = new System.Windows.Forms.Padding(3);
			this.tpStudent.Size = new System.Drawing.Size(616, 393);
			this.tpStudent.TabIndex = 0;
			this.tpStudent.Text = "Students";
			// 
			// cbStudentsGroups
			// 
			this.cbStudentsGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbStudentsGroups.FormattingEnabled = true;
			this.cbStudentsGroups.Location = new System.Drawing.Point(304, 15);
			this.cbStudentsGroups.Name = "cbStudentsGroups";
			this.cbStudentsGroups.Size = new System.Drawing.Size(304, 21);
			this.cbStudentsGroups.TabIndex = 2;
			this.cbStudentsGroups.SelectedIndexChanged += new System.EventHandler(this.cbStudents_SelectedIndexChanged);
			// 
			// cbDirectionsStudents
			// 
			this.cbDirectionsStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDirectionsStudents.FormattingEnabled = true;
			this.cbDirectionsStudents.Location = new System.Drawing.Point(8, 15);
			this.cbDirectionsStudents.Name = "cbDirectionsStudents";
			this.cbDirectionsStudents.Size = new System.Drawing.Size(290, 21);
			this.cbDirectionsStudents.TabIndex = 1;
			this.cbDirectionsStudents.DropDown += new System.EventHandler(this.cbDirectionsStudents_DropDown);
			this.cbDirectionsStudents.SelectedIndexChanged += new System.EventHandler(this.cbDirections_SelectedIndexChanged);
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.ContextMenuStrip = this.contextMenu;
			this.dgvStudents.Location = new System.Drawing.Point(3, 42);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(610, 348);
			this.dgvStudents.TabIndex = 0;
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmRefreshTable,
            this.cmSeeAllDirctions});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(164, 48);
			// 
			// cmRefreshTable
			// 
			this.cmRefreshTable.Name = "cmRefreshTable";
			this.cmRefreshTable.Size = new System.Drawing.Size(163, 22);
			this.cmRefreshTable.Text = "Refresh Table";
			this.cmRefreshTable.Click += new System.EventHandler(this.cmRefreshTable_Click);
			// 
			// cmSeeAllDirctions
			// 
			this.cmSeeAllDirctions.Name = "cmSeeAllDirctions";
			this.cmSeeAllDirctions.Size = new System.Drawing.Size(163, 22);
			this.cmSeeAllDirctions.Text = "See all Directions";
			this.cmSeeAllDirctions.CheckedChanged += new System.EventHandler(this.cmSeeAllDirctions_CheckedChanged);
			this.cmSeeAllDirctions.Click += new System.EventHandler(this.cmSeeAllDirctions_Click);
			// 
			// tbGroups
			// 
			this.tbGroups.BackColor = System.Drawing.Color.Teal;
			this.tbGroups.Controls.Add(this.cbDirectionsGroups);
			this.tbGroups.Controls.Add(this.dgvGroups);
			this.tbGroups.Location = new System.Drawing.Point(4, 22);
			this.tbGroups.Name = "tbGroups";
			this.tbGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tbGroups.Size = new System.Drawing.Size(616, 393);
			this.tbGroups.TabIndex = 1;
			this.tbGroups.Text = "Groups";
			// 
			// cbDirectionsGroups
			// 
			this.cbDirectionsGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDirectionsGroups.FormattingEnabled = true;
			this.cbDirectionsGroups.Location = new System.Drawing.Point(8, 15);
			this.cbDirectionsGroups.Name = "cbDirectionsGroups";
			this.cbDirectionsGroups.Size = new System.Drawing.Size(600, 21);
			this.cbDirectionsGroups.TabIndex = 1;
			this.cbDirectionsGroups.DropDown += new System.EventHandler(this.cbDirectionsGroups_DropDown);
			this.cbDirectionsGroups.SelectedIndexChanged += new System.EventHandler(this.cbDirectionsGroups_SelectedIndexChanged);
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGroups.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.ContextMenuStrip = this.contextMenu;
			this.dgvGroups.Location = new System.Drawing.Point(3, 42);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.Size = new System.Drawing.Size(610, 348);
			this.dgvGroups.TabIndex = 0;
			// 
			// tpDirections
			// 
			this.tpDirections.BackColor = System.Drawing.Color.Teal;
			this.tpDirections.Controls.Add(this.dgvDirections);
			this.tpDirections.Location = new System.Drawing.Point(4, 22);
			this.tpDirections.Name = "tpDirections";
			this.tpDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tpDirections.Size = new System.Drawing.Size(616, 393);
			this.tpDirections.TabIndex = 2;
			this.tpDirections.Text = "Directions";
			// 
			// dgvDirections
			// 
			this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDirections.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirections.ContextMenuStrip = this.contextMenu;
			this.dgvDirections.Location = new System.Drawing.Point(3, 42);
			this.dgvDirections.Name = "dgvDirections";
			this.dgvDirections.Size = new System.Drawing.Size(610, 348);
			this.dgvDirections.TabIndex = 0;
			// 
			// tpDisciplines
			// 
			this.tpDisciplines.BackColor = System.Drawing.Color.Teal;
			this.tpDisciplines.Controls.Add(this.dgvDisciplines);
			this.tpDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tpDisciplines.Name = "tpDisciplines";
			this.tpDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tpDisciplines.Size = new System.Drawing.Size(616, 393);
			this.tpDisciplines.TabIndex = 3;
			this.tpDisciplines.Text = "Disciplines";
			// 
			// dgvDisciplines
			// 
			this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDisciplines.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisciplines.ContextMenuStrip = this.contextMenu;
			this.dgvDisciplines.Location = new System.Drawing.Point(3, 42);
			this.dgvDisciplines.Name = "dgvDisciplines";
			this.dgvDisciplines.Size = new System.Drawing.Size(610, 348);
			this.dgvDisciplines.TabIndex = 0;
			// 
			// tbTeahcers
			// 
			this.tbTeahcers.BackColor = System.Drawing.Color.Teal;
			this.tbTeahcers.Controls.Add(this.dgvTeachers);
			this.tbTeahcers.Location = new System.Drawing.Point(4, 22);
			this.tbTeahcers.Name = "tbTeahcers";
			this.tbTeahcers.Padding = new System.Windows.Forms.Padding(3);
			this.tbTeahcers.Size = new System.Drawing.Size(616, 393);
			this.tbTeahcers.TabIndex = 4;
			this.tbTeahcers.Text = "Teachers";
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTeachers.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.ContextMenuStrip = this.contextMenu;
			this.dgvTeachers.Location = new System.Drawing.Point(3, 42);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.Size = new System.Drawing.Size(610, 348);
			this.dgvTeachers.TabIndex = 0;
			// 
			// toolStripFilterCount
			// 
			this.toolStripFilterCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.toolStripFilterCount.Name = "toolStripFilterCount";
			this.toolStripFilterCount.Size = new System.Drawing.Size(118, 17);
			this.toolStripFilterCount.Text = "toolStripStatusLabel1";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Academy";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tpStudent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.contextMenu.ResumeLayout(false);
			this.tbGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.tpDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
			this.tpDisciplines.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
			this.tbTeahcers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tpStudent;
		private System.Windows.Forms.TabPage tbGroups;
		private System.Windows.Forms.TabPage tpDirections;
		private System.Windows.Forms.TabPage tpDisciplines;
		private System.Windows.Forms.TabPage tbTeahcers;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.DataGridView dgvDirections;
		private System.Windows.Forms.DataGridView dgvDisciplines;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ComboBox cbDirectionsStudents;
		private System.Windows.Forms.ComboBox cbStudentsGroups;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem cmRefreshTable;
		private System.Windows.Forms.ComboBox cbDirectionsGroups;
		private System.Windows.Forms.ToolStripMenuItem cmSeeAllDirctions;
		private System.Windows.Forms.ToolStripStatusLabel toolStripFilterCount;
	}
}


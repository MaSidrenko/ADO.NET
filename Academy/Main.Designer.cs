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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tpStudent = new System.Windows.Forms.TabPage();
			this.tbGroups = new System.Windows.Forms.TabPage();
			this.tpDirections = new System.Windows.Forms.TabPage();
			this.tpDisciplines = new System.Windows.Forms.TabPage();
			this.tbTeahcers = new System.Windows.Forms.TabPage();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.dgvDirections = new System.Windows.Forms.DataGridView();
			this.dgvDisciplines = new System.Windows.Forms.DataGridView();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tpStudent.SuspendLayout();
			this.tbGroups.SuspendLayout();
			this.tpDirections.SuspendLayout();
			this.tpDisciplines.SuspendLayout();
			this.tbTeahcers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 419);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(624, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
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
			// 
			// tpStudent
			// 
			this.tpStudent.BackColor = System.Drawing.Color.Transparent;
			this.tpStudent.Controls.Add(this.dgvStudents);
			this.tpStudent.Location = new System.Drawing.Point(4, 22);
			this.tpStudent.Name = "tpStudent";
			this.tpStudent.Padding = new System.Windows.Forms.Padding(3);
			this.tpStudent.Size = new System.Drawing.Size(616, 393);
			this.tpStudent.TabIndex = 0;
			this.tpStudent.Text = "Students";
			// 
			// tbGroups
			// 
			this.tbGroups.Controls.Add(this.dgvGroups);
			this.tbGroups.Location = new System.Drawing.Point(4, 22);
			this.tbGroups.Name = "tbGroups";
			this.tbGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tbGroups.Size = new System.Drawing.Size(616, 393);
			this.tbGroups.TabIndex = 1;
			this.tbGroups.Text = "Groups";
			this.tbGroups.UseVisualStyleBackColor = true;
			// 
			// tpDirections
			// 
			this.tpDirections.Controls.Add(this.dgvDirections);
			this.tpDirections.Location = new System.Drawing.Point(4, 22);
			this.tpDirections.Name = "tpDirections";
			this.tpDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tpDirections.Size = new System.Drawing.Size(616, 393);
			this.tpDirections.TabIndex = 2;
			this.tpDirections.Text = "Directions";
			this.tpDirections.UseVisualStyleBackColor = true;
			// 
			// tpDisciplines
			// 
			this.tpDisciplines.Controls.Add(this.dgvDisciplines);
			this.tpDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tpDisciplines.Name = "tpDisciplines";
			this.tpDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tpDisciplines.Size = new System.Drawing.Size(616, 393);
			this.tpDisciplines.TabIndex = 3;
			this.tpDisciplines.Text = "Disciplines";
			this.tpDisciplines.UseVisualStyleBackColor = true;
			// 
			// tbTeahcers
			// 
			this.tbTeahcers.Controls.Add(this.dgvTeachers);
			this.tbTeahcers.Location = new System.Drawing.Point(4, 22);
			this.tbTeahcers.Name = "tbTeahcers";
			this.tbTeahcers.Padding = new System.Windows.Forms.Padding(3);
			this.tbTeahcers.Size = new System.Drawing.Size(616, 393);
			this.tbTeahcers.TabIndex = 4;
			this.tbTeahcers.Text = "Teachers";
			this.tbTeahcers.UseVisualStyleBackColor = true;
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(3, 42);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(610, 348);
			this.dgvStudents.TabIndex = 0;
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(3, 42);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.Size = new System.Drawing.Size(610, 348);
			this.dgvGroups.TabIndex = 0;
			// 
			// dgvDirections
			// 
			this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirections.Location = new System.Drawing.Point(3, 42);
			this.dgvDirections.Name = "dgvDirections";
			this.dgvDirections.Size = new System.Drawing.Size(610, 348);
			this.dgvDirections.TabIndex = 0;
			// 
			// dgvDisciplines
			// 
			this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisciplines.Location = new System.Drawing.Point(3, 42);
			this.dgvDisciplines.Name = "dgvDisciplines";
			this.dgvDisciplines.Size = new System.Drawing.Size(610, 348);
			this.dgvDisciplines.TabIndex = 0;
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(3, 42);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.Size = new System.Drawing.Size(610, 348);
			this.dgvTeachers.TabIndex = 0;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			this.tbGroups.ResumeLayout(false);
			this.tpDirections.ResumeLayout(false);
			this.tpDisciplines.ResumeLayout(false);
			this.tbTeahcers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
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
	}
}


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
			this.tabControl.SuspendLayout();
			this.tpStudent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
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
			this.tbGroups.Location = new System.Drawing.Point(4, 22);
			this.tbGroups.Name = "tbGroups";
			this.tbGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tbGroups.Size = new System.Drawing.Size(688, 348);
			this.tbGroups.TabIndex = 1;
			this.tbGroups.Text = "Groups";
			this.tbGroups.UseVisualStyleBackColor = true;
			// 
			// tpDirections
			// 
			this.tpDirections.Location = new System.Drawing.Point(4, 22);
			this.tpDirections.Name = "tpDirections";
			this.tpDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tpDirections.Size = new System.Drawing.Size(688, 348);
			this.tpDirections.TabIndex = 2;
			this.tpDirections.Text = "Directions";
			this.tpDirections.UseVisualStyleBackColor = true;
			// 
			// tpDisciplines
			// 
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
			this.tbTeahcers.Location = new System.Drawing.Point(4, 22);
			this.tbTeahcers.Name = "tbTeahcers";
			this.tbTeahcers.Padding = new System.Windows.Forms.Padding(3);
			this.tbTeahcers.Size = new System.Drawing.Size(688, 348);
			this.tbTeahcers.TabIndex = 4;
			this.tbTeahcers.Text = "Teachers";
			this.tbTeahcers.UseVisualStyleBackColor = true;
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(3, 42);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(610, 348);
			this.dgvStudents.TabIndex = 0;
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
			this.tabControl.ResumeLayout(false);
			this.tpStudent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
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
	}
}


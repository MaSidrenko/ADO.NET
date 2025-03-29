using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class Main : Form
	{
		Connector connector;
		public Main()
		{
			connector = new Connector(ConfigurationManager.ConnectionStrings["PV_319_IMPORT"].ConnectionString);
			InitializeComponent();
			Filling();


		}
		public void Filling()
		{
			toolStripStatusLabel.Text = "Количество студентов: " + connector.Count("Students").ToString();

			dgvStudents.DataSource = connector.Select("FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS N'Студент', birth_date AS N'Дата Рождения', group_name AS N'Группа', direction_name AS N'Направление'", "Students, Groups, Directions", "[group]=group_id AND direction=direction_id");
			cmSeeAllDirctions.Visible = false;
			toolStripFilterCount.Text = "";

			//dgvGroups.DataSource = connector.Select("group_name AS N'Группа', direction_name AS N'Направление', start_time AS N'Время начала занятий'", "Groups, Directions", "direction=direction_id");
			//dgvDirections.DataSource = connector.Select("direction_name AS N'Направление'", "Directions");
			//dgvDisciplines.DataSource = connector.Select("discipline_name AS N'Название дисциплины', number_of_lessons AS N'Количество занятий'", "Disciplines");
			//dgvTeachers.DataSource = connector.Select("FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS 'Преподователь', birth_date AS N'Дата рождения', work_since AS N'Опыт работы', rate AS N'Ставка'", "Teachers");
			//Console.WriteLine(dgvDirections.Columns[0]);

		}

		public void RefreshTable(bool isNeedResetCB = false)
		{
			switch (tabControl.SelectedIndex)
			{
				case 0:
					{
						dgvStudents.DataSource = connector.Select("FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS N'Студент', birth_date AS N'Дата Рождения', group_name AS N'Группа', direction_name AS N'Направление'", "Students, Groups, Directions", "[group]=group_id AND direction=direction_id");
						toolStripStatusLabel.Text = "Количество студентов: " + connector.Count("Students");
						if (isNeedResetCB)
						{
							cbDirectionsStudents.Text = "";
							cbStudentsGroups.Text = "";
							cbStudentsGroups.Items.Clear();
						}
						cmSeeAllDirctions.Visible = false;
						toolStripFilterCount.Text = "";
					}
					break;
				case 1:
					{
						toolStripStatusLabel.Text = "Количество групп: " + connector.Count("Groups");
						dgvGroups.DataSource = connector.Select("group_name AS N'Группа', direction_name AS N'Направление', dbo.GetLearningDays(group_name) AS N'Дни недели', start_time AS N'Время начала занятий'", "Groups, Directions", "direction=direction_id");
						if (isNeedResetCB)
						{
							cbDirectionsGroups.Text = "";
						}
						cmSeeAllDirctions.Visible = false;
						toolStripFilterCount.Text = "";
					}
					break;
				case 2:
					toolStripStatusLabel.Text = "Количество всех направлений: " + connector.Count("Directions");
					cmSeeAllDirctions.Visible = true;
					if (!cmSeeAllDirctions.Checked)
					{
						dgvDirections.DataSource = connector.Select
																	(
																		"direction_name AS N'Направление', COUNT(DISTINCT group_id) AS N'Количество групп', COUNT(stud_id) AS N'Количество студентов'",
																		"Directions, Groups LEFT JOIN Students ON [group]=group_id",
																		"direction=direction_id GROUP BY direction_name"
																	);
						toolStripFilterCount.Visible = true;
						toolStripFilterCount.Text = "Количество направлений с группами: " + (dgvDirections.Rows.Count - 1);
					}
					break;
				case 3:
					toolStripStatusLabel.Text = "Количество дисциплин: " + connector.Count("Disciplines");
					dgvDisciplines.DataSource = connector.Select("discipline_name AS N'Название дисциплины', number_of_lessons AS N'Количество занятий'", "Disciplines");
					cmSeeAllDirctions.Visible = false;
					toolStripFilterCount.Text = "";
					break;
				case 4:
					toolStripStatusLabel.Text = "Количество преподователей: " + connector.Count("Teachers");
					dgvTeachers.DataSource = connector.Select("FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS 'Преподователь', birth_date AS N'Дата рождения', work_since AS N'Опыт работы', rate AS N'Ставка'", "Teachers");
					cmSeeAllDirctions.Visible = false;
					toolStripFilterCount.Text = "";
					break;
			}
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshTable();
		}

		private void cbDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbStudentsGroups.Items.Clear();
			if (cbDirectionsStudents.SelectedIndex != -1)
			{
				dgvStudents.DataSource = connector.Select(
					"FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS N'Студент', birth_date AS N'Дата Рождения', group_name AS N'Группа', direction_name AS N'Направление'",
					"Students, Groups, Directions",
					$"[group]=group_id AND direction=direction_id AND direction_name=N'{cbDirectionsStudents.SelectedItem}'");
				for (int i = 0; i < dgvStudents.RowCount - 1; i++)
				{
					if (cbStudentsGroups.Items.Contains(dgvStudents.Rows[i].Cells["Группа"].Value))
					{
						continue;
					}
					cbStudentsGroups.Items.Add(dgvStudents.Rows[i].Cells["Группа"].Value.ToString());
				}
			}
		}

		private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbStudentsGroups.SelectedIndex != -1)
			{
				dgvStudents.DataSource = connector.Select(
				"FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS N'Студент', birth_date AS N'Дата Рождения', group_name AS N'Группа', direction_name AS N'Направление'",
				"Students, Groups, Directions",
				$"[group]=group_id AND direction=direction_id AND direction_name=N'{cbDirectionsStudents.SelectedItem}' AND group_name=N'{cbStudentsGroups.SelectedItem}'");
			}
			if (cbStudentsGroups.SelectedIndex == -1)
			{
				cbStudentsGroups.Items.Clear();
			}
		}

		private void tabControl_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button.HasFlag(MouseButtons.Right))
			{
				contextMenu.Show(Cursor.Position);
			}
		}

		private void cmRefreshTable_Click(object sender, EventArgs e)
		{
			RefreshTable(true);
		}


		private void cbDirectionsStudents_DropDown(object sender, EventArgs e)
		{

			if (dgvDirections.Rows.Count == 0 || cbDirectionsStudents.Items.Count == 0)
			{

				this.SuspendLayout();
				tabControl.Hide();

				tabControl.SelectTab("tpDirections");
				for (int i = 0; i < dgvDirections.RowCount - 1; i++)
				{
					cbDirectionsStudents.Items.Add(dgvDirections.Rows[i].Cells[0].Value.ToString());
				}
				tabControl.SelectTab("tpStudent");
				tabControl.Show();
				this.ResumeLayout();
			}
		}

		private void cbDirectionsGroups_DropDown(object sender, EventArgs e)
		{
			if (dgvDirections.Rows.Count == 0 || cbDirectionsGroups.Items.Count == 0)
			{
				this.SuspendLayout();
				tabControl.Hide();

				tabControl.SelectTab("tpDirections");
				for (int i = 0; i < dgvDirections.Rows.Count - 1; i++)
				{
					cbDirectionsGroups.Items.Add(dgvDirections.Rows[i].Cells[0].Value.ToString());
				}
				tabControl.SelectTab("tbGroups");
				tabControl.Show();
				this.ResumeLayout();
			}
		}

		private void cbDirectionsGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbDirectionsGroups.SelectedIndex != -1)
			{
				dgvGroups.DataSource = connector.Select
					(
					"group_name AS N'Группа', direction_name AS N'Направление', start_time AS N'Время начала занятий'", "Groups, Directions", $"direction=direction_id AND direction_name=N'{cbDirectionsGroups.SelectedItem}'"
					);
			}
		}

		private void cmSeeAllDirctions_Click(object sender, EventArgs e)
		{
			cmSeeAllDirctions.Checked = cmSeeAllDirctions.Checked ? false : true;
		}

		private void cmSeeAllDirctions_CheckedChanged(object sender, EventArgs e)
		{
			cbDirectionsGroups.Items.Clear();
			cbDirectionsStudents.Items.Clear();
			if (cmSeeAllDirctions.Checked)
			{
				toolStripFilterCount.Text = "";
				dgvDirections.DataSource = connector.Select("direction_name AS N'Направление'", "Directions");
			}
			if (!cmSeeAllDirctions.Checked)
			{
				RefreshTable();
			}
		}
	}
}
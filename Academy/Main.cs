using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			
			dgvStudents.DataSource = connector.Select("FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS N'Студент', birth_date AS N'Дата Рождения', group_name AS N'Группа'", "Students, Groups", "[group]=group_id");
			
			dgvGroups.DataSource = connector.Select("group_name AS N'Группа', direction_name AS N'Направление', start_time AS N'Время начала занятий'", "Groups, Directions", "direction=direction_id");
			
			dgvDirections.DataSource = connector.Select("direction_name AS N'Направление'", "Directions");
			
			dgvDisciplines.DataSource = connector.Select("discipline_name AS N'Название дисциплины', number_of_lessons AS N'Количество занятий'", "Disciplines");
			
			dgvTeachers.DataSource = connector.Select("FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS 'Преподователь', birth_date AS N'Дата рождения', work_since AS N'Опыт работы', rate AS N'Ставка'", "Teachers");
			
			//dgvStudents.DataSource = connector.Select("*", "Students");
			//dgvGroups.DataSource = connector.Select("*", "Groups");
			//dgvDirections.DataSource = connector.Select("*", "Directions");
			//dgvDisciplines.DataSource = connector.Select("*", "Disciplines");
			//dgvTeachers.DataSource = connector.Select("*", "Teachers");
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((sender as TabControl).SelectedIndex)
			{
				case 0:
					toolStripStatusLabel.Text = "Количество студентов: " + connector.Count("Students");
					break;
				case 1:
					toolStripStatusLabel.Text = "Количество групп: " + connector.Count("Groups");
					break;
				case 2:
					toolStripStatusLabel.Text = "Количество направлений: " + connector.Count("Directions");
					break;
				case 3:
					toolStripStatusLabel.Text = "Количество дисциплин: " + connector.Count("Disciplines");
					break;
				case 4:
					toolStripStatusLabel.Text = "Количество преподователей: " + connector.Count("Teachers");
					break;
			}
		}
	}
}

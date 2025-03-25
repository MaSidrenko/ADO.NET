using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace ExternalBase
{
	static internal class Connector
	{
		static readonly int PADDING = 30;
		static readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["PV_319_IMPORT"].ConnectionString;
		static SqlConnection connection;
		static Connector()
		{
			Console.WriteLine(CONNECTION_STRING);
			connection = new SqlConnection(CONNECTION_STRING);
		}
		public static void Selcet(string fields, string tables, string condition = "")
		{
			try
			{
				string cmd = $"SELECT {fields} FROM {tables}";
				if (condition != "")
					cmd += $" WHERE {condition}";
				cmd += ";";
				SqlCommand command = new SqlCommand(cmd, connection);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					Console.WriteLine("=======================================================================================================================");
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetName(i).PadRight(PADDING));
					}
					Console.WriteLine();
					Console.WriteLine("=======================================================================================================================");
				}
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(PADDING));
					}
					Console.WriteLine();
				}

				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		public static int GetIdDiscipline(string discipline_name)
		{
			int id_discipline = 0;
			try
			{
				string cmd = $"SELECT discipline_id FROM Disciplines WHERE discipline_name LIKE N'%{discipline_name}%'";
				connection.Open();
				SqlCommand command = new SqlCommand(cmd, connection);
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					id_discipline = (Int16)reader["discipline_id"];
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return id_discipline;
		}
		public static int GetIdTeacher(string last_name)
		{
			int id_teacher = 0;
			try
			{
				string cmd = $"SELECT teacher_id FROM Teachers WHERE last_name LIKE N'%{last_name}%'";
				connection.Open();

				SqlCommand command = new SqlCommand(cmd, connection);
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					id_teacher = (Int16)reader["teacher_id"];
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return id_teacher;
		}
		public static int CountStudents()
		{
			int count = 0;
			try
			{
				//string cmd = "SELECT * FROM Students";
				string cmd = "SELECT stud_id FROM Students";
				connection.Open();
				SqlCommand command = new SqlCommand(cmd, connection);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					count++;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return count;
		}
	}
}

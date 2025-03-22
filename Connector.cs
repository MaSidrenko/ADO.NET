using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
	static internal class Connector
	{
		const int PADDING = 30;
		const string CONNECTION_STRING =
					"Data Source=(localdb)\\MSSQLLocalDB;" +
					"Initial Catalog=Movies;Integrated Security=True;" +
					"Connect Timeout=30;Encrypt=False;" +
					"TrustServerCertificate=False;" +
					"ApplicationIntent=ReadWrite;" +
					"MultiSubnetFailover=False";
		static readonly SqlConnection connection = new SqlConnection(CONNECTION_STRING);
		static Connector()
		{
			connection = new SqlConnection(CONNECTION_STRING);
		}

		public static void SelectDirectors()
		{
			ReadData("SELECT * FROM Directors");
		}
		public static void SelectMovies()
		{
			ReadData("SELECT title, release_date, FORMATMESSAGE(N'%s %s', first_name, last_name) AS director FROM Movies, Directors WHERE director = director_id");
		}
		public static void InsertDirectors(string first_name, string last_name)
		{
			if (isExists("Directors", $"last_name = N'{last_name}' AND first_name = N'{first_name}'"))
			{
				return;
			}
			ChangeData($"INSERT Directors(last_name, first_name) VALUES(N'{last_name}', N'{first_name}')");
		}
		public static void InsertMovies(string title, DateTime date, string last_name, string first_name)
		{
			int directors = GetDirectorID(last_name, first_name);
			if(isExists("Movies", $"title = N'{title}'"))
			{
				return;
			}
			ChangeData($"INSERT Movies(title, release_date, director) VALUES(N'{title}', N'{date.ToString("yyyy-MM-dd")}', {directors})");
		}
		public static void ReadData(string cmd)
		{
			try
			{
				SqlCommand command = new SqlCommand(cmd, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					Console.WriteLine("====================================================================");
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetName(i).PadRight(PADDING));
					}
					Console.WriteLine();
					Console.WriteLine("====================================================================");
					while (reader.Read())
					{
						for (int i = 0; i < reader.FieldCount; i++)
						{
							Console.Write(reader[i].ToString().PadRight(PADDING));
						}
						Console.WriteLine();
					}
				}
				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		static public void ChangeData(string cmd)
		{
			try
			{
				SqlCommand command = new SqlCommand(cmd, connection);
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		public static int GetDirectorID(string last_name, string first_name)
		{
			int director = 0;
			try
			{
				string cmd = $"SELECT director_id FROM Directors WHERE last_name = '{last_name}' AND first_name = '{first_name}'";
				SqlCommand command = new SqlCommand(cmd, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					director = (Int16)reader["director_id"];
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return director;
		}
		public static bool isExists(string table, string condition)
		{
			bool exists = false;
			try
			{
				string cmd = $"SELECT CASE WHEN EXISTS (SELECT * FROM {table} WHERE {condition}) THEN 1 ELSE 0 END";
				SqlCommand command = new SqlCommand(cmd, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					exists = true;
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return exists;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
			//Статический конструктор нужен только для инициализации статических полей класса
		}
		public static void SelectDirectors()
		{
			Select("*", "Directors");
		}
		public static void SelectMovies()
		{
			Select("title, release_date, FORMATMESSAGE(N'%s %s', first_name, last_name)", "Movies, Directors", "director=director_id");
		}
		static void Select(string columns, string tables, string condition = "")
		{

			try
			{
				string cmd = $"SELECT {columns} FROM {tables}";
				if (condition != "") cmd += $" WHERE {condition}";
				cmd += ";";
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
		public static void InsertDirector(string first_name, string last_name)
		{
			#region OldInsert
			//try
			//{
			//	string cmd = $"INSERT Directors(first_name, last_name) VALUES('{first_name}', '{last_name}')";

			//	SqlCommand command = new SqlCommand(cmd, connection);
			//	connection.Open();
			//	command.ExecuteNonQuery();

			//	connection.Close();
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//} 
			#endregion

			Insert("Directors", "first_name, last_name", $"N'{first_name}', N'{last_name}'");
		}
		public static void InsertMovie(string title, string release_date, string director)
		{
			Insert("Movies", "title, release_date, director", $"N'{title}', N'{release_date}', N'{director}'");
		}
		static void Insert(string table, string columns, string values, string key = "")
		{
			try
			{

				if (key == "")
				{
					key = table.ToLower();

					key = key.Remove(key.Length - 1, 1) + "_id";
				}
				Console.WriteLine(key);
				string[] all_values = values.Split(',');
				string[] all_columns = columns.Split(',');
				string condition = "";
				for (int i = 0; i < all_columns.Length; i++)
				{
					condition += $"{all_columns[i]}={all_values[i]}";
					if (i != all_columns.Length - 1) condition += " AND ";
					Console.WriteLine(condition);
				}
				string check_string = $"IF NOT EXISTS (SELECT {key} FROM {table} WHERE {condition})";

				string query = $"INSERT {table} ({columns}) VALUES({values})";
				string cmd = $"{check_string} BEGIN {query} END";

				Console.WriteLine(cmd);
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
	}

}
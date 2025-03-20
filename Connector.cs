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
		public static void Select(string columns, string tables, string condition = "")
		{

			try
			{
				//string cmd = "SELECT title,release_date,FORMATMESSAGE(N'%s %s', first_name, last_name) AS director FROM Movies, Directors WHERE director=director_id";
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
						//Console.WriteLine(reader[0].ToString().PadRight(5) + reader[2].ToString().PadRight(15) + reader[1].ToString());
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
			try
			{
				string cmd = $"INSERT Directors(first_name, last_name) VALUES('{first_name}', '{last_name}')";

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
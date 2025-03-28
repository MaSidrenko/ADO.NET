﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Management;
using System.Data.SqlClient;

namespace ADO.NET
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int PADDING = 30;
			try
			{
				//const string CONNECTION_STRING = 
				//	"Data Source=(localdb)\\MSSQLLocalDB;" +
				//	"Initial Catalog=Movies;Integrated Security=True;" +
				//	"Connect Timeout=30;Encrypt=False;" +
				//	"TrustServerCertificate=False;" +
				//	"ApplicationIntent=ReadWrite;" +
				//	"MultiSubnetFailover=False";
				/*static readonly*/
				string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["Movies"].ConnectionString;
				Console.WriteLine(CONNECTION_STRING);
				SqlConnection connection = new SqlConnection(CONNECTION_STRING);

				string cmd = "SELECT title,release_date,FORMATMESSAGE(N'%s %s', first_name, last_name) AS director FROM Movies, Directors WHERE director=director_id";
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
				connection.Dispose();
				connection.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}


		}
	}
}

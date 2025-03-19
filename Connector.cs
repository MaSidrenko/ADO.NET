using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
	internal class Connector
	{
		private const int PADDING = 30;
		private const string CONNECTION_STRING =
					"Data Source=(localdb)\\MSSQLLocalDB;" +
					"Initial Catalog=Movies;Integrated Security=True;" +
					"Connect Timeout=30;Encrypt=False;" +
					"TrustServerCertificate=False;" +
					"ApplicationIntent=ReadWrite;" +
					"MultiSubnetFailover=False";
		public SqlConnection connection { get; set; }
		public SqlCommand command { get; set; }
		public Connector(string cmd)
		{
			connection = new SqlConnection(CONNECTION_STRING);
			command = new SqlCommand(cmd, connection);
		}
		public void ReadData()
		{
			try
			{
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
	}
}

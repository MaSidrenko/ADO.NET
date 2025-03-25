//#define OLD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Academy
{
	internal class Connector
	{
		readonly string CONNECTION_STRING; //= ConfigurationManager.ConnectionStrings["PV_319_IMPORT"].ConnectionString;
		SqlConnection connection;

		public Connector(string connections_string)
		{
			//CONNECTION_STRING = ConfigurationManager.ConnectionStrings["PV_319_IMPORT"].ConnectionString/*connections_string*/;
			CONNECTION_STRING = connections_string;
			connection = new SqlConnection(CONNECTION_STRING);
			AllocConsole();
			Console.WriteLine(CONNECTION_STRING);
		}
		~Connector()
		{
			FreeConsole();
		}
		public DataTable Select(string columns, string tables, string condition = "")
		{
			DataTable dataTable = null; /*new DataTable();*/
			try
			{
				string cmd = $"SELECT {columns} FROM {tables}";
				if (condition != "") cmd += $" WHERE {condition}";
				cmd += ";";
				connection.Open();
				SqlCommand command = new SqlCommand(cmd, connection);
				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					dataTable = new DataTable();
					dataTable.Load(reader);
#if OLD
					//dataTable = new DataTable();
					//for (int i = 0; i < reader.FieldCount; i++)
					//{
					//	dataTable.Columns.Add();
					//}
					//while (reader.Read())
					//{
					//	DataRow row = dataTable.NewRow();
					//	for (int i = 0; i < reader.FieldCount; i++)
					//	{
					//		row[i] = reader[i];
					//	}
					//	dataTable.Rows.Add(row);
					//}  
#endif
				}

				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				AllocConsole();
				Console.WriteLine(ex.Message);
			}
			return dataTable;
		}
		[DllImport("Kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("Kernel32.dll")]
		public static extern bool FreeConsole();
	}
}

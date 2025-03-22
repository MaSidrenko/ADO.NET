using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace ADO.NET
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Connector.InsertDirectors("Wachowskis", "Lana and Lily");

			Connector.InsertMovies("The Matrix 2", new DateTime(year: 2003, month: 5, day: 15), "Wachowskis", "Lana and Lily");
			Connector.SelectDirectors();
			Connector.SelectMovies();
		
		
		}
	}
}

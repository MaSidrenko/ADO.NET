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
			//string cmd = "SELECT title,release_date,FORMATMESSAGE(N'%s %s', first_name, last_name) AS director FROM Movies, Directors WHERE director=director_id";
			//Connector.Select("*", "Directors");
			//Connector.Select("title, release_date, FORMATMESSAGE(N'%s %s', first_name, last_name)", "Movies, Directors", "director=director_id");
			Connector.InsertDirector("George", "Martin");
			Connector.SelectDirectors();
			Connector.SelectMovies();
		
		
		}
	}
}

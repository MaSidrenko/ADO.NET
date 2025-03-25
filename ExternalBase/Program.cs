using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalBase
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Connector.Selcet("*", "Disciplines");
			int id_disc = Connector.GetIdDiscipline("Процедурное программирование");
			Console.WriteLine(id_disc);
			int id_teacher = Connector.GetIdTeacher("Ковтун");
			Console.WriteLine(id_teacher);
			Console.WriteLine(Connector.CountStudents());
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime date = new DateTime(2023, 09, 13);
			DateTime dateHour = new DateTime(2023, 09, 13, 21, 29, 10);

			//Acessando os dados individualmente
			Console.WriteLine("Year: " + dateHour.Year);
			Console.WriteLine("Month: " + dateHour.Month);
			Console.WriteLine("Day: " + dateHour.Day);
			Console.WriteLine("Hour: " + dateHour.Hour);
			Console.WriteLine("Minute: " + dateHour.Minute);
			Console.WriteLine("Second: " + dateHour.Second);
			Console.WriteLine("Day of week: " + dateHour.DayOfWeek);
			Console.WriteLine("--------------------");
			Console.WriteLine(date.ToString());
			Console.WriteLine(dateHour.ToString());
			Console.WriteLine("--------------------");

			//Current date and time
			DateTime dateHourNow = DateTime.Now;
			Console.WriteLine(dateHourNow.ToString());
			Console.WriteLine("--------------------");

			//Convert a string to datetime
			DateTime dateConverted =  Convert.ToDateTime("13/09/2023");
			DateTime dateHourConverted = Convert.ToDateTime("13/09/2023 10:27:41");
			Console.WriteLine(dateConverted.ToString());
			Console.WriteLine(dateHourConverted.ToString());
			Console.WriteLine("--------------------");

			//Formating the output
			Console.WriteLine(dateHourConverted.ToString("yyyy/MM"));
			Console.WriteLine(dateHourConverted.ToString("yyyy/MM/dd"));
			Console.WriteLine(dateHourConverted.ToString("yyyy-MM-dd"));
			Console.WriteLine(dateHourConverted.ToString("HH:mm:ss"));
			Console.WriteLine("--------------------");

			//Operations with datetime format
			DateTime dateHour2 = new DateTime(2023, 09, 27, 15, 12, 09);
			dateHour2 = dateHour2.AddDays(4);
			Console.WriteLine(dateHour2.ToString("dd/MM/yyyy"));
			/*dateHour2 = dateHour2.AddYears(4);
			dateHour2 = dateHour2.AddMonths(4);*/

			/*dateHour2 = dateHour2.Add(new TimeSpan(1, 55 ,30));
			Console.WriteLine(dateHour2.ToString("HH:mm:ss"));*/

			dateHour2 = dateHour2.Add(new TimeSpan(4, 1, 55, 30));
			Console.WriteLine(dateHour2.ToString("dd HH:mm:ss"));
			Console.WriteLine("--------------------");


			//Subtracting dates
			DateTime dateHour3 = new DateTime(2023, 3, 1, 14, 5, 20);
			dateHour3 = dateHour3.Subtract(new TimeSpan(1, 5, 20));
			Console.WriteLine(dateHour3.ToString("HH:mm:ss"));

			dateHour3 = dateHour3.AddDays(-1);
			Console.WriteLine(dateHour3.ToString("dd/MM/yyyy"));


			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}
	}
}

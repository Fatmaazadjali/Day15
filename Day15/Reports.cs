using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
	internal class Reports
	{



		//Genric
	


		public delegate bool TotalSales(Employee e);
		 public void TotalSalesAll(Employee[] emp, string title, TotalSales con)
		{
            Console.WriteLine(title);
			foreach (Employee e in emp)
			{
				if (con(e))
				{
					Console.WriteLine($"{e.Id} | {e.name} | {e.gender} | {e.totalSalery}");
				}
			   
			}
            Console.WriteLine("\n \n");
        }






		#region single function
		public void TotalSalesMoreThan60(Employee[] emp)
		{
			Console.WriteLine("Report for employee that there salarey equal 6k and above:");
			foreach (Employee e in emp)
			{
				if (e.totalSalery >= 60000m)
					Console.WriteLine($"{e.Id} | {e.name}, {e.gender} | {e.totalSalery}");
			}
		}

		public void TotalSalesbetween(Employee[] emp)
		{
			Console.WriteLine("Report for employee that there salarey is between 30000, 60000:");
			foreach (Employee e in emp)
			{
				if (3000m <= e.totalSalery && e.totalSalery <= 59999m)
					Console.WriteLine($"{e.Id} | {e.name}, {e.gender} | {e.totalSalery}");
			}
		}
		#endregion

	}
}

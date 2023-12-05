namespace Day15
{
	internal class Program
	{
		//Genric

		public static void print<T>(T val)
		{
			Console.WriteLine(typeof(T));
			Console.WriteLine(val);
		}
		static void Main(string[] args)
		{

			// print Genric
			print(1);
			print("fa");
			print(true); print(false);
			Employee[] emps = new Employee[]
		{
			new Employee { Id = 1, name= "Fatma", gender= 'F', totalSalery = 80000m},
			new Employee { Id = 2, name = "Moh", gender= 'M', totalSalery = 30000m},
			new Employee { Id = 3, name= "Ra", gender='F', totalSalery= 50000m}
		};

			Reports reports = new Reports();
			reports.TotalSalesAll(emps, "Total abouve or equal 60000", (emp) => emp.totalSalery >= 60000m);
			reports.TotalSalesAll(emps, "the Total is between 30000 and 60000", (emp) => 30000m >= emp.totalSalery && emp.totalSalery <= 59999m);

			#region Single function
			reports.TotalSalesMoreThan60(emps);
			reports.TotalSalesbetween(emps);
			#endregion

		}
	}



}
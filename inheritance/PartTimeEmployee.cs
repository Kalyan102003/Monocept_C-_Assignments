using System;
namespace _13_march_Tasks_inheritance
{
	public class PartTimeEmployee : Employee
	{
		public int NumOfHours { get; set; }
		public int RatePerHour { get; set; }

		public PartTimeEmployee(string name, int id, int salary, int numofhours, int rateperhour)
			: base(name, id, salary)
		{
			NumOfHours = numofhours;
			RatePerHour = rateperhour;
		}

		public override void DisplayEmployeeDetails()
		{
			Salary = NumOfHours * RatePerHour;

			Console.WriteLine($"Employee Name: {Name}");
			Console.WriteLine($"Employee Id: {Id}");
			Console.WriteLine($"Employee Salary: {Salary}");

		}
	}
}
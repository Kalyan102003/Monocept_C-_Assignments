using System;
using System.Collections.Generic;
using System.Text;

namespace March24_Assignments_EmployeeAbstraction_lists_set_dictonary
{
    public class Manager : Employee
    {

        public double TravelAllowence;
        public double DutyAllowence;
        public double TotalSalary;
        public double Totalctc;
        public double BaseSalary { get; set; }
        public Manager(string name, int id, int baseSalary) : base(name, id, baseSalary)
        {
            BaseSalary = baseSalary;
            TravelAllowence = BaseSalary * 0.45;
            DutyAllowence = BaseSalary * 0.5;


        }

        public override double Polymorphic()
        {
          
            TravelAllowence = TravelAllowence * 0.5;
            DutyAllowence = DutyAllowence * .04;
            TotalSalary = TravelAllowence + DutyAllowence + BaseSalary;
            Totalctc = TotalSalary * 12;
            Console.WriteLine("Name of Employee : "+EmployeeName);
            Console.WriteLine("Id of Employee : " + EmployeeId);
            Console.WriteLine("Role : Manager");
            Console.WriteLine("Total Monthly salary : " + Math.Floor(TotalSalary));

            Console.WriteLine("Total Anual CTC : " +Math.Floor(Totalctc));
            return Totalctc;
        }
    }
}

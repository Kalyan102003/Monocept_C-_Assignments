using System;
using System.Collections.Generic;
using System.Text;

namespace March24_Assignments_EmployeeAbstraction_lists_set_dictonary
{
    public class Tester : Employee
    {
        public double Perks;
        public double TotalSalary;
        public double Totalctc;
        public string Hello;
        public double BaseSalary { get; set; }
        public Tester(string name, int id, int baseSalary) : base(name, id, baseSalary)
        {
            BaseSalary = baseSalary;
            Perks = BaseSalary * .045;
        }
        public override double Polymorphic()
        {
            Perks = BaseSalary * 0.45;
            TotalSalary = Perks + BaseSalary;
            Totalctc = TotalSalary * 12;
            Console.WriteLine("Name of Employee : " + EmployeeName);
            Console.WriteLine("Id of Employee : " + EmployeeId);
            Console.WriteLine("Role : Tester");
            Console.WriteLine("Total Monthly salary : " + Math.Floor(TotalSalary));
            Console.WriteLine("Total Anual CTC : " + Math.Floor(Totalctc));
            return Totalctc;

        }
    }

    public static class check
    {
        public static void Checked(this double Totalctc)
        {
            if(Totalctc > 800000)
            {
                Console.WriteLine("Senior Tester");
            }
        }
    }
}

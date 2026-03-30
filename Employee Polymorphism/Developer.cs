using System;
using System.Collections.Generic;
using System.Text;

namespace March24_Assignments_EmployeeAbstraction_lists_set_dictonary
{
    public class Developer : Employee
    {
        public double PersonalAllowence { get; set; }
        public double TotalSalary { get; set; }
        public double Totalctc { get; set; }
        public double BaseSalary { get; set; }
        public Developer(string name, int id, int baseSalary) : base(name, id, baseSalary)
        {
            BaseSalary = baseSalary;
            PersonalAllowence = BaseSalary * 0.5;
        }

        public override double Polymorphic()
        {
            PersonalAllowence = PersonalAllowence * 0.5;
            TotalSalary = PersonalAllowence + BaseSalary;
            Totalctc = TotalSalary * 12;
            Console.WriteLine("Name of Employee : " + EmployeeName);
            Console.WriteLine("Id of Employee : " + EmployeeId);
            Console.WriteLine("Role : Developer");
            Console.WriteLine("Total Monthly salary : " + Math.Floor(TotalSalary));

            Console.WriteLine("Total Anual CTC : " + Math.Floor(Totalctc));
            return Totalctc;


        }

    }
}

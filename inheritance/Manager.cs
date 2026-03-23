using System;
using System.Collections.Generic;
using System.Text;

namespace _13_march_Tasks_inheritance
{
    public class Manager:FullEmployeeDeatils

    {

        public int Bonous { get; set; }
        public string Department { get; set; }
        public Manager(string name, int id, int salary, int leaves,int bonous,string department) : base(name, id, salary, leaves)
        {
            Bonous = bonous;
            Department = department;
            Salary = bonous + salary;
        }
         public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine($" The Bonous is {Bonous}");
            Console.WriteLine($" The Department is {Department}");

        }

    }
}

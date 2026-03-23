using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _13_march_Tasks_inheritance
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }

        //public Employee() 
        //{

        //    Console.WriteLine("Enter Employee Name :");
        //    Name = Console.ReadLine();


        //    Console.WriteLine("Enter Employee Id :");
        //    Id = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter Employee Salary :");
        //    Salary = int.Parse(Console.ReadLine());


        //}


        public Employee(string name, int id, int salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Salary: {Salary}");
        }
    }
}

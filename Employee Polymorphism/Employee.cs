using System;
using System.Collections.Generic;
using System.Text;

namespace March24_Assignments_EmployeeAbstraction_lists_set_dictonary
{
    public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public int BasicSalary { get; set; }
        public Employee(string name, int id, int baseSalary)
        {

            EmployeeName = name;
            EmployeeId = id;
            BasicSalary = baseSalary;

        }
        public abstract double Polymorphic();

    }
}

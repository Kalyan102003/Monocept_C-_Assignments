using System;
using System.Collections.Generic;
using System.Text;

namespace _13_march_Tasks_inheritance
{
    public class FullEmployeeDeatils: Employee
    {

        int Leaves { get; set; }
        
        public FullEmployeeDeatils(string name, int id, int salary,int leaves): base(name, id, salary)  
        {
      
            Leaves = leaves;

            if (Leaves > 20) {
                Console.WriteLine("Employee Leaves Should not be greater than 20:");
                return;
            }
        }




        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine($"Employee Leaves: {Leaves}");
        }
    }
}

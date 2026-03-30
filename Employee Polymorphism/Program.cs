using System.Text.RegularExpressions;

namespace March24_Assignments_EmployeeAbstraction_lists_set_dictonary
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Employee E;
            //using list to store Employee details
            List<Employee> ev = new List<Employee>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter 1.Tester 2.Developer 3.Manager");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Name : ");
                string Name = Console.ReadLine();

                //using Regular Expressions
                bool nameinput = Regex.IsMatch(Name, @"^[a-zA-Z]+$");

                while (!nameinput)
                {
                    Console.WriteLine("Invalid only Alphabets Allowed \n Please Enter Name Again : ");
                    Name = Console.ReadLine();
                    nameinput = Regex.IsMatch(Name, @"^[a-zA-Z]+$");
                }

                Console.WriteLine("ID : ");
                string id = Console.ReadLine();
                bool IDinput = Regex.IsMatch(id, @"^\d{4}$");

                while (!IDinput)
                {
                    Console.WriteLine("Invalid only 4 digits allowed \n Please Enter ID Again : ");
                    id = Console.ReadLine();
                    IDinput = Regex.IsMatch(id, @"^\d{4}$");
                }

                int finalid = int.Parse(id);

                Console.WriteLine("Base Salary : ");
                string salary = Console.ReadLine();
                bool Salaryinput = Regex.IsMatch(salary, @"^\d+$");

                while (!Salaryinput)
                {
                    Console.WriteLine("Invalid salary \n Please Enter Again : ");
                    salary = Console.ReadLine();
                    Salaryinput = Regex.IsMatch(salary, @"^\d+$");
                }

                int finalSalary = int.Parse(salary);

                if (input == 1)
                {
                    E = new Tester(Name, finalid, finalSalary);
                    ev.Add(E);
                }
                else if (input == 2)
                {
                    E = new Developer(Name, finalid, finalSalary);
                    ev.Add(E);
                }
                else if (input == 3)
                {
                    E = new Manager(Name, finalid, finalSalary);
                    ev.Add(E);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }

            foreach (Employee emp in ev)
            {
                Console.WriteLine(" ");
                
                double ctc = emp.Polymorphic();
                ctc.Checked();
            }
        }
    }
}
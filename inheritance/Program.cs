using _13_march_Tasks_inheritance;
using System.Xml.Linq;

public class Program
{

   
    static void UserGenerateEmployee(Employee[] employees) {
        int userInput;
        Console.WriteLine("Enter 1 for PartTimeEmployee and 2 for FullTimeEmployee");
        userInput = int.Parse(Console.ReadLine());
        for (int i = 0; i < employees.Length; i++) {
            if (userInput == 1)
            {
                Console.WriteLine("Enter Details for PartTimeEmployee");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Name");
                string NAME = Console.ReadLine();

                Console.WriteLine("ID");
                int ID = int.Parse(Console.ReadLine());
                
                int SALARY = 0;
                Console.WriteLine("Hours worked");
                int HOURSWORKED = int.Parse(Console.ReadLine());
                Console.WriteLine("Hourly Pay");
                int HOURLYRATE = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");

                employees[i] = new PartTimeEmployee(NAME, ID, SALARY, HOURSWORKED, HOURLYRATE);

            }
            else if (userInput == 2) {


                Console.WriteLine("Enter Details for FullEmployee");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Name");
                string NAME = Console.ReadLine();
                Console.WriteLine("ID");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("salary:");

                int SALARY = int.Parse(Console.ReadLine());
                Console.WriteLine("NO OF LEAVES :");

                int LEAVES = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");


                employees[i] = new FullEmployeeDeatils(NAME, ID, SALARY, LEAVES);

            }
            else { Console.WriteLine("Invalid Choice"); 
            }

        
        }

        for(int i=0;i<employees.Length; i++) {
            employees[i].DisplayEmployeeDetails();
        }
                
    }





    public static void Main(string[] args)


    {


        //Employee[] employees = new Employee[2];

        //UserGenerateEmployee(employees);

        // Shape S = new Shape();

        //Console.WriteLine(S.getArea());

        //Rectangle R = new Rectangle(10,20);

        //Console.WriteLine(R.getArea());


        //Employee E = new Employee();
        //E.DisplayEmployeeDetails();
        //FullEmployeeDeatils F = new FullEmployeeDeatils("kalyan",01,2000,20);
        //F.DisplayEmployeeDetails();

        //Banquet B = new Banquet(1, "Birthday", 100);
        //Console.WriteLine(B.CalculateEarning());


        Event E = new Event(1, "Birthday", 100, 500);
        E.CalculateEarning();
        E.DisplayEventDetails();


        Console.WriteLine(" ");
        Exhibition Ex = new Exhibition(1, "Birthday", 100, 51, 500);
        Ex.CalculateEarning();
        Ex.DisplayDetails();

        //Banquet El = new Exhibition(1,"Birthday", 100, 10, 500);


        //PartTimeEmployee P = new PartTimeEmployee("kalyan",503,0,5,500);
        //P.DisplayEmployeeDetails();

        //Manager M = new Manager("kalyan",503,50000,15,500,"technical");
        //M.DisplayEmployeeDetails();

    }
}
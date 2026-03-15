using _11_march_assignments;

public class Program
{
    public static void Main(string[] args)
    {
        //ProductDetails P = new ProductDetails();
        //P.takeValues();
        //P.GetValues();



        //Book B = new Book();
        //B.ProcessBooks();


        //BankAccount game = new BankAccount("Game", 0);
        //game.StartGame();



        //Console.WriteLine("Select Course Type 1/2/3 to select :");
        //Console.WriteLine("1. Online");
        //Console.WriteLine("2. In-Person");
        //Console.WriteLine("3. Lab");

        //int choice = Convert.ToInt32(Console.ReadLine());

        //Course course = null;

        //if (choice == 1)
        //    course = new OnlineCourse();
        //else if (choice == 2)
        //    course = new InPersonCourse();
        //else
        //    course = new LabCourse();

        //course.Enroll();


        Account a = new Account("temp", 0, "savings");
        a.StartBank();
    }
}
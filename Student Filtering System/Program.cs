using System;
using System.Collections.Generic;
using System.Text;
using static March27_LinkedList.DelegatePractice;
using static March27_LinkedList.Deligatee;

namespace March27_LinkedList
{
    internal class Program
    {


        static bool isEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        {
            //DelegatePractice DP = new DelegatePractice();
            //MyDelegate MyD = DP.Hello;
            //CalcDel CD = DP.AddDel;
            //CD(1, 2);
            //Console.WriteLine(" ");
            //CD += DP.SubDel;
            //CD(2, 3);

            //Console.WriteLine(" ");
            //CD += DP.MulDel;
            //CD(4, 5);

            //Console.WriteLine(" ");
            //CD += DP.DivDel;
            //CD(6, 7);


            //Action<string> A = DP.Display;
            //A("Hello");

            //DP.show("kalyan");
            //--------------------------------------------------------------------------
            List<ActionDelegate> list = new List<ActionDelegate>();
             list.Add(new ActionDelegate("Kalyan",01,55,23));
            list.Add(new ActionDelegate("Ram", 02, 65, 23));
            list.Add(new ActionDelegate("Shyam", 05, 45, 15));
            list.Add(new ActionDelegate("Aryan", 06, 90, 20));

            foreach (var i in list)
            {
                Console.WriteLine("Name :" +i.Name);
                Console.WriteLine("id : "+i.Id);
                Console.WriteLine("marks : " +i.marks);
                Console.WriteLine("age : " +i.Age);
            }



            Predicate<ActionDelegate> check = x => x.marks > 60;

            List<ActionDelegate> result = list.FindAll(check);
            foreach (var i in result)
            {
                Console.WriteLine(" Marks Scored Greater than 60 : "+i.Name);

            }

            Predicate<ActionDelegate> AgeCheck = x => x.Age < 18;
            List<ActionDelegate> Ageresult = list.FindAll(AgeCheck);

            foreach (var i in Ageresult)
            {
                Console.WriteLine("Student Age Below 18 : "+i.Name);
            }
            bool Nameresult = list.Exists(
                x => x.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Is name starting with A exists : " + Nameresult);


            Predicate<ActionDelegate> NameCheck = x => x.Name.StartsWith("A");
            List<ActionDelegate> NameResult = list.FindAll(NameCheck);
            foreach(var i in NameResult)
            {
                Console.WriteLine("The Name Starts With A is : "+ i.Name);
            }


            //---------------------------------------------------------------------

            //Deligatee D = new Deligatee();
            //DelCalc d;


            //Console.WriteLine("\n normal product ");
            //d = D.Multiply;
            //d(20, 30);

            //Console.WriteLine("\n normal Reminder ");
            //d = D.Divisioin;
            //d(20, 30);

            //Console.WriteLine("\n MultiCasting ");
            //d += D.sum;
            //d(10, 20);

            //Console.WriteLine("\n remove MultiCasting ");
            //d -= D.sum;
            //d(7, 8);

            //Console.WriteLine("\n Division Multicasting");
            //d += D.Multiply;

            //d(2, 3);



            //StudentLinkiedList sl = new StudentLinkiedList();
            //sl.UserInput();



        }


    }
}
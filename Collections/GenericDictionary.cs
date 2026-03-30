using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class GenericDictionary
    {
        public int id;
        public string Name;
        public Dictionary<int, string> dict = new Dictionary<int, string>();



        public void UserIn()
        {
            Console.WriteLine("Enter 1. Add values , 2.Display Values,3.Update Value,4.Remove Value,5.Exit : ");
            int.TryParse(Console.ReadLine(), out int Input);
            if(Input == 1)
            {
                stdDict();
            }
            else if(Input == 2)
            {
                Display();
            }
            else if (Input == 3)
            {
                Update();
            }
            else if (Input == 4)
            {
                Remove();
            }
            else if (Input == 5)
            {
                Console.WriteLine(" Exited");
                return;
            }
            else
            {
                Console.WriteLine("Wrong Input Exited");

            }
        }
        public void stdDict()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Id ");
                int.TryParse(Console.ReadLine(), out id);

                Console.WriteLine("Enter Name : ");
                Name = Console.ReadLine();

                dict.Add(id, Name);
               
            }
            UserIn();

        }

        public void Display()
        {
            foreach (var i in dict)
            {
                Console.WriteLine("Student Id " + i.Key + " Student Name : "+ i.Value);
            }
            UserIn();
        }

        public void Update()
        {
            Console.WriteLine("Enter Id to Update Name :");
            int UserInput = int.Parse(Console.ReadLine());
            dict[UserInput] = "Kalyan Kumar"; 
            Console.WriteLine("Updated Details : ");
            foreach (var i in dict)
            {
               
                Console.WriteLine("Student Id " + i.Key + " Student Name : " + i.Value);
            }
            UserIn();
        }

        public void Remove()
        {
            Console.WriteLine("Enter Id to  Remove :");
            int UserInput = int.Parse(Console.ReadLine());
            dict.Remove(UserInput);
            Console.WriteLine("Updated Details : ");
            foreach (var i in dict)
            {
               
                Console.WriteLine("Student Id " + i.Key + " Student Name : " + i.Value);
            }
            UserIn();
        }
    }
}

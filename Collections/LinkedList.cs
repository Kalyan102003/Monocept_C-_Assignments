using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class Linkedlist
    {
        public string Name;
        public LinkedList<string> list = new LinkedList<string>();

        public void UserIn()
        {
            Console.WriteLine("Enter 1. Add values , 2.Display Values,3.Update Value,4.Remove Value,5.Exit : ");
            int.TryParse(Console.ReadLine(), out int Input);
            if (Input == 1)
            {
                stdDict();
            }
            else if (Input == 2)
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
            for (int i = 0; i < 3; i++)
            {
    
                Console.WriteLine("Enter Name : ");
                Name = Console.ReadLine();
                list.AddLast(Name);

            }
            UserIn();

        }

        public void Display()
        {
            foreach (var i in list)
            {
                Console.WriteLine( " City Name : " + i);
            }
            UserIn();
        }

        public void Update()
        {
            Console.WriteLine("Enter City Name :");
            string cityname = Console.ReadLine();
            var find = list.Find(cityname);

            Console.WriteLine("Enter new City Name :");
            string newcityname = Console.ReadLine();
            find.Value = newcityname;

            Console.WriteLine("Updated Details : ");
            foreach (var i in list)
            {
                Console.WriteLine(" City Name : " + i);
            }
            UserIn();
        }

        public void Remove()
        {
            Console.WriteLine("\n Enter City name to remove :");
            string cityname = Console.ReadLine();
            list.Remove(cityname);
            Console.WriteLine("Updated Details : ");
            foreach (var i in list)
            {

                Console.WriteLine(" City Name : " + i);
            }
            UserIn();
        }
    }
}


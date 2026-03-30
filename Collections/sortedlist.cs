using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class sortedlist
    {
        public SortedList sl = new SortedList();
        public void empsortedlist()
        {
            for(int i = 0;i < 3; i++)
            {
                Console.WriteLine($"Enter Emp {i+1} id : ");
               

                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter his salary : ");
                int salary = int.Parse(Console.ReadLine());

                sl.Add(id, salary);
            }

            foreach(DictionaryEntry i in sl)
            {
                Console.WriteLine("Emp id " + i.Key + " Emp salary " + i.Value);
            }

            Console.WriteLine("\n Enter Id to search : \n");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(sl[x]);

            sl[x] = 98746;
            Console.WriteLine("\n updated Details : \n");
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine("Emp id " + i.Key + " Emp salary " + i.Value);
            }

        }
    }
}

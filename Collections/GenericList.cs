using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class GenericList
    {
        public List<int> li = new List<int>();
        public void NumList()
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter A number ");
                int.TryParse(Console.ReadLine(), out int num);
                li.Add(num);
            }
            foreach(var i in li)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n enter num to remove \n ");
            int.TryParse(Console.ReadLine(), out int re);
            li[li.IndexOf(re)] = 55;
          
            li.Remove(re);

            foreach (var i in li)
            {
                Console.WriteLine(i);
            }

        }
    }
}

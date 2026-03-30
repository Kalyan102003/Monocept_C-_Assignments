using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class Stackk
    {
       
        public void BooksStack()
        {
              Stack stk = new Stack();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Book Name " + (i+1));
                string Name = Console.ReadLine();
                stk.Push(Name);
                
            } 
                Console.WriteLine(" ");
            foreach(var i in stk)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");
          

            stk.Pop();

            Console.WriteLine(" ");

            foreach (var i in stk)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("top Book " + stk.Peek());

        }
    }
}

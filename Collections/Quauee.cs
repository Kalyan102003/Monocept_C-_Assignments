using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class Quauee
    {

        public void TicketQuaue()
        {
            Queue q = new Queue();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Ticket Number" + (i + 1));
                int.TryParse(Console.ReadLine(),out int num);
                q.Enqueue(num);

            }
            Console.WriteLine(" ");
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");


            q.Dequeue();

            Console.WriteLine(" ");

            foreach (var i in q)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("first ticket " + q.Peek());

        }
    }
}


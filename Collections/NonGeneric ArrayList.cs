using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class NonGeneric_ArrayList
    {
        public ArrayList MyList = new ArrayList();
         
        public void StudentDetails()
        {
            for (int i = 1; i < 6; i++)
            {
                //Console.WriteLine("Enter Student name : ");
                //string studentName = Console.ReadLine();
                //MyList.Add(studentName);

                Console.WriteLine("Enter Marks");
                int.TryParse(Console.ReadLine(), out int stdMarks);
                MyList.Add(stdMarks);
            }

            foreach (var i in MyList)
            {
              
              
                Console.WriteLine(i);

            }

            int heighest = 0;
            int lowest = 0;

           foreach(var i in MyList)
            {
                int mark = (int)i;
                if (mark > heighest)
                {
                    heighest = mark;
                }
                else if (mark < lowest)
                {
                    lowest = mark;
                }
            }

            Console.WriteLine("heighist "+heighest);
            Console.WriteLine("lowest"+lowest);

            //Console.WriteLine("Enter Student name to remove : ");
            //string stdRemove = Console.ReadLine();

            //MyList.Remove(stdRemove);

            //foreach (var input in MyList)
            //{
            //    Console.WriteLine(input);
            //}


        }
    }
}

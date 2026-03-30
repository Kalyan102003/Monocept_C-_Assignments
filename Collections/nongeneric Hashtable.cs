using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Evaluation_01_march25_practice
{
    internal class nongeneric_Hashtable
    {
        public Hashtable Ht = new Hashtable();
        public void studenthashtable()
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter id : ");
                int.TryParse(Console.ReadLine(), out int id);
                Console.WriteLine("Enter name : ");
                string name = Console.ReadLine(); 
                Ht.Add(id, name);

            }
               foreach(DictionaryEntry i in Ht)
            {
                Console.WriteLine("Student Id " + i.Key + " student Name " + i.Value);

            }

            Console.WriteLine("Enter id to search : ");
            int.TryParse(Console.ReadLine(), out int Search);
            Console.WriteLine("Id Found His name is : "+Ht[Search]);

            Ht[Search] = "Kalyan";
            Console.WriteLine("Updated Name :" + Ht[Search]);

            

            foreach (DictionaryEntry i in Ht)
            {
                Console.WriteLine("Student Id " + i.Key + " student Name " + i.Value);

            }


            Console.WriteLine(" Removed  :" + Ht[Search]);
            Ht.Remove(Search);



            foreach (DictionaryEntry i in Ht)
            {
                Console.WriteLine("Student Id " + i.Key + " student Name " + i.Value);

            }


        }

    }
}

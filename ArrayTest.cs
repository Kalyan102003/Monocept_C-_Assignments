using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    
        public class ArrayPractice
    {
            public void Arrayy()
            {
                string[] names = { "Kalyan", "Ravi", "Sita", "Anu" };

                Console.WriteLine("Using FOR loop:");
                for(int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]); 
                }


                Console.WriteLine("Using FOREach loop:");

                foreach (string name in names) {
                    Console.WriteLine(name);
                }
            }
        }
    }


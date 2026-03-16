using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverLoading
{
    public class ConstructoroverLoading
    {

        public ConstructoroverLoading()
        {
            Console.WriteLine("This is the default constructor.");
        }
        public ConstructoroverLoading(string message)
        {
            Console.WriteLine("This is a parameterized constructor. Message: " + message);
        }
        public ConstructoroverLoading(int number)
        {
            Console.WriteLine("This is another parameterized constructor. Number: " + number);
        }
    }
}

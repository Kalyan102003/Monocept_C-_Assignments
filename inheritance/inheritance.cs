using System;
using System.Collections.Generic;
using System.Text;

namespace _13_march_Tasks_inheritance
{
    public class Shape
    {

        public Shape() {
            Console.WriteLine("Hi from parent class");
        }
       public virtual  double getArea()
        {
           
            return 0;
        }
    }
    public class Rectangle:Shape
    {
        public double length;
        public double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double getArea()
        {
            return length * width;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EnumAndArrayAssignments
{
    enum Planet
    {
        MERCURY,
        VENUS,
        EARTH,
        MARS,
        JUPITER,
        SATURN,
        URANUS,
        NEPTUNE
    }

    class Enums
    {
        public double GetGravity(Planet planet)
        {
            switch (planet)
            {
                case Planet.MERCURY: return 0.38;
                case Planet.VENUS: return 0.91;
                case Planet.EARTH: return 1.0;
                case Planet.MARS: return 0.38;
                case Planet.JUPITER: return 2.37;
                case Planet.SATURN: return 0.93;
                case Planet.URANUS: return 0.92;
                case Planet.NEPTUNE: return 1.12;
                default: return 1;
            }
        }

        public void EnumProgram()
        {
            Console.Write("Enter Earth weight: ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());

            foreach (Planet p in System.Enum.GetValues(typeof(Planet)))
            {
                if (p == Planet.EARTH) continue;

                double weight = earthWeight * GetGravity(p);

                Console.WriteLine($"Weight on {p}: {weight:F1} kg");
            }
        }
    }
}

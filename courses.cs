using System;
using System.Collections.Generic;
using System.Text;

namespace _11_march_assignments
{
        public abstract class Course
        {
            public string CourseName;
            public int Students;
            public abstract void Enroll();
        }

    class OnlineCourse : Course
    {
        public string VideoLink;

        public override void Enroll()
        {
            Console.Write("Enter Course Name: ");
            CourseName = Console.ReadLine();

            Console.Write("Enter Video Platform Link: ");
            VideoLink = Console.ReadLine();

            Console.Write("Enter Number of Students: ");
            Students = Convert.ToInt32(Console.ReadLine());

            if (VideoLink == "")
                Console.WriteLine("Online course must have a video platform link.");
            else
                Console.WriteLine("Online Course Enrollment Successful");
        }
    }


    class InPersonCourse : Course
    {
        public int RoomNumber;
        public int Capacity;

        public override void Enroll()
        {
            Console.Write("Enter Course Name: ");
            CourseName = Console.ReadLine();

            Console.Write("Enter Room Number: ");
            RoomNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Capacity: ");
            Capacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Students: ");
            Students = Convert.ToInt32(Console.ReadLine());

            if (Students > Capacity)
                Console.WriteLine("Enrollment exceeds room capacity.");
            else
                Console.WriteLine("In-Person Course Enrollment Successful");
        }
    }

    class LabCourse : Course
    {
        public bool SafetyTraining;

        public override void Enroll()
        {
            Console.Write("Enter Course Name: ");
            CourseName = Console.ReadLine();

            Console.Write("Safety Training Completed? (true/false): ");
            SafetyTraining = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Number of Students: ");
            Students = Convert.ToInt32(Console.ReadLine());

            if (!SafetyTraining)
                Console.WriteLine("Students must complete safety training.");
            else
                Console.WriteLine("Lab Course Enrollment Successful");
        }
    }
}

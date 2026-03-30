using System;
using System.Collections.Generic;
using System.Text;

namespace March27_LinkedList
{
    internal class StudentLinkiedList
    {
        public string StudentName;
        public int StudentId;
        public int StudentAge;
        public int StudentMarks;
        public static LinkedList<StudentLinkiedList> std = new LinkedList<StudentLinkiedList>();


        public  void UserInput()
        {
            while (true)
            {
                Console.WriteLine("\nSelect 1 : Add students");
                Console.WriteLine("Select 2 : Display Student Details");
                Console.WriteLine("Select 3 : Update Student Details");
                Console.WriteLine("Select 4 : Delete Student Details");
                Console.WriteLine("Select 5 : Exit");

                int.TryParse(Console.ReadLine(), out int UserInput);

                if (UserInput == 1)
                {
                    AddStudents();
                }
                else if (UserInput == 2)
                {
                    DisplayStudents();
                }
                else if (UserInput == 3)
                {
                    UpdateStudent();
                }
                else if (UserInput == 4)
                {
                    RemoveStudent();
                }
                else if (UserInput == 5)
                {
                    Console.WriteLine("Exited Successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        public  void AddStudents()
        {
            Console.WriteLine("Enter Number of students : ");
            int.TryParse(Console.ReadLine(), out int NumberOfStudents);

            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.WriteLine("Enter Name of Student : ");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Id of student : ");
                int.TryParse(Console.ReadLine(), out int Id);

                Console.WriteLine("Enter student Age : ");
                int.TryParse(Console.ReadLine(), out int Age);

                Console.WriteLine("Enter student Marks : ");
                int.TryParse(Console.ReadLine(), out int Marks);
                StudentLinkiedList student = new StudentLinkiedList()
                {
                    StudentName = Name,
                    StudentId = Id,
                    StudentAge = Age,
                    StudentMarks = Marks
                };

                std.AddFirst(student);

            }
        }

        public  void DisplayStudents()
        {
            foreach (var item in std)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Student Name : " + item.StudentName);
                Console.WriteLine("Student Id : " + item.StudentId);
                Console.WriteLine("Student Age : " + item.StudentAge);
                Console.WriteLine("Student Age : " + item.StudentMarks);
            }
        }

        public  void UpdateStudent()
        {
            Console.WriteLine("Enter Student Name to Update : ");
            string searchName = Console.ReadLine();

            foreach (var item in std)
            {
                if (item.StudentName == searchName)
                {
                    Console.WriteLine("Enter New Name : ");
                    item.StudentName = Console.ReadLine();

                    Console.WriteLine("Enter New Id : ");
                    item.StudentId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter New Age : ");
                    item.StudentAge = int.Parse(Console.ReadLine());

                    Console.WriteLine("Updated Successfully");
                }
            }
        }

        public  void RemoveStudent()
        {
            Console.WriteLine("Enter student Name to Remove : ");
            string RemoveStudent = Console.ReadLine();

            var node = std.First;

            while (node != null)
            {
                var next = node.Next;

                if (node.Value.StudentName == RemoveStudent)
                {
                    std.Remove(node);
                    Console.WriteLine("Removed Successfully");
                }

                node = next;
            }


            // another method to remove values

            //foreach(var i in std)
            //{
            //    if(RemoveStudent == i.StudentName)
            //    {
            //        std.Remove(i);
            //        Console.WriteLine("Removed sucessfully");
            //    }
            //}

            Console.WriteLine("Updated List");

            foreach (var item in std)
            {
                Console.WriteLine("Student Name : " + item.StudentName);
                Console.WriteLine("Student Id : " + item.StudentId);
                Console.WriteLine("Student Age : " + item.StudentAge);
                Console.WriteLine("Student Age : " + item.StudentMarks);
            }
        }
    }


}

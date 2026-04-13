using System;

namespace MovieAssignment
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }

      
        public static Movie ReadFromConsole()
        {
            var movie = new Movie();

            Console.Write("Enter Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Invalid Id. Enter numeric Id: ");
            }
            movie.Id = id;

            Console.Write("Enter Name: ");
            movie.Name = Console.ReadLine();

            Console.Write("Enter Year of release: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Invalid year. Enter numeric year: ");
            }
            movie.YearOfRelease = year;

            Console.Write("Enter Genre: ");
            movie.Genre = Console.ReadLine();

            return movie;
        }
    }
}

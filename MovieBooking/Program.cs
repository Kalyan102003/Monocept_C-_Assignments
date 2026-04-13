using System;
using System.Collections.Generic;

namespace MovieAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MoviesList = new List<Movie>();

            Console.WriteLine("Welcome to movie store developed by : Kalyan");
            Console.WriteLine("-----------------------------------------------");

            while (true)
            {
                Console.WriteLine("1.Add Movie \r\n" +
                    "2.Display All Movies\r\n" +
                    "3.Find Movie by ID\r\n" +
                    "4.Remove Movie by ID\r\n" +
                    "5.Clear All Movies\r\n" +
                    "6.Exit\r\n");
                Console.WriteLine("-----------------------------------------------");

                int.TryParse(Console.ReadLine(), out int Input);

                switch (Input)
                {
                    case 1:
                        MoviesList.Add(Movie.ReadFromConsole());
                        Console.WriteLine("Movie added.");
                        Console.WriteLine("-----------------------------------------------");
                        break;
                    case 2:
                        if (MoviesList.Count == 0)
                        {
                            Console.WriteLine("No movies to display.");
                        }
                        else
                        {
                            foreach (var m in MoviesList)
                            {
                                Console.WriteLine($"Id: {m.Id}\nName: {m.Name}\nYear: {m.YearOfRelease}\nGenre: {m.Genre}");
                                Console.WriteLine("-----------------------------------------------");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Enter Id: ");
                        int.TryParse(Console.ReadLine(), out int IdInput);
                        var found = MoviesList.Find(m => m.Id == IdInput);
                        if (found is null)
                        {
                            Console.WriteLine("Movie not found.");
                        }
                        else
                        {
                            Console.WriteLine($"Id: {found.Id}\nName: {found.Name}\nYear: {found.YearOfRelease}\nGenre: {found.Genre}");
                        }
                        Console.WriteLine("-----------------------------------------------");
                        break;

                    case 4:
                        Console.Write("Enter Id: ");
                        int.TryParse(Console.ReadLine(), out int InputId);
                        var removed = MoviesList.RemoveAll(m => m.Id == InputId);
                        Console.WriteLine(removed > 0 ? "Movie(s) removed." : "No movie with that Id.");
                        Console.WriteLine("-----------------------------------------------");
                        break;

                    case 5:
                        MoviesList.Clear();
                        Console.WriteLine("All movies cleared.");
                        Console.WriteLine("-----------------------------------------------");
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please choose a number from 1 to 6.");
                        Console.WriteLine("-----------------------------------------------");
                        break;
                }
            }
        }
    }
}

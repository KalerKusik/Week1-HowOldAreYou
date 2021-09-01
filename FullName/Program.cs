using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest eesnime
            //programm küsib kasutaja käest perekonnanime
            //programm tervitab kasutajat kasutades neid andmeid



            Console.WriteLine("What is your first name?");
            string UserFirstName = Console.ReadLine();

            Console.WriteLine("And what is your name?");
            string UserLastName = Console.ReadLine();

            Console.WriteLine($"Hello {UserFirstName} {UserLastName}");
        }
    }
}

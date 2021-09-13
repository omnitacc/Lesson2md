using System;

namespace Lesson2md
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Sveiks {userName}");
            Console.WriteLine("----------------------------------------------?");

            Console.WriteLine("Kāds ir tavs vecums?");
            string userAgeText = Console.ReadLine();
            int userAge = int.Parse(userAgeText);
            int userAgeNext = userAge + 1;
            bool isAdult = userAge >= 18;
            Console.WriteLine($"Nākamgad tev paliks {userAgeNext}, Tu esi pilngadīgs: {isAdult}");


        }
    }
}

using System;

namespace sak
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ord = new string[5];
            
            Console.WriteLine("Skriv fem tal");

            for (int i = 0; i < ord.Length; i++)
            {
                tal[i] = Console.ReadLine();
            }

            Console.WriteLine("Här är de sorterade alfabetiskt.");

            Array.Sort(ord);

            for (int i = 0; i < ord.Length; i++)
            {
                Console.WriteLine(ord[i]);
            }




        }
    }
}

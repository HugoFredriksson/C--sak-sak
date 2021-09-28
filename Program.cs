using System;

namespace _2222
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[5];        
            
            Console.WriteLine("Skriv fem tal");

            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Här är de numeriskt.");

            Array.Reverse(tal);

            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }

        }
    }
}

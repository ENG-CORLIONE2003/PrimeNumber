using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            bool isPrime = true;

            Console.WriteLine("Enter the lower bound (n1):");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper bound (n2):");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers between {0} and {1} are:", n1, n2);

            for (int i = n1; i <= n2; i++)
            {
                isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
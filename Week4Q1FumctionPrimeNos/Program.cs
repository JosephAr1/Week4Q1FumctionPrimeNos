using System;

namespace Week4Q1FumctionPrimeNos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; 
            int i, count = 0;

            Console.Write("\nPlease Enter a number: "  );
            num1 = Convert.ToInt32(Console.ReadLine());
            
            PrimeNumber(num1);
        }
        static void PrimeNumber(int num1)
        {
            int count = 0;

            for (int i = 2; i <= num1 / 2; i++)
            {

                if (num1 % i == 0)
                {
                    count = 1;
                }
            }
            if (num1 == 1)
            {
                Console.WriteLine(num1.ToString() + "is not a Prime Number");
            }
            else
            {
                if (count == 0)
                    Console.WriteLine(num1.ToString() + " is a prime number.");
                else
                    Console.WriteLine(num1.ToString() + " is not a prime number.");
            }
        }
    }  
}

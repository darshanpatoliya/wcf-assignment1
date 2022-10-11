using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment1Reference.Assignment1ServiceClient client = new Assignment1Reference.Assignment1ServiceClient();
            string choice = "";
            while (!choice.Equals("5"))
            {
                Console.WriteLine("Assignment1");
                Console.WriteLine("1. PrimeNumber");
                Console.WriteLine("2. Sum of Digits");
                Console.WriteLine("3. Reverse a String");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 Numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Number 1: ");
                        int n = int.Parse(Console.ReadLine());
                        
                        string result = client.primeCheck(n);
                        Console.WriteLine(result);

                        break;
                    case "2":
                        

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections;
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
            ServiceReference1.Assignment1ServiceClient assignment1ServiceClient = new ServiceReference1.Assignment1ServiceClient();
            string selection = "";
            while (!selection.Equals("5"))
            {
                Console.WriteLine("Assignment1");
                Console.WriteLine("1. PrimeNumber");
                Console.WriteLine("2. Sum of Digits");
                Console.WriteLine("3. Reverse a String");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 Numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");

                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Enter Number 1: ");
                        int n = int.Parse(Console.ReadLine());

                        string result = assignment1ServiceClient.primeCheck(n);
                        Console.WriteLine(result);

                        break;
                    case "2":
                        Console.WriteLine("Enter Number 1: ");
                        n = int.Parse(Console.ReadLine());

                        int result2 = assignment1ServiceClient.sumOfDigits(n);
                        Console.WriteLine(result2);
                        break;
                    case "3":
                        Console.WriteLine("Enter Number 1: ");
                        string n2 = Console.ReadLine();

                        string result3 = assignment1ServiceClient.reverseString(n2);
                        Console.WriteLine(result3);
                        break;
                    case "4":
                        Console.WriteLine("Enter Number 1: ");
                        string n3 = Console.ReadLine();
                        string result4 = assignment1ServiceClient.printHtml(n3);
                        Console.WriteLine(result4);
                        break;
                    case "5":
                        /*int i;
                        int[] intArray = new int[5];

                        for (i = 0; i <= 4; i++)
                        {
                            Console.Write("Enter the No " + i + ":");
                            intArray[i] = int.Parse(Console.ReadLine());
                        }

                        int[] resultArray = assignment1ServiceClient.sortFiveNumbers(intArray);
                        Console.WriteLine("\n\n\nSorted Integer Array:\n");


                        foreach (int a in intArray)
                        {
                            Console.Write(a + "\t");
                        }*/


                        break;
                    case "6":
                        break;
                }
            }
        }
    }
}

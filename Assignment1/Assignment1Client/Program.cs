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
            ServiceReference1.Assignment1ServiceClient service = new ServiceReference1.Assignment1ServiceClient();
            string selection = "";
            while (!selection.Equals("6"))
            {
                Console.WriteLine("\n\nAssignment1");
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
                        Console.WriteLine("\nEnter Number to check whether it is prime or not: ");
                        int n = int.Parse(Console.ReadLine());

                        string result = service.primeCheck(n);
                        Console.WriteLine("Result: " + result);

                        break;
                    case "2":
                        Console.WriteLine("\nEnter any digits to do a sum of them: ");
                        n = int.Parse(Console.ReadLine());

                        int result2 = service.sumOfDigits(n);
                        Console.WriteLine("Sum of Digits: " + result2);
                        break;
                    case "3":
                        Console.WriteLine("\nEnter a string to reverse it: ");
                        string n2 = Console.ReadLine();

                        string result3 = service.reverseString(n2);
                        Console.WriteLine("Reversed string: " + result3);
                        break;
                    case "4":
                        Console.WriteLine("\nEnter Tag: ");
                        string tag = Console.ReadLine();
                        Console.WriteLine("\nEnter String: ");
                        string string1 = Console.ReadLine();
                        string result4 = service.printHtml(string1, tag);
                        Console.WriteLine("Tag added: " + result4);
                        break;
                    case "5":
                        bool loop = true;
                        while (loop)
                        {
                            string SortType = "";
                            Console.WriteLine("\nSort Type: (Enter Asc or Desc) ");
                            SortType = Console.ReadLine();
                            if (SortType == "Asc")
                            {
                                int i;
                                int[] intArray = new int[5];

                                for (i = 0; i <= 4; i++)
                                {
                                    Console.Write("Enter the No " + (i + 1) + ":");
                                    intArray[i] = int.Parse(Console.ReadLine());
                                }

                                int[] resultArray = service.sortFiveNumbersAsc(intArray);

                                Console.Write("Ascending Sort : ");
                                for (i = 0; i <= 4; i++)
                                {
                                    Console.Write(resultArray[i] + " ");
                                }
                                loop= false;
                            }
                            else if (SortType == "Desc")
                            {
                                int i;
                                int[] intArray = new int[5];

                                for (i = 0; i <= 4; i++)
                                {
                                    Console.Write("Enter the No " + (i + 1) + ":");
                                    intArray[i] = int.Parse(Console.ReadLine());
                                }

                                int[] resultArray = service.sortFiveNumbersDesc(intArray);

                                Console.Write("Descending Sort : ");
                                for (i = 0; i <= 4; i++)
                                {
                                    Console.Write(resultArray[i] + " ");
                                }
                                loop = false;
                            }
                            else
                            {
                                Console.WriteLine("\nEnter Asc or Desc, Any other word not accepted!");
                                loop = true;
                            }
                        }                                              
                        break;
                    case "6":
                        break;
                }
            }
        }
    }
}

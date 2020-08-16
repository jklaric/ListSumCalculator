using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace ListSumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFinished = false;
            string numberAmount;
            int numberAmountAsInt;
            string numberInput;
            int numberInputAsInt;
            var specificList = new List<int>();
            var openList = new List<int>();
            bool isValid = true;
            

            while (!isFinished)
            {
                Console.WriteLine("How many numbers would you like to enter?");
                numberAmount = Console.ReadLine();

                if (Int32.TryParse(numberAmount, out numberAmountAsInt))
                {
                    for (int i = 0; i < numberAmountAsInt; i++)
                    {
                        bool isRunning = true;
                        
                        while (isRunning)
                        {
                            Console.WriteLine("Please enter a number!");
                            numberInput = Console.ReadLine();

                            if (Int32.TryParse(numberInput, out numberInputAsInt))
                            {
                                openList.Add(numberInputAsInt);
                                isRunning = false;
                            }

                            if (isMultipleOfThree(numberInputAsInt, isValid))
                            {
                                specificList.Add(numberInputAsInt);
                            }

                            else
                            {
                                Console.WriteLine("Please enter a valid number!");
                            }
                        }
                    }
                }
                else if (!Int32.TryParse(numberAmount, out numberAmountAsInt))
                {
                    Console.WriteLine("Please enter a valid number!");
                }

                if (openList.Count == numberAmountAsInt)
                {
                    isFinished = true;
                }
                
            }

            foreach (int number in specificList)
            {
                Console.WriteLine(number);
            }

        }

        static bool isMultipleOfThree(int numberInputAsInt, bool isValid)
        {
            double divisionValue = numberInputAsInt / 3;

            if (divisionValue % 1 != 0)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

    }
}

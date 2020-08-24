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
            var isFinished = false;
            string numberAmount;
            int numberAmountAsInt;
            string numberInput;
            int numberInputAsInt;
            var multipleList = new List<int>();
            var inputCounter = 0;
            var previousUserInput = 0;

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
                                if (numberInputAsInt != previousUserInput)
                                {
                                    inputCounter++;
                                    isRunning = false;
                                }

                                else if (numberInputAsInt == previousUserInput)
                                {
                                    Console.WriteLine("Please enter a different number.");
                                }

                                if (IsMultipleOfThree(numberInputAsInt))
                                {
                                    multipleList.Add(numberInputAsInt);
                                }

                                previousUserInput = numberInputAsInt;
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

                if (inputCounter == numberAmountAsInt && numberAmountAsInt != 0)
                {
                    isFinished = true;
                }

            }
            if (multipleList.Count > 2)
            {
                Console.WriteLine("The sum of all entered multiples of 3 is");
                Console.WriteLine(multipleList.Sum());
            }
            else
            {
                Console.WriteLine("There are not enough multiples of 3 for the calculator to work");
                isFinished = true;
            }

        }

        private static bool IsMultipleOfThree(int numberInputAsInt)
        {
            if ((double)numberInputAsInt / 3 % 1 != 0)
            {
                return false;
            }
            return true;
        }

    }
}

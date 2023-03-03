using System;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] numbers = new int[0];
            string userInput;
            string commandSum = "sum";
            string commandExit = "exit";
            int number;
            bool isWork = true;

            Console.WriteLine($"Введите целое число. Введите {commandSum} для сложения. Bведите {commandExit} для выходы из программы \n");

            while (isWork)
            {
                Console.WriteLine($"eneter number,{commandSum} or {commandExit}");
                userInput = Console.ReadLine();

                Console.WriteLine();
                int.TryParse(userInput, out number);

                if (userInput == commandSum)
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    
                    Console.WriteLine(sum); 
                }
                else if (userInput == commandExit)
                {
                    isWork = false;
                }
                else
                {
                    int[] tempArray = new int[numbers.Length + 1];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        tempArray[i] = numbers[i];
                    }

                    tempArray[tempArray.Length - 1] = number;
                    numbers = tempArray;
                }
            }
        }
    }
}

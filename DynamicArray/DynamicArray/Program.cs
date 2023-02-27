using System;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 0;
            int[] array = new int[sizeArray];
            string userInput;
            string textSum = "sum";
            string exit = "exit";
            int numbers;
            int sum = 0;
            bool isWork = true;

            Console.WriteLine($"Введите целое число. Введите {textSum} для сложения. Bведите {exit} для выходы из программы \n");

            while (isWork)
            {
                Console.WriteLine("eneter number,sum or exit");
                userInput = Console.ReadLine();
               
                Console.WriteLine();
                bool isInputResult = int.TryParse(userInput, out numbers);

                if (isInputResult != true)
                {
                    if (userInput == textSum)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum += array[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else if (userInput == exit)
                    {
                        isWork = false;
                    }
                }
                else
                {
                    int[] tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }

                    tempArray[tempArray.Length - 1] = numbers;
                    array = tempArray;
                }
            }
        }
    }
}

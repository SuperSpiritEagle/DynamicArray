﻿using System;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 1;
            int[] array = new int[sizeArray];
            int[] tempArray = new int[array.Length + 1];
            string userInput = "";
            string textSum = "sum";
            string exit = "exit";
            int numbers;
            int sum = 0;

            Console.WriteLine($"Введите целое число. Введите {textSum} для сложения. Bведите {exit} для выходы из программы \n") ;

            while (userInput != exit)
            {
                Console.WriteLine("eneter number,sum or exit");

                userInput = Console.ReadLine();
                int.TryParse(userInput, out numbers);

                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }

                tempArray[tempArray.Length - 1] = numbers;
                array = tempArray;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                if (userInput == textSum)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}

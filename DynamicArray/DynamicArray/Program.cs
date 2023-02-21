using System;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 1;
            int[] array = new int[sizeArray];
            int[] tempArray = new int[array.Length + 1];
            string text = "";
            int numbers;
            int sum = 0;

            Console.WriteLine("Введите целое число для сложения введите sum для выхода введите exit\n");

            while (text != "exit")
            {
                Console.WriteLine("eneter number,sum or exit");

                text = Console.ReadLine();
                int.TryParse(text, out numbers);

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

                if (text == "sum")
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}

//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        //Напишите свое решение здесь
        int[] array_sum_rows = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum_row = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum_row = sum_row + array[i, j];
            }
            array_sum_rows[i] = sum_row;
            //Console.WriteLine($"{i} - {sum_row}");
        }
        return array_sum_rows;
    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
        //Напишите свое решение здесь
        int ind_min = 0;
        int min = array[0];
        for(int i=0; i<array.Length ; i++)
        {
            if (array[i]<min)
            {
                min=array[i];
                ind_min=i;
            }
        }
        return ind_min;
    }
    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        Console.WriteLine($"{MinIndex(SumRows(numbers))}");
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив

            numbers = new int[,] {
                {10, 20, 30, 40},
                {50, 60, 7, 8},
                {9, 10, 11, 12}
    };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
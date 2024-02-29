// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split(' ');

        string[] resultArray = FilterArray(inputArray);

        // Выводим результат в одну строку через запятую
        Console.WriteLine("Новый массив: " + string.Join(", ", resultArray));
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Создаем массив для хранения строк, удовлетворяющих условию (длина <= 3 символов)
        string[] resultArray = new string[inputArray.Length];
        int resultIndex = 0;

        // Фильтруем строки
        foreach (var item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[resultIndex] = item;
                resultIndex++;
            }
        }

        // Создаем новый массив с учетом количества строк, удовлетворяющих условию
        string[] finalResultArray = new string[resultIndex];
        Array.Copy(resultArray, finalResultArray, resultIndex);

        return finalResultArray;
    }
}
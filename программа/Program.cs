using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("введите массив через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');
        string[] resultArray = FilterStrings(inputArray);
        Console.WriteLine("результат:");
        foreach (string element in resultArray)
        {
            Console.Write(element + " ");
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];

        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}

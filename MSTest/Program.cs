using System;

class Program
{
    static void Main()
    {
        int int1, int2;
        float float1, float2;
        int[] numbers;

        Console.WriteLine("Enter the first integer: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the first float: ");
        float1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter the second float: ");
        float2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter the numbers for the array separated by commas (e.g., 3,4,5,6,6,7): ");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(',');
        numbers = new int[numberStrings.Length];
        for (int i = 0; i < numberStrings.Length; i++)
        {
            numbers[i] = Convert.ToInt32(numberStrings[i]);
        }

        // Test the functions with user input
        int sumOfIntegers = AddIntegers(int1, int2);
        Console.WriteLine("Sum of integers: " + sumOfIntegers);

        float sumOfFloats = AddFloats(float1, float2);
        Console.WriteLine("Sum of floats: " + sumOfFloats);

        double average = FindAverage(numbers);
        Console.WriteLine("Average: " + average);
    }

    static int AddIntegers(int a, int b)
    {
        return a + b;
    }

    static float AddFloats(float a, float b)
    {
        return a + b;
    }

    static double FindAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return (double)sum / array.Length;
    }
}

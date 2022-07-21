// See https://aka.ms/new-console-template for more information

using Generics;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Maximum value finder Using Generic Method :");

        int[] intArray = { 6,2,5,9, 4 };
        double[] doubleArray = { 2.356, 5.263, 9.215, 2.3 };
        string[] stringArray = { "Sagar", "Megha", "Shreyas", "kruthi" };

        MaxNumberCheck.FindMax<int>(intArray);
        MaxNumberCheck.FindMax<double>(doubleArray);
        MaxNumberCheck.FindMax<string>(stringArray);
    }
}
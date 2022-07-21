// See https://aka.ms/new-console-template for more information

using Generics;



    Console.WriteLine("Welcome to Maximum value finder Using Generic Method :");

    int[] integer = {2, 75, 82, 6, 13 };
    double[] doubles = { 23.35, 4231.2562, 52.369, 899.23, 72.156 };
    string[] strings = { "megh", "meghana", "Nayak", "nayak" };
    MaxNumberCheck<int> max = new MaxNumberCheck<int>(integer);
    MaxNumberCheck<double> doub = new MaxNumberCheck<double>(doubles);
    MaxNumberCheck<string> str = new MaxNumberCheck<string>(strings);

    max.testMaximum();
    doub.testMaximum();
    str.testMaximum();

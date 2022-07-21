// See https://aka.ms/new-console-template for more information

using Generics;

Console.WriteLine("Welcome to Maximum value finder Using Generic Class :");

int[] intArray = { 104, 412, 253, 523, 12 };
GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
genericInt.PrintMaxValue();

double[] doubleArray = { 2.3, 74.5, 5.66, 54.23, 9.36 };
GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
genericDouble.PrintMaxValue();

string[] stringArray = { "Megha", "shreyas", "Abhi", "Kruthi", "sagar" };
GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
genericString.PrintMaxValue();
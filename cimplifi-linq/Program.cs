// See https://aka.ms/new-console-template for more information
using cimplifi_linq;

int[] numbers = { 1, 2, 3, 4, 5, 6 };

LinqClass num = new(numbers);

// Print original numbers
Console.Write("The square of ");
Console.WriteLine(string.Join(", ", numbers));

// Print squared numbers
Console.Write("is: ");
Console.WriteLine(string.Join(", ", num.Square()));
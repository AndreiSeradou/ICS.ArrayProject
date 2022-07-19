// See https://aka.ms/new-console-template for more information

using ICS.ArrayProject;

var firstArray = new int[] { 8,5,5, 5, 3, 5, 14 };
var secondArray = new int[] { 5 };

var result = CustomArray.СonvertArrays(firstArray, secondArray);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"result {i + 1}: {result[i]}");
}

Console.ReadLine();
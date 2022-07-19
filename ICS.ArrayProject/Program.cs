// See https://aka.ms/new-console-template for more information

using ICS.ArrayProject;

var firstArray = new int[] { 5,-11,6 };
var secondArray = new int[] { 5 };

var result = CustomArray.СonvertArrays(firstArray, secondArray);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"result {i + 1}: {result[i]}");
}

Console.ReadLine();
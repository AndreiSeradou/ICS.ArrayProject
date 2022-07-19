// See https://aka.ms/new-console-template for more information

using ICS.ArrayProject;

var firstArray = new int[] {-11,1,9,1,10,1,3,1,4,1,6,-11 };
var secondArray = new int[] {  0, 10 , -100 };

var result = CustomArray.СonvertArrays(firstArray, secondArray);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"result {i + 1}: {result[i]}");
}

Console.ReadLine();
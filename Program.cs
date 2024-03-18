// See https://aka.ms/new-console-template for more information

// Give Array
int[] array = { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };

// Find the sum of all the integers in the array
int sum = array.Sum();
Console.WriteLine($"Sum of all integers: {sum}");

// Find the maximum and minimum values in the array
int max = array.Max();
int min = array.Min();
Console.WriteLine($"\nmaximum value: {max}");
Console.WriteLine($"\nminimum value: {min}");

// Count the number of even and odd integers in the array
int even = array.Count(num => num % 2 == 0);
int odd = array.Count(num => num % 2 != 0);
Console.WriteLine($"\nNumber of even integers: {even}");
Console.WriteLine($"\nNumber of odd integers: {odd}");

// Calculate the average of all the integers in the array
double ave = array.Average();
Console.WriteLine($"\nAverage of all integers: {ave}");

// Check if a specific integer is present in the array
int specificNum = 20;
bool Present = array.Contains(specificNum);
Console.WriteLine($"\n{specificNum} is present in the array: {Present}\n");


// Create a two-dimensional array
int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

int row = matrix.GetLength(0);
int col = matrix.GetLength(1);

int suma = 0;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        //sum of all elements in a two-dimensional array (matrix).
        Console.WriteLine($"sum of all elements in a two-dimensional array (matrix): {suma += matrix[i, j]}");
    }
}
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите число m: ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число n : ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);

if (numberN == false || numberN == false)
{
    Console.WriteLine("Введены неправильные данные");
}

int[,] FillArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
int[,] result = FillArray(m, n);

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray2D(result);

void FintNumberInArray(int[,] array2, int m)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        double sum = 0;
        double endSum = 0;
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            sum = sum + array2[i, j];
        }
        endSum = sum / m;
        Console.Write($"{endSum}; ");
    }
}

    FintNumberInArray(result, m);
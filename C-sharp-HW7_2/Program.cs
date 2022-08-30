// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
Console.WriteLine("Введите число m: ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число n : ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите число, которое будем искать ");
bool FindNumber = int.TryParse(Console.ReadLine(), out int Value);

if (numberN == false || numberN == false || FindNumber == false)
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

void FintNumberInArray(int[,] array2, int v)
{
    double result = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (array2[i, j] == v)
            {
                result = array2[i, j];
                Console.WriteLine($" {i}, {j}");
            }
        }
    }
    if (result != v)
    {
        Console.WriteLine("Такого числа нет");
    }
}
FintNumberInArray(result, Value);
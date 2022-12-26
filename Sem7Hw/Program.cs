// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*

double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a range of array from: ");
    int from = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a range of array to: ");
    int to = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j= 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(from, to +1) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Clear();
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);


*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int[,] CreateRandom2dArray()
{
Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a range of array from: ");
    int from = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a range of array to: ");
    int to = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j= 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(from, to +1);
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SearchingForValueByIndexes (int[,] array, int num1, int num2)
{
    int i = array.GetLength(0);
    int j = array.GetLength(1);
    if(num1 > i  && num2 > j)
        Console.WriteLine($"Такого числа нет.");
    else
    {
        Console.WriteLine ($"Значение элемента с индексами {num1} и {num2} равняется {array[num1,num2]}.");
    }
}
int[,] myArray = CreateRandom2dArray();
Console.Write("Введите первый индекс: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй индекс: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Show2dArray(myArray);
SearchingForValueByIndexes(myArray, num1, num2);


*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a range of array from: ");
    int from = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a range of array to: ");
    int to = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j= 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(from, to + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ResultArray (int[,] array)
{
    double[] midArithmetic = new double[array.GetLength(0)]; 
    int a =0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i= 0; i < array.GetLength(0); i++)
        {
            sum +=array[i,j];   
        }
        midArithmetic[a]= sum / array.GetLength(0);
        Console.Write(Math.Round(midArithmetic[a], 2) + "\t");
    }
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ResultArray(myArray);
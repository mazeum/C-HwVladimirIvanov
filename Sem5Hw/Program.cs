// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


/*

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999 + 1);
    }
    return array;
}
void ShowArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
int NumberofEvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        sum++;
    }
    return sum;
}
Console.Write("Inpuat size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
int result = NumberofEvenNumbers(myArray);
Console.WriteLine();
Console.WriteLine($"quantity of even numbers: {result}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
int SumofOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a range of array FROM: ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a range of array TO: ");
int to = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, from, to);
ShowArray(myArray);
int result = SumofOddElements(myArray);
Console.WriteLine();
Console.WriteLine($"Summ of elemts of array with odd place is: {result}");


// Задача 38 : Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

double[] CreateRandomArray(int size, int from, int to)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to + 1) + Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

void ShowArray(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + "  ");
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }

    double dif = max - min;
    return Math.Round(dif, 2);
}
Console.Clear();
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a range of array From: ");
int from = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a range of array TO: ");
int to = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, from, to);
ShowArray(myArray);
double result = Difference(myArray);
Console.WriteLine();
Console.WriteLine($"Difference betweeen min and max is: {result}");

*/

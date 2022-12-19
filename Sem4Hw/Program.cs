//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int NumInPow(int num1, int num2)
{
    int res = 1;
    for(int i = 1; i <= num2; i++)
    {
        res = num1 * res;
    }
return res;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа {a} : ");
int b = Convert.ToInt32(Console.ReadLine());
int result = NumInPow(a, b);
Console.Write($"Число {a} в степени {b} = {result}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumofDigits(int number)
{
    int ed = 0, count = 0;
    while(number > 0)
    {
        ed = number % 10;
        count += ed;
        number /= 10;
    }
    return count;
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumofDigits(num);
Console.Write($"Digit summ of your number is: {result}");


// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input array number {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}
Console.Write("Input a size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);

*/
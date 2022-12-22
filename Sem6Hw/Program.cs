// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int Number(int size)
{
    int count = 0;
    Console.WriteLine("Input a size of array: ");
    for(int i = 0; i < size; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) count++;
    }
    return count;
}
Console.WriteLine("Input a number of elements: ");
int numofElements = Convert.ToInt32(Console.ReadLine());
int result = Number(numofElements);
Console.WriteLine($"Quantity of numbers more than 'zero' = {result} ");

*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionofStraightLines (double  b1, double  k1, double  b2, double  k2)
{
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Straight lines match");
    else
    {
        if (k1 == k2)
            Console.WriteLine("Straight lines are parallel");
        else
        {
            double  x = (b2 - b1) / (k1 - k2);
            double  y = (k1*(b2 - b1))/(k1 - k2)+ b1;
            Console.WriteLine($"{x};{y}");
        }
    }
}

Console.Clear();
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionofStraightLines(b1,  k1,  b2,  k2);
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums(num - 1);

}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SummNums(int num1, int num2)
{
    if (num1 > num2) return SummNums(num1 - 1, num2) + num1;
    if (num1 < num2) return SummNums(num1, num2 - 1) + num2;
    if (num1 == num2) return num1;
    return 1;
}
Console.Write("Input a fist number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = SummNums(M, N);
Console.WriteLine(result);

*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num1 != 0 && num2 == 0) return AckermanFunction(num1 - 1, 1);
    else return AckermanFunction(num1 - 1, AckermanFunction(num1, num2 - 1));
}

Console.Write("Input a fist number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = AckermanFunction(m, n);
Console.WriteLine(res);

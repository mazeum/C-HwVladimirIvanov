// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int secDigit(int num)
{
    int sec = num % 100;
    sec = sec / 10;
    return sec;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = secDigit(number);
Console.WriteLine($"Вторая цифра этого числа - {newNumber}");

*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

int thirdNum(int num)
{
    if (num > 1000)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        num = num % 10;

    }
    else if (num < 100)
        num = -1;
    return num;
}
Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
int newNum = thirdNum(number);

if (newNum==-1)
Console.WriteLine("Третьей цифры нет в данном числе");
else 
Console.WriteLine($"Третья цифра заданного числа: {newNum}");

*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int day)
{
    bool result;
    if (day < 6) 
        result = false;
    else
        result = true;
    return result;
}

Console.Write("Напишите порядковый номер дня недели: ");
int NumOfday = Convert.ToInt32(Console.ReadLine());
bool days = Weekend(NumOfday);

if (days == true)
Console.WriteLine("Этот день явялеется выходным");
else 
Console.WriteLine("Этот будний день");
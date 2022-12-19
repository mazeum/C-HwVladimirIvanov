// ДЗ семинар 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
Console.WriteLine($"Наибольшее число {a}");
else 
Console.WriteLine($"Наибольшее число {b}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.



Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine()),
max = a;
if (b > max)
{
    max = b;
    if (c > max)
    {
        max = c;
        Console.WriteLine($"Максимальное число: {c}");
    }
    else
    Console.WriteLine($"Максимальное число: {b}");
}
else
{
    if (c > max)
    {
    max=c;
    Console.WriteLine($"Максимальное число: {c}");
    }
    else
    Console.WriteLine($"Максимальное число: {a}");  
}



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Write("Введите целое число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0)
Console.WriteLine($"Число {a} является четным");
else
Console.WriteLine($"Число {a} нечетное");



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Задайте конец диапазона для выявления четных чисел n:");
int n = Convert.ToInt32(Console.ReadLine()),
current = 0;
while (current < n)
{
    if (current % 2 == 0)
    {
        Console.Write($" {current} ");
    }
    else{};
  current++;   

}


*/
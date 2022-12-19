// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,

// является ли оно палиндромом.
/*

void pallindrom(int number)
{
    int temp = number;
    int backwords = 0;
    while (number > 0)
    {
        int end = number % 10;
        backwords = backwords * 10 + end;
        number = number / 10;
    }
    if (temp == backwords)
        Console.WriteLine($"Число {temp} - явлеется паллиндромом");
    else
        Console.WriteLine($"Число {temp} - НЕ паллиндром!");
}

Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
pallindrom(Num);

*/



// Задача 21 Напишите программу, которая принимает на вход 
// координаты двух точек и находит 
// расстояние между ними в 3D пространстве. 

/*


double Length(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}
Console.WriteLine("Введите координаты точки A (x,y,z):  ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());    
Console.WriteLine("Введите координаты точки B (x,y,z):  ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine()); 

double length = Length(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"Расстояние между точками: {length}");


*/


// Задача 23 Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

void Сube(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Сube(num);

Console.Clear();

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да

// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());


// int a = num / 10000;
// int b = num % 10000 / 1000;
// int d = num % 100 / 10;
// int e = num % 10;

// if (a == e && b == d)
// {
//     Console.WriteLine("Число является палиндромом.");
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом.");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// Console.WriteLine("Введите координаты X1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Z1");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// Console.WriteLine("Введите координаты X2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты Z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(y2 - y1,2));

// Console.WriteLine(distance);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=n; i++){
    Console.Write(i*i*i + ", ");
}
Console.WriteLine();

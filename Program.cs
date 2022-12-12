// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// // Task 19
// Console.WriteLine("Task 19");
// void testPalindrom(int chislo5)
// {
//     int[] mas=new int [5];
//     for (int i=0; i<5; i++)
//     {
//         mas[i]=chislo5%(10*(i+1));
//     }
//     for (int i=0; i<5; i++)
//     {
//         if (mas[i]==mas[4-i])
//         {
//             if (i==4)
//             {
//                 Console.WriteLine("Число является палиндромом");
//             }
//         } else
//         {
//             Console.WriteLine("Число не является палиндромом");
//             break;
//         }
//     }
// }
// Console.WriteLine("Введите пятизначное число: ");
// testPalindrom(int.Parse(Console.ReadLine()));

//Task 21
Console.WriteLine("Task 21");
double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double rezult=Math.Cbrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
 return rezult;
}

int enterData(string text)
{
    Console.Write(text);
    int number=int.Parse(Console.ReadLine());
    return number;
}
int x1 = enterData("Введите координаты первой точки x1: ");
int y1 = enterData("Введите координаты первой точки y1: ");
int z1 = enterData("Введите координаты первой точки z1: ");
int x2 = enterData("Введите координаты второй точки x2: ");
int y2 = enterData("Введите координаты второй точки y2: ");
int z2 = enterData("Введите координаты второй точки z2: ");

Console.WriteLine($"{distance(x1, y1, z1, x2, y2, z2)}");





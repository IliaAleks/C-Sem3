// Task 19
Console.WriteLine("Task 19");
void testPalindrom(string chislo5)
{
    for (int i=0; i<5; i++)
    {
        if (chislo5[i]==chislo5[4-i])
        {
            if (i==4)
            {
                Console.WriteLine("Число является палиндромом");
            }
        } else
        {
            Console.WriteLine("Число не является палиндромом");
            break;
        }
    }
}
Console.WriteLine("Введите пятизначное число: ");
testPalindrom((Console.ReadLine()));

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

//Task 23
Console.WriteLine("Task 23");
void tableKyb(int number)
{
for (int i=1; i<number+1; i++)
{
    Console.WriteLine($"{Math.Pow(i, 3)}");
}
}
Console.WriteLine("Введите число:");
tableKyb(int.Parse(Console.ReadLine()));
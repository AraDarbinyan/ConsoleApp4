// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Write tree-digit number:");
string num = Console.ReadLine();
int Num = Convert.ToInt32(num);

int firstnum = Num % 100;
int secondnum = firstnum / 10;
Console.WriteLine(secondnum);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)
Console.WriteLine("write any number");
string num1 = Console.ReadLine();
int Num1 = Convert.ToInt32(num1);
if (Num1 < 100) { Console.WriteLine("Error"); }
else { while (Num1 > 999) { Num1 = Num1 / 10; }
    Console.WriteLine(Num1 % 10);
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("input number 1 to 7 and you will get of week");

int day = Convert.ToInt32(Console.ReadLine());
if (day == 1); 
{
    Console.WriteLine("It is monday"); 
}
if (day == 2);
{ Console.WriteLine("It is tuesday"); }
if (day == 3) ;
{ Console.WriteLine("It is wednesday");  };
if (day == 4) ;
{ Console.WriteLine("It is thursday"); };
if (day == 5) ;
{ Console.WriteLine("It is fryday"); };
if (day == 6) ;
{ Console.WriteLine("It is saturday"); };
if (day == 7) ;
{ Console.WriteLine("It is sunday"); 
}; 


//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("input five digitl number");
int palindrom = Convert.ToInt32(Console.ReadLine());
int first = palindrom / 10000;
int second = (palindrom - first) / 1000;
int third = (palindrom - first - second) / 100;
int fourth = (palindrom - first - second - third) / 10;
int fifth = palindrom- first - second - third - fourth;
int ispalindrom = (10000 * fifth) + (1000 * fourth) + (100 * third) + (10 * second) + first;
if (ispalindrom == palindrom)
{
    Console.WriteLine("True");
}
else
{ Console.WriteLine("False"); };


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53
Console.WriteLine("input coordinates ax, ay, az, bx, by, bz");
double ax = Convert.ToDouble(Console.ReadLine());
double ay = Convert.ToDouble(Console.ReadLine());
double az = Convert.ToDouble(Console.ReadLine());
double bx = Convert.ToDouble(Console.ReadLine());
double by = Convert.ToDouble(Console.ReadLine());
double bz = Convert.ToDouble(Console.ReadLine());
double x = Math.Pow(bx - ax, 2);
double y = Math.Pow(by - ay, 2);
double z = Math.Pow(bz - bz, 2);
double res = Math.Sqrt(x + y + z);
Console.WriteLine(res);

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("input any number(N): ");
double N = Convert.ToDouble(Console.ReadLine());
double n = 1;
while (N >= n)
{
    double c = Math.Pow(n, 3);
    Console.WriteLine(c);
    n++;
}
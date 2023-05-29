// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int x = Prompt("Введите пятизначное число: ");
Polidrome(x);



int Prompt(string massage)
{
Console.WriteLine("Введит пятизначное число");
int num = int.Parse(Console.ReadLine());
return num;
}

void Polidrome(int X)
{ 
int x1 = x % 10;
int x2 = x / 10 % 10;
int x3 = x / 100 % 10;
int x4 = x / 1000 % 10;
int x5 = x / 10000 % 10;


if (x1 == x5 && x2 == x4)
{
    Console.WriteLine("Это число - полидром");
}
else
{
    Console.WriteLine("Это число - НЕ полидром");
}
}










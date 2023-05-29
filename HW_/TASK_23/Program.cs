// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine());
//     return num;

int num = Prompt ("Введите число: ");
int count = 1;
CubOfDigit(num);


int Prompt (string massage)
{
Console.Write(massage);
int number = int.Parse(Console.ReadLine());
return number;
}

void CubOfDigit(int number)
{
int count = 1;
while (count <= number)
{
    int cubnomber = count * count * count;
    Console.Write(cubnomber + " / ");
    count = count + 1;
}
}







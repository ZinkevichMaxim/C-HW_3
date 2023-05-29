// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = Promot ("Введите X-координаты точки А");
// int y1 = Promot ("Введите Y-координаты точки A");
// int z1 = Promot ("Введите Z-координаты точки А");
// int x2 = Promot ("Введите X-координаты точки B");
// int y2 = Promot ("Введите Y-координаты точки B");
// int z2 = Promot ("Введите Z-координаты точки B");


// double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

// Console.WriteLine(distance);

int x1 = Prompt ("Введите X-координаты первой точки");
int y1 = Prompt ("Введите Y-координаты первой точки");
int z1 = Prompt ("Введите Z-координаты первой точки");
int x2 = Prompt ("Введите X-координаты первой точки");
int y2 = Prompt ("Введите Y-координаты первой точки");
int z2 = Prompt ("Введите Z-координаты первой точки");

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine(distance);


int Prompt (string massage)
{
Console.WriteLine(massage);
int num = int.Parse(Console.ReadLine());
return num;
}

// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int z1 = int.Parse(Console.ReadLine());
// }

// void PromptB (string massage)
// {
// Console.WriteLine(massage);
// int x2 = int.Parse(Console.ReadLine());
// int y2 = int.Parse(Console.ReadLine());
// int z2 = int.Parse(Console.ReadLine());
// }

// double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
// Console.WriteLine(distance);








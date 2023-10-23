// Задача №17. Напишите программу, 
// // которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// // четверти плоскости, в которой находится эта точка.

Console.Write("Введите коорднаты  по оси ОХ");
int x = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Введите коорднаты  по оси ОY");
int y = Convert.ToInt32(Console.ReadLine()) ;

if (x > 0 && y > 0)
{
    Console.WriteLine("I четверть");
}else if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}
else if (x >0 && y < 0)
{
    Console.WriteLine("IV четверть");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("Начало коорлинат: (0,0)");
}
else
{
    Console.WriteLine("Точка лежит на оси. Одна из коорлинат");

}
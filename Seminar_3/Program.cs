// Задача №17. Напишите программу, 
// // которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// // четверти плоскости, в которой находится эта точка.

// Console.Write("Введите коорднаты  по оси ОХ");
// int x = Convert.ToInt32(Console.ReadLine()) ;

// Console.Write("Введите коорднаты  по оси ОY");
// int y = Convert.ToInt32(Console.ReadLine()) ;

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("I четверть");
// }else if (x < 0 && y > 0)
// {
//     Console.WriteLine("II четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("III четверть");
// }
// else if (x >0 && y < 0)
// {
//     Console.WriteLine("IV четверть");
// }
// else if (x == 0 && y == 0)
// {
//     Console.WriteLine("Начало коорлинат: (0,0)");
// }
// else
// {
//     Console.WriteLine("Точка лежит на оси. Одна из коорлинат");

// }



// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// x1 = 3, y1 = 6; x2 = 2, y2 = 1;
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Введите x1: ");
int x2= Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Введите y1: ");
int y2 = Convert.ToInt32(Console.ReadLine()) ;

// // d = distance (расстояние между 2 точками)
// // AB = √(x1 - x2)2 + (y1 + y2)2
// // Math.Sqrt(25) = 5  извлечение корня
// // Math.Pow(число, степень )=> Math.Pow(2, 3)=> 2*2*2 = 8
double d = Math.Sqrt ((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)));
// // Math.Round(число, кол-во знаков): Math.Round(1.275, 2)=> 1.27
 Console.Write($"d = {Math.Round(d, 2)}");
// // d до двух знаков после запятой









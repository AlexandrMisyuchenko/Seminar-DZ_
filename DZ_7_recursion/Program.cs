//Задача 64: Задайте значения M и N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"


// int ReadInt(string argument) 
// {
//     Console.Write(argument);
//     int a;
//     while (!int.TryParse(Console.ReadLine(), out a))
//     {
//         Console.WriteLine("НЕ является числом!");
//         Console.Write(argument);
//     }
//     return a;
// }
// string NumbersRec1(int M, int N)
// {
//     if (M < N + 1) return $"{M} " + NumbersRec1(M + 1, N);
//     else return String.Empty;
// }
// int M = ReadInt("Введите M: ");
// int N = ReadInt("Введите N: ");
// Console.WriteLine(NumbersRec1(M, N));

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// int ReadInt(string argument) 
// {
//     Console.Write(argument);
//     int a;
//     while (!int.TryParse(Console.ReadLine(), out a))
//     {
//         Console.WriteLine("НЕ является числом!");
//         Console.Write(argument);
//     }
//     return a;
// }
// int SumNumbers(int M, int N)
// {
//     if (N == M) return N;
//     else return N + SumNumbers(M, N - 1);
// }
// int M = ReadInt("Введите M: ");
// int N = ReadInt("Введите N: ");
// if (N < M)
// {
//     int temp = N;
//     N = M;
//     M = temp;
// }
// Console.WriteLine(SumNumbers(M, N));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

// int ReadInt(string argument) 
// {
//     Console.Write(argument);
//     int a;
//     while (!int.TryParse(Console.ReadLine(), out a))
//     {
//         Console.WriteLine("НЕ является числом!");
//         Console.Write(argument);
//     }
//     return a;
// }
// int Akkerman(int M, int N)
// {
//     if (M == 0) return N + 1;
//     else if (N == 0) return Akkerman(M - 1, 1);
//     else return Akkerman(M - 1, Akkerman(M, N - 1));
// }

// int M = ReadInt("Введите M: ");
// int N = ReadInt("Введите N: ");
// Console.WriteLine(Akkerman(M, N));


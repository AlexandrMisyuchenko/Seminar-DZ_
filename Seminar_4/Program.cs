

// !!!! Методы !!!!

// Методы можно повторно использрвать, просто поменяв данные;

// Метолы: которые возвращают значения и voitd
// тип_метоад ИмяМетода(параметр1, параметр2)
// Параметра: два числа и знак арифм. операции

int Calculate(int first, int second, char sign)
{
    if (sign == '+') // '' - это только для char
    {
        return first + second;
    }
    
     else if (sign == '-') // '' - это только для char
    {
        return first - second;
    }
     else if (sign == '*') // '' - это только для char
    {
        return first * second;
    }
    else if (sign == '/') // '' - это только для char
    {
        return first / second;
    }
   else // Другие "знаки": всеБ кроме "+", "-", "*";
   {
    Console.WriteLine("Ошибка при вводе знака");
    return 0;
   }

}

//Calculate(int first, int second, char sign)
// Используем метод - вызов
Console.WriteLine(Calculate(100, 5, '+'));
// first=2, second=5, char= +;
Console.WriteLine(Calculate(100, 35, '-'));
// first=2, second=5, char= +;
Console.WriteLine(Calculate(100, 35, '*'));
// first=2, second=5, char= +;
Console.WriteLine(Calculate(100, 25, '/'));
// first=2, second=5, char= +;



// остановился на 49 минуте

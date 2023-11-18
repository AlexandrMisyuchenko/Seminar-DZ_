// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
// min = -9, max = 9, массив на 12 элементов
// из промежутка [min,max]]

// int[] res = GetArry(12, -9, 9);
// Console.Write($"Массив искомый: [{String.Join(", ", res)}]");
// int[] GetArry(int size, int min, int max)
// {
//     int [] arry = new int[size];// Изначально массив из нулей
//     for(int i = 0; i< size; i++) // arry.Length
//     {
//         // min = -9, max = 9; max пишем как 9+1 либо цифрой 10ж
//         arry[i] = new Random().Next(min, max +1);
//     }
//     return arry;
// }
// vint[] result = GetSum(res);
// Console.Write($"Массив с суммами элементов {String.Join(", ", result)}");

// int[] GetSum(int[] arr) // arr массив в котором ищем значения
// {
//     int[] resSum = new int[2]; //resSum = [сум.пол, сум.отрц]
//     int positiveSum = 0; // сумма пол чисел
//     int negativSum = 0; // сумма отрц чисел

//     for(int i = 0; i < arr.Length; i++)
//     {
//         //Тернарный оператор 
//         positiveSum += arr[i] > 0 ? arr[i] : 0;
//         // positiveSum = positiveSum + (arr[i] или 0)
//         negativSum += arr[i] < 0  ? arr[i] : 0;
//         // negativSum = negativSum + (arr[i] или 0)
//     }
//     // resSum = [сум.пол, сум.отрц]
//     resSum[0] = positiveSum;
//     resSum[1] = negativSum;
//     return  resSum;
// }

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] res = GetArry(8, 0, 10);
Console.Write($"Массив искомый: [{String.Join(", ", res)}]");
int[] GetArry(int size, int min, int max)
{
    int [] array = new int[size];// Изначально массив из нулей
    for(int i = 0; i< size; i++) // arry.Length
    {
        // min = 0, max = 9; max пишем как 9+1 либо цифрой 10ж
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

bool FindElement (int[] array, int element)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == element)
        {
            return true; // true - элемент найден
        }
    }
    return false; // false - элемент не найден
}
if (FindElement(res, number)) // FindElement(res, number) == true
{
    Console.Write($"Элемент {number} присутствует в массиве");
}
else   // FindElement(res, number) == false
{
    Console.Write($"Элемент {number} отсутствует в массиве");
}
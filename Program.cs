﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] FillArrayWithRandom(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }

// int[] array = new int [5];
// FillArrayWithRandom(array);
// Console.Write("Ваш случайный массив: ");
// Console.Write(string.Join(", ", array));

// int sumPositive = 0;
// int sumNegative = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//     {
//         sumPositive+=array[i];
//     }
//     else
//     {
//         sumNegative+=array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}, а сумма положительных чисел = {sumPositive}");

// Задача 32: Напишите программу замены элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// int[] FillArrayWithRandom(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }
// int[] array = new int [5];
// FillArrayWithRandom(array);
// Console.Write("Ваш случайный массив: ");
// Console.Write(string.Join(", ", array));

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1; // -8 * -1 = +8; +1 * -1 = -1 это же гениально просто
// }
// Console.WriteLine();
// Console.Write(string.Join(", ", array));

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] FillArrayWithRandom(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(-9, 10);
// }
// return array;
// }

// int[] array = new int [5];
// FillArrayWithRandom(array);
// Console.Write("Ваш случайный массив: ");
// Console.Write(string.Join(", ", array));
// Console.WriteLine();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool isOk = false; // переменная bool выдает только true, false // тут мы сразу сказали, что начинаем с false
// for(int i = 0; i < array.Length; i++)
// {
// if(number == array[i]) // если число введенное с клавиатуры равно число [i] - элемента миссива
// {
// isOk = true; // тогда bool поменяет false на true
// break;
// } // можно не писать else, если он не нужен
// }
// if(isOk)
// {
// Console.Write("Элемент найден");
// }
// else
// {
// Console.Write("Элемент не найден");
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] FillArrayWithRandom(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(0, 200);
// }
// return array;
// }

// int[] array = new int [7];
// FillArrayWithRandom(array);
// Console.Write("Ваш случайный массив: ");
// Console.WriteLine(string.Join(", ", array));

// int count = 0; // ввести счетчик, чтоб его вывести
// for(int i = 0; i < array.Length; i++)
// {
// if(array[i] > 9 && array[i] < 100) // условие, значения которых лежат в отрезке [0 > 10,99 < 100]
// {
// count++;
// }
// }
// Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] FillArrayWithRandom(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(0, 10);
// }
// return array;
// }
// Console.Write("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine()); // вводим переменную длины
// int[] array = new int [length]; // создаем массив по введенной ранее длине
// FillArrayWithRandom(array); 
// Console.Write("Ваш случайный массив: ");
// Console.WriteLine(string.Join(", ", array));

// int newLength = array.Length/2 + array.Length%2; // создаем переменную, для длины нового массива *1
// // вычисляем ее так, чтобы можно было соединить попарно, где длина_массива/2 + остаток от длины_массива
// // newLenght = 5/2 + 5%2 = 2 + 1 = 3 и т.п.
// int[] newArray = new int [newLength]; // создаем новый массив с длиной полученной ранее по формуле
// for(int i = 0; i < array.Length / 2; i++) // т.к. при создании нового массива нам нужна лишь половина элементов
// // например [1,2,3,4,5] нам нужно перемножить [1*5,2*4,3] = [5,8,3] - половина элементов от исходного массива
// { 
// newArray[i] = array[i] * array[array.Length - 1 - i];
// // новый_массив[i элемента] = массив[i элемента] * массив[длину массива - 1 - счетчик]
// // данный трюк дает возможность перемножить первый и последний элемент массива
// // потом повторить цикл и перемножить второй и предпоследний элемент массива и т.д.
// }
// if(array.Length % 2 > 0) // выполнять условие if, только когда остаток от деления больше нуля
// // это фильтр четного кол-ва элементов массива от нечетного, ссылка на *1
// {
// newArray[newArray.Length - 1] = array[array.Length/2]; // вычисление для среднего элемента в НЕчетном случае
// // новый_массив[длина.нового_массива - 1] = (присвоить) исходный_массив[длина.исходного_массива / 2]
// // [5,8,_] станет [5,8,3]
// // новый_массив[3 - 1] = 2ой элемент = (присвоить) исходный_массив[5 / 2] это 2ой элемент исходного массива
// }
// Console.Write("Ваш получившийся массив: ");
// Console.WriteLine(string.Join(", ", newArray));

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// нужно проверить делится ли число на 2
// сделать счетчик в цикле, вывести число с счетчика

int[] FillRandMass(int[] mass)
{
for(int i = 0; i < mass.Length; i++)
{
mass[i] = new Random().Next(100, 1000); // положительные трёхзначные числа
}
return mass;
}

Console.Write("Введите размер массива: ");
int dlina = Convert.ToInt32(Console.ReadLine()); // вводим переменную длины
int[] mass = new int [dlina]; // создаем массив по введенной ранее длине
FillRandMass(mass); 
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", mass));
int count = 0; // отдельный счетчик
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0) // если остаток от деления равен 0
    {
        count++;
    }
}
Console.WriteLine("Количество четных элементов: " + count);

// Задача 36: Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Сделать цикл с обходом проверки на четность(начать с 1 и прибавлять по 2)

// Задача 38: Задайте массив вещественных(double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.7 7.2 2.1 7.8] -> 5.7 // вывод тоже вещественным числом
﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет:
// Пример: 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6:


Console.Write("Введите любое число: ");               // запрос ввода числа 
int num = Convert.ToInt32(Console.ReadLine());        // принимаем введенное число

if (num > 99)                                                      // проверяем введенное число на меньше чем 3 символа
{
    while (num / 1000 != 0)                                        // запуск условия цикла (если изменить на 100, то будем искать 2-у цифру, если делить на 10 - первую, и т.д.)
    {
        num = num / 10;                                            // если условие (10) верно, то делим num на 10 и переходим обратно к запуску цикла, т.е. убираем последнюю цифру с конца
    }
    Console.Write(num % 10 + " <- третья цифра нашего числа! ");   // если условие (10) не верно, то выводим на печать остаток от num деленного (%) на 10
}
else { Console.WriteLine(num + " - третьей цифры нет!"); }          // если проверка (8) не пройдена, то выводим на печать...
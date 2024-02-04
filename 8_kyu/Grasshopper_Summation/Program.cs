﻿/*Напишите программу, которая находит суммирование каждого числа от 1 до num. 
Число всегда будет положительным целым числом, большим 0. 
Вашей функции нужно только возвращать результат, то, что показано в скобках в примере ниже, - это то, 
как вы достигаете этого результата, и это не является его частью, смотрите Примеры тестов.

Для примера (Ввод -> Вывод):

2 -> 3 (1 + 2)
8 -> 36 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)*/

using System;

public static class Kata
{
    public static int summation(int num)
    {
        //Code here
        int sum = 0;
        for (int i = 1; i <= num; i++)
            sum += i; ;
        return sum;
    }
}
/*Создайте несколько функций, которые будут возвращать сумму, разность, модуль, произведение, частное и показатель степени соответственно.
Пожалуйста, используйте следующие названия функций:
* дополнение = Добавить
* умножать = Умножать
* разделение = Divide
* модуль = Mod
* экспоненциальный = Показатель степени
* вычитание = Подзаголовок
Примечание: Все функции могут возвращать значение int, и все они будут получать 2 целых числа.
Примечание: Все математические операции будут: a (операция) b */

using System;
public static class Kata
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }
    public static int Subt(int a, int b)
    {
        return a - b;
    }
    public static int Exponent(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }
    public static int Mod(int a, int b)
    {
        return a % b;
    }
}
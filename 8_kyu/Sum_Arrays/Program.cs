/* Напишите функцию, которая принимает массив чисел и возвращает сумму чисел. 
Числа могут быть отрицательными или нецелыми. Если массив не содержит никаких чисел, вы должны вернуть 0.

Примеры
Ввод: [1, 5.2, 4, 0, -1]
Вывод: 9.2

Ввод: []
Вывод: 0 */

public class Kata
{
  public static double SumArray(double[] array)
  {
    if (array.Length == 0) return 0;
  
    double summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
      summ += array[i];
    }
    return summ;
  }
}
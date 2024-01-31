/* Учитывая непустой массив целых чисел, верните результат умножения значений по порядку. 
Пример:
[1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24 */

public class Kata
{
  public static int Grow(int[] x)
  {
    int product = 1;
    for (int i = 0; i < x.Length; i++)
    {
      product *= x[i];
    }
    return product;
  }
}
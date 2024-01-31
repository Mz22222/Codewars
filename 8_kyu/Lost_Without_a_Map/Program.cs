/* Учитывая массив целых чисел, верните новый массив с удвоением каждого значения.
Например:
[1, 2, 3] --> [2, 4, 6] */

public class Kata
{
  public static int[] Maps(int[] x)
  {
    for (int i = 0; i < x.Length; i++)
    {
      x[i] *= 2 ;
    }
    return x;
  }
}
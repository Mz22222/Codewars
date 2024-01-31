/* Рассмотрим массив / список овец, в котором некоторые овцы могут отсутствовать на своем месте. Нам нужна функция, 
которая подсчитывает количество овец, присутствующих в массиве (true означает присутствует).
Например,
[true,  true,  true,  false,
  true,  true,  true,  true ,
  true,  false, true,  false,
  true,  false, false, true ,
  true,  true,  true,  true ,
  false, false, true,  true]  */

  public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int count = 0;
    for (int i = 0; i < sheeps.Length; i++)
    {
      if (sheeps[i])
      {
        count++;
      }
    }
    return count;
  }
}
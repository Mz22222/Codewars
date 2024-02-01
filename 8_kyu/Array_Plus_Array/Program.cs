/* Я новичок в программировании и теперь хочу получить сумму двух массивов... Фактически сумму всех их элементов. 
Буду признателен за вашу помощь.
P.S. Каждый массив содержит только целые числа. Выходные данные тоже представляют собой число. */
public static class Kata
{
    public static int ArrayPlusArray(int[] arr1, int[] arr2)
    {
        int sum1 = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            sum1 += arr1[i];
        }
        int sum2 = 0;
        for (int j = 0; j < arr2.Length; j++)
        {
            sum2 += arr2[j];
        }
        return sum1 + sum2;
    }
}
/*
 * 
 * Написать метод, который выводит сумму элементов при помощи рекурсии
 */
using System;

class Program
{
    static void SumAllElements(int[] Array, ref int i, ref int result)
    {
        
        result += Array[i];
        
        i++;

        if(i == Array.Length)
        {
            Console.WriteLine(result);
            return;
        }

        SumAllElements(Array, ref i, ref result);
    }

    static void Main(string[] args)
    {
        int result = 0;
        int i = 0;
        int[] Array = new int[] { 1, 2, 3, 4, 5 };

        SumAllElements(Array, ref i, ref result);
    }
}

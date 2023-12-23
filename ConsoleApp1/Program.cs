
using System;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumList = 0;
            int[] myList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Tong cua mang la");
            for (int i = 0; i <= myList.Length-1; i++) //for(int i = 0; i < myList.Length; i++)
            {
                sumList += myList[i];
            }
            Console.WriteLine(sumList);
            Console.ReadKey();
        }
    }
}
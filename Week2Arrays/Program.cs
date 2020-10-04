using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in array1)
            {
                Console.WriteLine(number);
            }

            int[] array2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array2[i] = i + 1;
            }

            int[] array3 = new int[10];

            for (int i = 0; i < array3.Length; i++)
            {
                array3[0] = i + 1;
            }

            foreach (int number in array3)
            {
                Console.WriteLine($"array3: {number}");
            }

            int[] array4 = new int[10];
            for (int i = array4.Length - 1, j = 0; i >= 0; i--, j++)
            {
                array4[j] = i;
            }
            foreach (int num in array4)
            {
                Console.WriteLine(num);
            }

            int[] array5 = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array5.Length; i++)
            {
                array5[i] = rnd.Next(1, 101);
            }

            foreach (int num in array5)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}

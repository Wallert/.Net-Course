using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1Task
            /*
            int[] array = new int[] { 10, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int Min = array[0]; int k = 0;
            foreach (var arr in array)
            {
                if (Min > arr)
                {
                    Min = arr;
                }
            }
            foreach (var arr in array)
            {
                if (Min + 5 <= arr)
                {
                    k++;
                }
            }
            Console.WriteLine($"Min:{Min} Quantity:{k}");
            */
            #endregion

            #region 2Task
            /*
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5, 11, 12, 13 };
            Array.Sort(array);
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]==array[i-1])
                {
                    Console.WriteLine("Array have same elements");
                    goto End;
                }   
            }
            Console.WriteLine("Array have not any same elements");
        End:;
            */
            #endregion

            #region 3TaskNotWorking
            /*
            Console.WriteLine("Enter a num of numbers");
            int num =Int32.Parse(Console.ReadLine());
            int[] array = new int[num];
            Random rand = new Random();
            int needed = 0;
            for (int i = 0; i < num; i++)
            {
                array[i] =rand.Next(10);                
            }
            Array.Sort(array);
            Console.WriteLine("Random array:");
            foreach (var item in array)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("Longest sequense of numbers:");
            for (int i = 1; i < num; i++)
            {
                if (array[i-1]+1==array[i])
                {
                    Console.WriteLine($"{array[i-1]}");
                    needed++;
                }
            }
            //Console.WriteLine(array[needed]);*/
            #endregion

            #region 4Task
            /*
            Console.Write("Enter a num of numbers:");
            int num =Int32.Parse(Console.ReadLine());
            int[] array = new int[num];
            Random rand = new Random();
            int avg = 0, iter = 0;
            for (int i = 0; i < num; i++)
            {
                array[i] =rand.Next(1,20);
                if (array[i]%2==0 && i%2!=0)
                {
                    avg += array[i];
                    iter++;
                }
            }            
            Console.WriteLine("Array:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"arr[{i}]={array[i]}");
            }
            if (iter>0)
            {
                Console.WriteLine($"Average value:{avg / iter}");
            }
            else Console.WriteLine("Unluck");
            */
            #endregion

            #region 5TaskNotComplete
            /*
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] array2 = new int[] { 20, 21, 22, 23};
            array2.CopyTo(array1, 2);            
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region 6Task
            /*
            const int N = 15;           
            int[] array = new int[N] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            int K = 4, L=13, Kindex=0, Lindex=0;
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==K)
                {
                    Kindex = i;
                }
                if (array[i] == L)
                {
                    Lindex = i;
                }
            }
            for (int i=Kindex+1; i <= Lindex; i++)
            {
                avg += array[i];
            }
            Console.WriteLine($"AVG: {avg/(Lindex-Kindex)}");
            */
            #endregion

            #region 7Task
            /*
            Random rand = new Random();
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(10, 30);
                arr2[i] = rand.Next(10, 30);
                arr3[i] = arr1[i] + arr2[i];
            }
            double avg = 0;
            int min = arr3[0], max = arr3[0];
            foreach (var item in arr3)
            {
                avg += item;
                if (min > item) min = item;
                if (max < item) max = item;
            }
            Console.WriteLine($"AVG: {avg / arr3.Length} Min: {min} Max: {max}");
            */
            #endregion
        }
    }
}

using System;

namespace QuickSortRunTimeFunc
{
    internal class Program
    {
        static int q = 0;
        static void quick_sort(int[] dizi, int p, int r)
        {
            if (p < r)
            {
                partition(dizi, p, r);
                quick_sort(dizi, p, q);
                quick_sort(dizi, q + 1, r);
            }
        }

        static void partition(int[] dizi, int p, int r)
        {
            int x = dizi[p];
            int i = p - 1;
            int j = r + 1;
            while (true)
            {
                do
                {
                    j--;
                }
                while (dizi[j] > x);

                do
                {
                    i++;
                }
                while (dizi[i] < x);

                if (i < j)
                {
                    int gecici = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = gecici;
                }
                else
                {
                    q = j;
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            /*Quick Sort Kullanımı*/
            int[] dizi = { 12, 3, 8, 5, 15, 12, 45, 31 };
            quick_sort(dizi, 0, dizi.Length - 1);
            Console.WriteLine("Hello World!");
        }
    }
}

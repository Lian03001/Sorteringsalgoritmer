using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Random random = new Random();
            int[] tallista = new int[100000];
            for (int i = 0; i < tallista.Length; i++)
            {
                tallista[i] = random.Next(1, 10000);
            }

            stopWatch.Start();
            SortArray(tallista);
            stopWatch.Stop();

            foreach (var number in tallista)
                Console.WriteLine(number);

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("hej");
        }

        private static void SortArray(int[] numbers)
        {
            Quicksort(numbers, 0, numbers.Length - 1);
        }

        private static void Quicksort(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i] < pivot)
                    i++;

                while (numbers[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                Quicksort(numbers, left, j);

            if (i < right)
                Quicksort(numbers, i, right);
        }
    }
}
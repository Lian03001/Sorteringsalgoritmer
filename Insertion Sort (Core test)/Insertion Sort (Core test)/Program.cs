using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Insertion_Sort
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
            Insertionsort(tallista);
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

        private static void Insertionsort(int[] minlista)
        {
            for (int i = 0; i < minlista.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (minlista[j - 1] > minlista[j])
                    {
                        int temp = minlista[j - 1];
                        minlista[j - 1] = minlista[j];
                        minlista[j] = temp;
                    }
                }
            }
        }
    }
}
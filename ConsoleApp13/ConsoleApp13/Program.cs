using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp13
{
    class Program
    {
        static void Bubblesort(List<int> minLista)
        {
            for(int i = 0; i < minLista.Count; i++)
            {
                for(int j = 0; j < minLista.Count - 1 - i; j++)
                {
                    if (minLista[j] > minLista[j + 1])
                    {
                        int temp = minLista[j];
                        minLista[j] = minLista[j + 1];
                        minLista[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            var random = new Random();
            var tallista = new List<int>();
            for (int x = 0; x < 50000; x++)
            {
                tallista.Add(random.Next(50000));
            }

            stopWatch.Start();
            Bubblesort(tallista);
            stopWatch.Stop();

            foreach (int i in tallista)
                Console.WriteLine(i);

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

        }
    }
}

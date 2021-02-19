using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MergeSort
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            var tallista = new int[100000000];
            var random = new Random();

            for (int i = 0; i < tallista.Length; i++)
            {
                tallista[i] = random.Next(100);
            }

            //Console.WriteLine("osorterad data");
            //DisplayArray(tallista);

            stopWatch.Start();
            MergeSort(tallista);
            stopWatch.Stop();

            //Console.WriteLine("sorterad data");
            //DisplayArray(tallista);

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        private static void MergeSort(Span<int> tallista)
        {
            var center = tallista.Length / 2;

            if (tallista.Length > 1)
            {
                MergeSort(tallista.Slice(0, center));
                MergeSort(tallista.Slice(center));
                Merge(tallista, center);
            }
        }

        private static void Merge(Span<int> result, int startOfRightHalf)
        {
            //0...StartOfRightHalf
            //startOfRightHalf..unsorted.length

            var tallista = result.ToArray();
            var lhs = 0;
            var rhs = startOfRightHalf;
            var offset = 0;

            while (lhs < startOfRightHalf && rhs < tallista.Length)
            {

                if (tallista[lhs] <= tallista[rhs])
                {
                    result[offset] = tallista[lhs];
                    lhs++;
                }
                else
                {
                    result[offset] = tallista[rhs];
                    rhs++;
                }
                offset++;
            }

            while (lhs < startOfRightHalf)
            {
                result[offset] = tallista[lhs];
                lhs++;
                offset++;
            }

            while (rhs < tallista.Length)
            {
                result[offset] = tallista[rhs];
                rhs++;
                offset++;
            }
        }

        private static void DisplayArray(int[] tallista)
        {
            var text = string.Join(",", tallista);
            Console.WriteLine(text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var tallista = new int[16];
            var random = new Random();

            for (int i = 0; i < tallista.Length; i++)
            {
                tallista[i] = random.Next(10000);
            }
            
            Console.WriteLine("osorterad data");
            DisplayArray(tallista);

            MergeSort(tallista);

        }

        private static void MergeSort(Span<int> tallista)
        {
            var center = tallista.Length / 2;

            if (tallista.Length > 1)
            {
                MergeSort(tallista.Slice(0, center));
                MergeSort(tallista.Slice(center));
                MergeSort(tallista, center);
            }
        }

        private static void DisplayArray(int[] tallista)
        {
            var text = string.Join(",", tallista);
            Console.WriteLine(text);
        }
    }
}

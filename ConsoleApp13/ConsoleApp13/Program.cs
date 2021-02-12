using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var random = new Random();
            var tallista = new List<int>();
            for (int x = 0; x < 10000; x++)
            {
                tallista.Add(random.Next(10000));
            }

            Bubblesort(tallista);

            foreach (int i in tallista)
                Console.WriteLine(i);

        }
    }
}

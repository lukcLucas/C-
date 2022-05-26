using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.AlgoritmoDeOrdenacao
{
    /*
     * 
    Ordenação por inserção
        Insertion Sort
        Shell Sort
    Ordenação por seleção
        Selection Sort
        HeapSort
    Ordenação por troca
        Bubble sort
        Cocktail sort
        Comb sort
        Gnome sort
        Odd-even sort
        Quicksort

      
     */
    class Orden
    {
        
     static void Main(string[] args)
        {
            int[] numeros = { 230, 45, 345, 14, 324, 90, 76, 34, 67, 3 };
            Console.WriteLine("######## Ordenação com Selecion Sort ########\n");
            Console.WriteLine("Array original\n");

            foreach (int numero in numeros)
                Console.Write($"{numero} ");

            Console.WriteLine("\n\nOrdenando o array usando Selection Short\n");

            int[] arrayOrdenado = IntArraySelectionSort(numeros);

            Console.WriteLine("Array Ordenado\n");

            foreach (int numero in arrayOrdenado)
                Console.Write($"{numero} ");

            Console.ReadLine();
        }

        public static int[] IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    TrocarValores(data, i, k);
            }
            return data;
        }

        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;

            for (int pos = start + 1; pos < data.Length; pos++)
            {
                if (data[pos] < data[minPos])
                    minPos = pos;
            }

            return minPos;
        }

        public static int[] TrocarValores(int[] arrayDados, int m, int n)
        {
            int temp;
            temp = arrayDados[m];
            arrayDados[m] = arrayDados[n];
            arrayDados[n] = temp;
            return arrayDados;
        }
    }
 }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_Tablic
{
    public class BubbleSort
    {
        // Przykładowy kod, który muszę jeszcze przeanalizować 
        public static void bubbleSort(int[] arr, int n)
        {
            int i, j, current;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        current = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = current;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }

        public static void print(int[] arr, int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

        Conosle.wwwww  // Edycja Bartek
        }

    }
}

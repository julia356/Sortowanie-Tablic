using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_Tablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tablica losowych wartości
                int n;                                                                         // tworzymy zmienną, która posłuży nam jako parametr do wypisania tablicy o długości ustalonej przez użytkownika
                do                                                                             // funkcja zabezpieczająca przed wpisaniem nieporządanego symbolu ( liczby ujemne jak i litery)
                {
                    Console.WriteLine("----------------------------------------- ");           // dopóki symbolem nie będzie liczba większa/równa 0 program będzie stale 
                    Console.WriteLine("Podaj maksymalną długość tablicy (3-200): ");           // powatarzać sekfencję wypisania poprawnej długości tablicy
                    Console.WriteLine("----------------------------------------- ");


                } while (!int.TryParse(Console.ReadLine(), out n) || n <= 3 && n >= 200);

                Console.WriteLine(" ");                                     // estetyczne oddzielenie tesktu :)

                int[] arr = new int[n];                                     // tworzymy tablicę o klasie int

                Random random = new Random();                               // definiujemy funkcje "Random" do wypisania losowych liczb w tablicy

                for (int i = 0; i < arr.Length; i++)                        // funkcja pozwalająca na wykonanie wielokrotnego wypisania instrukcji zgodnie z warunkiem
                    arr[i] = random.Next(1, 1000);                          // ustawienie zakresu losowania cyfr w danej tablicy

                Console.WriteLine("---------------------- ");
                Console.WriteLine("Tablica o długości: " + n);
                Console.WriteLine("---------------------- ");
                Console.WriteLine(" ");

                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");                              // wypisanie tablicy
                Console.WriteLine("\n");


            // Sortowanie bombelkowe
            BubbleSort.bubbleSort(arr, n);
            Console.WriteLine("------------- ");
            Console.WriteLine("Sorted array:");
            Console.WriteLine("------------- " + "\n");
            BubbleSort.print(arr, n);
            Console.WriteLine("\n");
        }
    }
}

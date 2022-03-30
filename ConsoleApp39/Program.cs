using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile chcesz wpisać liczb?");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] numbers = new int[rozmiar];
            for (int i = 0; i < numbers.Length; i++) //petla zapelniająca tablice liczbami
            {
                Console.WriteLine("Podaj {0} liczbę", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elementy tablicy to:");
            for (int i = 0; i < numbers.Length; i++) // petla wypisujaca elementy tablicy
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

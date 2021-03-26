using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendixBoek
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> getallenStack = new Stack<int>();
            getallenStack.Push(1);
            getallenStack.Push(2);
            getallenStack.Push(3);
            getallenStack.Push(4);
            getallenStack.Push(5);

            getallenStack.Pop();

            foreach (var item in getallenStack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


            Queue<int> getallenQueue = new Queue<int>();
            getallenQueue.Enqueue(1);
            getallenQueue.Enqueue(2);
            getallenQueue.Enqueue(3);
            getallenQueue.Enqueue(4);
            getallenQueue.Enqueue(5);

            getallenQueue.Dequeue();
            getallenQueue.Dequeue();

            foreach (var item in getallenQueue)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();

            Location<int> location = new Location<int>();
            location.X = 5;

            Console.WriteLine(ReturnValue("Geert"));

            DataBewaarder<string, int> data1 = new DataBewaarder<string, int>("Grootte klas", 10);
            DataBewaarder<double, bool> data2 = new DataBewaarder<double, bool>(3.5, true);

            Console.ReadLine();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            Console.WriteLine(location.X);

            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            double[] dblArray = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] strArray = new string[] { "1.", "2.", "3." };
            ToonArray(intArray);
            ToonArray(dblArray);
            ToonArray(strArray);

            if (true)
                Console.WriteLine("Hello world");
            else
                Console.WriteLine("Hi");


            ToonGeboortejaar(1996);
            Console.WriteLine(Maal(5, 6));
            Console.ReadLine();

            int getal1 = 5;
            int getal2 = 6;

            Console.WriteLine(getal1 + getal2);

            Kassa kassa1 = new Kassa() { Bouwjaar = 2002, Totaal = 1500 };
            Kassa kassa2 = new Kassa() { Bouwjaar = 2005, Totaal = 1800 };

            Kassa opgeteld = kassa1 + kassa2;
            Kassa aftrekken = kassa1 - kassa2;
            Kassa maal = kassa1 * kassa2;

            Console.WriteLine($"{opgeteld.Totaal} - {opgeteld.Bouwjaar}");
            Console.WriteLine($"{aftrekken.Totaal} - {aftrekken.Bouwjaar}");
            Console.WriteLine($"{maal.Totaal} - {maal.Bouwjaar}");
            Console.ReadLine();
        }

        static void ToonGeboortejaar(int jaar) => Console.WriteLine($"Jouw geboortejaar is {jaar}.");
        static int Maal(int a, int b) => a * b;

        static void ToonArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static T ReturnValue<T>(T value)
        {
            return value;
        }
    }
}

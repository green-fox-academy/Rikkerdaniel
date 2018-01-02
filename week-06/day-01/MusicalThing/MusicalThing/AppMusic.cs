using System;
using MusicalThing;

namespace Musical
{
    public class AppMusic
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test 1, create Electric Guitar, Bass Guitar and Violin with default strings.");
            var guitar = new ElectricGuitar();
            var bassGuitar = new BassGuitar();
            var violin = new Violin();

            Console.WriteLine("Test 1 Play");
            guitar.Play();
            Console.Beep(659, 325); Console.Beep(659, 325); Console.Beep(659, 325);
            bassGuitar.Play();
            Console.Beep(584, 525);
            violin.Play();
            Console.Beep(784, 125); Console.Beep(784, 125);

            Console.WriteLine("Test 2, create Electric Guitar, Bass Guitar with 7 and 5 strings .");
            ElectricGuitar guitar2 = new ElectricGuitar(7);
            BassGuitar bassGuitar2 = new BassGuitar(5);
            Console.WriteLine("Test 2 Play");
            guitar2.Play();
            bassGuitar2.Play();
            Console.ReadKey();
        }

    }
}
using System;

namespace GreatingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            Greet(al );
            Console.ReadKey();


        }
        static void  Greet(string al)
        {
            Console.WriteLine("Greetings dear ,"+ al +"!");
        }
    }
}

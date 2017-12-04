using System;

namespace ZeroException
{
    class Program
    {
        static void Div()
        {
            Console.WriteLine("Gimme that number");

            int b = 10;
            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(b / a);

            }
            catch (Exception)
            {

                Console.WriteLine("dont try to devigne with 0 ");
            }
        }
        static void Main(string[] args)
        {
            Div();
            Console.ReadLine();

        }
    }
}

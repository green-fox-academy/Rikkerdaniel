using System;

namespace TodoText
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            todoText = todoText.Insert(0, "My todo:\n");
            todoText = todoText.Insert(todoText.LastIndexOf("\n"), "\n - Download games");
            todoText = todoText.Insert(todoText.LastIndexOf("\n"), "\n   - Diablo");
            Console.WriteLine(todoText);
            Console.ReadKey();
        }
    }
}

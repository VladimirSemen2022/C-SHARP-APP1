using System;

namespace C_SHARP_APP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            for (int c = 0; c < name.Length; c++)
                Console.WriteLine(name[c]);
        }
    }
}

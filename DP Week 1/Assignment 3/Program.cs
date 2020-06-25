using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            string input = "";
            PencilSharpener sharpener = new PencilSharpener();
            Pencil pencil = new Pencil(10);
            do
            {
                Console.Write("Enter a word: ");
                input = Console.ReadLine();

                if (input == "sharpen")
                {
                    sharpener.Sharpen(pencil);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sharpening the pencil");
                    Console.ResetColor();
                }
                else if (input == "stop")
                {
                    Console.WriteLine();
                    Console.WriteLine("End of Program...");
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                pencil.Write(input);
                Console.ResetColor();
                Console.WriteLine();

            } while (input != "stop");
            Console.ReadKey();
        }
    }
}

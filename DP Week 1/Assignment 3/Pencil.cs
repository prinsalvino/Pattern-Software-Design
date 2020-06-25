using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Pencil : IPencil
    {
        private int maxToWrite; // number of characters to write with a sharpened pencil
        private int nrOfCharsWritten; // number of written characters
        public Pencil(int maxtowrite)
        {
            maxToWrite = maxtowrite;
        }
        public bool CanWrite
        {
            get
            {
                return (nrOfCharsWritten < maxToWrite);
            }
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }

        public void Write(string message)
        {
            foreach (char letter in message)
            {
                if (CanWrite)
                {
                    Console.Write(letter);
                }
                else
                {
                    Console.Write("#");
                }
                nrOfCharsWritten++;
            }
        }
    }
}

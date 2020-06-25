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
            // create an MP3 player
            ISubject mp3player = new MP3Player();
            
            // create the displays
            IObserver mp3Display1 = new SimpleMP3Display(mp3player);
            IObserver mp3Display2 = new FancyMP3Display(mp3player);
           
            // change song a few times           
            // (since there is no hardware, we do it hardcoded here...)
            mp3player.NextSong();
            mp3player.NextSong();
            mp3player.NextSong();
            Console.ReadKey();
        }
    }
}

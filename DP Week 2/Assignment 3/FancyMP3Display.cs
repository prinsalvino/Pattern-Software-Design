using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class FancyMP3Display : IObserver
    {
        private ISubject mp3Player;
        public FancyMP3Display(ISubject subject)
        {
            mp3Player = subject;
            mp3Player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"Fancy Display: '{song.title}' by {song.artist} ({song.duration})");
        }
    }
}

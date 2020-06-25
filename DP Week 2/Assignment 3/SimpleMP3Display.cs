using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class SimpleMP3Display : IObserver
    {
        private ISubject Mp3Player;
        public SimpleMP3Display(ISubject subject)
        {
            Mp3Player = subject;
            Mp3Player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"Simple Display: {song.artist} - '{song.title}'");
        }
    }
}

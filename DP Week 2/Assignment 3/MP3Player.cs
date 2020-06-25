using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class MP3Player : ISubject
    {
        public Song CurrentSong { get; private set; }
        List<Song> songs;
        List<IObserver> mp3displays = new List<IObserver>();
        Random rnd;
        public MP3Player()
        {
            songs = new List<Song>();
            AddSong();
            rnd = new Random();
        }

        public void AddObserver(IObserver observer)
        {
            mp3displays.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            mp3displays.Remove(observer);
        }

        private void AddSong()
        {
            Song song1 = new Song("Wish You Were Here", "Pink Floyd", "03:12");
            Song song2 = new Song("Billionaire", "Bruno Mars", "03:33");
            Song song3 = new Song("Dazed and Confused", "Led Zeppelin", "04:00");
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);

        }

        public void NextSong()
        {
            int index = rnd.Next(songs.Count);
            CurrentSong = songs[index];
            NotifyObserver();       
        }
        public void NotifyObserver()
        {
            foreach (IObserver item in mp3displays)
            {
                item.Update(CurrentSong);
            }
        }

    }
}

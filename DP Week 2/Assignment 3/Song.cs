using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Song
    {      
        public string title { get; set; }
        public string artist { get; set; }
        public string duration { get; set; }
        public Song(string title, string artist, string duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
        }
    }
}

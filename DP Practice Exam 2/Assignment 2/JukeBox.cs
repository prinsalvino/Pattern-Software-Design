using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class JukeBox
    {
        public List<IVinylSingle> Singles { get; set; }
        public IVinylSingle Currentsingle { get; set; }
        public JukeBox(List<IVinylSingle> singles)
        {
            this.Singles = singles;
        }
        public void Play()
        {
            Currentsingle.Play();
        }
        public void SelectSingle(int index)
        {
            Currentsingle = Singles[index];
        }
        public void Stop()
        {
            Currentsingle.Stop();
        }
        public void AddAlbum(List<IVinylSingle> Album)
        {
            foreach (IVinylSingle single in Album)
            {
                Singles.Add(single);
            }        
        }
    }
}

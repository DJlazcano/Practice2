using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.MusicVideoI
{
    public class MusicPlayer : IPlayable
    {
        bool isPlaying;
        public void Play()
        {
            Console.WriteLine("Music is Playing...\n");
            isPlaying = true;
        }

        public void Pause()
        {
            Console.WriteLine("Music is Paused...\n");
            isPlaying = false;
        }
    }
}

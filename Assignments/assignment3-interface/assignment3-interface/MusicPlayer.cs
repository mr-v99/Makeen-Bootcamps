using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_interface
{
    internal class MusicPlayer:Playable
    {
        public string Play() {
            return "the music is now playing";
        }

        public string Stop()
        {
            return "the music stopped";
        }


    }
}

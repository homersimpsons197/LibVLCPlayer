using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerFF.Controller
{
    public class PlayerController
    {
        LibVLC lib;
        MediaPlayer mp;
        public PlayerController(LibVLC lib, MediaPlayer mp) 
        {
            this.lib = lib;
            this.mp = mp;
        }

        public void Play(string filename)
        {
            var media = new Media(lib, new Uri(filename));
            mp.Play(media);
        }

        public void Pause()
        {
            mp.Pause();
        }

        public void Stop()
        {
            mp.Stop();
        }
    }
}

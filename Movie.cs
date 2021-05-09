using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Movie : Media
    {
        public double RunTime { get; private set; }

        public Movie(string mediaTitle, MediaType mediaType, double runTime) : base(mediaTitle, mediaType)
        {
            RunTime = runTime;
        }

        public override string MediaInfo()
        {
            return "Movie Details:\n" + base.MediaInfo() + "Run Time -> " + RunTime + " Hours";
        }
    }
}

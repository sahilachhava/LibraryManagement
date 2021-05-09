using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Book : Media
    {
        public int PageCount { get; private set; }

        public Book(string mediaTitle, MediaType mediaType, int pageCount) : base(mediaTitle, mediaType)
        {
            PageCount = pageCount;
        }

        public override string MediaInfo()
        {
            return "Book Details:\n" + base.MediaInfo() + "Page Count -> " + PageCount;
        }
    }
}

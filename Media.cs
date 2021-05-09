using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    public enum MediaType { Book, Magazine, Movie }
    public abstract class Media
    {
        public string MediaTitle { get; set; }
        public MediaType MediaType { get; set; }
        public int SerialNo { get; private set; }
        public int NoOfTimeLent { get; set; }
        public bool IsBorrowed { get; set; }
        public string CurrentBorrower { get; set; }

        public Media(string mediaTitle, MediaType mediaType)
        {
            MediaTitle = mediaTitle;
            MediaType = mediaType;
            SerialNo = Library.uniqueSerialNumber + 1001;
            NoOfTimeLent = 0;
            IsBorrowed = false;
            CurrentBorrower = null;

            Library.uniqueSerialNumber++;
        }

        public virtual string MediaInfo()
        {
            string info = "Serial No -> " + SerialNo + "\n";
            info += "Media Title -> " + MediaTitle + "\n";
            info += "Media Type -> " + MediaType + "\n";
            info += "No. Of. Lents -> " + NoOfTimeLent + "\n";
            info += "Is Borrowed -> " + IsBorrowed + "\n";
            if(IsBorrowed)
                info += "Current Borrower -> " + CurrentBorrower + "\n";

            return info;
        }
    }
}

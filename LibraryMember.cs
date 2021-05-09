using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class LibraryMember
    {
        public int MemberID { get; private set; }
        public string MemberName { get; set; }
        public List<Media> borrowHistory = new List<Media>();
        public List<Media> currentlyBorrowed = new List<Media>();

        public LibraryMember(string memberName)
        {
            MemberID = Library.uniqueMemberID + 1001;
            MemberName = memberName;

            Library.uniqueMemberID++;
        }

        public string MemberInfo()
        {
            string info = "Member Details:\n";
            info += "Member ID -> " + MemberID + "\n";
            info += "Member Name -> " + MemberName + "\n";

            if(currentlyBorrowed.Count != 0)
            {
                info += "\nCurrently Borrowed Media:\n\n";
                foreach (Media media in currentlyBorrowed)
                {
                    info += "Media Title -> " + media.MediaTitle + "\n";
                }
            }

            if(borrowHistory.Count != 0)
            {
                info += "\nMedia Borrow History:\n\n";
                foreach (Media media in borrowHistory)
                {
                    info += "Media Title -> " + media.MediaTitle + "\n";
                }
            }

            return info;
        }
    }
}

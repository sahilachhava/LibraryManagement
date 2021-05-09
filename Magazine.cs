using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Magazine : Book
    {
        public int IssueNumber { get; private set; }

        public Magazine(string mediaTitle, MediaType mediaType, int pageCount, int issueNo) : base(mediaTitle, mediaType, pageCount)
        {
            IssueNumber = issueNo;
        }

        public override string MediaInfo()
        {
            return "Magazine Details:\n" + base.MediaInfo() + "\nIssue No -> " + IssueNumber;
        }
    }
}

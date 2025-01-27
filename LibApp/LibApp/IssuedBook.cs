using System;

namespace LibApp
{
    public class IssuedBook
    {
        public string BookTitle { get; set; }
        public string ReaderFIO { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; } 
    }
}

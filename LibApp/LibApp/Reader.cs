using System;
using System.Collections.Generic;

namespace LibApp
{
    public class Reader
    {
        public string FIO { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string TicketNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Education { get; set; }
        public string HallName { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}

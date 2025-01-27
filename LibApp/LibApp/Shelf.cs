using System.Collections.Generic;

namespace LibApp
{
    public class Shelf
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int CurrentBooks { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}

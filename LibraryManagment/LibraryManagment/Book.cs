// Book.cs
namespace LibraryManagement.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Code { get; set; }
        public int Copies { get; set; }
    }
}
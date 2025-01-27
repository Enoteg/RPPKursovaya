// ReaderService.cs
using System.Collections.Generic;
using LibraryManagment.Models;

namespace LibraryManagement.Services
{
    public class ReaderService
    {
        private readonly List<Reader> _readers;

        public ReaderService()
        {
            _readers = new List<Reader>();
        }

        public void AddReader(Reader reader)
        {
            _readers.Add(reader);
        }
    }
}

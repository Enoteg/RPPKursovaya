using LibApp;
using System.Collections.Generic;
using System.Linq;

public class Hall
{
    public string Name { get; set; }
    public string LibraryName { get; set; }
    public string Specialization { get; set; }
    public int Capacity { get; set; }
    public int OccupiedSeats { get; set; }
    public List<Reader> Readers { get; set; } = new List<Reader>();

    public void AddReader(Reader reader)
    {
        if (Readers.All(r => r.TicketNumber != reader.TicketNumber))
        {
            Readers.Add(reader);
            OccupiedSeats++;
        }
    }

    public void RemoveReader(Reader reader)
    {
        int removedCount = Readers.RemoveAll(r => r.TicketNumber == reader.TicketNumber);

        if (removedCount > 0)
        {
            OccupiedSeats -= removedCount;
        }
    }
}

// RoomService.cs
using System.Collections.Generic;
using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public class RoomService
    {
        private readonly List<Room> _rooms;

        public RoomService()
        {
            _rooms = new List<Room>
            {
                new Room { Name = "Общий зал", Specialization = "Общий", Capacity = 50 },
                new Room { Name = "Физико-Математический зал", Specialization = "Физика и Математика", Capacity = 30 }
            };
        }

        public List<Room> GetAllRooms()
        {
            return _rooms;
        }
    }
}
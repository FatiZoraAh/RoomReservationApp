using System;

namespace RoomReservationApp
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
    }
}
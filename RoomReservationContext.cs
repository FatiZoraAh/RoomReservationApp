using System.Data.Entity;

namespace RoomReservationApp.Models
{
    public class RoomReservationContext : DbContext
    {
        public RoomReservationContext() : base("RoomContext")
        {
        }
        public DbSet<Room> Rooms { get; set; }
    }
}
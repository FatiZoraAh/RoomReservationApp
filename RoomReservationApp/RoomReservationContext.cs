using System.Data.Entity;

namespace RoomReservationApp
{
    class RoomReservationContext : DbContext
    {
        public RoomReservationContext() : base("RoomContext")
        {
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
using lab3_3.model;

public class Seat
{
    public int Id { get; set; }
    public int Number { get; set; }
    public bool IsAvailable { get; set; }
    public int BusId { get; set; }
    public Bus Bus { get; set; }
    public List<Booking> Bookings { get; set; } = new List<Booking>();
}
namespace lab3_3.model;

public class Bus
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public int AmountSeats { get; set; }
    public List<Seat> Seats { get; set; } = new List<Seat>();
    public List<Rating> Ratings { get; set; } = new List<Rating>();
}
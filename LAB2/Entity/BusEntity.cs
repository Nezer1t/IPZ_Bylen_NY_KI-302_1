namespace lab2_3.Entity;

public class BusEntity(string name, int? maxSeats, int? number)
{
    public string Name { get; set; } = name;
    public int? Number { get; set; } = number;
    public int? MaxSeats { get; set; } = maxSeats;

    public BusEntity() : this(string.Empty, 0, 0) { }
}
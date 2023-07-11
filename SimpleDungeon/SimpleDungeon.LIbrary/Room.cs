namespace SimpleDungeon.LIbrary;

public class Room
{
    private int _roomId { get; set; }
    private string? _name { get; set; }
    private string? _description { get; set; }
    private List<Directions> _exits;
}

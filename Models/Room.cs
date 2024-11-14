namespace back.Models;

public class Room
{
    public int _number { set; get; }

    public Seat[] _seats { set; get; }

    public Room () {}
    public Room (int number, Seat[] seats)
    {
        _number = number;
        _seats = seats;
    }
}

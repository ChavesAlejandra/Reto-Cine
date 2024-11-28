using back.Models;

namespace Models;

public enum Rooms
{
    R1,
    R2,
    R3,
    R4,
    R5
}

public class Session
{
    private static int count = 1;
    public int _id { set; get; }
    public DateTime _date { set; get; }
    public Film _film { set; get; }

    public string _room { set; get; }

    public List<Seat> _seats { set; get; }

    public bool _full { set; get; }

    public Session () {}
    public Session (DateTime date, Film film, string room, List<Seat> seats, bool full)
    {
        _id  = count++;
        _date = date;
        _film = film;
        _room = room;
        _seats = seats;
        _full = full;
    }

    public void ShowData ()
    {
        string fullShow = _full ? "full" : "not full";

        Console.WriteLine("Session:\n{" + $"\n\tId: { _id }\n\tDate: { _date }\n\tRoom: { _room }\n\tSeats: { _seats }\n\tStatus: { fullShow }\n" + "}");
    }
}

namespace Models;

public class Session
{
    public int _id { set; get; }
    public string _date { set; get; } // format --> 'dd/mm/yyyy'

    public string _hour { set; get; } // format --> 'hh/mm/ss'

    public int _room { set; get; }

    public Seat[] _seats { set; get; }

    public bool _full { set; get; }

    public Session () {}
    public Session (string date, string hour, int room, Seat[] seats, bool full)
    {
        _id++;
        _date = date;
        _hour = hour;
        _room = room;
        _seats = seats;
        _full = full;
    }

    private void ShowSeatData ()
    {
        string fullShow = fullShow = _full ? "full" : "not full";

        Console.WriteLine("Seat:\n{" + $"\n\tId: { _id }\n\tDate: { _date }\n\tHour: { _hour }\n\tRoom: { _room }\n\tSeats: { _seats }\n\tStatus: { fullShow }\n" + "}");
    }
}

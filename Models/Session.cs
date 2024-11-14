namespace Models;

public class Session
{
    public string _date { set; get; } // format --> 'dd/mm/yyyy'

    public string _hour { set; get; } // format --> 'hh/mm/ss'

    public int _room { set; get; }

    public Seat[] _seats { set; get; }

    public bool _full { set; get; }

    public Session () {}
    public Session (string date, string hour, string room, Seat[] seats, string full)
    {
        _date = date;
        _hour = hour;
        _room = room;
        _seats = seats;
        _full = full;
    }

    private void ShowSeatData ()
    {
        string fullShow = "";
        _full ? fullShow = "full" : fullShow = "not full";

        Console.WriteLine("Seat:\n{".$"\n\tDate: { _date }\n\tHour: { _hour }\n\tRoom: { _room }\n\tSeats: { _seats }\n\tStatus: { fullShow }\n"."}");
    }
}

namespace Models;

public class SeatTemp
{
    public Seat _seat { set; get; }
    public Session _session { set; get; }
    public DateTime _date { set; get; }
    public int _minutesKept { set; get; }

    public SeatTemp () {}
    public SeatTemp (Seat seat, Session session, DateTime date)
    {
        _seat = seat;
        _session = session;
        _date = date;
        _minutesKept = 10;
    }
}

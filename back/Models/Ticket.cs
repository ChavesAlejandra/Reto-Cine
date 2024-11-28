using back.Models;

namespace Models;

public class Ticket
{
    private static int count = 1;
    public int _id { set; get; }

    public string _shownId { set; get; }

    public string _room { set; get; }

    public Session _session { set; get; }

    public Seat _seat { set; get; }

    public Menu _menu { set; get;}

    public Ticket () {}
        public Ticket (string room, Session session, Seat seat)
    {
        _id = count++;
        _shownId = String.Concat('T', _id);
        _room = room;
        _session = session;
        _seat = seat;
    }

    public Ticket (string room, Session session, Seat seat, Menu menu)
    {
        _id++;
        _shownId = String.Concat('T', _id);
        _room = room;
        _session = session;
        _seat = seat;
        _menu = menu;
    }

    public void ShowData ()
    {
        Console.WriteLine("Ticket:\n{" + $"\n\tId: { _shownId }\n\tRoom: { _room }\n\tSession: { _session }\n\tSeat: { _seat }\n\tMenu: { _menu }\n" + "}");
    }
}

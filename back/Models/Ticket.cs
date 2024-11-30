using back.Models;

namespace Models;

public class Ticket
{
    private static int count = 1;
    public int _id { set; get; }

    public string _shownId { set; get; }

    public string _room { set; get; }

    public Session _session { set; get; }

    public List<Seat> _seats { set; get; }

    public List<Menu> _menus { set; get;}

    public Ticket () {}
        public Ticket (string room, Session session, List<Seat> seats)
    {
        _id = count++;
        _shownId = String.Concat('T', _id);
        _room = room;
        _session = session;
        _seats = seats;
    }

    public Ticket (string room, Session session, List<Seat> seats, List<Menu> menus)
    {
        _id++;
        _shownId = String.Concat('T', _id);
        _room = room;
        _session = session;
        _seats = seats;
        _menus = menus;
    }

    public void ShowData ()
    {
        Console.WriteLine("Ticket:\n{" + $"\n\tId: { _shownId }\n\tRoom: { _room }\n\tSession: { _session }\n\tSeat: { _seats }\n\tMenus: { _menus }\n" + "}");
    }
}

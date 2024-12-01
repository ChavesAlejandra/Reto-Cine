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

    public string _userFirstName { set; get; }

    public string _userLastName { set; get; }

    public string _userIban { set; get; }

    public int _userCsv { set; get; }

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

    public Ticket (string room, Session session, List<Seat> seats, string userFirstName, string userLastName, string userIban, int userCsv)
    {
        _id = count++;
        _shownId = String.Concat('T', _id);
        _room = room;
        _session = session;
        _seats = seats;
        _userFirstName = userFirstName;
        _userLastName = userLastName;
        _userIban = userIban;
        _userCsv = userCsv;
    }

    public Ticket (string room, Session session, List<Seat> seats, List<Menu> menus, string userFirstName, string userLastName, string userIban, int userCsv)
    {
        _id++;
        _shownId = String.Concat('T', _id);
        _room = room;
        _session = session;
        _seats = seats;
        _menus = menus;
        _userFirstName = userFirstName;
        _userLastName = userLastName;
        _userIban = userIban;
        _userCsv = userCsv;
    }

    public void ShowData ()
    {
        Console.WriteLine("Ticket:\n{" + $"\n\tId: { _shownId }\n\tRoom: { _room }\n\tSession: { _session }\n\tSeat: { _seats }\n\tMenus: { _menus }\n\tUser First Name: { _userFirstName }\n\tUser Last Name: { _userLastName }\n\tUser IBAN: { _userIban }\n\tUser CSV: { _userCsv }\n" + "}");
    }
}

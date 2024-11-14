namespace Models;

public class Ticket
{
    public int _id { set; get; }

    public int _room { set; get; }

    public Session _session { set; get; }

    public Seat _seat { set; get; }

    public Ticket () {}

    public Ticket (int id, int room, Session session, Seat seat)
    {
        _id = id;
        _room = room;
        _session = session;
        _seat = seat;
    }

        private void ShowSeatData ()
    {
        Console.WriteLine("Seat:\n{".$"\n\tId: { _id }\n\tRoom: { _room }\n\tSession: { _session }\n\tSeat: { _seat }\n"."}");
    }
}

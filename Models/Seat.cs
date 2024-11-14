namespace back.Models;

public enum SeatTypes
{
    normal,
    VIP,
    disabled
}

public class Seat
{
    public string _id { set; get; }

    public string _type { set; get; }

    public float _price { set; get; }

    public bool _occupied { set; get; }

    public Seat () {}
    public Seat (string id, string type, float price, bool occupied)
    {
        _id = id;
        _type = type;
        _price = price;
        _occupied = occupied;
    }
}

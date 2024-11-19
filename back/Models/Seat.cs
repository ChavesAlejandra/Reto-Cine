namespace Models;

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
    public string _img { set; get; }

    public Seat () {}
    public Seat (string id, string type, float price, bool occupied, string img)
    {
        _id = id;
        _type = type;
        _price = price;
        _occupied = occupied;
        _img = img;
    }

    private void ShowSeatData ()
    {
        Console.WriteLine("Seat:{"+$"\n\tId: { _id }\n\tType: { _type }\n\tPrice: { _price }\n\tOccupied: { _occupied }\n"+"}");
    }
}

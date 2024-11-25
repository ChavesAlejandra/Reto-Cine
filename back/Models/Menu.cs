namespace back.Models;

public class Menu
{

    private static int count = 1;
    public int _id { set; get; }
    public string _title { set; get; }

    public int _price { set; get; } // full name

    public string _img { set; get; } // in minutes


    public Menu() {}
    public Menu(string title, int price, string img)
    {
        _id = count++;
        _title = title;
        _price = price;
        _img = img;
    }

    private void ShowSeatData ()
    {
        Console.WriteLine("Seat:\n{" + $"\n\tId: { _id }\n\tTitle: { _title }\n\tDirector: { _price }\n\tDuration: { _img }\n" + "}");
    }
}
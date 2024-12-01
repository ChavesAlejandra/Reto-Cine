namespace back.Models;

public class Menu
{

    private static int count = 1;

    public int _id { set; get; }

    public string _name { set; get; }

    public int _price { set; get; }

    public string _img { set; get; }


    public Menu () {}
    public Menu (string name, int price, string img)
    {
        _id = count++;
        _name = name;
        _price = price;
        _img = img;
    }

    public void ShowData ()
    {
        Console.WriteLine("Menu:\n{" + $"\n\tId: { _id }\n\tName: { _name }\n\tPrice: { _price }\n\tImg: { _img }\n" + "}");
    }
}
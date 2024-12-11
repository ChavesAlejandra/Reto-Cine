namespace back.Models;

public class Comment
{
    private static int count = 1;
    public int _id { set; get; }
    public string _user { set; get; } // name
    public DateTime _date { set; get;}
    public string _message { set; get; }
    public float _puntuation { set; get; }
    public int _filmID { set; get; }

    public Comment () {}
    public Comment (string user, string message, float puntuation)
    {
        _id = count++;
        _user = user;
        _message = message;
        _puntuation = puntuation;
        _date = DateTime.Now;
    }
    public Comment (string user, string message, float puntuation, int filmID)
    {
        _id = count++;
        _user = user;
        _message = message;
        _puntuation = puntuation;
        _date = DateTime.Now;
        _filmID = filmID;
    }
}

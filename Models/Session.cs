namespace back.Models;

public class Session
{
    string _date { set; get; } // format --> 'dd/mm/yyyy'

    string _hour { set; get; } // format --> 'hh/mm/ss'

    int _room { set; get; }

    bool full { set; get; }
}

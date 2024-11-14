namespace back.Models;

public enum FilmGenres
{
    scary,
    romantic,
    scienceFiction,
    animation
}

public enum FilmAgeRestrictions
{
    allPublic = 0,
    overTwelve = 12,
    overSixteen = 16,
    overEighteen = 18
}

public class Film
{
    string _title { set; get; }

    string _director { set; get; } // full name

    int _duration { set; get; } // in seconds

    int _ageRestriction { set; get; }

    string[] _genres { set; get; }

    public Film () {}
    public Film (string title, string director, int duration, int ageRestriction, string[] genres)
    {
        _title = title;
        _director = director;
        _duration = duration;
        _ageRestriction = ageRestriction;
        _genres = genres;
    }
}

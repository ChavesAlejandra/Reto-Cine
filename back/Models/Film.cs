namespace back.Models;

public enum FilmGenres
{
    horror,
    romantic,
    sciFi,
    animation
}

public enum FilmAgeRestrictions
{
    allPublic = 0,
    overSeven = 7,
    overThirteen = 13,
    overSixteen = 16,
    overEighteen = 18
}

public class Film
{

    private static int count = 1;
    public int _id { set; get; }
    public string _title { set; get; }

    public string _director { set; get; } // full name

    public int _duration { set; get; } // in minutes

    public string _description { set; get; }

    public int _ageRestriction { set; get; }

    public string _premiereYear { set; get; }

    public string[] _genres { set; get; }

    public string _filmImg { set; get; }

    public Film () {}
    public Film (string title, string director, int duration, string description, int ageRestriction, string premiereYear, string[] genres, string filmImg)
    {
        _id = count++;
        _title = title;
        _director = director;
        _duration = duration;
        _description = description;
        _ageRestriction = ageRestriction;
        _premiereYear = premiereYear;
        _genres = genres;
        _filmImg = filmImg;
    }

    private void ShowSeatData ()
    {
        Console.WriteLine("Seat:\n{" + $"\n\tId: { _id }\n\tTitle: { _title }\n\tDirector: { _director }\n\tDuration: { _duration }\n\tAge Restriction: { _ageRestriction }\n\tPremiere Date: { _premiereYear }\n\tGenres: { _genres }\n" + "}");
    }
}

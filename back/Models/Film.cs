using Microsoft.Extensions.Configuration.EnvironmentVariables;

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

    public string _personName {set; get;}
    
    public string _comentario {set; get;}

    public int _filmStars{set; get;}

    public Film () {}

    public Film (string personName, string comentario, int filmStars)
    {
        _personName = personName;
        _comentario = comentario;
        _filmStars = filmStars;
    }

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

    public void ShowData ()
    {
        Console.WriteLine("Film:\n{" + $"\n\tId: { _id }\n\tTitle: { _title }\n\tDirector: { _director }\n\tDuration: { _duration }\n\tAge Restriction: { _ageRestriction }\n\tPremiere Date: { _premiereYear }\n\tGenres: { _genres }\n\tPerson Name: { _personName }\n\tComentario: { _comentario }\n\tStars: { _filmStars }\n" + "}");
    }
}

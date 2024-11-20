using Microsoft.AspNetCore.Mvc;
using back.Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]


public class FilmController : ControllerBase
{
    private static List<Film> films = DataGen();

    public static List<Film> DataGen ()
    {
        List<Film> genFilms =
        [
            new Film("Children Who Chase Lost Voices", "Makoto Shinkai", 116, (int) FilmAgeRestrictions.allPublic, "2011", [ Enum.GetName(FilmGenres.animation) ], "ChildrenWhoChaseLostVoices.jpg"),
            new Film("Space Jam", "Joe Pytka", 88, (int) FilmAgeRestrictions.allPublic, "1996", [ Enum.GetName(FilmGenres.animation) ], "SpaceJam.jpg"),
            new Film("Coraline", "Henry Selick", 115, (int) FilmAgeRestrictions.overSeven, "2009", [ Enum.GetName(FilmGenres.animation), Enum.GetName(FilmGenres.horror) ], "Coraline.jpg"),
            new Film("The Nightmare Before Christmas", "Henry Selick", 76, (int) FilmAgeRestrictions.overSeven, "1993", [ Enum.GetName(FilmGenres.animation) ], "NightmareBeforeChristmas.jpg"),
            new Film("Grave of Fireflies", "Isao Takahata", 89, (int) FilmAgeRestrictions.overThirteen, "1988", [ Enum.GetName(FilmGenres.animation) ], "GraveOfFireflies.jpg"),
            new Film("Howl's Moving Castle", "Hayao Miyazaki", 119, (int) FilmAgeRestrictions.overSeven, "2004", [ Enum.GetName(FilmGenres.animation) ], "HowlsMovingCastle.jpg"),
            new Film("Princess Mononoke", "Hayao Miyazaki", 133, (int) FilmAgeRestrictions.overSeven, "1997", [ Enum.GetName(FilmGenres.animation) ], "PrincessMononoke.jpg"),
            new Film("Spirited Away", "Hayao Miyazaki", 125, (int) FilmAgeRestrictions.allPublic, "2001", [ Enum.GetName(FilmGenres.animation) ], "SpiritedAway.jpg"),

            new Film("Deep Blue Sea", "Renny Harlin", 105, (int) FilmAgeRestrictions.overThirteen, "1999", [ Enum.GetName(FilmGenres.horror) ], "DeepBlueSea.jpg"),
            new Film("Shark Attack", "David Worth", 98, (int) FilmAgeRestrictions.overSixteen, "2000", [ Enum.GetName(FilmGenres.horror) ], "SharkAttack.jpg"),
            new Film("Scary Movie 1", "Keenen Ivory Wayans", 88, (int) FilmAgeRestrictions.overThirteen, "2000", [ Enum.GetName(FilmGenres.horror) ], "ScaryMovie1.jpg"),
            new Film("Scary Movie 2", "Keenen Ivory Wayans", 83, (int) FilmAgeRestrictions.overSixteen, "2001", [ Enum.GetName(FilmGenres.horror) ], "ScaryMovie2.jpg"),
            new Film("Scream 1", "Wes Craven", 111, (int) FilmAgeRestrictions.overEighteen, "1996", [ Enum.GetName(FilmGenres.horror) ], "Scream1.jpg"),
            new Film("Scream 2", "Wes Craven", 120, (int) FilmAgeRestrictions.overEighteen, "1997", [ Enum.GetName(FilmGenres.horror) ], "Scream2.jpg")
        ];

        return genFilms;
    }

    [HttpGet] // decorator
    public ActionResult<IEnumerable<Film>> GetFilms() { return Ok(films); }

    [HttpGet("genre/{genre}")]
    public ActionResult<IEnumerable<Film>> GetFilmsGenre(string genre)
    {
        List<Film> filteredFilms = new List<Film>();
        films.ForEach(el =>
        {
            if (el._genres.Contains(genre)) { filteredFilms.Add(el); }
        });
        if (filteredFilms.ToArray().Length == 0) { return NotFound(); }
        return Ok(filteredFilms);
    }

    [HttpGet("{film}")]
    public ActionResult<IEnumerable<Film>> GetFilmSpecific(string film)
    {
        List<Film> filteredFilms = new List<Film>();
        films.ForEach(el =>
        {
            if (el._title.ToLower().Contains(film.ToLower())) { filteredFilms.Add(el); }
        });
        if (filteredFilms.ToArray().Length == 0) { return NotFound(); }
        return Ok(filteredFilms);
    }
}


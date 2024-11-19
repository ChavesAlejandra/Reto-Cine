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
            new Film("Coraline", "full name", 150, (int) FilmAgeRestrictions.overTwelve, [ Enum.GetName(FilmGenres.animation), Enum.GetName(FilmGenres.horror) ]),
            new Film("Space Jam", "full name", 160, (int) FilmAgeRestrictions.allPublic, [ Enum.GetName(FilmGenres.animation) ])
        ];

        return genFilms;
    }

    [HttpGet] // decorator
    public ActionResult<IEnumerable<Film>> GetFilms() { return Ok(films); }

    [HttpGet("{category}")]
    public ActionResult<IEnumerable<Film>> GetFilmsCategory(string category)
    {
        List<Film> filteredFilms = new List<Film>();
        films.ForEach(el =>
        {
            if (el._genres.Contains(category)) { filteredFilms.Add(el); }
        });
        if (filteredFilms.ToArray().Length == 0) { return NotFound(); }
        return Ok(filteredFilms);
    }
}


using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

[ApiController]
[Route("[controller]")]


public class FilmController : ControllerBase
{
    private static List<Film> films = new List<Film>();

    public static void DataGen ()
    {
        films.Add(new Film("meow", "director", 1600, (int) FilmAgeRestrictions.allPublic, [Enum.GetName(FilmGenres.animation), Enum.GetName(FilmGenres.romantic)]));
    }

    [HttpGet] // decorator
    public ActionResult<IEnumerable<Film>> GetFilms() { return Ok(films); }
}


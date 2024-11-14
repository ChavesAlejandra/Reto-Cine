using Microsoft.AspNetCore.Mvc;
using back.Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]


public class FilmController : ControllerBase
{
    private static List<Film> films = new List<Film>();


    //metodo que devuelve todas las peliculas
    [HttpGet]
    public ActionResult<IEnumerable<Film>> GetPeliculas() { 
        return Ok(films); }
    public static void InitiateData ()
    {
        //films.Add(new Film("meow", "director", 1600, (int) FilmAgeRestrictions.allPublic, [FilmGenres.animation, FilmGenres.romantic]));
    }


}


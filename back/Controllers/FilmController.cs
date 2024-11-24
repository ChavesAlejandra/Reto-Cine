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
            new Film("Children Who Chase Lost Voices", "Makoto Shinkai", 116, "Attacked by a monstrous creature, rescued by a mysterious boy named Shun and pursued by an implacable enemy, Asuna is drawn into an ancient mystery that could be the secret of life itself.", (int) FilmAgeRestrictions.allPublic, "2011", [ Enum.GetName(FilmGenres.animation) ], "ChildrenWhoChaseLostVoices.jpg"),
            new Film("Space Jam", "Joe Pytka", 88, "Bugs Bunny and his friends face the most important basketball game of their lives: the one that will determine their freedom and permanence on planet Earth.", (int) FilmAgeRestrictions.allPublic, "1996", [ Enum.GetName(FilmGenres.animation) ], "SpaceJam.jpg"),
            new Film("Coraline", "Henry Selick", 115, "A young girl discovers a secret door in her new home and enters an alternate reality that mirrors her in many ways.", (int) FilmAgeRestrictions.overSeven, "2009", [ Enum.GetName(FilmGenres.animation), Enum.GetName(FilmGenres.horror) ], "Coraline.jpg"),
            new Film("The Nightmare Before Christmas", "Henry Selick", 76, "The Lord of Halloween, Jack Skellington, bored of doing the same thing every year, discovers Christmas in Christmas Town and is fascinated, so he decides to go all out and improve the holiday. To this end, he kidnaps Father Christmas and creates a version of Christmas that is the complete opposite of the existing one.", (int) FilmAgeRestrictions.overSeven, "1993", [ Enum.GetName(FilmGenres.animation) ], "NightmareBeforeChristmas.jpg"),
            new Film("Grave of Fireflies", "Isao Takahata", 89, "In Japan in 1945, during an American air raid on the city of Kobe, young Seita and his little sister Setsuko, the children of a Japanese naval officer, fail to reach the shelter where their mother is waiting for them in time.", (int) FilmAgeRestrictions.overThirteen, "1988", [ Enum.GetName(FilmGenres.animation) ], "GraveOfFireflies.jpg"),
            new Film("Howl's Moving Castle", "Hayao Miyazaki", 119, "Sophie, an 18-year-old girl, works tirelessly in her late father's hat shop. On one of her infrequent walks through the city, Sophie meets the magician Howl, a young man with extraordinary powers and extremely seductive.", (int) FilmAgeRestrictions.overSeven, "2004", [ Enum.GetName(FilmGenres.animation) ], "HowlsMovingCastle.jpg"),
            new Film("Princess Mononoke", "Hayao Miyazaki", 133, "Con el fin de curar la herida que le ha causado un jabalí enloquecido, el joven Ashitaka sale en busca del dios Ciervo, pues sólo él puede liberarlo del sortilegio. A lo largo de su periplo descubre cómo los animales del bosque luchan contra hombres que están dispuestos a destruir la Naturaleza.", (int) FilmAgeRestrictions.overSeven, "1997", [ Enum.GetName(FilmGenres.animation) ], "PrincessMononoke.jpg"),
            new Film("Spirited Away", "Hayao Miyazaki", 125, "Chihiro is a capricious and stubborn ten-year-old girl who believes that the entire universe must submit to her wishes.", (int) FilmAgeRestrictions.allPublic, "2001", [ Enum.GetName(FilmGenres.animation) ], "SpiritedAway.jpg"),

            new Film("Deep Blue Sea", "Renny Harlin", 105, "A doctor, trying to find the key to the regeneration of human brain tissue, modifies the DNA of sharks, accidentally turning them into predatory monsters that endanger the entire team.", (int) FilmAgeRestrictions.overThirteen, "1999", [ Enum.GetName(FilmGenres.horror) ], "DeepBlueSea.jpg"),
            new Film("Shark Attack", "David Worth", 98, "Due to a failed experiment, several sharks have washed up on the shores of Hawaii. After committing several murders, their destruction will be a suicide mission.", (int) FilmAgeRestrictions.overSixteen, "2000", [ Enum.GetName(FilmGenres.horror) ], "SharkAttack.jpg"),
            new Film("Scary Movie 1", "Keenen Ivory Wayans", 88, "In this parody of modern horror films, a year after running over a man and disposing of the body, a group of teenagers are stalked by a rather useless serial killer.", (int) FilmAgeRestrictions.overThirteen, "2000", [ Enum.GetName(FilmGenres.horror) ], "ScaryMovie1.jpg"),
            new Film("Scary Movie 2", "Keenen Ivory Wayans", 83, "A mad professor recruits a girl and a group of young people, all eager for adventure and new experiences, for a weekend outing.", (int) FilmAgeRestrictions.overSixteen, "2001", [ Enum.GetName(FilmGenres.horror) ], "ScaryMovie2.jpg"),
            new Film("Scream 1", "Wes Craven", 111, "A serial killer, wearing a mask and a black costume, sows panic among the teenagers of a Californian town. At the same time, young Sidney Prescott is going through a difficult time: it is a year since her mother died.", (int) FilmAgeRestrictions.overEighteen, "1996", [ Enum.GetName(FilmGenres.horror) ], "Scream1.jpg"),
            new Film("Scream 2", "Wes Craven", 120, "Two years after the Woodsboro massacre, Sidney and Randy try to rebuild their lives in another town. Their tranquility is disturbed by a wave of brutal murders committed by a masked psychopath.", (int) FilmAgeRestrictions.overEighteen, "1997", [ Enum.GetName(FilmGenres.horror) ], "Scream2.jpg")
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


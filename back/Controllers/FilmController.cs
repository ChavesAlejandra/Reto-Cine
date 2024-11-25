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
            new Film("Scream 2", "Wes Craven", 120, "Two years after the Woodsboro massacre, Sidney and Randy try to rebuild their lives in another town. Their tranquility is disturbed by a wave of brutal murders committed by a masked psychopath.", (int) FilmAgeRestrictions.overEighteen, "1997", [ Enum.GetName(FilmGenres.horror) ], "Scream2.jpg"),

            new Film("Mr. & Mrs. Smith",  "Doug Liman", 120, "After five years of marital idyll, John and Jane Smith's marriage has fallen into a rut. Until they both discover the truth: they are both cold, lethal and very expensive contract killers for opposing organisations.", (int) FilmAgeRestrictions.allPublic,"2005", [Enum.GetName(FilmGenres.romantic)], "MrMrsSmith.jpg"),
            new Film("Love Actually", "Richard Curtis", 130, "The lives of several couples intersect in London, just before the Christmas holidays, with romantic, funny and bittersweet results.", (int) FilmAgeRestrictions.allPublic,"2003", [Enum.GetName(FilmGenres.romantic)], "LoveActually.jpg"),
            new Film("Shakespear In Love",  "John Madden", 123, "The young William Shakespeare falls in love with Viola, awakening his creativity and writing a new play. However, she is already engaged to another man.", (int) FilmAgeRestrictions.allPublic ,"1998", [Enum.GetName(FilmGenres.romantic)], "ShakespearInLove.jpg"),
            new Film("Pretty Woman",  "Garry Marshall", 119, "During a business trip to Los Angeles, Edward, an executive who buys and sells companies, meets the prostitute Vivian. After spending a first night with her, Edward offers her money to spend the whole week with him and accompany him to various social events.", (int) FilmAgeRestrictions.allPublic, "1990", [Enum.GetName(FilmGenres.romantic)], "PrettyWoman.jpg"),
            new Film("Titanic", "James Cameron", 194, "Jack is a young artist who wins a ticket to America on the Titanic, the largest and safest ocean liner ever built.", (int) FilmAgeRestrictions.allPublic, "1997", [Enum.GetName(FilmGenres.romantic)], "Titanic.jpg"),
            new Film("Grease", "Randal Kleiser", 110, "Rebellious Danny Zuko and innocent Australian Sandy have an affair during the summer holidays, believing they will never see each other again. However, to their surprise, they end up studying together at the same high school for the new academic year.", (int) FilmAgeRestrictions.allPublic, "1978", [Enum.GetName(FilmGenres.romantic)], "Grease.jpg"),
            new Film("Grase 2", "Patricia Birch", 115, "It is 1961 and a new school year begins at Rydell High School. Carrington, a young Englishman, falls in love with Stephanie, the leader of the cheerleading squad. However, she only dreams of dating a boy with a motorbike.", (int) FilmAgeRestrictions.allPublic, "1982", [Enum.GetName(FilmGenres.romantic)], "Grease2.jpg"),

            new Film("Cube", "Vincenzo Natali", 90, "A group of strangers awaken to find themselves placed in a giant cube. Each one of them is gifted with a special skill and they must work together to escape an endless maze of deadly traps.", (int) FilmAgeRestrictions.overThirteen, "1997", [Enum.GetName(FilmGenres.sciFi)], "Cube.jpg"),
            new Film("ET", "Steven Spielberg", 115, "A small alien from another planet is abandoned on Earth when his ship forgets about him. He is all alone and scared until Elliott, a nine-year-old boy, finds him and decides to hide him in his house to protect him.", (int) FilmAgeRestrictions.allPublic, "1982", [Enum.GetName(FilmGenres.sciFi)], "ET.jpg"),
            new Film("Hardware", "Richard Stanley", 94, "A cyborg's head reactivates, rebuilds itself and goes on a violent rampage in the apartment of a space marine's girlfriend.", (int) FilmAgeRestrictions.overEighteen, "1990", [Enum.GetName(FilmGenres.sciFi), Enum.GetName(FilmGenres.horror)], "Hardware.jpg" ),
            new Film("Matrix", "Lana Wachowski, Lilly Wachowski", 136, "When a beautiful stranger leads hacker Neo into a forbidden underworld, he discovers the shocking truth: the life he knows is an elaborate hoax by an evil cyber-intelligence.", (int) FilmAgeRestrictions.overEighteen, "1999", [Enum.GetName(FilmGenres.sciFi)], "Matrix.jpg"),
            new Film("Predator", "John McTiernan", 107, "A group of mercenaries is hired by the CIA to rescue some pilots who have been captured by guerrillas in the Central American jungle.", (int) FilmAgeRestrictions.overEighteen, "1987", [Enum.GetName(FilmGenres.sciFi), Enum.GetName(FilmGenres.horror)], "Predator.jpg"),
            new Film("Supernova", "Walter Hill, Francis Ford Coppola, Jack Sholder", 90, "A medical aid spacecraft rescues a mysterious survivor and a strange and menacing alien artifact.", (int) FilmAgeRestrictions.overEighteen, "2000", [Enum.GetName(FilmGenres.sciFi), Enum.GetName(FilmGenres.horror)], "Supernova.jpg"),
            new Film("The Fifth Element", "Luc Besson", 126, "In a colorful future, a cab driver unwittingly becomes the central figure in the search for a legendary cosmic weapon to keep Zorg and El Maligno at bay.", (int) FilmAgeRestrictions.overSeven, "1997", [Enum.GetName(FilmGenres.sciFi)], "TheFifthElement.jpg")

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


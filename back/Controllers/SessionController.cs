using Microsoft.AspNetCore.Mvc;
using back.Models;
using Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class SessionController : ControllerBase
{
    public static List<Session> sessions = DataGen(FilmController.films, SeatController.seats);

    public static List<Session> DataGen(List<Film> parFilms, List<Seat> parSeats)
    {
        List<Session> genSessions =
        [
            new Session("20/11/2024", "20:15", parFilms[1-1], Enum.GetName(Rooms.R1), parSeats, false)
        ];

        return genSessions;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Session>> GetSessions() { return Ok(sessions); }

    [HttpGet("film/{film}")]
    public ActionResult<IEnumerable<Session>> GetSessionsSpecific(string film)
    {
        List<Session> filteredSessions = new List<Session>();
        sessions.ForEach(el =>
        {
            if (el._film._title.ToLower().Contains(film.ToLower())) { filteredSessions.Add(el); }
        });
        if (filteredSessions.ToArray().Length == 0) { return NotFound(); }
        return Ok(filteredSessions);
    }
}

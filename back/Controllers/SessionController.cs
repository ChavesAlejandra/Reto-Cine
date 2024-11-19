using Microsoft.AspNetCore.Mvc;
using back.Models;
using Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class SessionController : ControllerBase
{
    private static List<Session> sessions = DataGen(FilmController.DataGen(), SeatController.DataGen());

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
}

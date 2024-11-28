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
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[1-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[1-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[2-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[2-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[3-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[3-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[4-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[4-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[5-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[5-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[6-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[6-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[7-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[7-1], Enum.GetName(Rooms.R1), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[8-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[8-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[9-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[9-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[10-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[10-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[11-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[11-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[12-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[12-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[13-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[13-1], Enum.GetName(Rooms.R2), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[14-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[14-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[15-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[15-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[16-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[16-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[17-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[17-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[18-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[18-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[19-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[19-1], Enum.GetName(Rooms.R3), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[20-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[20-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[21-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[21-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[22-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[22-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[23-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[23-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[24-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[24-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[25-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[25-1], Enum.GetName(Rooms.R4), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[26-1], Enum.GetName(Rooms.R5), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[26-1], Enum.GetName(Rooms.R5), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[27-1], Enum.GetName(Rooms.R5), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[27-1], Enum.GetName(Rooms.R5), parSeats, false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[28-1], Enum.GetName(Rooms.R5), parSeats, false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[28-1], Enum.GetName(Rooms.R5), parSeats, false)
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

    [HttpGet("id/{id}")]
    public ActionResult<IEnumerable<Session>> GetSessionSpecific (int id)
    {
        List<Session> filteredSession = new List<Session>();
        sessions.ForEach(el =>
        {
            if (el._id.Equals(id)) { filteredSession.Add(el); }
        });
        if (filteredSession.ToArray().Length == 0) { return NotFound(); }
        return Ok(filteredSession);
    }

    
    [HttpPut("id/{id}/seat/{seatId}/occupied/{occ}")]
    public ActionResult<Seat> PutSeat (int id, string seatId, bool occ)
    {
        Session session = sessions.Find(co => co._id == id);
        Seat seat = session._seats.Find(co => co._id == seatId);

        seat._occupied = occ;
        if (seat._occupied == true) { seat._img = "seat_taken.png"; }
        else { seat._img = "seat_blanco.png"; }

        return seat;
    }
}

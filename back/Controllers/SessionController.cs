using Microsoft.AspNetCore.Mvc;
using back.Models;
using Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class SessionController : ControllerBase
{
    public static List<Session> sessions = DataGen(FilmController.films, SeatController.seats);

    public static List<Session> DataGen(List<Film> parFilms, List<List<Seat>> parSeats)
    {
        List<Session> genSessions =
        [
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[1-1], Enum.GetName(Rooms.R1), parSeats[0], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[1-1], Enum.GetName(Rooms.R1), parSeats[1], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[2-1], Enum.GetName(Rooms.R1), parSeats[2], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[2-1], Enum.GetName(Rooms.R1), parSeats[3], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[3-1], Enum.GetName(Rooms.R1), parSeats[4], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[3-1], Enum.GetName(Rooms.R1), parSeats[5], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[4-1], Enum.GetName(Rooms.R1), parSeats[6], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[4-1], Enum.GetName(Rooms.R1), parSeats[7], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[5-1], Enum.GetName(Rooms.R1), parSeats[8], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[5-1], Enum.GetName(Rooms.R1), parSeats[9], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[6-1], Enum.GetName(Rooms.R1), parSeats[10], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[6-1], Enum.GetName(Rooms.R1), parSeats[11], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[7-1], Enum.GetName(Rooms.R1), parSeats[12], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[7-1], Enum.GetName(Rooms.R1), parSeats[13], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[8-1], Enum.GetName(Rooms.R2), parSeats[14], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[8-1], Enum.GetName(Rooms.R2), parSeats[15], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[9-1], Enum.GetName(Rooms.R2), parSeats[16], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[9-1], Enum.GetName(Rooms.R2), parSeats[17], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[10-1], Enum.GetName(Rooms.R2), parSeats[18], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[10-1], Enum.GetName(Rooms.R2), parSeats[19], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[11-1], Enum.GetName(Rooms.R2), parSeats[20], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[11-1], Enum.GetName(Rooms.R2), parSeats[21], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[12-1], Enum.GetName(Rooms.R2), parSeats[22], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[12-1], Enum.GetName(Rooms.R2), parSeats[23], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[13-1], Enum.GetName(Rooms.R2), parSeats[24], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[13-1], Enum.GetName(Rooms.R2), parSeats[25], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[14-1], Enum.GetName(Rooms.R3), parSeats[26], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[14-1], Enum.GetName(Rooms.R3), parSeats[27], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[15-1], Enum.GetName(Rooms.R3), parSeats[28], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[15-1], Enum.GetName(Rooms.R3), parSeats[29], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[16-1], Enum.GetName(Rooms.R3), parSeats[30], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[16-1], Enum.GetName(Rooms.R3), parSeats[31], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[17-1], Enum.GetName(Rooms.R3), parSeats[32], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[17-1], Enum.GetName(Rooms.R3), parSeats[33], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[18-1], Enum.GetName(Rooms.R3), parSeats[34], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[18-1], Enum.GetName(Rooms.R3), parSeats[35], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[19-1], Enum.GetName(Rooms.R3), parSeats[36], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[19-1], Enum.GetName(Rooms.R3), parSeats[37], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[20-1], Enum.GetName(Rooms.R4), parSeats[38], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[20-1], Enum.GetName(Rooms.R4), parSeats[39], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[21-1], Enum.GetName(Rooms.R4), parSeats[40], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[21-1], Enum.GetName(Rooms.R4), parSeats[41], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[22-1], Enum.GetName(Rooms.R4), parSeats[42], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[22-1], Enum.GetName(Rooms.R4), parSeats[43], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[23-1], Enum.GetName(Rooms.R4), parSeats[44], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[23-1], Enum.GetName(Rooms.R4), parSeats[45], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[24-1], Enum.GetName(Rooms.R4), parSeats[46], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[24-1], Enum.GetName(Rooms.R4), parSeats[47], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[25-1], Enum.GetName(Rooms.R4), parSeats[48], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[25-1], Enum.GetName(Rooms.R4), parSeats[49], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[26-1], Enum.GetName(Rooms.R5), parSeats[50], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[26-1], Enum.GetName(Rooms.R5), parSeats[51], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[27-1], Enum.GetName(Rooms.R5), parSeats[52], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[27-1], Enum.GetName(Rooms.R5), parSeats[53], false),
            new Session(new DateTime(2024, 12, 02, 20, 00, 00), parFilms[28-1], Enum.GetName(Rooms.R5), parSeats[54], false),
            new Session(new DateTime(2024, 12, 13, 22, 00, 00), parFilms[28-1], Enum.GetName(Rooms.R5), parSeats[55], false)
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

        int count = 0;
        session._seats.ForEach(el => { if (el._occupied) { count++; } });
        if (count == 72) { session._full = true; }

        return seat;
    }
}

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
        int roomsNum = Enum.GetNames(typeof(Rooms)).Length;
        List<Session> genSessions = new List<Session>();

        Random random = new Random();
        random.Next(1, 5);

        int filmRandom = random.Next(parFilms.Count);

        int roomRandom = random.Next(roomsNum);

        DateTime session = DateTime.Now;
        session = DateTime.Now.Date.Add(new TimeSpan(16, 00, 0));

        while(session.Date<=session.AddDays(3))
        {
            genSessions.Add(new Session(session, parFilms[filmRandom], Enum.GetNames(typeof(Rooms))[roomRandom], SeatController.SeatGeneration(), false));
            session = session.AddHours(1).AddMinutes(30);
            if(session.Hour>=22)
            {
                session = session.AddDays(1);
            }
        }
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

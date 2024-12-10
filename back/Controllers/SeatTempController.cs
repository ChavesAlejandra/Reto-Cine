using Microsoft.AspNetCore.Mvc;
using back.Models;
using Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class SeatTempController : ControllerBase
{
    public static List<SeatTemp> seatTemps = new List<SeatTemp>();

    [HttpGet]
    public ActionResult<IEnumerable<SeatTemp>> GetSeats() { return Ok(seatTemps); }
    
    [HttpGet("session/{sessionID}")]
    public ActionResult<IEnumerable<SeatTemp>> GetSeatsBySession(int sessionID)
    {
        Session session = SessionController.sessions.First(el => el._id == sessionID);
        List<SeatTemp> currentSeatTemp = new List<SeatTemp>();
        seatTemps.ForEach(el => { if (el._session._id == sessionID) { currentSeatTemp.Add(el); } });
        return Ok(currentSeatTemp);
    }

    [HttpPost("session/{sessionID}/seat/{seatID}")]
    public ActionResult<IEnumerable<SeatTemp>> GetSeatsBySession(int sessionID, string seatID)
    {
        Session session = SessionController.sessions.First(el => el._id == sessionID);
        Seat seat = session._seats.First(el => el._id == seatID);
        SeatTemp seatTemp = new SeatTemp(seat, session, DateTime.Now);
        seatTemps.Add(seatTemp);
        return Ok(seatTemp);
    }
}

using Microsoft.AspNetCore.Mvc;
using back.Models;
using Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class TicketController : ControllerBase
{
    public static List<Ticket> tickets = new List<Ticket>();

    [HttpGet]
    public ActionResult<IEnumerable<Ticket>> GetTickets () { return Ok(tickets); }
    
    [HttpGet("id/{id}")]
    public ActionResult<IEnumerable<Ticket>> GetTicketId (int id)
    {
        List<Ticket> filteredTickets = new List<Ticket>();
        tickets.ForEach(el => 
        {
            if (el._id.Equals(id)) { filteredTickets.Add(el); }
        });

        if(filteredTickets.ToArray().Length == 0) {return NotFound();}
        return Ok(filteredTickets);
    }

    [HttpPost("session/{idSession}")]
    public ActionResult<Ticket> PostSeat (int idSession, [FromBody] List<Seat> seats)
    {
        Session session = SessionController.sessions.Find(co => co._id == idSession);
        Ticket ticket = new Ticket(session._room, session, seats);
        tickets.Add(ticket);

        return ticket;
    }
    
    [HttpPut("id/{id}/menus")]
        public ActionResult<Ticket> PutTicket (int id, [FromBody] List<Menu> menus)
    {
        Ticket ticket = tickets.Find(co => co._id == id);

        ticket._menus = menus;

        return ticket;
    }

        [HttpPut("id/{id}/user")]
        public ActionResult<Ticket> PutTicket (int id, [FromBody] string user)
    {
        Ticket ticket = tickets.Find(co => co._id == id);

        ticket._userFirstName = user.Split('-')[0];
        ticket._userLastName = user.Split('-')[1];
        ticket._userIban = user.Split('-')[2];
        ticket._userCsv = Convert.ToInt32(user.Split('-')[3]);

        return ticket;
    }
}

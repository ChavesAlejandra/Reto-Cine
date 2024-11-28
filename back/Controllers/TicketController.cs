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
    public ActionResult<Ticket> PostSeat (int idSession, [FromBody] Seat seat)
    {
        Session session = SessionController.sessions.Find(co => co._id == idSession);
        Ticket ticket = new Ticket(session._room, session, seat);
        tickets.Add(ticket);

        return ticket;
    }
    
    [HttpPut("id/{id}/menu/{menu}")]
        public ActionResult<Ticket> PutTicket (int id, Menu menu)
    {
        Ticket ticket = tickets.Find(co => co._id == id);

        ticket._menu = menu;

        return ticket;
    }
}

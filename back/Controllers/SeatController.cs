using Microsoft.AspNetCore.Mvc;
using back.Models;
using Models;

namespace back.Controllers;

[ApiController]
[Route("[controller]")]

public class SeatController : ControllerBase
{
    public static List<List<Seat>> seats = DataGen();

    public static List<List<Seat>> DataGen()
    {
        List<List<Seat>> genSeats = new List<List<Seat>>();
        
        for (int count = 0; count < FilmController.films.Count()*2; count++)
        {
            genSeats.Add(
            [
                new Seat("A4", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("A5", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("A7", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("A8", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("B1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F4", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F5", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F6", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F7", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F8", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I3", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I9", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png")
            ]);
        }

        return genSeats;
    }
    public static List<Seat> SeatGeneration()
    {
        List<Seat> genSeats =
        [
                new Seat("A4", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("A5", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("A7", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("A8", Enum.GetName(SeatTypes.disabled), 7, false, "seat_disabled.png"),
                new Seat("B1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("B11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("C11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("D11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("E11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F4", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F5", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F6", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F7", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F8", Enum.GetName(SeatTypes.VIP), 9, false, "seat_VIP.png"),
                new Seat("F10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("F11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("G11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("H11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I1", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I2", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I3", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I4", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I5", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I6", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I7", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I8", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I9", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I10", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png"),
                new Seat("I11", Enum.GetName(SeatTypes.normal), (float) 7.50, false, "seat_blanco.png")
            ];

        return genSeats;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Session>> GetSeats() { return Ok(seats); }

}

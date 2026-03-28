using Microsoft.AspNetCore.Mvc;
using EventBooking.API.Data;
using EventBooking.API.Models;
using EventBooking.API.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace EventBooking.API.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        //[Authorize]
        public IActionResult Book(BookingDto dto)
        {
            var ev = _context.Events.Find(dto.EventId);

            if (ev == null)
                return NotFound("Event not found");

            if (ev.AvailableSeats < dto.SeatsBooked)
                return BadRequest("Not enough seats");

            ev.AvailableSeats -= dto.SeatsBooked;

            var booking = new Booking
            {
                EventId = dto.EventId,
                SeatsBooked = dto.SeatsBooked,
                UserId = "User1"
            };

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return Ok("Booking successful");
        }

        [HttpDelete("{id}")]
        //[Authorize]
        public IActionResult Cancel(int id)
        {
            var booking = _context.Bookings.Find(id);

            if (booking == null)
                return NotFound();

            _context.Bookings.Remove(booking);
            _context.SaveChanges();

            return Ok("Booking cancelled");
        }
    }
}
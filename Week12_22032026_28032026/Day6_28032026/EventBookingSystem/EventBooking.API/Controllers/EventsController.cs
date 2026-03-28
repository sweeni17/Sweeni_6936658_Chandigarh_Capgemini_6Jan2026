using Microsoft.AspNetCore.Mvc;
using EventBooking.API.Data;
using EventBooking.API.DTOs;
using AutoMapper;

namespace EventBooking.API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EventsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            var events = _context.Events.ToList();
            var result = _mapper.Map<List<EventDto>>(events);
            return Ok(result);
        }

        [HttpPost]
public IActionResult AddEvent(EventBooking.API.DTOs.EventDto dto)
{
    var ev = new EventBooking.API.Models.Event
    {
        Title = dto.Title,
        Description = dto.Description,
        Date = dto.Date,
        Location = dto.Location,
        AvailableSeats = dto.AvailableSeats
    };

    _context.Events.Add(ev);
    _context.SaveChanges();

    return Ok("Event added successfully");
}
    }
}
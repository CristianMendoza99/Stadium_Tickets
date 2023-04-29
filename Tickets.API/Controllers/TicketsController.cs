using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Tickets.API.Data;

using Tickets.Shared.Entities;



namespace Tickets.API.Controllers
{
    [ApiController]
    [Route("/api/tickets")]
    public class TicketsController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Tickets.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Ticket tickets)
        {
            _context.Add(tickets);
            await _context.SaveChangesAsync();
            return Ok(tickets);
        }
    }
}

using Api.Controllers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class TicketsController : BaseApiController
    {
        private readonly DataContext _context;

        public TicketsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ticket>>> GetTickets()
        {
            return await _context.Tickets.ToListAsync();
        }

        [HttpGet("{id}")] // tickets/id -> Get single ticket
        public async Task<ActionResult<Ticket>> GetTicket(Guid id)
        {
            return await _context.Tickets.FindAsync(id);
        }
    }
}
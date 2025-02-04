using BlazorTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Controllers
{
    public class TicketService : ITicketService
    {
        private readonly SuhrobOfficialContext _context;

        public TicketService(SuhrobOfficialContext context)
        {
            _context = context;
        }
        public async Task<List<Ticket>> GetAllTickets()
        {
            var tickets = await _context.Tickets.ToListAsync();
            return tickets;
        }
    }
}

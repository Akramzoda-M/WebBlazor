using BlazorTest.Entities;

namespace BlazorTest.Controllers
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetAllTickets();
    }
}

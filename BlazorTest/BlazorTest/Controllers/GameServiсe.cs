using BlazorTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Controllers
{
    public class GameServiсe : IGameServiсe
    {
        private readonly SuhrobOfficialContext _context;

        public GameServiсe(SuhrobOfficialContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGames()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }

    }
}

using BlazorTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Servises
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
            if (games==null) 
            {
                Console.WriteLine("Empty");
            }
            return games;
        }
        
    }
}

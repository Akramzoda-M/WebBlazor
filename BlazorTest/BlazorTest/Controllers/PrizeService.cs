using BlazorTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Controllers
{
    public class PrizeService : IPrizeService
    {
        private readonly SuhrobOfficialContext _context;

        public PrizeService(SuhrobOfficialContext context)
        {
            _context = context;
        }
        public async Task<List<Prize>> GetAllPrizes()
        {
            var prizes = await _context.Prizes.ToListAsync();
            return prizes;
        }
    }
}

using BlazorTest.Entities;

namespace BlazorTest.Controllers
{
    public interface IPrizeService
    {
        Task<List<Prize>> GetAllPrizes();
    }
}

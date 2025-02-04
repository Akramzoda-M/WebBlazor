using BlazorTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Controllers
{
    public interface IGameServiсe
    {
        Task<List<Game>> GetAllGames();

    }
}

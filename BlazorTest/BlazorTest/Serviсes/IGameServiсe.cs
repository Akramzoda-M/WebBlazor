using BlazorTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorTest.Servises
{
    public interface IGameServiсe
    {
        Task<List<Game>> GetAllGames();
       
    }
}

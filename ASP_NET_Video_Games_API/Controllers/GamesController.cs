using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllGames()
        {
            var videoGames = _context.VideoGames;

            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public IActionResult GetGamesById(int id)
        {
            var videoGameId = _context.VideoGames.Where(vgi => vgi.Id == id);

            return Ok(videoGameId);
        }

        //[HttpGet("{rank}")]
        //public IActionResult GetGamesByRank(int rank)
        //{
        //    var videoGameRank = _context.VideoGames.Where(vgr => vgr.Rank == rank);

        //    return Ok(videoGameRank);
        //}
    }
}

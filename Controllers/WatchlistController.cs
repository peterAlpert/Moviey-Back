using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviey_Back.Interfaces;
using Moviey_Back.Models;
using Moviey_Back.Repositories;

namespace Moviey_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchlistController : ControllerBase
    {
        public IWatchlistRepo WatchlistRepo { get; }

        public WatchlistController(IWatchlistRepo _watchlistRepo)
        {
            WatchlistRepo = _watchlistRepo;
        }

        [HttpGet]

        public IActionResult GetAllWatchlists()
        {
            List<Watchlist> watchlists = WatchlistRepo.GetAll();
            return Ok(watchlists);
        }

        [HttpGet("id")]
        public IActionResult GetWatchlist(int id)
        {
            Watchlist watchlist = WatchlistRepo.GetById(id);
            if (watchlist == null)
            {
                return BadRequest("there is no watchlists");
            }
            return Ok(watchlist);
        }

        [HttpDelete("id")]

        public IActionResult DeleteWatchlist(int id)
        {
            WatchlistRepo.Delete(id);
            WatchlistRepo.Save();
            return Ok();
        }

        [HttpPost]

        public IActionResult AddItem(Watchlist item) {
            WatchlistRepo.Add(item);
            WatchlistRepo.Save();
            return Ok(item);
        }

    }
}

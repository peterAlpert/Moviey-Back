using Moviey_Back.Models;

namespace Moviey_Back.Interfaces
{
    public interface IWatchlistRepo 
    {
        public void Add(Watchlist watchlist);

        public List<Watchlist> GetAll();

        public Watchlist GetById(int id);

        public void Update(Watchlist watchlist);

        public void Delete(int id);

        public void Save();


    }
}

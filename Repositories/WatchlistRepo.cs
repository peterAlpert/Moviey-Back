using Moviey_Back.Interfaces;
using Moviey_Back.Models;

namespace Moviey_Back.Repositories
{
    public class WatchlistRepo : IWatchlistRepo
    {
        public Context Context { get; }

        public WatchlistRepo(Context _Context)
        {
            Context = _Context;
        }


        public void Add(Watchlist watchlist)
        {
            Context.Add(watchlist);
        }

        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }

        public List<Watchlist> GetAll()
        {
            return Context.watchlists.ToList();
        }

        public Watchlist GetById(int id)
        {
            return Context.watchlists.FirstOrDefault(wl => wl.Id == id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(Watchlist watchlist)
        {
            Context.Update(watchlist);
        }
    }
}

using Moviey_Back.Interfaces;
using Moviey_Back.Models;

namespace Moviey_Back.Repositories
{
    public class CommentRepo : ICommentRepo
    {
        public Context Context { get; }
        public CommentRepo(Context _Context)
        {
            Context = _Context;
        }

        public void Add(Comment comment)
        {
            Context.Add(comment);
        }

        public List<Comment> GetAll()
        {
            return Context.comments.ToList();
        }

        public List<Comment> GetAllByProdId(int prodId)
        {
            return Context.comments
                .Where(c => c.ProductId == prodId)
                .ToList();
        }

        public Comment GetById(int id)
        {
            return Context.comments.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Comment comment)
        {
            Context.Update(comment);
        }

        public void Delete(int id)
        {
            Comment comment = GetById(id);
            Context.Remove(comment);
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}

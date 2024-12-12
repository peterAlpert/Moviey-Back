using Moviey_Back.Models;

namespace Moviey_Back.Interfaces
{
    public interface ICommentRepo
    {
        public void Add(Comment comment);
        public List<Comment> GetAll();
        public List<Comment> GetAllByProdId(int prodId);
        public Comment GetById(int id);
        public void Update(Comment comment);
        public void Delete(int id);

        public void Save();
    }
}

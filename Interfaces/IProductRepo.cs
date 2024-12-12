using Moviey_Back.Models;

namespace Moviey_Back.Interfaces
{
    public interface IProductRepo
    {
        public void Add(Product product);
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Update(Product product);
        public void Delete(int id);

        public void Save();
    }
}

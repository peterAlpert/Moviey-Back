using Moviey_Back.Interfaces;
using Moviey_Back.Models;

namespace Moviey_Back.Repositories
{
    public class ProductRepo : IProductRepo
    {
        public Context Context { get; }
        

        public ProductRepo(Context _Context)
        {
            Context = _Context;
        }


        public void Add(Product product)
        {
            Context.Add(product);
        }

        public void Delete(int id)
        {
            Product product = GetById(id);
            Context.Remove(product);
        }

        public List<Product> GetAll()
        {
            List<Product> products = Context.products.ToList();
            return products;
        }

        public Product GetById(int id)
        {
            return Context.products.FirstOrDefault(p => p.Id == id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(Product product)
        {
            Context.Update(product);
        }
    }
}

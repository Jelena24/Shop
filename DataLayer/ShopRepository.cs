using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class ShopRepository : IShopRepository
    {
        private readonly ShopContext context;
        public ShopRepository(ShopContext _context)
        {
            context = _context;
        }

        public int deleteProduct(int id)
        {
            Product product = context.Products.Find(id);
            if(product == null)
            {
                return 0;
            }
            else
            {
                context.Products.Remove(product);
                context.SaveChanges();
                return 1;
            }
        }

        public Product getProductById(int id)
        {
            return context.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Product> getProducts()
        {
            return context.Products.ToList();
        }

        public List<Product> getProducts(decimal price1, decimal price2)
        {
            return context.Products.Where(p => p.Price >price1 && p.Price < price2).ToList();
        }

        public int insertProduct(Product product)
        {
            context.Products.Add(product);
            try
            {
                context.SaveChanges();
                return context.Products.Count();
            }
            catch
            {
                return 0;
            }
        }

        public int updateProduct(Product product)
        {
            context.Entry(product).State =Microsoft.EntityFrameworkCore.EntityState.Modified;
            try
            {
                context.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}

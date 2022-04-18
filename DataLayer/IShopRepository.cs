using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IShopRepository
    {
        public List<Product> getProducts();
        public List<Product> getProducts(decimal price1, decimal price2);
        public int insertProduct(Product product);
        public int updateProduct(Product product);
        public int deleteProduct(int id);
        public Product getProductById(int id);
    }
}

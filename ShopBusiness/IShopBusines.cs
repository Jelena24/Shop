using DataLayer.Models;
using System.Collections.Generic;

namespace ShopBusiness
{
    public interface IShopBusines
    {
        public List<Product> getProducts();
        public List<Product> getProducts(decimal price1, decimal price2);
        public Product insertProduct(Product product);
        public bool updateProduct(Product product);
        public bool deleteProduct(int id);
        public Product getProductById(int id);
    }
}

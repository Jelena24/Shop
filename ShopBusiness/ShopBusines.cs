using DataLayer;
using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopBusiness
{
    public class ShopBusines : IShopBusines
    {
        private readonly IShopRepository shopRepository;

        public ShopBusines(IShopRepository _shopRepository)
        {
            shopRepository = _shopRepository;
        }

        public bool deleteProduct(int id)
        {
           int counter = shopRepository.deleteProduct(id);
            if(counter == 0)
                return false;
            return true;
        }

        public Product getProductById(int id)
        {
            return shopRepository.getProductById(id);
        }

        public List<Product> getProducts()
        {
            return shopRepository.getProducts();
        }

        public List<Product> getProducts(decimal price1, decimal price2)
        {
            return shopRepository.getProducts(price1, price2);
           
        }

        public Product insertProduct(Product product)
        {
            int counter = shopRepository.insertProduct(product);
            if(counter == 0)
                return null;
            return product;
        }

        public bool updateProduct(Product product)
        {
            int counter = shopRepository.updateProduct(product);
            if(counter == 0)
                return false;
            return true;
        }
    }
}

using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ShopBusiness;
using System.Collections.Generic;

namespace ShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopBusines shopBusiness;
        public ShopController(IShopBusines _shopBusiness)
        {
            shopBusiness = _shopBusiness;
        }
        
        [HttpGet("getProducts")]
        public List<Product> getProducts()
        {
            return shopBusiness.getProducts();
        }

        [HttpGet("{minprice}/{maxprice}/getProducts")]
        public List<Product> getProducts(decimal price1, decimal price2)
        {
            return shopBusiness.getProducts(price1, price2);
        }
        
        [HttpPost("insert")]
        public Product insertProduct(Product product)
        {
            return shopBusiness.insertProduct(product);
        }

        [HttpDelete("delete")]
        public void deleteProduct(int id)
        {
            shopBusiness.deleteProduct(id);
        }

        [HttpGet("getProductById")]
        public Product getProductById(int id)
        {
            return shopBusiness.getProductById(id);
        }

        [HttpPut("update")]
        public void updateProduct(Product product)
        {
            shopBusiness.updateProduct(product);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlusAPI.Model;

namespace PlusAPI.Services
{
    public class ProductService
    {

        List<Product> products;

        public ProductService() {
            products = new List<Product>();
        }

        public List<Product> GetProducts() {
            return products;
        }

        public void AddProduct(Product product) {
            products.Add(product);
        }
    }
}
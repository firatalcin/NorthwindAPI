using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product() { ProductId = 1, CategoryId = 1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product() { ProductId = 2, CategoryId = 1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product() { ProductId = 3, CategoryId = 2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product() { ProductId = 4, CategoryId = 2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product() { ProductId = 5, CategoryId = 2, ProductName="Fare", UnitPrice=85, UnitsInStock=1},
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var deleteProduct = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(deleteProduct);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public Product GetById(int id)
        {
            return _products.SingleOrDefault(x => x.ProductId == id);
        }

        public void Update(Product product)
        {
            var updateProduct = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            updateProduct.ProductName = product.ProductName;
            updateProduct.UnitPrice = product.UnitPrice;
            updateProduct.UnitsInStock = product.UnitsInStock;
            updateProduct.CategoryId = product.CategoryId;
        }
    }
}

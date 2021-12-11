using MinWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MinWebApi.Repositories
{
    public class Repository : IRepository<Product>
    {
        private List<Product> _products = new List<Product>();
        public Repository()
        {
            _products = new List<Product>()
            {
                new Product()
                {
                    Name = "Product 1 title",
                    Description = "Product 1 description",
                    Price = 10,
                    Stock = 100
                },new Product()
                {
                    Name = "Product 2 title",
                    Description = "Product 2 description",
                    Price = 20,
                    Stock = 200
                },new Product()
                {
                    Name = "Product 3 title",
                    Description = "Product 3 description",
                    Price = 30,
                    Stock = 300
                },new Product()
                {
                    Name = "Product 4 title",
                    Description = "Product 4 description",
                    Price = 40,
                    Stock = 400
                },new Product()
                {
                    Name = "Product 5 title",
                    Description = "Product 5 description",
                    Price = 50,
                    Stock = 500
                },new Product()
                {
                    Name = "Product 6 title",
                    Description = "Product 6 description",
                    Price = 60,
                    Stock = 600
                },new Product()
                {
                    Name = "Product 7 title",
                    Description = "Product 7 description",
                    Price = 70,
                    Stock = 700
                },new Product()
                {
                    Name = "Product 8 title",
                    Description = "Product 8 description",
                    Price = 80,
                    Stock = 800
                },new Product()
                {
                    Name = "Product 9 title",
                    Description = "Product 9 description",
                    Price = 90,
                    Stock = 900
                },new Product()
                {
                    Name = "Product 10 title",
                    Description = "Product 10 description",
                    Price = 100,
                    Stock = 1000
                },new Product()
                {
                    Name = "Product 11 title",
                    Description = "Product 11 description",
                    Price = 110,
                    Stock = 1100
                }
            };
        }

        public Product Create(Product entity)
        {
            _products.Add(entity);
            return entity;
        }

        public void Delete(string id)
        {
            _products.Remove(_products.FirstOrDefault(p => p.Id == id));
        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(x => x.Name).ToList();
        }

        public Product GetById(string id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}

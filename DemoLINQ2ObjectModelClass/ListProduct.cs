using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ2ObjectModelClass
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_products()
        {
            products.Add(new Product() { Id = 1, Name = "P1", Quantity = 10, Price = 100 });
            products.Add(new Product() { Id = 2, Name = "P2", Quantity = 11, Price = 110 });
            products.Add(new Product() { Id = 3, Name = "P3", Quantity = 12, Price = 120 });
            products.Add(new Product() { Id = 4, Name = "P4", Quantity = 13, Price = 130 });
            products.Add(new Product() { Id = 5, Name = "P5", Quantity = 14, Price = 140 });
            products.Add(new Product() { Id = 6, Name = "P6", Quantity = 15, Price = 150 });
            products.Add(new Product() { Id = 7, Name = "P7", Quantity = 16, Price = 160 });
            products.Add(new Product() { Id = 8, Name = "P8", Quantity = 17, Price = 170 });
            products.Add(new Product() { Id = 9, Name = "P9", Quantity = 18, Price = 180 });
            products.Add(new Product() { Id = 10, Name = "P10", Quantity = 19, Price = 190 });
        }

        public List<Product> FilterProductByPrice(double price1, double price2)
        {
            var result = from p in products
                         where p.Price >= price1 && p.Price <= price2
                         select p;
            return result.ToList();
        }

        public List<Product> FilterProductByPrice2(double price1, double price2)
        {
            return products
                .Where(p => p.Price >= price1 && p.Price <= price2)
                .ToList();
        }

        public List<Product> SortProductByPriceAsc()
        {
            return products
                .OrderBy(p => p.Price)
                .ToList();
        }

        public List<Product> SortProductByPriceAsc2()
        {
            var result = from p in products
                         orderby p.Price
                         select p;
            return result.ToList(); 
        }

        public List<Product> SortProductByPriceDesc()
        {
            return products
                .OrderByDescending(p => p.Price)
                .ToList();
        }

        public List<Product> SortProductByPriceDesc2()
        {
            var result = from p in products
                         orderby p.Price descending
                         select p;
            return result.ToList();
        }

        public double SumOfValue()
        {
            return products.Sum(p => p.Price * p.Quantity);
        }

        public Product SearchProductDetail(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> SearchTopProduct(int n)
        {
            var result = (from p in products
                         orderby (p.Price * p.Quantity) descending
                         select p).Take(n);
            return result.ToList();
        }

        public List<Product> GetTopProducts(int n)
        {
            return products
                .OrderByDescending(p => p.Quantity * p.Price)
                .Take(n)
                .ToList();
        }
    }
}

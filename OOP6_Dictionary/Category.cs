using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category() {
            Products = new Dictionary<int, Product>();
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }

        public void AddProduct(Product p)
        {
            //ktra neu ID product chua ton tai thi` them moi
            if (p == null)
            {
                return;//du lieu dau vao null
            }
            if (Products.ContainsKey(p.Id))
            {
                return;//Id da ton tai
            }
            //thêm mới Product vào Dictionary
            Products.Add(p.Id, p);
        }

        //Xuất toàn bộ sản phẩm
        public void PrintAllProducts()
        {
            foreach(KeyValuePair<int, Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
        }

        //Lọc sản phẩm có giá trị từ min tới max
        public Dictionary<int, Product>
            FilterProductsByPrice(double min, double max)
        {
            return Products.Where(item=>item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
        }

        //sắp xếp sản phẩm theo đơn giá tăng dần
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        public Dictionary<int, Product> SortComplex()
        {
            return Products.OrderBy(item => item.Value.Price).
                OrderByDescending(item =>item.Value.Quantity).
                ToDictionary<int, Product>();
        }

        public bool UpdateProduct(Product p)
        {
            if (p == null)
                return false;
            if (Products.ContainsKey(p.Id) == false)
            {
                return false;
            }
            Products[p.Id] = p;
            return true;
        }

        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
                return false;
            Products.Remove(id);
            return true;
        }
       
        public Dictionary<int, Product> RemoveMulProduct(double min, double max)
        {
            var removed = Products
        .Where(p => p.Value.Price >= min && p.Value.Price <= max)
        .ToDictionary(p => p.Key, p => p.Value);
            foreach (var key in removed.Keys)
            {
                Products.Remove(key);
            }

            return removed;
        }
    }
}

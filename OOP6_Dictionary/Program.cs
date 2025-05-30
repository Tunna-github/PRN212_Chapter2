using OOP6_Dictionary;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước ngọt";

Product p1 = new Product();
p1.Id = 1;
p1.Name = "Pepsi";
p1.Quantity = 10;
p1.Price = 30;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Coke";
p2.Quantity = 20;
p2.Price = 30;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "Sting";
p3.Quantity = 30;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "C2";
p4.Quantity = 25;
p4.Price = 30;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "RedBull";
p5.Quantity = 21;
p5.Price = 38;
c1.AddProduct(p5);

Console.WriteLine("---------------------Thông tin danh mục---------------------");
Console.WriteLine(c1);
Console.WriteLine("---------------------Danh sách sản phẩm----------------------");
c1.PrintAllProducts();

double min_price = 20;
double max_price = 35;
Dictionary<int, Product>products_by_price =
    c1.FilterProductsByPrice(min_price, max_price);
Console.WriteLine($"Danh sách sản phẩm có giá từ {min_price} đến {max_price}:");
foreach(KeyValuePair<int, Product>kvp in products_by_price)
{
    Product p=kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sorted_products = c1.SortProductByPrice();
Console.WriteLine("--------------------------Danh sách sản phẩm sau khi sắp xếp giá tăng dần----------------------");
foreach(KeyValuePair<int, Product>kvp in sorted_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}
//sắp xếp sp theo đơn giá tăng dần, nếu đơn giá trùng nhau thì sắp xếp theo số lượng giảm dần
Dictionary<int, Product> sorted_complex = c1.SortProductByPrice();
Console.WriteLine("--------------------------Danh sách sản phẩm sau khi sắp xếp complex----------------------");
foreach (KeyValuePair<int, Product> kvp in sorted_complex)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p5.Name = "Fanta";
p5.Price = 80;
p5.Quantity = 17;
bool ret = c1.UpdateProduct(p5);
Console.WriteLine("---Sản phẩm sau khi chỉnh sửa---");
c1.PrintAllProducts();

int id = 5;
ret = c1.RemoveProduct(id);
if(ret == false)
{
    Console.WriteLine($"Không tìm thấy mã {id} để xóa");
}
else
{
    Console.WriteLine($"Đã xóa thành công sản phẩm có mã {id}");
    Console.WriteLine("---Sản phẩm sau khi xóa---");
    c1.PrintAllProducts();
}

//viết hàm cho phép xóa nhiều sản phẩm có đơn giá từ A tới B
double min = 0;
double max = 0;
Console.WriteLine("--------------------------Danh sách sản phẩm sau khi xóa nhiều sản phẩm----------------------");
Dictionary<int, Product> removed_multiple = c1.RemoveMulProduct(min, max);
foreach (KeyValuePair<int, Product> kvp in removed_multiple)
{
    Product p = kvp.Value;
    Console.WriteLine($"Đã xóa sản phẩm {p.Name}");
}
c1.PrintAllProducts();

LinkedList<Category> categories = new LinkedList<Category>();
categories.AddLast(c1);

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia các loại";

c2.AddProduct(new Product() { Id = 6, Name = "Tiger", Quantity = 17, Price = 28 });
c2.AddProduct(new Product() { Id = 7, Name = "Crystal", Quantity = 20, Price = 30 });
c2.AddProduct(new Product() { Id = 8, Name = "Ken", Quantity = 15, Price = 15 });
c2.AddProduct(new Product() { Id = 9, Name = "Tiger Bạc", Quantity = 16, Price = 25 });

categories.AddFirst(c2);
Console.WriteLine("---Danh sách toàn bộ sản phẩm theo danh mục---");
foreach(Category c in categories)
{
    Console.WriteLine(c);
    Console.WriteLine("--------------------");
    c.PrintAllProducts();
    Console.WriteLine("--------------------");
}
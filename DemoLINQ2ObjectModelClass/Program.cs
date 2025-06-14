using DemoLINQ2ObjectModelClass;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

ListProduct lp = new ListProduct();
lp.gen_products();
//Câu 1: lọc ra các sản phẩm có giá từ a tới b
var result = lp.FilterProductByPrice(100, 200);
Console.WriteLine("Các sản phẩm có giá từ 100 đến 200:");
result.ForEach(x => Console.WriteLine(x));

//câu 2: sắp xếp sản phẩm theo đơn giá tăng dần
var result2 = lp.SortProductByPriceAsc2();
Console.WriteLine("Các sản phẩm sau khi sắp xếp giá tăng dần:");
result2.ForEach(x => Console.WriteLine(x));

//Câu 3: sắp xếp sản phẩm theo đơn giá giảm dần
var result3 = lp.SortProductByPriceDesc();
Console.WriteLine("Các sản phẩm sau khi sắp xếp giá giảm dần:");
result3.ForEach(x => Console.WriteLine(x));

//Caau 4: tính tổng giá trị các sản phẩm trong cửa hàng
Console.WriteLine("Tổng giá trị kho hàng =" + lp.SumOfValue());

//Câu 5: tìm chi tiết sản phẩm khi biết mã sản phẩm
Product p = lp.SearchProductDetail(30);
if(p!= null)
{
    Console.WriteLine("Tìm thấy sản phẩm, thông tin chi tiết");
    Console.WriteLine(p);
}
else
{
    Console.WriteLine("Không tìm thấy sản phẩm");
}

//Câu 6: viết hàm lọc ra top n sản phẩm có trị giá lớn nhất
var result4 = lp.SearchTopProduct(3);
Console.WriteLine("Các sản phẩm có giá trị lớn nhất:");
result4.ForEach(x => Console.WriteLine(x));
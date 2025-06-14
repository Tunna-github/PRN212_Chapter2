using Lucy_SalesDataManagement;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = @"server=TUNNA\MSSQLSERVER02;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);

//Câu 1: lọc ra toàn bộ khách hàng
var dskh = context.Customers.toList();
Console.WriteLine("---Danh sách kháng hàng---");
foreach(var d in dskh)
    Console.WriteLine(d.CustomeID + "\t" + )




Customer cust = context.Customers
                .FirstOrDefault(c => c.CustomerID == mkh);
if(cust != null)
{
    Console.WriteLine("---Chi tiết thông tin khách hàng mã = " + cust.ContactName);
    Console.WriteLine(cust.CustomerID +  "\t" + cust.CustomerName);
}
//Câu 3: từ kết quả của câu 2
//lập ra danh sách các hóa đơn của khách hàng
//các cột dữ liệu gồm: Mã hóa đơn + ngày hóa đơn
if(cust != null)
{
    var dshd = cust.Orders.Select(od = new {od.OrderID, od.OrderDate});
    Console.WriteLine("Danh sách hóa đơn của khách hàng");
}
foreach(var od in dshd)
{
    Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy");
}
}
//Câu 4: từ kết quả của câu 3
//          bổ sung thêm cột trị giá của đơn hàng cho mỗi hóa đơn
if(cust != null)
{
    var dshd = cust.Orders
            .Select(od => new {od.OrderID, od.})
}
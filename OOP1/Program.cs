using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Tao doi tuong Category 1:
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước mắm";
//Xuat thong tin bang cach goi ham
c1.PrintInfor();
//Gia su doi gia tri trong o nho
c1.Name = "Thuốc trị hôi nách";
Console.WriteLine("Sau khi đổi giá trị:");
c1.PrintInfor();
//Su dung lop Employee
Console.WriteLine("------------------EMPLOYEE------------------");
Employee e1 = new Employee();
e1.Id = 1;
e1.IdCard = "001";
e1.Name = "Teo";
e1.Email = "teo@gmail.com";
e1.Phone = "0981234567";
e1.PrintInfor();
Employee e2 = new Employee()
{
    Id = 2,
    IdCard = "001",
    Name = "Ti",
    Email = "ti@gmail.com",
    Phone = "0987654321"
};
Console.WriteLine("----------------------EMPLOYEE2-------------------------");
e2.PrintInfor();

Employee e3 = new Employee();
Console.WriteLine("-----------------------EMPLOYEE3-------------------------");
e3.PrintInfor();

//Tao Employee 4
Employee e4 = new Employee(4, "004", "Tun", "tun@gmail.com", "12345");
Console.WriteLine("-----------------------EMPLOYEE4-------------------------");
e4.PrintInfor();
Console.WriteLine("-----------------------EMPLOYEE4 Cach 2-------------------------");
Console.WriteLine(e4);//Tu dong goi ham toString

Console.WriteLine("-----------------------CUSTOMER--------------------------");
Customer cus1 = new Customer()
{
    Id = 1,
    Name = "Nguyen Thi Lung Linh",
    Email = "lunglinh@gmail.com",
    Phone = "090909090909",
    Address = "So 1 - Dinh Tien Hoang"
};
cus1.PrintIfnor();
cus1.Address = "So 2 - Dinh Tien Hoang";
Console.WriteLine("Customer sau khi doi dia chi");
cus1.PrintIfnor();